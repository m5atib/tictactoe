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
    public partial class PlayingPnl : Form
    {
        public PlayingPnl()
        {
            InitializeComponent();
        }

        private void PlayingPnl_Load(object sender, EventArgs e)
        {


        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            // to set image in butto that user clicked

            //gunaButton1.Image = (System.Drawing.Image)(TicTacToe.Properties.Resources.Ellipse_6);
            
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.Application.Exit();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Welcome we = new Welcome();
            we.Show();

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
