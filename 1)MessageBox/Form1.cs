using System.Windows.Forms;
namespace _1_MessageBox
{

    /*
    public static DialogResult Show( - ���������� Message Box
       string text, - ���������� 
       string caption, - ���������
       MessageBoxButtons buttons, - enum ������
				    AbortRetryIgnore
 				    OK
				    OKCancel
 				    RetryCancel
				    YesNo
 				    YesNoCancel
       MessageBoxIcon icon - enum ������
 				    Asterisk
 				    Error
 				    Exclamation
 				    Question
    );
    DialogResult ���������� �� ����� ������ ����� ������������ ��� �������� Message Box.
 			    OK
 			    Cancel
 			    Ignore
*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("�����!", "���� ���������");
            bool play;

            do
            {
                int min = 1;
                int max = 100;
                int attempts = 0;
                bool end = false;

                MessageBox.Show("��������� ����� �� 1 �� 100",
                    "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (!end)
                {
                    int guess = (min + max) / 2;
                    attempts++;

                    DialogResult result = MessageBox.Show($"���� ����� {guess}?",
                        "������ �����", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        end = true;
                        MessageBox.Show($"���� �����: {guess}. �������: {attempts}.",
                            "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.No)
                    {
                        DialogResult highOrLow = MessageBox.Show($"���� ����� > {guess}?",
                            "������ �����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (highOrLow == DialogResult.Yes)
                        {
                            min = guess + 1;
                        }
                        else
                        {
                            max = guess - 1;
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("����� ����.",
                            "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (min > max)
                    {
                        MessageBox.Show("������. min > max.",
                            "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult again = MessageBox.Show("������� �����?",
                    "������ �����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                play = again == DialogResult.Yes;
            } while (play);

        }



    }
}

