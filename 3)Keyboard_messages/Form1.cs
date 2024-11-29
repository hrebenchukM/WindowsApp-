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



            KeyPreview = true; // ��������� ���������� ����� ��������� �������� ���� (�����)
            Text = "���������� ������: " + Screen.PrimaryScreen?.Bounds.Width.ToString() +
                "x" + Screen.PrimaryScreen?.Bounds.Height.ToString()
                + "   ������� ������� ������: " + Screen.GetWorkingArea(this).Width.ToString() +
                "x" + Screen.GetWorkingArea(this).Height.ToString();

        }
        /*
            public delegate void KeyEventHandler(
               Object sender,- ������ �� ��� ������, �������� ������ �������.
               KeyEventArgs e - �������� �������������� ���������� � ������������ ���������.
           );

           �������� KeyEventArgs.
           public int KeyValue { get; } - ����������� ��� �������
           public Keys KeyCode { get; } - �������� �������
           public Keys KeyData { get; } - �������� ������� ������� ������ � ������ �������, �������������, 
                                          ����� �� ������ CTRL, SHIFT � ALT ���� ������������ ������ 
           public enum Keys � �������� ������� (��������, Keys.Return, Keys.Left, Keys.A � �.�.)
       */

        /*
          public delegate void KeyEventHandler(
             Object sender,- ������ �� ��� ������, �������� ������ �������.
             KeyEventArgs e - �������� �������������� ���������� � ������������ ���������.
         );

         �������� KeyEventArgs.
         public int KeyValue { get; } - ��� �������
         public Keys KeyCode { get; } - �������� �������
         public Keys KeyData { get; } - �������� ������� ������� ������ � ������ �������, �������������, 
                                        ����� �� ������ CTRL, SHIFT � ALT ���� ������������ ������ 
         public enum Keys - �������� ������� (��������, Keys.Return, Keys.Left, Keys.A � �.�.)
     */

        /*
            public Timer(); - �����������.
            public int Interval {get; set;} - ��� ������� ��������� � �������������. 
            public void Start(); - ��������� ������
            public void Stop(); - ������������� ������.
            public virtual bool Enabled {get; set;} - ��������� ��� ������������� ������.
            public event EventHandler Tick; - ������� ��� ��������� ���������� �������
            public delegate void EventHandler( 
               object sender, - ������ �� ��� ������, ��� �������� ��������� �������
               EventArgs e  - �������������� ���������� � �������.
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
                MessageBox.Show("������ ������� <ENTER>");
            else if (e.KeyCode == Keys.Escape)
              MessageBox.Show("������ ������� <Escape>");
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

