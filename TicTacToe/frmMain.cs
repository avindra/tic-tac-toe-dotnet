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
        Button[] btnArray;
        uint turns = 0;
        bool blnComp = true;
        public frmMain()
        {
            InitializeComponent();
            btnArray = new Button[] { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9 };
            for (ushort i = 0; i < 9; ++i)
                btnArray[i].Click += new System.EventHandler(this.makeMove);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            turns = 0;
            Button temp;
            for (ushort i = 0; i < 9; ++i)
            {
                temp = btnArray[i];
                temp.Text = "";
                temp.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void makeMove(object sender, EventArgs e)
        {
            ++turns;
            Button button_pressed = (Button)sender;
            lblturns.Text = turns + " Turns";
            if (lblTurn.Text == "X")
            {
                button_pressed.Text = "X";
                lblTurn.Text = "O";
            }
            else
            {
                button_pressed.Text = "O";
                lblTurn.Text = "X";
            }
            button_pressed.Enabled = false;
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
        public Button ComputerMove()
        {
            Random generator = new Random();
            Button[] north = {
		        Button1,
		        Button2,
		        Button3,
		        Button4,
		        Button5,
		        Button6,
		        Button7,
		        Button8,
		        Button9
	        };
            Button[] northr = {
		        Button3,
		        Button2,
		        Button1,
		        Button6,
		        Button5,
		        Button4,
		        Button9,
		        Button8,
		        Button7
	        };
            Button[] east = {
		        Button3,
		        Button6,
		        Button9,
		        Button2,
		        Button5,
		        Button8,
		        Button1,
		        Button4,
		        Button7
	        };
            Button[] eastr = {
		        Button9,
		        Button6,
		        Button3,
		        Button8,
		        Button5,
		        Button2,
		        Button7,
		        Button4,
		        Button1
	        };
            Button[] west = {
		        Button7,
		        Button4,
		        Button1,
		        Button8,
		        Button5,
		        Button2,
		        Button9,
		        Button6,
		        Button3
	        };
            Button[] westr = {
		        Button1,
		        Button4,
		        Button7,
		        Button2,
		        Button5,
		        Button8,
		        Button3,
		        Button6,
		        Button9
	        };
            Button[] south = {
		        Button9,
		        Button8,
		        Button7,
		        Button6,
		        Button5,
		        Button4,
		        Button3,
		        Button2,
		        Button1
	        };
            Button[] southr = {
		        Button7,
		        Button8,
		        Button9,
		        Button4,
		        Button5,
		        Button6,
		        Button1,
		        Button2,
		        Button3
	        };
            Button[][] orientations = new Button[][] {
                north,
                northr,
                east,
                eastr,
                west,
                westr,
                south,
                southr
            };
            //win
            if (radHard.Checked || radImp.Checked)
            {
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "O" && rot[1].Text == "O" && rot[2].Enabled)
                        return rot[2];
                    //midmiss
                    if (rot[0].Text == "O" && rot[2].Text == "O" && rot[1].Enabled)
                        return rot[1];
                    if (rot[0].Text == "O" && Button5.Text == "O" && rot[8].Enabled)
                        return rot[8];
                    //3
                    if (rot[3].Text == "O" && Button5.Text == "O" && rot[5].Enabled)
                        return rot[5];
                }
            }
            //defend
            if (radNormal.Checked || radHard.Checked || radImp.Checked)
            {
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "X" && rot[1].Text == "X" && rot[2].Enabled)
                        return rot[2];
                    if (rot[0].Text == "X" && rot[2].Text == "X" && rot[1].Enabled)
                        return rot[1];
                    if (rot[0].Text == "X" && Button5.Text == "X" && rot[8].Enabled)
                        return rot[8];
                    if (rot[3].Text == "X" && Button5.Text == "X" && rot[5].Enabled)
                        return rot[5];
                }
            }
            if (radImp.Checked)
            {
                //<-------------------------------------------------------------------------->
                //                                   FORKING
                //<-------------------------------------------------------------------------->
                //<--a-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "O" && rot[2].Text == "O" && Button5.Enabled)
                        return Button5;
                    if (rot[0].Text == "O" && Button5.Text == "O" && rot[2].Enabled)
                        return rot[2];
                    if (rot[2].Text == "O" && Button5.Text == "O" && rot[0].Enabled)
                        return rot[0];
                }
                //<--b-->
                foreach (Button[] rot in orientations)
                {
                    if (Button5.Text == "O" && rot[6].Text == "O" && rot[7].Enabled)
                        return rot[7];
                    if (Button5.Text == "O" && rot[7].Text == "O" && rot[6].Enabled)
                        return rot[6];
                    if (rot[7].Text == "O" && rot[6].Text == "O" && Button5.Enabled)
                        return Button5;
                }
                //<--c-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "O" && rot[1].Text == "O" && rot[3].Enabled)
                        return rot[3];
                    if (rot[0].Text == "O" && rot[3].Text == "O" && rot[1].Enabled)
                        return rot[1];
                    if (rot[3].Text == "O" && rot[1].Text == "O" && rot[0].Enabled)
                        return rot[0];
                }
                //<--d-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "O" && rot[8].Text == "O" && rot[6].Enabled)
                        return rot[6];
                    if (rot[0].Text == "O" && rot[6].Text == "O" && rot[2].Enabled)
                        return rot[2];
                    if (rot[0].Text == "O" && rot[2].Text == "O" && rot[6].Enabled)
                        return rot[6];
                    if (rot[6].Text == "O" && rot[2].Text == "O" && rot[0].Enabled)
                        return rot[0];
                }
                //<--e-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[1].Text == "O" && rot[6].Text == "O" && rot[7].Enabled)
                        return rot[7];
                    if (rot[1].Text == "O" && rot[7].Text == "O" && rot[6].Enabled)
                        return rot[6];
                    if (rot[6].Text == "O" && rot[7].Text == "O" && rot[1].Enabled)
                        return rot[1];
                }
                //<-------------------------------------------------------------------------->
                //                            BLOCK FORKING
                //<-------------------------------------------------------------------------->
                //<--f-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "X" && rot[2].Text == "X" && rot[5].Enabled)
                        return rot[5];
                    if (rot[0].Text == "X" && rot[5].Text == "X" && rot[2].Enabled)
                        return rot[2];
                    if (rot[5].Text == "X" && rot[2].Text == "X" && rot[0].Enabled)
                        return rot[0];
                }
                //<--a-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "X" && rot[2].Text == "X" && Button5.Enabled)
                        return Button5;
                    if (rot[0].Text == "X" && Button5.Text == "X" && rot[2].Enabled)
                        return rot[2];
                    if (rot[2].Text == "X" && Button5.Text == "X" && rot[0].Enabled)
                        return rot[0];
                }
                //<--b-->
                foreach (Button[] rot in orientations)
                {
                    if (Button5.Text == "X" && rot[6].Text == "X" && rot[7].Enabled)
                        return rot[7];
                    if (Button5.Text == "X" && rot[7].Text == "X" && rot[6].Enabled)
                        return rot[6];
                    if (rot[7].Text == "X" && rot[6].Text == "X" && Button5.Enabled)
                        return Button5;
                }
                //<--c-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "X" && rot[1].Text == "X" && rot[3].Enabled)
                        return rot[3];
                    if (rot[0].Text == "X" && rot[3].Text == "X" && rot[1].Enabled)
                        return rot[1];
                    if (rot[3].Text == "X" && rot[1].Text == "X" && rot[0].Enabled)
                        return rot[0];
                }
                //<--d-->
                bool defend = false;
                Button badbut = default(Button);
                foreach (Button[] rot in orientations)
                {
                    if (rot[0].Text == "X" && rot[6].Text == "X" && (rot[2].Enabled || rot[8].Enabled))
                    {
                        defend = true;
                        badbut = rot[2];
                    }
                    if (rot[0].Text == "X" && rot[2].Text == "X" && (rot[6].Enabled || rot[8].Enabled))
                    {
                        defend = true;
                        badbut = rot[6];
                    }
                    if (rot[6].Text == "X" && rot[2].Text == "X" && (rot[0].Enabled || rot[8].Enabled))
                    {
                        defend = true;
                        badbut = rot[0];
                    }
                    if (defend)
                    {
                        Button theMove = Button1;
                        while (theMove.Enabled == false || object.ReferenceEquals(theMove, badbut) || object.ReferenceEquals(theMove, rot[8]))
                        {
                            theMove = btnArray[generator.Next(0, 8)];
                        }
                        return theMove;
                    }
                }
                //<--e-->
                foreach (Button[] rot in orientations)
                {
                    if (rot[1].Text == "X" && rot[6].Text == "X" && rot[7].Enabled)
                        return rot[7];
                    if (rot[1].Text == "X" && rot[7].Text == "X" && rot[6].Enabled)
                        return rot[6];
                    if (rot[6].Text == "X" && rot[7].Text == "X" && rot[1].Enabled)
                        return rot[1];
                }
                //center
                if (Button5.Enabled)
                    return Button5;
                //opposite corner
                if (Button1.Text == "X" && Button9.Enabled)
                    return Button9;
                if (Button9.Text == "X" && Button1.Enabled)
                    return Button1;
                if (Button3.Text == "X" && Button7.Enabled)
                    return Button7;
                if (Button7.Text == "X" && Button3.Enabled)
                    return Button3;
                //empty corner
                Button[] corners = {
			        Button1,
			        Button3,
			        Button7,
			        Button9
		        };
                Button cornPlay = corners[generator.Next(0, 3)];
                while (cornPlay.Enabled == false)
                {
                    cornPlay = corners[generator.Next(0, 3)];
                }
                return cornPlay;
                //empty side
                Button[] sides = {
			        Button2,
			        Button4,
			        Button6,
			        Button8
		        };
                Button sidePlay = sides[generator.Next(0, 3)];
                while (sidePlay.Enabled == false)
                {
                    sidePlay = sides[generator.Next(0, 3)];
                }
                return sidePlay;
            }

            Button compMove = btnArray[generator.Next(0, 8)];
            while (compMove.Enabled == false)
            {
                compMove = btnArray[generator.Next(0, 8)];
            }
            return compMove;
        }

        public bool Winner()
        {
            System.EventArgs nulle = null;
            if ((Button1.Text == "X" && Button2.Text == "X" && Button3.Text == "X") || (Button4.Text == "X" && Button5.Text == "X" && Button6.Text == "X") || (Button7.Text == "X" && Button8.Text == "X" && Button9.Text == "X") || (Button4.Text == "X" && Button1.Text == "X" && Button7.Text == "X") || (Button2.Text == "X" && Button5.Text == "X" && Button8.Text == "X") || (Button3.Text == "X" && Button9.Text == "X" && Button6.Text == "X") || (Button1.Text == "X" && Button5.Text == "X" && Button9.Text == "X") || (Button3.Text == "X" && Button5.Text == "X" && Button7.Text == "X"))
            {
                DialogResult playgain = MessageBox.Show("Do you want to play again?", "X Wins!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (playgain == DialogResult.Yes)
                    New_Game(null, nulle);
                else
                    Application.Exit();
                return true;
            }
            if ((Button1.Text == "O" && Button2.Text == "O" && Button3.Text == "O") || (Button4.Text == "O" && Button5.Text == "O" && Button6.Text == "O") || (Button7.Text == "O" && Button8.Text == "O" && Button9.Text == "O") || (Button4.Text == "O" && Button1.Text == "O" && Button7.Text == "O") || (Button2.Text == "O" && Button5.Text == "O" && Button8.Text == "O") || (Button3.Text == "O" && Button9.Text == "O" && Button6.Text == "O") || (Button1.Text == "O" && Button5.Text == "O" && Button9.Text == "O") || (Button3.Text == "O" && Button5.Text == "O" && Button7.Text == "O"))
            {
                DialogResult playgain = MessageBox.Show("Do you want to play again?", "O Wins!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (playgain == DialogResult.Yes)
                    New_Game(null, nulle);
                else
                    Application.Exit();
                return true;
            }
            bool blnDraw = true;
            foreach (Button gamebutton in btnArray)
            {
                if (gamebutton.Enabled)
                    blnDraw = false;
            }
            if (blnDraw && radImp.Checked)
            {
                DialogResult playgain = MessageBox.Show("I told you it was impossible! Want to try again, even though you'll lose?", "It's a Draw ~ Give Up Already!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (playgain == DialogResult.Yes)
                    New_Game(null, nulle);
                else
                    Application.Exit();
                return true;
            }
            if (blnDraw)
            {
                DialogResult playgain = MessageBox.Show("Do you want to play again?", "It's a Draw!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
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
            turns = 0;
            foreach (Button gamebutton in btnArray)
            {
                gamebutton.Text = "";
                gamebutton.Enabled = true;
            }
            lblTurn.Text = "X";
            blnComp = true;
        }

    }
}
