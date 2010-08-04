namespace TicTacToe
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Form Designer Generated Code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblturns = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.radImp = new System.Windows.Forms.RadioButton();
			this.radHard = new System.Windows.Forms.RadioButton();
			this.radNormal = new System.Windows.Forms.RadioButton();
			this.radEasy = new System.Windows.Forms.RadioButton();
			this.btnExit = new System.Windows.Forms.Button();
			this.grpMode = new System.Windows.Forms.GroupBox();
			this.rad2P = new System.Windows.Forms.RadioButton();
			this.radComp = new System.Windows.Forms.RadioButton();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.lblTurn = new System.Windows.Forms.Label();
			this.Button9 = new btnSquare();
			this.Button8 = new btnSquare();
			this.Button7 = new btnSquare();
			this.Button6 = new btnSquare();
			this.Button5 = new btnSquare();
			this.Button4 = new btnSquare();
			this.Button3 = new btnSquare();
			this.Button2 = new btnSquare();
			this.Button1 = new btnSquare();
			this.GroupBox1.SuspendLayout();
			this.grpMode.SuspendLayout();
			this.SuspendLayout();
			//
			// lblturns
			//
			this.lblturns.Location = new System.Drawing.Point(19, 245);
			this.lblturns.Name = "lblturns";
			this.lblturns.Size = new System.Drawing.Size(195, 28);
			this.lblturns.TabIndex = 32;
			//
			// GroupBox1
			//
			this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox1.Controls.Add(this.radImp);
			this.GroupBox1.Controls.Add(this.radHard);
			this.GroupBox1.Controls.Add(this.radNormal);
			this.GroupBox1.Controls.Add(this.radEasy);
			this.GroupBox1.Location = new System.Drawing.Point(244, 148);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(181, 80);
			this.GroupBox1.TabIndex = 31;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Difficulty";
			//
			// radImp
			//
			this.radImp.AutoSize = true;
			this.radImp.Checked = true;
			this.radImp.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radImp.ForeColor = System.Drawing.Color.Red;
			this.radImp.Location = new System.Drawing.Point(46, 45);
			this.radImp.Name = "radImp";
			this.radImp.Size = new System.Drawing.Size(92, 20);
			this.radImp.TabIndex = 3;
			this.radImp.TabStop = true;
			this.radImp.Text = "Impossible";
			this.radImp.UseVisualStyleBackColor = true;
			//
			// radHard
			//
			this.radHard.AutoSize = true;
			this.radHard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radHard.Location = new System.Drawing.Point(125, 19);
			this.radHard.Name = "radHard";
			this.radHard.Size = new System.Drawing.Size(53, 20);
			this.radHard.TabIndex = 2;
			this.radHard.Text = "Hard";
			this.radHard.UseVisualStyleBackColor = true;
			//
			// radNormal
			//
			this.radNormal.AutoSize = true;
			this.radNormal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radNormal.Location = new System.Drawing.Point(61, 19);
			this.radNormal.Name = "radNormal";
			this.radNormal.Size = new System.Drawing.Size(67, 20);
			this.radNormal.TabIndex = 1;
			this.radNormal.Text = "Normal";
			this.radNormal.UseVisualStyleBackColor = true;
			//
			// radEasy
			//
			this.radEasy.AutoSize = true;
			this.radEasy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radEasy.Location = new System.Drawing.Point(7, 19);
			this.radEasy.Name = "radEasy";
			this.radEasy.Size = new System.Drawing.Size(56, 20);
			this.radEasy.TabIndex = 0;
			this.radEasy.Text = "Easy";
			this.radEasy.UseVisualStyleBackColor = true;
			//
			// btnExit
			//
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.Location = new System.Drawing.Point(290, 279);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(134, 35);
			this.btnExit.TabIndex = 30;
			this.btnExit.Text = "Exit Game";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			//
			// grpMode
			//
			this.grpMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.grpMode.Controls.Add(this.rad2P);
			this.grpMode.Controls.Add(this.radComp);
			this.grpMode.Location = new System.Drawing.Point(258, 62);
			this.grpMode.Name = "grpMode";
			this.grpMode.Size = new System.Drawing.Size(166, 61);
			this.grpMode.TabIndex = 29;
			this.grpMode.TabStop = false;
			this.grpMode.Text = "Game Mode";
			//
			// rad2P
			//
			this.rad2P.AutoSize = true;
			this.rad2P.Location = new System.Drawing.Point(12, 39);
			this.rad2P.Name = "rad2P";
			this.rad2P.Size = new System.Drawing.Size(63, 17);
			this.rad2P.TabIndex = 12;
			this.rad2P.Text = "2 Player";
			this.rad2P.UseVisualStyleBackColor = true;
			//
			// radComp
			//
			this.radComp.AutoSize = true;
			this.radComp.Checked = true;
			this.radComp.Location = new System.Drawing.Point(11, 17);
			this.radComp.Name = "radComp";
			this.radComp.Size = new System.Drawing.Size(70, 17);
			this.radComp.TabIndex = 11;
			this.radComp.TabStop = true;
			this.radComp.Text = "Computer";
			this.radComp.UseVisualStyleBackColor = true;
			//
			// btnNewGame
			//
			this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnNewGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewGame.Location = new System.Drawing.Point(287, 238);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(138, 35);
			this.btnNewGame.TabIndex = 28;
			this.btnNewGame.Text = "New Game";
			this.btnNewGame.UseVisualStyleBackColor = false;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			//
			// lblTurn
			//
			this.lblTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurn.Location = new System.Drawing.Point(328, 6);
			this.lblTurn.Name = "lblTurn";
			this.lblTurn.Size = new System.Drawing.Size(97, 50);
			this.lblTurn.TabIndex = 27;
			this.lblTurn.Text = "X";
			this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// Button9
			//
			this.Button9.Location = new System.Drawing.Point(149, 158);
			this.Button9.Name = "Button9";
			this.Button9.TabIndex = 26;
			//
			// Button8
			//
			this.Button8.Location = new System.Drawing.Point(78, 158);
			this.Button8.Name = "Button8";
			this.Button8.TabIndex = 25;
			//
			// Button7
			//
			this.Button7.Location = new System.Drawing.Point(7, 158);
			this.Button7.Name = "Button7";
			this.Button7.TabIndex = 24;
			//
			// Button6
			//
			this.Button6.Location = new System.Drawing.Point(149, 82);
			this.Button6.Name = "Button6";
			this.Button6.TabIndex = 23;
			//
			// Button5
			//
			this.Button5.Location = new System.Drawing.Point(78, 82);
			this.Button5.Name = "Button5";
			this.Button5.TabIndex = 22;
			//
			// Button4
			//
			this.Button4.Location = new System.Drawing.Point(7, 82);
			this.Button4.Name = "Button4";
			this.Button4.TabIndex = 21;
			//
			// Button3
			//
			this.Button3.Location = new System.Drawing.Point(149, 6);
			this.Button3.Name = "Button3";
			this.Button3.TabIndex = 20;
			//
			// Button2
			//
			this.Button2.Location = new System.Drawing.Point(78, 6);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 19;
			//
			// Button1
			//
			this.Button1.Location = new System.Drawing.Point(7, 6);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 18;
			//
			// frmMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 322);
			this.Controls.Add(this.lblturns);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.grpMode);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.lblTurn);
			this.Controls.Add(this.Button9);
			this.Controls.Add(this.Button8);
			this.Controls.Add(this.Button7);
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Name = "frmMain";
			this.Text = "Tic Tac Toe";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.grpMode.ResumeLayout(false);
			this.grpMode.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Label lblturns;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton radImp;
		internal System.Windows.Forms.RadioButton radHard;
		internal System.Windows.Forms.RadioButton radNormal;
		internal System.Windows.Forms.RadioButton radEasy;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.GroupBox grpMode;
		internal System.Windows.Forms.RadioButton rad2P;
		internal System.Windows.Forms.RadioButton radComp;
		internal System.Windows.Forms.Button btnNewGame;
		internal System.Windows.Forms.Label lblTurn;
		internal TicTacToe.btnSquare Button9;
		internal TicTacToe.btnSquare Button8;
		internal TicTacToe.btnSquare Button7;
		internal TicTacToe.btnSquare Button6;
		internal TicTacToe.btnSquare Button5;
		internal TicTacToe.btnSquare Button4;
		internal TicTacToe.btnSquare Button3;
		internal TicTacToe.btnSquare Button2;
		internal TicTacToe.btnSquare Button1;
	}
}

