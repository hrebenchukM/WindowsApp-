using System.Windows.Forms;

namespace _3_Keyboard_messages
{
    public partial class Form1 : Form
    {
        static int left;
        static int top;
        static int speed = 10;
        static bool move = false;
        public Form1()
        {
            InitializeComponent();


            Width = 400;
            Height = 300;
            StartPosition = FormStartPosition.Manual;
            left = (Screen.PrimaryScreen.Bounds.Width - 300) / 2;
            top = (Screen.PrimaryScreen.Bounds.Height - 300) / 2;
            Location = new Point(left, top);



            KeyPreview = true; // Сообщения клавиатуры будут приходить главному окну (форме)
            Text = "Разрешение экрана: " + Screen.PrimaryScreen?.Bounds.Width.ToString() +
                "x" + Screen.PrimaryScreen?.Bounds.Height.ToString()
                + "   Рабочая область экрана: " + Screen.GetWorkingArea(this).Width.ToString() +
                "x" + Screen.GetWorkingArea(this).Height.ToString();

        }
        /*
            public delegate void KeyEventHandler(
               Object sender,- ссылка на тот объект, которому пришло событие.
               KeyEventArgs e - содержит дополнительную информацию о клавиатурном сообщении.
           );

           Свойства KeyEventArgs.
           public int KeyValue { get; } - виртуальный код клавиши
           public Keys KeyCode { get; } - название клавиши
           public Keys KeyData { get; } - название нажатой клавиши вместе с любыми флагами, показывающими, 
                                          какие из клавиш CTRL, SHIFT и ALT были одновременно нажаты 
           public enum Keys – название клавиши (например, Keys.Return, Keys.Left, Keys.A и т.д.)
       */

        /*
          public delegate void KeyEventHandler(
             Object sender,- ссылка на тот объект, которому пришло событие.
             KeyEventArgs e - содержит дополнительную информацию о клавиатурном сообщении.
         );

         Свойства KeyEventArgs.
         public int KeyValue { get; } - код клавиши
         public Keys KeyCode { get; } - название клавиши
         public Keys KeyData { get; } - название нажатой клавиши вместе с любыми флагами, показывающими, 
                                        какие из клавиш CTRL, SHIFT и ALT были одновременно нажаты 
         public enum Keys - название клавиши (например, Keys.Return, Keys.Left, Keys.A и т.д.)
     */

        /*
            public Timer(); - конструктор.
            public int Interval {get; set;} - для задания интервала в миллисекундах. 
            public void Start(); - запускает таймер
            public void Stop(); - останавливает таймер.
            public virtual bool Enabled {get; set;} - запускает или останавливает таймер.
            public event EventHandler Tick; - событие для обработки прерываний таймера
            public delegate void EventHandler( 
               object sender, - ссылка на тот таймер, для которого сработало событие
               EventArgs e  - дополнительная информация о событии.
            );
        */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form frm = (Form)sender;


            switch (e.KeyCode)
            {
                case Keys.Enter:
                    move = true;
                    left = 0;
                    top = 0;
                    frm.Location = new Point(left, top);
                    timer1.Start();
                    break;
                case Keys.Escape:
                    move = false;
                    timer1.Stop();
                    break;
            }


            frm.Text = "KeyValue = " + e.KeyValue.ToString()
                + "   KeyCode = " + e.KeyCode
                + "   KeyData = " + e.KeyData;


            if (e.KeyCode == Keys.Return)
                MessageBox.Show("Нажата клавиша <ENTER>");
            else if (e.KeyCode == Keys.Escape)
              MessageBox.Show("Нажата клавиша <Escape>");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

            if (!move) return;
            int screenW = 1800;
            int screenH = 900; 


            Text = DateTime.Now.ToString();

            if (top == 0 && left + Width < screenW)
                left += speed;
            else if (left + Width >= screenW && top + Height < screenH)
                top += speed; 
            else if (top + Height >= screenH && left > 0)
                left -= speed;
            else if (left <= 0 && top > 0)
                top -= speed;

           Location = new Point(left, top); 

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                timer1.Start();
            if (e.Button == MouseButtons.Right)
                timer1.Stop();
        }
    }
}

