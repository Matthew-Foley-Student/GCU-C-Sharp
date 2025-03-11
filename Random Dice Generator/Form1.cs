/*
 * Matthew Foley
 * CST-150
 * Random Dice Roller
 * 3/10/25
 * Citation Here
 */

namespace Random_Dice_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RollRandomDiceEvent(object sender, EventArgs e)
        {
            Random rand = new Random();
            int rand1 = rand.Next(1,6);
            int rand2 = rand.Next(1, 6);
            if (rand1 == 1)
            {
                pctDice1.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-one.png";
            }
            if (rand2 == 1)
            {
                pctDice2.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-one.png";
            }
            if (rand1 == 2)
            {
                pctDice1.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-two.png";
            }
            if (rand2 == 2)
            {
                pctDice2.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-two.png";
            }
            if (rand1 == 3)
            {
                pctDice1.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-three.png";
            }
            if (rand2 == 3)
            {
                pctDice2.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-three.png";
            }
            if (rand1 == 4)
            {
                pctDice1.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-four.png";
            }
            if (rand2 == 4)
            {
                pctDice2.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-four.png";
            }
            if (rand1 == 5)
            {
                pctDice1.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-five.png";
            }
            if (rand2 == 5)
            {
                pctDice2.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-five.png";
            }
            if (rand1 == 6)
            {
                pctDice1.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-six.png";
            }
            if (rand2 == 6)
            {
                pctDice2.ImageLocation = "C:\\Users\\Jarvis\\Desktop\\C#\\Week 5\\Activity Week 4\\Random Dice Generator\\bin\\Debug\\net9.0-windows\\dice-six-faces-six.png";
            }
        }
    }
}
