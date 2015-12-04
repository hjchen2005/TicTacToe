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
    public partial class Form1 : Form
    {
        bool turn = true; // true: A's turn, false: B's turn
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the game?", "Infomate", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        } // end method

        private void button_click(object sender, EventArgs e)
        {
            bool someoneWins = false;
            Button b = (Button)sender;
            if (turn == true) // A's turn = true
                b.Text = "X";
            else if (!turn) // B's turn = false
                b.Text = "O";
            else
                MessageBox.Show("Something's wrong, no one can play at the moment :-(");
            b.Enabled = false;
            /*
            while (turnCount <= 9)
            {
                turnCount++; // Global variable
                turn = !turn; // Swtich turn from A to B or from B to A
                b.Enabled = false;
                while (someoneWins == false)
                {
                    someoneWins = checkForWinners(someoneWins);
                } //end while
            }// end both whiles
            printWinner(someoneWins);*/
            checkForWinner();
        } // end method


        private void checkForWinner() {
            bool thereIsAWinner = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            
                thereIsAWinner= true;
            
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                thereIsAWinner= true;
            }
            else if ((c1.Text == b2.Text) && (b2.Text == a3.Text) && (!c1.Enabled))
            {
                thereIsAWinner= true;
            }

            // Andrew's cross
            else if ((a1.Text == a2.Text) && (b2.Text == c3.Text))
            {
                thereIsAWinner= true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text))
            {
                thereIsAWinner= true;
            }
            // verticals
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text))
            {
                thereIsAWinner= true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text))
            {
                thereIsAWinner= true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text))
            {
                thereIsAWinner= true;
            }

            if (thereIsAWinner) {
                String winner="";
                if (turn)
                    winner = "O";
                else winner = "X";
                MessageBox.Show(winner + " wins!");
            }

        }

        /*
        private bool checkForWinners(bool someoneWins)
        {
            //foreach(Control c in Control)

            // Horizontals
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {
                return true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                return true;
            }
            else if ((c1.Text == b2.Text) && (b2.Text == a3.Text) && (!c1.Enabled))
            {
                return true;
            }

            // Andrew's cross
            else if ((a1.Text == a2.Text) && (b2.Text == c3.Text))
            {
                return true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text))
            {
                return true;
            }
            // verticals
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text))
            {
                return true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text))
            {
                return true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text))
            {
                return true;
            }
            else if (turnCount == 9)
            {
                return false;
            }
            return false;
        }// end method*/

        public void printWinner(string winnerName, bool someoneWins)
        {

        }

        public void printWinner(bool someoneWins)
        {
            disableOtherButtons();
            if (someoneWins)
            {
                char winner = 'X';
                if (turn == true)
                    winner = 'O';
                MessageBox.Show(winner + " wins!");
            } // end if
        }

        private void disableOtherButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    c.Enabled = false;
                }// end foreach
            }// end try 
            catch (Exception rEx)
            {
                Console.WriteLine("Error: " + rEx);
            }
        }
    }
}
