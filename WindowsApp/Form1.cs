namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//генииальная вещь 
        }

        private void button1_Click(object sender, EventArgs e)//обработчик собітия клик по кнопке 
        {
            label1.Text=textBox1.Text;
        }
    }
}
