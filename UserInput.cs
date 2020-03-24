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
    public partial class UserInput : Form
    {
        public UserInput()
        {
            InitializeComponent();
        }

        private void UserInput_Load(object sender, EventArgs e)
        {

        }

        private void UserInputSubmitButton_Click(object sender, EventArgs e)
        {
            TicTacToeGame.SetPlayerNames(P1nameTextBox.Text, p2NameTextBox.Text);
            this.Close();
        }

        private void p2NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                UserInputSubmitButton.PerformClick();
        }

        private void p2NameTextBox_TextChanged(object sender, EventArgs e)
        {                   

        }
    }
}
