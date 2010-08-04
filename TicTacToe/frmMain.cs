using System;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class frmMain : Form
	{
		/// <summary>
		/// An array for storing the 9 squares
		/// in this game.
		/// </summary>
		btnSquare[] btnArray;

		/// <summary>
		/// The count of the amount of turns. Should be reset every game.
		/// </summary>
		uint turns = 0;

		bool blnComp = true;

		public frmMain()
		{
			InitializeComponent();
			btnArray = new btnSquare[9];
			btnSquare temp;
			int lastTabIndex = 18, currentX = 7, spaceX = 70, currentY = -70, spaceY = 76;
			for (uint i = 0; i < 9; ++i)
			{
				if (i % 3 == 0)
				{
					currentX = 7;
					currentY += spaceY;
				}
				else
				{
					currentX += spaceX;
				}
				temp = btnArray[i] = new btnSquare();
				temp.TabIndex = lastTabIndex++;
				temp.Location = new System.Drawing.Point(currentX, currentY);
				temp.Click += new System.EventHandler(this.makeMove);
				this.Controls.Add(temp);
			}
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
			lblturns.Text = ++turns + " Turns";
			if (lblTurn.Text == "X")
			{
				button_pressed.setX();
				lblTurn.Text = "O";
			}
			else
			{
				button_pressed.setO();
				lblTurn.Text = "X";
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
		/// <param name="orientation">The current orientation that needs to be checked.</param>
		/// <param name="toChk">The 3-long integer array which tells which two to check, and which to return if successful.</param>
		/// <param name="isX">Tell the function whether to verify against X (true) or O (false).</param>
		/// <returns></returns>
		private btnSquare checkMove(uint[] orientation, uint[] toChk, bool isX)
		{
			return (btnArray[orientation[toChk[0]]].autoCheck(isX)
				 && btnArray[orientation[toChk[1]]].autoCheck(isX)
				 && btnArray[orientation[toChk[2]]].Enabled) 
				 
				 ? btnArray[orientation[toChk[2]]]
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
			/*
				The following is a matrix of all the possible board orientations.
				The purpose is that we can check a single possibility, and automatically
			    rotate through the other possibilities instead of typing out 
			    each and every possibility, which would take forever and would lead to 
			    unnecessarily complex code.
			 */
			uint[][] orientations = {
				new uint[] { // north
					0, 1, 2,
					3, 4, 5,
					6, 7, 8
				},
				new uint[] { // northr
					2, 1, 0,
					5, 4, 3,
					8, 7, 6
				},
				new uint[] { // east
					2, 5, 8,
					1, 4, 7,
					0, 3, 6
				},
				new uint[] { // eastr
					8, 5, 2,
					7, 4, 1,
					6, 3, 0
				},
				new uint[] { // west
					6, 3, 0,
					7, 4, 1,
					8, 5, 2
				},
				new uint[] { // westr
					0, 3, 6,
					1, 4, 7,
					2, 5, 8
				},
				new uint[] { // south
					8, 7, 6,
					5, 4, 3,
					2, 1, 0
				},
				new uint[] { // southr
					6, 7, 8,
					3, 4, 5,
					0, 1, 2 
				}
			};
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
				foreach (uint[] rot in orientations)
				{
					btnSquare temp;
					for (uint i = 0; i < criticalChecks.Length; ++i)
					{
						temp = checkMove(rot, criticalChecks[i], false);
						if (temp != null) return temp;
					}
				}
			}
			//defend
			if (radHard.Checked || radImp.Checked || radNormal.Checked)
			{
				foreach (uint[] rot in orientations)
				{
					btnSquare temp;
					for (uint i = 0; i < criticalChecks.Length; ++i)
					{
						temp = checkMove(rot, criticalChecks[i], true);
						if (temp != null) return temp;
					}
				}
			}
			if (radImp.Checked)
			{
				//<-------------------------------------------------------------------------->
				//								   FORKING
				//<-------------------------------------------------------------------------->

				foreach (uint[] rot in orientations)
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
						temp = checkMove(rot, checks[i], false);
						if (temp != null) return temp;
					}
				}
				//<-------------------------------------------------------------------------->
				//							BLOCK FORKING
				//<-------------------------------------------------------------------------->

				foreach (uint[] rot in orientations)
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
						temp = checkMove(rot, checks[i], true);
						if (temp != null) return temp;
					}
				}
				//<--d-->
				bool defend = false;
				btnSquare badbut = default(btnSquare);
				foreach (uint[] rot in orientations)
				{
					if (btnArray[rot[0]].isX() && btnArray[rot[6]].isX() && (btnArray[rot[2]].Enabled || btnArray[rot[8]].Enabled))
					{
						defend = true;
						badbut = btnArray[rot[2]];
					}
					if (btnArray[rot[0]].isX() && btnArray[rot[2]].isX() && (btnArray[rot[6]].Enabled || btnArray[rot[8]].Enabled))
					{
						defend = true;
						badbut = btnArray[rot[6]];
					}
					if (btnArray[rot[6]].isX() && btnArray[rot[2]].isX() && (btnArray[rot[0]].Enabled || btnArray[rot[8]].Enabled))
					{
						defend = true;
						badbut = btnArray[rot[0]];
					}
					if (defend)
					{
						btnSquare theMove = btnArray[0];
						while (!theMove.Enabled || object.ReferenceEquals(theMove, badbut) || object.ReferenceEquals(theMove, rot[8]))
						{
							theMove = btnArray[generator.Next(1, 8)];
						}
						return theMove;
					}
				}
				//center
				if (btnArray[4].Enabled)
					return btnArray[4];
				//opposite corner
				uint[][] opposites = {
					new uint[] {0, 8},
					new uint[] {3, 7}
				};
				foreach (uint[] inner in opposites)
				{
					if (btnArray[inner[0]].isX() && btnArray[inner[1]].Enabled) return btnArray[inner[1]];
					if (btnArray[inner[1]].isX() && btnArray[inner[0]].Enabled) return btnArray[inner[0]];
				}
				//empty corner
				int[] corners = {
					0, 2, 6, 8
				};
				btnSquare cornPlay = btnArray[corners[generator.Next(0, 3)]];
				while (!cornPlay.Enabled)
				{
					cornPlay = btnArray[corners[generator.Next(0, 3)]];
				}
				if (cornPlay.Enabled) return cornPlay;
				//empty side
				int[] sides = {
					1, 3, 5, 7
				};
				btnSquare sidePlay = btnArray[sides[generator.Next(0, 3)]];
				while (!sidePlay.Enabled)
				{
					sidePlay = btnArray[sides[generator.Next(0, 3)]];
				}
				return sidePlay;
			}

			// randomly play a remaining square
			// Theoretically, the code will never reach here.
			btnSquare compMove = btnArray[generator.Next(0, 8)];
			while (!compMove.Enabled)
			{
				compMove = btnArray[generator.Next(0, 8)];
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
					btnSquare temp = btnArray[path[i]];
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
			foreach (btnSquare gamebutton in btnArray)
			{
				if (gamebutton.Enabled)
					blnDraw = false;
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
			for (int i = 8; i >= 0; --i)
				btnArray[i].unset();
			lblTurn.Text = "X";
			blnComp = true;
		}
	}
}