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
		}

		#region Minor Event Handlers
		private void btnNewGame_Click(object sender, EventArgs e)
		{
			resetGame();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		/// <summary>
		/// The method handler for all of the buttons being clicked.
		/// </summary>
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
				// Board may be left out of position by the clumsy computer, so
				// reposition it. When makeMove is called, we need to have faith that
				// the current position is the standard one. If you don't believe me
				// or have trouble understanding, erase the reorient() call and try playing
				// the following moves: 4, 6, 8, 7.
				//
				// As you can see, the computer would fail to win across 0 2 1, because
				// it's orientations are all out of whack.
				// Instead of winning immediately, it lets the game become a draw.
				gameBoard.reorient();
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
		/// <param name="toCheck">The 3-long integer array which tells which two to check, and which to return if successful.</param>
		/// <param name="isX">Tell the function whether to verify against X (true) or O (false).</param>
		/// <returns></returns>
		private btnSquare checkMove(uint[] toCheck, bool isX)
		{

			return (gameBoard.get(toCheck[0]).autoCheck(isX)
				 && gameBoard.get(toCheck[1]).autoCheck(isX)
				 && gameBoard.get(toCheck[2]).Enabled)

				 ? gameBoard.get(toCheck[2])
				 : null;
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
			//win
			if (radHard.Checked || radImp.Checked || (radNormal.Checked && generator.Next(0, 2) >= 1))
			{
				do
				{
					btnSquare temp;
					for (uint i = 0; i < criticalChecks.Length; ++i)
					{
						temp = checkMove(criticalChecks[i], false);
						if (temp != null) return temp;
					}
				} while (!gameBoard.rotate());
			}
			//defend
			if (radHard.Checked || radImp.Checked || radNormal.Checked)
			{
				do
				{
					btnSquare temp;
					for (uint i = 0; i < criticalChecks.Length; ++i)
					{
						temp = checkMove(criticalChecks[i], true);
						if (temp != null) return temp;
					}
				} while (!gameBoard.rotate());
			}
			if (radImp.Checked)
			{
				//<-------------------------------------------------------------------------->
				//								   FORKING
				//<-------------------------------------------------------------------------->

				do
				{
					uint[][] checks = {
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
					};
					btnSquare temp;
					for (uint i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(checks[i], false);
						if (temp != null) return temp;
					}
				} while (!gameBoard.rotate());
				//<-------------------------------------------------------------------------->
				//							BLOCK FORKING
				//<-------------------------------------------------------------------------->

				do
				{
					uint[][] checks = {
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
					};
					btnSquare temp;
					for (uint i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(checks[i], true);
						if (temp != null) return temp;
					}
				} while (!gameBoard.rotate());
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
				} while (!gameBoard.rotate());
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
					0, 2, 6, 8
				};
				btnSquare cornPlay = gameBoard.get(corners[generator.Next(0, 3)]);
				while (!cornPlay.Enabled)
				{
					cornPlay = gameBoard.get(corners[generator.Next(0, 3)]);
				}
				if (cornPlay.Enabled) return cornPlay;
				//empty side
				uint[] sides = {
					1, 3, 5, 7
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
			else
				Application.Exit();
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