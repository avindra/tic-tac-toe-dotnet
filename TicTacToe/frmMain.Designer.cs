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
			this.grpDifficulty.SuspendLayout();
			this.grpMode.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNoTurns
			// 
			this.lblNoTurns.Location = new System.Drawing.Point(12, 251);
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
			this.grpDifficulty.Location = new System.Drawing.Point(244, 148);
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
			// lblWhoseTurn
			// 
			this.lblWhoseTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWhoseTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblWhoseTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblWhoseTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWhoseTurn.Location = new System.Drawing.Point(328, 6);
			this.lblWhoseTurn.Name = "lblWhoseTurn";
			this.lblWhoseTurn.Size = new System.Drawing.Size(97, 50);
			this.lblWhoseTurn.TabIndex = 27;
			this.lblWhoseTurn.Text = "X";
			this.lblWhoseTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 322);
			this.Controls.Add(this.lblNoTurns);
			this.Controls.Add(this.grpDifficulty);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.grpMode);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.lblWhoseTurn);
			this.Name = "frmMain";
			this.Text = "Tic Tac Toe";
			this.grpDifficulty.ResumeLayout(false);
			this.grpDifficulty.PerformLayout();
			this.grpMode.ResumeLayout(false);
			this.grpMode.PerformLayout();
			this.ResumeLayout(false);

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
	}
}

