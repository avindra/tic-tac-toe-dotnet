using System.Windows.Forms;

namespace TicTacToe
{
	/// <summary>
	/// A class which provides useful and common
	/// functionality on top of the Button class for
	/// Tic-Tac-Toe.
	/// </summary>
	partial class btnSquare : Button
	{

		/// <summary>
		/// A private instance variable for storing
		/// whether or not the current square is an X.
		/// 
		/// Cannot be used publicly because it needs
		/// to be used in conjunction with whether or not
		/// the Button is enabled.
		/// </summary>
		private bool blnIsX = false;

		/// <summary>
		/// Constructor with common properties to every single btnSquare.
		/// </summary>
		public btnSquare()
		{
			this.Size = new System.Drawing.Size(65, 70);
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.Yellow;
			this.UseVisualStyleBackColor = false;
		}

		/// <summary>
		/// Returns whether or not the current square is an "X".
		/// </summary>
		public bool isX()
		{
			return !this.Enabled && blnIsX;
		}

		/// <summary>
		/// Returns whether or not the current square is an "O".
		/// </summary>
		public bool isO()
		{
			return !this.Enabled && !blnIsX;
		}

		/// <summary>
		/// Purely for the sake of reducing code in computerMove.
		/// </summary>
		/// <param name="checkX">Whether or not we're checking for X.</param>
		public bool autoCheck(bool checkX)
		{
			return checkX ? isX() : isO();
		}

		public void setX()
		{
			this.Text = "X";
			this.blnIsX = true;
			this.Enabled = false;
		}

		public void setO()
		{
			this.Text = "O";
			this.blnIsX = false;
			this.Enabled = false;
		}

		/// <summary>
		/// Call this method whenever you need to
		/// unset or reset the square.
		/// </summary>
		public void unset()
		{
			this.Text = "";
			this.Enabled = true;
		}
	}
}
