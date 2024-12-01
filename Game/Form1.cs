using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        int index = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            while (numbers.Count < 16)
            {
                int num = rnd.Next(1, 101); 
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                }
            }

            index = 0;

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8,
                         button9, button10, button11, button12, button13, button14, button15, button16 };

         
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = numbers[i].ToString();
                buttons[i].Enabled = true;
            }


            listBox1.Items.Clear();
            progressBar1.Maximum = (int)numericUpDown1.Value * 10;
            timer1.Start();  
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int num = int.Parse(btn.Text);

                List<int> sortNumbers = new List<int>(numbers);
                sortNumbers.Sort();
                int nextNum = sortNumbers[index];


                if (num == nextNum) 
                {
                    listBox1.Items.Add(num);
                    btn.Enabled = false;
                    index++;

                    if (index == numbers.Count)
                    {
                        timer1.Stop();
                        MessageBox.Show("Вы выиграли!", "Победа");
                    }
                }
            }
        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1; 
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!", "Проигрыш");
                Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8,
                         button9, button10, button11, button12, button13, button14, button15, button16 };

                foreach (var btn in buttons)
                {
                    btn.Enabled = false;
                }
            }
        }

       
    }
}
