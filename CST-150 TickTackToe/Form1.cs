/*
 * Matthew Foley
 * CST-150
 * Activity 6 Tic Tac Tow
 * 3/17/25
 * cictation
 */

using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace CST_150_TickTackToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblWarning.Visible = false;
        }

        String[] gameBoard = new String[9];
        int currentTurn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void checkWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                string combination = "";
                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }
                if (combination.Equals("OOO"))
                {
                    lblWarning.Text = "Congradulations, O has won the match";
                    lblWarning.Visible = true;
                }
                if (combination.Equals("XXX"))
                {
                    lblWarning.Text = "Congradulations, X has won the match";
                    lblWarning.Visible = true;
                }
                if (currentTurn == 9)
                {
                    if (combination.Equals("XXX") || combination.Equals("OOO"))
                    {
                        if (combination.Equals("OOO"))
                        {
                            lblWarning.Text = "Congradulations, O has won the match";
                            lblWarning.Visible = true;
                        }
                        if (combination.Equals("XXX"))
                        {
                            lblWarning.Text = "Congradulations, X has won the match";
                            lblWarning.Visible = true;
                        }
                    }
                    else
                    {
                        lblWarning.Text = "It Is A Draw There Is No Winner";
                        lblWarning.Visible = true;
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[0] = returnSymbol(currentTurn);
                    button1.Text = gameBoard[0];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[1] = returnSymbol(currentTurn);
                    button2.Text = gameBoard[1];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[2] = returnSymbol(currentTurn);
                    button3.Text = gameBoard[2];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[3] = returnSymbol(currentTurn);
                    button4.Text = gameBoard[3];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[4] = returnSymbol(currentTurn);
                    button5.Text = gameBoard[4];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[5] = returnSymbol(currentTurn);
                    button6.Text = gameBoard[5];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[6] = returnSymbol(currentTurn);
                    button7.Text = gameBoard[6];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else
                {
                    currentTurn++;
                    gameBoard[7] = returnSymbol(currentTurn);
                    button8.Text = gameBoard[7];
                    lblWarning.Visible = false;
                    checkWinner();
                }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (lblWarning.Text.Equals("Congradulations, O has won the match") || lblWarning.Text.Equals("Congradulations, X has won the match")) { }
                else { 
                currentTurn++;
                gameBoard[8] = returnSymbol(currentTurn);
                button9.Text = gameBoard[8];
                lblWarning.Visible = false;
                checkWinner();
            }
            }
            else
            {
                lblWarning.Text = "Do Not Press A Taken Space, Pick A Diffrent Space";
                lblWarning.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            lblWarning.Text = "";
            lblWarning.Visible = false;
            gameBoard = new string[9];
            currentTurn = 0;
        }
    }
}
