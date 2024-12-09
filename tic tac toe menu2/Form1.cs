namespace tic_tac_toe_menu2
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Обработчик загрузки формы не требует особых действий в данном контексте.
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

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            if (!playerX)
            {
                ComputerMove();
            }
        }

     

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easy = false;
            MessageBox.Show("Уровень сложности: Сложный");
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easy = true;
            MessageBox.Show("Уровень сложности: Легкий");
           
        }
        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerX = false;
            Reset();
            MessageBox.Show("Первый ход: Компьютер");

        }

        private void noComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerX = true;
            MessageBox.Show("Первый ход: Игрок");
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
            List<Button> emptyButtons = gameBtns.Where(btn => btn.BackgroundImage == null).ToList();

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
            List<Button> emptyButtons = gameBtns.Where(btn => btn.BackgroundImage == null).ToList();

            // Попытка выиграть
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

            // Попытка блокировки хода игрока
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

            bool draw = gameBtns.All(btn => btn.BackgroundImage != null);

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
