namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        private bool playerX = true;
        private bool easy = true;
        private Image imgX = Image.FromFile(@"Resources\x.png");
        private Image imgO = Image.FromFile(@"Resources\o.png");
        private List<Button> gameBtns;

        public Form1()
        {
            InitializeComponent();
            gameBtns = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            foreach (Button btn in gameBtns)
            {
                btn.BackgroundImage = null;

            }

            playerX = !checkBox1.Checked;
            if (!playerX)
            {
                ComputerMove();
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && btn.BackgroundImage == null && playerX)
            {
                btn.BackgroundImage = imgX;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                if (CheckGameState())
                {
                    return;
                }

                playerX = false;
                ComputerMove();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            playerX = !checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            easy = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            easy = false;
        }

        private void ComputerMove()
        {
            if (easy)
            {
                RandomMove();
            }
            else
            {
                SmartMove();
            }

            if (!CheckGameState())
            {
                playerX = true;
            }

        }

        private void RandomMove()
        {
            List<Button> emptyButtons = new List<Button>();
            foreach (Button btn in gameBtns)
            {
                if (btn.BackgroundImage == null)
                {
                    emptyButtons.Add(btn);
                }
            }

            if (emptyButtons.Count > 0)
            {
                Random rand = new Random();
                Button btn = emptyButtons[rand.Next(emptyButtons.Count)];
                btn.BackgroundImage = imgO;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void SmartMove()
        {
            List<Button> emptyButtons = new List<Button>();
            foreach (Button btn in gameBtns)
            {
                if (btn.BackgroundImage == null)
                {
                    emptyButtons.Add(btn);
                }
            }


            // попітка победить
            foreach (Button btn in emptyButtons)
            {
                btn.BackgroundImage = imgO;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                if (CheckGameState())
                {
                    return;
                }
                btn.BackgroundImage = null;
            }

            // попітка блокировки победі игрока
            foreach (Button btn in emptyButtons)
            {
                btn.BackgroundImage = imgX;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                if (CheckWin())
                {
                    btn.BackgroundImage = imgO;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    return;
                }
                btn.BackgroundImage = null;
            }

            RandomMove();
        }

        private bool CheckGameState()
        {

            if (CheckWin())
            {
                MessageBox.Show(playerX ? "Человек X выиграл!" : "Компьютер O выиграл!");
                Reset();
                return true;
            }

            bool draw = true;
            foreach (Button btn in gameBtns)
            {
                if (btn.BackgroundImage == null)
                {
                    draw = false;
                }
            }


            if (draw)
            {
                MessageBox.Show("Ничья!");
                Reset();
                return true;
            }

            return false;
        }

        private void Reset()
        {
            foreach (Button btn in gameBtns)
            {
                btn.BackgroundImage = null;
            }

            playerX = true;
        }

        private bool CheckLine(Button b1, Button b2, Button b3)
        {
            return b1.BackgroundImage != null &&
                   b1.BackgroundImage == b2.BackgroundImage &&
                   b1.BackgroundImage == b3.BackgroundImage;
        }

        private bool CheckWin()
        {
            return CheckLine(button1, button2, button3) ||
                   CheckLine(button4, button5, button6) ||
                   CheckLine(button7, button8, button9) ||
                   CheckLine(button1, button4, button7) ||
                   CheckLine(button2, button5, button8) ||
                   CheckLine(button3, button6, button9) ||
                   CheckLine(button1, button5, button9) ||
                   CheckLine(button3, button5, button7);
        }
    }
}
