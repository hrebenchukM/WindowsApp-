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
         public event MouseEventHandler MouseMove; - �������
         * 
         public delegate void MouseEventHandler( - �������.
           object sender, - ������ �� ��� ������, �������� ������ �������.
           MouseEventArgs events - �������� �������������� ���������� � ��������� ����.
        );

        �������� MouseEventArgs.
        public int X {get;} - ���������� ����.
        public int Y {get;}
        public int Delta {get;} - ���������� ������� ������
        public MouseButtons Button {get;} - ������������, ������� ���������� ����� ������ 
                    ���� ���� ������ � ������ ������������� �������. (	Left Middle	Right )
        */
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = string.Format("x = {0}  y = {1}  ����� = {2} ������: {3} �������: {4}", e.X, e.Y, leftN, rightN, middleN);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("������� ������ �����", "��������� ��������� ����",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;



            if (e.Button == MouseButtons.Right)
            {
                rightN++;
                MessageBox.Show("�� ������ ������ ������ ����", "��������� ��������� ����",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.Button == MouseButtons.Left)
            {
                leftN++;
                MessageBox.Show("�� ������ ����� ������ ����", "��������� ��������� ����",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            if (e.Button == MouseButtons.Middle)
            {
                middleN++;
                MessageBox.Show("�� ������ ������� ������", "��������� ��������� ����",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frm.Text = string.Format("x = {0}  y = {1}  ����� = {2} ������: {3} �������: {4}", e.X, e.Y, leftN, rightN, middleN);

        }
    }
}
