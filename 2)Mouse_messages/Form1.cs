namespace _2_Mouse_messages
{
    public partial class Form1 : Form
    {
        int leftN = 0;
        int rightN = 0;
        int middleN = 0;
        public Form1()
        {
            InitializeComponent();
            Text = "Windows Forms";
            StartPosition = FormStartPosition.Manual;
            Location = new Point(100, 100);
            Width = 500;
            Height = 500;

        }

        /*
         public event MouseEventHandler MouseMove; - событие
         * 
         public delegate void MouseEventHandler( - делегат.
           object sender, - ссылка на тот объект, которому пришло событие.
           MouseEventArgs events - содержит дополнительную информацию о сообщении мыши.
        );

        Свойства MouseEventArgs.
        public int X {get;} - координаты мыши.
        public int Y {get;}
        public int Delta {get;} - количество сдвигов колеса
        public MouseButtons Button {get;} - перечисление, которое определяет какие кнопки 
                    мыши были нажаты в момент возникновения события. (	Left Middle	Right )
        */
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = string.Format("x = {0}  y = {1}  Левый = {2} Правый: {3} Средний: {4}", e.X, e.Y, leftN, rightN, middleN);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Двойной щелчок мышью", "Обработка сообщений мыши",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;



            if (e.Button == MouseButtons.Right)
            {
                rightN++;
                MessageBox.Show("Вы нажали правую кнопку мыши", "Обработка сообщений мыши",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.Button == MouseButtons.Left)
            {
                leftN++;
                MessageBox.Show("Вы нажали левую кнопку мыши", "Обработка сообщений мыши",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            if (e.Button == MouseButtons.Middle)
            {
                middleN++;
                MessageBox.Show("Вы нажали среднюю кнопку", "Обработка сообщений мыши",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frm.Text = string.Format("x = {0}  y = {1}  Левый = {2} Правый: {3} Средний: {4}", e.X, e.Y, leftN, rightN, middleN);

        }
    }
}
