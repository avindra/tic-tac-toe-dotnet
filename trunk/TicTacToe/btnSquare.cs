using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{

    public class btnSquare : Button
    {
        private bool blnIsX = false;
        public bool isX()
        {
            return !this.Enabled && blnIsX;
        }

        public bool isO()
        {
            return !this.Enabled && !blnIsX;
        }

        public bool isFree()
        {
            return this.Enabled;
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

        public void unset()
        {
            this.Text = "";
            this.Enabled = true;
        }
    }
}
