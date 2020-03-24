using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class TicTacToeGame : Form
    {
        bool turn = true; //true=X turn, false =O turn
        int turnCount = 0;
        static string player1;
        static string player2;
        bool againstComputer = false;

        public TicTacToeGame()
        {
            InitializeComponent();
        }

        public static void SetPlayerNames(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void TicTacToeGame_Load(object sender, EventArgs e)
        {
            Form f2 = new UserInput();
            f2.ShowDialog();
            XWinCount.Text = player1;
            OWinCount.Text = player2;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Melissa Hunter", "Tic Tac Toe About");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {   //Assign button to create X or O on click
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            //End turn and disable button once clicked
            
            turn = !turn;
            b.Enabled = false; //Disable button after turn
            turnCount++; //Advance turn count
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
            if ((A1.Text == A2.Text) & (A2.Text == A3.Text) & (!A1.Enabled))
                there_is_a_winner = true;
            if ((B1.Text == B2.Text) & (B2.Text == B3.Text) & (!B1.Enabled))
                there_is_a_winner = true;
            if ((C1.Text == C2.Text) & (C2.Text == C3.Text) & (!C1.Enabled))
                there_is_a_winner = true;

            //vertical checks
            if ((A1.Text == B1.Text) & (B1.Text == C1.Text) & (!A1.Enabled))
                there_is_a_winner = true;
            if ((A2.Text == B2.Text) & (B2.Text == C2.Text) & (!A2.Enabled))
                there_is_a_winner = true;
            if ((A3.Text == B3.Text) & (B3.Text == C3.Text) & (!A3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            if ((A1.Text == B2.Text) & (B2.Text == C3.Text) & (!A1.Enabled))
                there_is_a_winner = true;
            if ((A3.Text == B2.Text) & (B2.Text == C1.Text) & (!C1.Enabled))
                there_is_a_winner = true;
            

            if (there_is_a_winner)
            {
                disableButtons();

                string winner = "";
                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!", "Congrats!");
            }// end if
            else 
            {
                if (turnCount == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Bummer");
                }
               
            }


        }//end checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }//end disabled buttons

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end try
                catch { }
            }
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Each player takes a turn until \nthey get three matches in a row.\nIf no player wins, its a draw.", "How To Play");
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }//end button enter event

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }//end mouse leave event
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";

        }

        private void XWinCount_Click(object sender, EventArgs e)
        {

        }
    }
}
