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
        public Welcome()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayingPnl pPnl= new PlayingPnl();
            pPnl.Show();
           
        }
    }
}
