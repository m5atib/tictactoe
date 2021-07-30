using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Welcome : Form
    {
        int currentPlayer = 5;
        public Welcome()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 5) MessageBox.Show("choose one sympol");
            else
            {

                PlayingPnl pPnl = new PlayingPnl(currentPlayer , gunaTextBox1.Text);
                pPnl.Show();
                //this.Close();
            }
           
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            currentPlayer = 0;
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            currentPlayer = 1;
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text.Equals("Player Name"))
            {
                gunaTextBox1.Text = " ";
            }
        }

        private void gunaTextBox1_DoubleClick(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text.Equals("Player Name"))
            {
                gunaTextBox1.Text = "";
            }
        }
    }
}
