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

		private void makeMove(object sender, EventArgs e)
		{
			++turns;
			btnSquare button_pressed = (btnSquare)sender;
			lblturns.Text = turns + " Turns";
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
		public btnSquare ComputerMove()
		{
			Random generator = new Random();
			btnSquare[][] orientations = new btnSquare[][] {
				new btnSquare[] { // north
					Button1,
					Button2,
					Button3,
					Button4,
					Button5,
					Button6,
					Button7,
					Button8,
					Button9
				},
				new btnSquare[] { // northr
					Button3,
					Button2,
					Button1,
					Button6,
					Button5,
					Button4,
					Button9,
					Button8,
					Button7
				},
				new btnSquare[] { // east
					Button3,
					Button6,
					Button9,
					Button2,
					Button5,
					Button8,
					Button1,
					Button4,
					Button7
				},
				new btnSquare[] { // eastr
					Button9,
					Button6,
					Button3,
					Button8,
					Button5,
					Button2,
					Button7,
					Button4,
					Button1
				},
				new btnSquare[] { // west
					Button7,
					Button4,
					Button1,
					Button8,
					Button5,
					Button2,
					Button9,
					Button6,
					Button3
				},
				new btnSquare[] { // westr
					Button1,
					Button4,
					Button7,
					Button2,
					Button5,
					Button8,
					Button3,
					Button6,
					Button9
				},
				new btnSquare[] { // south
					Button9,
					Button8,
					Button7,
					Button6,
					Button5,
					Button4,
					Button3,
					Button2,
					Button1
				},
				new btnSquare[] { // southr
					Button7,
					Button8,
					Button9,
					Button4,
					Button5,
					Button6,
					Button1,
					Button2,
					Button3
				}
			};
			//win
			if (radHard.Checked || radImp.Checked)
			{
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isO() && rot[1].isO() && rot[2].Enabled)
						return rot[2];
					//midmiss
					if (rot[0].isO() && rot[2].isO() && rot[1].Enabled)
						return rot[1];
					if (rot[0].isO() && Button5.isO() && rot[8].Enabled)
						return rot[8];
					//3
					if (rot[3].isO() && Button5.isO() && rot[5].Enabled)
						return rot[5];
				}
			}
			//defend
			if (radNormal.Checked || radHard.Checked || radImp.Checked)
			{
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isX() && rot[1].isX() && rot[2].Enabled)
						return rot[2];
					if (rot[0].isX() && rot[2].isX() && rot[1].Enabled)
						return rot[1];
					if (rot[0].isX() && Button5.isX() && rot[8].Enabled)
						return rot[8];
					if (rot[3].isX() && Button5.isX() && rot[5].Enabled)
						return rot[5];
				}
			}
			if (radImp.Checked)
			{
				//<-------------------------------------------------------------------------->
				//								   FORKING
				//<-------------------------------------------------------------------------->
				//<--a-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isO() && rot[2].isO() && Button5.Enabled)
						return Button5;
					if (rot[0].isO() && Button5.isO() && rot[2].Enabled)
						return rot[2];
					if (rot[2].isO() && Button5.isO() && rot[0].Enabled)
						return rot[0];
				}
				//<--b-->
				foreach (btnSquare[] rot in orientations)
				{
					if (Button5.isO() && rot[6].isO() && rot[7].Enabled)
						return rot[7];
					if (Button5.isO() && rot[7].isO() && rot[6].Enabled)
						return rot[6];
					if (rot[7].isO() && rot[6].isO() && Button5.Enabled)
						return Button5;
				}
				//<--c-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isO() && rot[1].isO() && rot[3].Enabled)
						return rot[3];
					if (rot[0].isO() && rot[3].isO() && rot[1].Enabled)
						return rot[1];
					if (rot[3].isO() && rot[1].isO() && rot[0].Enabled)
						return rot[0];
				}
				//<--d-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isO() && rot[8].isO() && rot[6].Enabled)
						return rot[6];
					if (rot[0].isO() && rot[6].isO() && rot[2].Enabled)
						return rot[2];
					if (rot[0].isO() && rot[2].isO() && rot[6].Enabled)
						return rot[6];
					if (rot[6].isO() && rot[2].isO() && rot[0].Enabled)
						return rot[0];
				}
				//<--e-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[1].isO() && rot[6].isO() && rot[7].Enabled)
						return rot[7];
					if (rot[1].isO() && rot[7].isO() && rot[6].Enabled)
						return rot[6];
					if (rot[6].isO() && rot[7].isO() && rot[1].Enabled)
						return rot[1];
				}
				//<-------------------------------------------------------------------------->
				//							BLOCK FORKING
				//<-------------------------------------------------------------------------->
				//<--f-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isX() && rot[2].isX() && rot[5].Enabled)
						return rot[5];
					if (rot[0].isX() && rot[5].isX() && rot[2].Enabled)
						return rot[2];
					if (rot[5].isX() && rot[2].isX() && rot[0].Enabled)
						return rot[0];
				}
				//<--a-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isX() && rot[2].isX() && Button5.Enabled)
						return Button5;
					if (rot[0].isX() && Button5.isX() && rot[2].Enabled)
						return rot[2];
					if (rot[2].isX() && Button5.isX() && rot[0].Enabled)
						return rot[0];
				}
				//<--b-->
				foreach (btnSquare[] rot in orientations)
				{
					if (Button5.isX() && rot[6].isX() && rot[7].Enabled)
						return rot[7];
					if (Button5.isX() && rot[7].isX() && rot[6].Enabled)
						return rot[6];
					if (rot[7].isX() && rot[6].isX() && Button5.Enabled)
						return Button5;
				}
				//<--c-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isX() && rot[1].isX() && rot[3].Enabled)
						return rot[3];
					if (rot[0].isX() && rot[3].isX() && rot[1].Enabled)
						return rot[1];
					if (rot[3].isX() && rot[1].isX() && rot[0].Enabled)
						return rot[0];
				}
				//<--d-->
				bool defend = false;
				btnSquare badbut = default(btnSquare);
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[0].isX() && rot[6].isX() && (rot[2].Enabled || rot[8].Enabled))
					{
						defend = true;
						badbut = rot[2];
					}
					if (rot[0].isX() && rot[2].isX() && (rot[6].Enabled || rot[8].Enabled))
					{
						defend = true;
						badbut = rot[6];
					}
					if (rot[6].isX() && rot[2].isX() && (rot[0].Enabled || rot[8].Enabled))
					{
						defend = true;
						badbut = rot[0];
					}
					if (defend)
					{
						btnSquare theMove = Button1;
						while (!theMove.Enabled || object.ReferenceEquals(theMove, badbut) || object.ReferenceEquals(theMove, rot[8]))
						{
							theMove = btnArray[generator.Next(0, 8)];
						}
						return theMove;
					}
				}
				//<--e-->
				foreach (btnSquare[] rot in orientations)
				{
					if (rot[1].isX() && rot[6].isX() && rot[7].Enabled)
						return rot[7];
					if (rot[1].isX() && rot[7].isX() && rot[6].Enabled)
						return rot[6];
					if (rot[6].isX() && rot[7].isX() && rot[1].Enabled)
						return rot[1];
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

		public bool Winner()
		{
			System.EventArgs nulle = null;
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
				DialogResult playgain = MessageBox.Show("Do you want to play again?", (intWinRar == 1 ? "X" : "O") + " Wins!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (playgain == DialogResult.Yes)
					New_Game(null, nulle);
				else
					Application.Exit();
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
				DialogResult playgain = MessageBox.Show(radImp.Checked ? "I told you it was impossible! Want to try again, even though you won't win?" : "Do you want to play again?", radImp.Checked ? "It's a Draw ~ Give Up Already!" : "It's a Draw!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (playgain == DialogResult.Yes)
					New_Game(null, nulle);
				else
					Application.Exit();
				return true;
			}
			return false;
		}
		private void New_Game(System.Object sender, System.EventArgs e)
		{
			resetGame();
		}

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
