using System;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class frmMain : Form
	{
		/// <summary>
		/// The board object defined by Board.cs. Contains
		/// utilities for easily manipulating and representing
		/// the game board.
		/// </summary>
		Board gameBoard;

		/// <summary>
		/// The count of the amount of turns. Should be reset every game.
		/// </summary>
		uint turns = 0;

		bool blnComp = true;

		public frmMain()
		{
			InitializeComponent();
			btnSquare[] btnArray = new btnSquare[9];
			btnSquare temp;
			for (uint i = 0; i < 9; ++i)
			{
				temp = btnArray[i] = new btnSquare();
				temp.Click += new System.EventHandler(this.makeMove);
				this.pnlGameBoard.Controls.Add(temp);
			}
			gameBoard = new Board(btnArray);
#if DEBUG
			this.Text += " (debug mode)";
			ToolStripMenuItem mnuDbg = new ToolStripMenuItem();
			mnuDbg.Text = "Debug";

			ToolStripMenuItem mnuBench = new ToolStripMenuItem();
			mnuBench.Text = "Perform Benchmark";
			mnuBench.Click += new System.EventHandler(doBenchmark);
			mnuDbg.DropDownItems.AddRange(new ToolStripMenuItem [] {
				mnuBench
			});
			mnuMain.Items.Insert(mnuMain.Items.Count - 1, mnuDbg);
#endif
		}

#if DEBUG
		/// <summary>
		/// This performs the benchmarks and tries to make a statisically accurate figure from the runs.
		/// </summary>
		public void doBenchmark(object sender, EventArgs e)
		{
			long[] benches = new long[10];
			for (int i = benches.Length - 1; i >= 0; --i)
			{
				benches[i] = bench();
			}
			long sum = 0;
			string benchlog = "";
			for (int i = 0; i < benches.Length; ++i)
			{
				sum += benches[i];
				benchlog += "["+i+"]=" + benches[i] + "\n";
			}
			MessageBox.Show("Computer choice algorithm benchmark results:\n\n(Lower values are better, results vary from computer to computer)\n\nPARAMETERS:\nRuns: 10\nIterations per run: 1000\n\n" + benchlog + "\nAverage benchmark: " + (sum / benches.Length), "Benchmark Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Run a single benchmark.
		/// </summary>
		public long bench()
		{
	
			System.Diagnostics.Stopwatch x = System.Diagnostics.Stopwatch.StartNew();
			for (int i = 1000; i >= 0; --i) ComputerMove();
			x.Stop();
			return x.ElapsedMilliseconds;
		}
#endif

		#region Minor Event Handlers
		private void btnNewGame_Click(object sender, EventArgs e)
		{
			resetGame();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			resetGame();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tic-Tic-Toe.NET. Written in Visual Basic .NET, then ported over to C#. This application is only licensed for educational or personal uses, and is not authorized for commercial uses.", "About this game", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}
		#endregion


		/// <summary>
		/// The event handler for all of the buttons being clicked.
		/// </summary>
		/// <param name="sender">The button with which this call is associated.</param>
		/// <param name="e">The event parameter. Just pass one if you have one, or give it a null.</param>
		private void makeMove(object sender, EventArgs e)
		{
			btnSquare button_pressed = (btnSquare)sender;
			lblNoTurns.Text = ++turns + " Turns";
			if (lblWhoseTurn.Text == "X")
			{
				button_pressed.setX();
				lblWhoseTurn.Text = "O";
			}
			else
			{
				button_pressed.setO();
				lblWhoseTurn.Text = "X";
			}
			if (Winner())
				return;
			if (radComp.Checked && blnComp)
			{
				blnComp = false;
				makeMove(ComputerMove(), e);
			}
			else
			{
				blnComp = true;
			}
		}
		/*
			Here is where this implementation truly shines.
			I've coded an impossible mode, where you can only either
			draw or lose.

			The human readable instructions for this strategy
			are freely available on Wikipedia:

			http://en.wikipedia.org/wiki/Tic-tac-toe#Strategy
		*/

		/// <summary>
		/// This function heavily improves program flow by 
		/// checking the moves from a single function, instead
		/// of just repeating a lot of code.
		/// </summary>
		/// <param name="checks">The array of checks.</param>
		/// <param name="isX">Tell the function whether to verify against X (true) or O (false).</param>
		/// <returns></returns>
		private btnSquare checkMoves(uint[][] checks, bool isX)
		{
			do
			{
				btnSquare temp;
				for (uint i = 0; i < checks.Length; ++i)
				{
					temp = (gameBoard.get(checks[i][0]).autoCheck(isX)
						 && gameBoard.get(checks[i][1]).autoCheck(isX)
						 && gameBoard.get(checks[i][2]).Enabled)

						 ? gameBoard.get(checks[i][2])
						 : null;
					if (temp != null)
					{
						gameBoard.reorient();
						return temp;
					}
				}
			} while (gameBoard.rotate());
			return null;
		}

		#region Computer Decision Making
		/// <summary>
		/// Returns the square which the Computer would pick,
		/// based on the selected difficulty.
		/// </summary>
		private btnSquare ComputerMove()
		{
			Random generator = new Random();
			// These are the paths along which you can win or lose.
			uint[][] criticalChecks = {
				new uint[] {0, 1, 2},
				/*
					O O ?
					_ _ _
					_ _ _
				*/
		
				
				new uint[] {0, 2, 1},
				/*
					O ? O
					_ _ _
					_ _ _
				*/
				new uint[] {0, 4, 8},
				/*
					O _ _
					_ O _
					_ _ ?
				*/
				// I excluded 804 / 084, because later on, the 
				// center would be picked anyway. Similar coding
				// strategy is used further down as well.
				new uint[] {3, 4, 5}
				/*
					_ _ _
					O O ?
					_ _ _
						 
				*/
			};
			// for storing button choice calculations
			btnSquare temp;

			//win
			if (radHard.Checked || radImp.Checked || (radNormal.Checked && generator.Next(0, 2) >= 1))
			{
				if ((temp = checkMoves(criticalChecks, false)) != null) return temp;
			}
			//defend
			if (radHard.Checked || radImp.Checked || radNormal.Checked)
			{
				if ((temp = checkMoves(criticalChecks, true)) != null) return temp;
			}
			if (radImp.Checked)
			{
				//<-------------------------------------------------------------------------->
				//								   FORKING
				//<-------------------------------------------------------------------------->
				temp = checkMoves(new uint[][] {
		 			//<--a-->
					new uint[] {0, 2, 4},
					new uint[] {0, 4, 2},
					new uint[] {2, 4, 0},
					//<--b-->
					new uint[] {4, 6, 7},
					new uint[] {4, 7, 6},
					new uint[] {7, 6, 4},
					//<--c-->
					new uint[] {0, 1, 3},
					new uint[] {0, 3, 1},
					new uint[] {3, 1, 0},
					//<--d-->
					new uint[] {0, 8, 6},
					new uint[] {0, 6, 2},
					new uint[] {0, 2, 6},
					new uint[] {6, 2, 0},
					//<--e-->
					new uint[] {1, 6, 7},
					new uint[] {1, 7, 6},
					new uint[] {6, 7, 1}
				}, false);
				if (temp != null) return temp;
				//<-------------------------------------------------------------------------->
				//							BLOCK FORKING
				//<-------------------------------------------------------------------------->
				temp = checkMoves(new uint[][] {
					//<--f-->
					new uint[] {0, 2, 5},
					new uint[] {0, 5, 2},
					new uint[] {5, 2, 0},
		 			//<--a-->
					new uint[] {0, 2, 4},
					new uint[] {0, 4, 2},
					new uint[] {2, 4, 0},
					//<--b-->
					new uint[] {4, 6, 7},
					new uint[] {4, 7, 6},
					new uint[] {7, 6, 4},
					//<--c-->
					new uint[] {0, 1, 3},
					new uint[] {0, 3, 1},
					new uint[] {3, 1, 0},
					//<--e-->
					new uint[] {1, 6, 7},
					new uint[] {1, 7, 6},
					new uint[] {6, 7, 1}
				}, true);
				if (temp != null) return temp;
				//<--d-->
				bool defend = false;
				btnSquare badbut = default(btnSquare);
				do
				{
					uint[][] tests = {
						new uint[] {0, 6, 2},
		 				new uint[] {0, 2, 6},
						new uint[] {6, 2, 0}
					};
					foreach (uint[] innerTest in tests)
					{
						if (gameBoard.get(innerTest[0]).isX() && gameBoard.get(innerTest[1]).isX() && (gameBoard.get(innerTest[2]).Enabled || gameBoard.get(8).Enabled))
						{
							defend = true;
							badbut = gameBoard.get(innerTest[2]);
						}
					}
					if (defend)
					{
						btnSquare theMove = gameBoard.get(0);
						while (!theMove.Enabled || object.ReferenceEquals(theMove, badbut) || object.ReferenceEquals(theMove, gameBoard.get(8)))
						{
							theMove = gameBoard.get((uint)generator.Next(1, 8));
						}
						return theMove;
					}
				} while (gameBoard.rotate());
				//center
				if (gameBoard.get(4).Enabled)
					return gameBoard.get(4);
				//opposite corner
				uint[][] opposites = {
					new uint[] {0, 8},
					new uint[] {3, 7}
				};
				foreach (uint[] inner in opposites)
				{
					if (gameBoard.get(inner[0]).isX() && gameBoard.get(inner[1]).Enabled) return gameBoard.get(inner[1]);
					if (gameBoard.get(inner[1]).isX() && gameBoard.get(inner[0]).Enabled) return gameBoard.get(inner[0]);
				}
				//empty corner
				uint[] corners = {
					0,  2,

					6,  8
				};
				btnSquare cornPlay = gameBoard.get(corners[generator.Next(0, 3)]);
				while (!cornPlay.Enabled)
				{
					cornPlay = gameBoard.get(corners[generator.Next(0, 3)]);
				}
				if (cornPlay.Enabled) return cornPlay;
				//empty side
				uint[] sides = {
					 1, 
				   3,  5,
				     7  
				};
				btnSquare sidePlay = gameBoard.get(sides[generator.Next(0, 3)]);
				while (!sidePlay.Enabled)
				{
					sidePlay = gameBoard.get(sides[generator.Next(0, 3)]);
				}
				return sidePlay;
			}

			// randomly play a remaining square
			// Theoretically, the code will never reach here.
			btnSquare compMove = gameBoard.get((uint) generator.Next(0, 8));
			while (!compMove.Enabled)
			{
				compMove = gameBoard.get((uint) generator.Next(0, 8));
			}
			return compMove;
		}
		#endregion

		/// <summary>
		/// Determines whether or not there is a winner,
		/// and performs the prompts to play again.
		/// </summary>
		public bool Winner()
		{
			uint[][] winPaths = {
				// straight across
				new uint[] {0, 1, 2},
				new uint[] {3, 4, 5},
				new uint[] {6, 7, 8},

				// vertical
				new uint[] {0, 3, 6},
				new uint[] {1, 4, 7},
				new uint[] {2, 5, 8},

				// diagonal
				new uint[] {0, 4, 8},
				new uint[] {2, 4, 6}
			};
			uint intWinRar = 0;
			for (uint j = 0; j < winPaths.Length; ++j)
			{
				uint[] path = winPaths[j];
				uint xCount = 0, oCount = 0;
				for (uint i = 0; i < 3; ++i)
				{
					btnSquare temp = gameBoard.get(path[i]);
					if (temp.isX())
					{
						if (++xCount == 3)
						{
							intWinRar = 1;
							break;
						}
						else if (oCount != 0) break;
					}
					else if (temp.isO())
					{
						if (++oCount == 3)
						{
							intWinRar = 2;
							break;
						}
						else if (xCount != 0) break;
					}
				}
				if (intWinRar != 0) break;
			}
			if (intWinRar != 0)
			{
				prompt("Do you want to play again?", (intWinRar == 1 ? "X" : "O") + " Wins!!");
				return true;
			}
			bool blnDraw = true;
			for (uint i = 0; i < 9; ++i)
			{
				if (gameBoard.get(i).Enabled)
				{
					blnDraw = false;
					break;
				}
			}
			if (blnDraw)
			{
				prompt(radImp.Checked ? "I told you it was impossible!\nWant to try again, even though you won't win?" : "Do you want to play again?", radImp.Checked ? "It's a Draw ~ Give Up Already!" : "It's a Draw!!");
				return true;
			}
			return false;
		}

		/// <summary>
		/// Ask the user if they want to play again or not, with a custom message and title.
		/// </summary>
		/// <param name="msg">The message you want to ask the user about.</param>
		/// <param name="title">The title of the dialog.</param>
		private void prompt(String msg, String title)
		{
			if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)== DialogResult.Yes)
				resetGame();
		}

		/// <summary>
		/// This function should be called whenever the game needs to be reset.
		/// </summary>
		private void resetGame()
		{
			turns = 0;
			for (uint i = 0; i < 9; ++i)
				gameBoard.get(i).unset();
			lblWhoseTurn.Text = "X";
			lblNoTurns.Text = "";
			blnComp = true;
		}
	}
}