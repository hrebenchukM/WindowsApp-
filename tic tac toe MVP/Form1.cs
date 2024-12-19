namespace tic_tac_toe_MVP
{  // Представление отвечает только за взаимодействие с пользователем
   // Это соответствует принципу единственной обязанности

    public partial class Form1 : Form, IView
    {
        #region IView Implementation 

        public Image imgX = Image.FromFile(@"Resources\x.png");
        public Image imgO = Image.FromFile(@"Resources\o.png");
        public List<Button> gameBtns { get; private set; }

        public event EventHandler<int> ClickEvent;
        public event EventHandler StartGameEvent;
        public event EventHandler EasyEvent;
        public event EventHandler HardEvent;
        public event EventHandler PlayerFirstEvent;
        public event EventHandler ComputerFirstEvent;

        #endregion IView Implementation 

        public Form1()
        {
            InitializeComponent();
            gameBtns = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var btn in gameBtns)
            {
                btn.Click += button_Click;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            if (btn != null && btn.BackgroundImage == null)
            {
                int index = gameBtns.IndexOf(btn);
                ClickEvent?.Invoke(this, index);
            }
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!easyToolStripMenuItem.Checked && !hardToolStripMenuItem.Checked)
            {
                MessageBox.Show("Выберите уровень - Легкий/Сложный");
                return;
            }

            if (!playerToolStripMenuItem.Checked && !computerToolStripMenuItem.Checked)
            {
                MessageBox.Show("Выберите, кто ходит первым - Игрок/Компьютер");
                return;
            }

            StartGameEvent?.Invoke(this, EventArgs.Empty);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = true;
            HardEvent?.Invoke(this, EventArgs.Empty);
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hardToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = true;
            EasyEvent?.Invoke(this, EventArgs.Empty);
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computerToolStripMenuItem.Checked = true;
            playerToolStripMenuItem.Checked = false;
            ComputerFirstEvent?.Invoke(this, EventArgs.Empty);
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerToolStripMenuItem.Checked = true;
            computerToolStripMenuItem.Checked = false;
            PlayerFirstEvent?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateBoard(List<int> gameBoard)
        {
            for (int i = 0; i < gameBoard.Count; i++)
            {
                Button btn = gameBtns[i];

                if (gameBoard[i] == 1)
                {
                    btn.BackgroundImage = imgX;
                }
                else if (gameBoard[i] == 2)
                {
                    btn.BackgroundImage = imgO;
                }
                else
                {
                    btn.BackgroundImage = null;
                }

                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public bool GameStarted { get; set; }
    }

}

