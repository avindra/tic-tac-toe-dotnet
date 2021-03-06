﻿namespace TicTacToe
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
			this.lblNoTurns = new System.Windows.Forms.Label();
			this.grpDifficulty = new System.Windows.Forms.GroupBox();
			this.radImp = new System.Windows.Forms.RadioButton();
			this.radHard = new System.Windows.Forms.RadioButton();
			this.radNormal = new System.Windows.Forms.RadioButton();
			this.radEasy = new System.Windows.Forms.RadioButton();
			this.btnExit = new System.Windows.Forms.Button();
			this.grpMode = new System.Windows.Forms.GroupBox();
			this.rad2P = new System.Windows.Forms.RadioButton();
			this.radComp = new System.Windows.Forms.RadioButton();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.lblWhoseTurn = new System.Windows.Forms.Label();
			this.pnlGameBoard = new System.Windows.Forms.TableLayoutPanel();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grpDifficulty.SuspendLayout();
			this.grpMode.SuspendLayout();
			this.mnuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNoTurns
			// 
			this.lblNoTurns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNoTurns.Location = new System.Drawing.Point(12, 272);
			this.lblNoTurns.Name = "lblNoTurns";
			this.lblNoTurns.Size = new System.Drawing.Size(195, 28);
			this.lblNoTurns.TabIndex = 32;
			// 
			// grpDifficulty
			// 
			this.grpDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.grpDifficulty.Controls.Add(this.radImp);
			this.grpDifficulty.Controls.Add(this.radHard);
			this.grpDifficulty.Controls.Add(this.radNormal);
			this.grpDifficulty.Controls.Add(this.radEasy);
			this.grpDifficulty.Location = new System.Drawing.Point(243, 166);
			this.grpDifficulty.Name = "grpDifficulty";
			this.grpDifficulty.Size = new System.Drawing.Size(181, 80);
			this.grpDifficulty.TabIndex = 31;
			this.grpDifficulty.TabStop = false;
			this.grpDifficulty.Text = "Difficulty";
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
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.Location = new System.Drawing.Point(290, 300);
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
			this.grpMode.Location = new System.Drawing.Point(257, 80);
			this.grpMode.Name = "grpMode";
			this.grpMode.Size = new System.Drawing.Size(166, 61);
			this.grpMode.TabIndex = 29;
			this.grpMode.TabStop = false;
			this.grpMode.Text = "Opponent";
			// 
			// rad2P
			// 
			this.rad2P.AutoSize = true;
			this.rad2P.Location = new System.Drawing.Point(12, 39);
			this.rad2P.Name = "rad2P";
			this.rad2P.Size = new System.Drawing.Size(59, 17);
			this.rad2P.TabIndex = 12;
			this.rad2P.Text = "Human";
			this.rad2P.UseVisualStyleBackColor = true;
			// 
			// radComp
			// 
			this.radComp.AutoSize = true;
			this.radComp.Checked = true;
			this.radComp.Location = new System.Drawing.Point(12, 17);
			this.radComp.Name = "radComp";
			this.radComp.Size = new System.Drawing.Size(70, 17);
			this.radComp.TabIndex = 11;
			this.radComp.TabStop = true;
			this.radComp.Text = "Computer";
			this.radComp.UseVisualStyleBackColor = true;
			// 
			// btnNewGame
			// 
			this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnNewGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewGame.Location = new System.Drawing.Point(290, 259);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(134, 35);
			this.btnNewGame.TabIndex = 28;
			this.btnNewGame.Text = "New Game";
			this.btnNewGame.UseVisualStyleBackColor = false;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// lblWhoseTurn
			// 
			this.lblWhoseTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWhoseTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblWhoseTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblWhoseTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWhoseTurn.Location = new System.Drawing.Point(327, 30);
			this.lblWhoseTurn.Name = "lblWhoseTurn";
			this.lblWhoseTurn.Size = new System.Drawing.Size(97, 50);
			this.lblWhoseTurn.TabIndex = 27;
			this.lblWhoseTurn.Text = "X";
			this.lblWhoseTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlGameBoard
			// 
			this.pnlGameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlGameBoard.ColumnCount = 3;
			this.pnlGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.pnlGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33331F));
			this.pnlGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.pnlGameBoard.Location = new System.Drawing.Point(11, 30);
			this.pnlGameBoard.MinimumSize = new System.Drawing.Size(210, 210);
			this.pnlGameBoard.Name = "pnlGameBoard";
			this.pnlGameBoard.RowCount = 3;
			this.pnlGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.pnlGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.pnlGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.pnlGameBoard.Size = new System.Drawing.Size(210, 210);
			this.pnlGameBoard.TabIndex = 33;
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.helpToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(436, 24);
			this.mnuMain.TabIndex = 34;
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.mnuExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "&File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newGameToolStripMenuItem.Text = "&New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(152, 22);
			this.mnuExit.Text = "&Exit";
			this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 343);
			this.Controls.Add(this.pnlGameBoard);
			this.Controls.Add(this.lblNoTurns);
			this.Controls.Add(this.grpDifficulty);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.grpMode);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.lblWhoseTurn);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.MinimumSize = new System.Drawing.Size(452, 360);
			this.Name = "frmMain";
			this.Text = "Tic Tac Toe";
			this.grpDifficulty.ResumeLayout(false);
			this.grpDifficulty.PerformLayout();
			this.grpMode.ResumeLayout(false);
			this.grpMode.PerformLayout();
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblNoTurns;
		internal System.Windows.Forms.GroupBox grpDifficulty;
		internal System.Windows.Forms.RadioButton radImp;
		internal System.Windows.Forms.RadioButton radHard;
		internal System.Windows.Forms.RadioButton radNormal;
		internal System.Windows.Forms.RadioButton radEasy;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.GroupBox grpMode;
		internal System.Windows.Forms.RadioButton rad2P;
		internal System.Windows.Forms.RadioButton radComp;
		internal System.Windows.Forms.Button btnNewGame;
		internal System.Windows.Forms.Label lblWhoseTurn;
		private System.Windows.Forms.TableLayoutPanel pnlGameBoard;
		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

