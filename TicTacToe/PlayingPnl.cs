using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class PlayingPnl : Form
    {

        int[] matrixPatel = { 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        int[,] allChances = new int[8,3]  
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
         };
     

        int currentPlayer , attemptNO = 0;
        
        public PlayingPnl(int cp ,string playername)
        {
           

            InitializeComponent();
            currentPlayer = cp;
            bunifuCustomLabel1.Text = playername;
        }
        
        public bool isWinner(int player)
        {
            bool XPlayer = true;
            for (int i=0; i<8; i++)
            {
                XPlayer = false;
                for (int j=0; j<3; j++)
                {
                    if (matrixPatel[(int)allChances.GetValue(i, j)] == player)
                    {
                        XPlayer = true;
                    }
                    else
                    {
                        XPlayer = false;
                        break;
                    }
                }
                if (XPlayer == true)
                {
                    return true;
                    
                }
            }
            return false;
        }
       
        private void PlayingPnl_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }
      
        private void gunaButton1_Click(object sender, EventArgs e)
        {
                anyButton_Click(gunaButton1, 0);
        }
        public void anyButton_Click (Guna.UI.WinForms.GunaButton btn, int row )
        {
            attemptNO++;
            if (attemptNO <9)
            {
                if (currentPlayer == 1)
                {
                    btn.Image = (System.Drawing.Image)(TicTacToe.Properties.Resources.Group_1);
                    matrixPatel.SetValue(1, row);
                    currentPlayer = 0;
                    
                  
                }
                else if (currentPlayer == 0)
                {
                    btn.Image = (System.Drawing.Image)(TicTacToe.Properties.Resources.Ellipse_6);
                    matrixPatel.SetValue(0, row);
                    currentPlayer = 1;
                  
                    
                }
                btn.Enabled = false;
                
                whosWinner();
            }
            else
            {
                MessageBox.Show("no more attempts");
            }

        }
        public void whosWinner()
        {

            if (isWinner(1))
            {
                timer1.Stop();
                MessageBox.Show("the winner is X          \n       "+ gunaLabel2.Text);
                gunaShadowPanel2.Enabled = false;
                this.Hide();
            }
            else if (isWinner(0))
            {
                timer1.Stop();
                MessageBox.Show("the winner is O         \n       " + gunaLabel2.Text);
                gunaShadowPanel2.Enabled = false;
                this.Hide();
            }


        }
       
        
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.Application.Exit();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
             anyButton_Click(gunaButton2, 1);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
           

            anyButton_Click(gunaButton3, 2);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            
            anyButton_Click(gunaButton4, 3);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
           
            anyButton_Click(gunaButton5, 4);
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
           
            anyButton_Click(gunaButton6 ,5);
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
          
            anyButton_Click(gunaButton7 ,6);
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
          
            anyButton_Click(gunaButton8 ,7);
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
           
            anyButton_Click(gunaButton9 ,8);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            Welcome we = new Welcome();
            we.Show();
            this.Close();
        }
        int seconds = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            gunaLabel2.Text = TimeSpan.FromSeconds(seconds).ToString("hh\\:mm");
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
