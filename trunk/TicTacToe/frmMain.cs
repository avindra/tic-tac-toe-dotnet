using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
		uint turns = 0;
		bool blnComp = true;
		public frmMain()
		{
			InitializeComponent();
			btnArray = new btnSquare[] { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9 };
			for (uint i = 0; i < 9; ++i)
				btnArray[i].Click += new System.EventHandler(this.makeMove);
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
			resetGame();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

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

			http://en.wikipedia.org/wiki/Tic_tac_toe#Strategy
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
		private btnSquare checkMove(int[] orientation, int[] toChk, bool isX)
		{
			return (btnArray[orientation[toChk[0]]].autoCheck(isX)
				 && btnArray[orientation[toChk[1]]].autoCheck(isX)
				 && btnArray[orientation[toChk[2]]].Enabled) 
				 
				 ? btnArray[orientation[toChk[2]]]
				 : null;
		}

		/// <summary>
		/// Returns the square which the Computer would pick,
		/// based on the selected difficulty.
		/// </summary>
		private btnSquare ComputerMove()
		{
			Random generator = new Random();
			int[][] orientations = new int[][] {
				new int[] { // north
					0, 1, 2,
					3, 4, 5,
					6, 7, 8
				},
				new int[] { // northr
					2, 1, 0,
					5, 4, 3,
					8, 7, 6
				},
				new int[] { // east
					2, 5, 8,
					1, 4, 7,
					0, 3, 6
				},
				new int[] { // eastr
					8, 5, 2,
					7, 4, 1,
					6, 3, 0
				},
				new int[] { // west
					6, 3, 0,
					7, 4, 1,
					8, 5, 2
				},
				new int[] { // westr
					0, 3, 6,
					1, 4, 7,
					2, 5, 8
				},
				new int[] { // south
					8, 7, 6,
					5, 4, 3,
					2, 1, 0
				},
				new int[] { // southr
					6, 7, 8,
					3, 4, 5,
					0, 1, 2 
				}
			};
			//win
			if (radHard.Checked || radImp.Checked)
			{
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 1, 2},
						new int[] {0, 2, 1},
						new int[] {0, 4, 8},
						new int[] {3, 4, 5}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], false);
						if (temp != null) return temp;
					}
				}
			}
			//defend
			if (radNormal.Checked || radHard.Checked || radImp.Checked)
			{
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 1, 2},
						new int[] {0, 2, 1},
						new int[] {0, 4, 8},
						new int[] {3, 4, 5}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], true);
						if (temp != null) return temp;
					}
				}
			}
			if (radImp.Checked)
			{
				//<-------------------------------------------------------------------------->
				//								   FORKING
				//<-------------------------------------------------------------------------->
				//<--a-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 2, 4},
						new int[] {0, 4, 2},
						new int[] {2, 4, 0}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], false);
						if (temp != null) return temp;
					}
				}
				//<--b-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {4, 6, 7},
						new int[] {4, 7, 6},
						new int[] {7, 6, 4}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], false);
						if (temp != null) return temp;
					}
				}
				//<--c-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 1, 3},
						new int[] {0, 3, 1},
						new int[] {3, 1, 0}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], false);
						if (temp != null) return temp;
					}
				}
				//<--d-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 8, 6},
						new int[] {0, 6, 2},
						new int[] {0, 2, 6},
						new int[] {6, 2, 0}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], false);
						if (temp != null) return temp;
					}
				}
				//<--e-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {1, 6, 7},
						new int[] {1, 7, 6},
						new int[] {6, 7, 1}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], false);
						if (temp != null) return temp;
					}
				}
				//<-------------------------------------------------------------------------->
				//							BLOCK FORKING
				//<-------------------------------------------------------------------------->
				//<--f-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 2, 5},
						new int[] {0, 5, 2},
						new int[] {5, 2, 0}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], true);
						if (temp != null) return temp;
					}
				}
				//<--a-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 2, 4},
						new int[] {0, 4, 2},
						new int[] {2, 4, 0}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], true);
						if (temp != null) return temp;
					}
				}
				//<--b-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {4, 6, 7},
						new int[] {4, 7, 6},
						new int[] {7, 6, 4}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], true);
						if (temp != null) return temp;
					}
				}
				//<--c-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {0, 1, 3},
						new int[] {0, 3, 1},
						new int[] {3, 1, 0}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], true);
						if (temp != null) return temp;
					}
				}
				//<--d-->
				bool defend = false;
				btnSquare badbut = default(btnSquare);
				foreach (int[] rot in orientations)
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
						btnSquare theMove = Button1;
						while (!theMove.Enabled || object.ReferenceEquals(theMove, badbut) || object.ReferenceEquals(theMove, rot[8]))
						{
							theMove = btnArray[generator.Next(1, 8)];
						}
						return theMove;
					}
				}
				//<--e-->
				foreach (int[] rot in orientations)
				{
					int[][] checks = {
						new int[] {1, 6, 7},
						new int[] {1, 7, 6},
						new int[] {6, 7, 1}
					};
					btnSquare temp;
					for (int i = 0; i < checks.Length; ++i)
					{
						temp = checkMove(rot, checks[i], true);
						if (temp != null) return temp;
					}
				}
				//center
				if (Button5.Enabled)
					return Button5;
				//opposite corner
				if (Button1.isX() && Button9.Enabled)
					return Button9;
				if (Button9.isX() && Button1.Enabled)
					return Button1;
				if (Button3.isX() && Button7.Enabled)
					return Button7;
				if (Button7.isX() && Button3.Enabled)
					return Button3;
				//empty corner
				btnSquare[] corners = {
					Button1,
					Button3,
					Button7,
					Button9
				};
				btnSquare cornPlay = corners[generator.Next(0, 3)];
				while (!cornPlay.Enabled)
				{
					cornPlay = corners[generator.Next(0, 3)];
				}
				if (cornPlay.Enabled) return cornPlay;
				//empty side
				btnSquare[] sides = {
					Button2,
					Button4,
					Button6,
					Button8
				};
				btnSquare sidePlay = sides[generator.Next(0, 3)];
				while (!sidePlay.Enabled)
				{
					sidePlay = sides[generator.Next(0, 3)];
				}
				return sidePlay;
			}

			btnSquare compMove = btnArray[generator.Next(0, 8)];
			while (!compMove.Enabled)
			{
				compMove = btnArray[generator.Next(0, 8)];
			}
			return compMove;
		}

		/// <summary>
		/// Determines whether or not there is a winner,
		/// and performs the prompts to play again.
		/// </summary>
		public bool Winner()
		{
			uint[][] winPaths = {
				// Straight across
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
				prompt(radImp.Checked ? "I told you it was impossible! Want to try again, even though you won't win?" : "Do you want to play again?", radImp.Checked ? "It's a Draw ~ Give Up Already!" : "It's a Draw!!");
				return true;
			}
			return false;
		}

		/// <summary>
		/// Ask the user if they want to play again or not, with custom messages.
		/// </summary>
		/// <param name="msg">The message you want to ask the user about.</param>
		/// <param name="title">The title of the dialog.</param>
		private void prompt(String msg, String title)
		{
			DialogResult playgain = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (playgain == DialogResult.Yes)
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
			btnSquare temp;
			for (uint i = 0; i < 9; ++i)
			{
				temp = btnArray[i];
				temp.unset();
			}
			lblTurn.Text = "X";
			blnComp = true;
		}
	}
}
