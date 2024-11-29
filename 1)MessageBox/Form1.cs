using System.Windows.Forms;
namespace _1_MessageBox
{

    /*
    public static DialogResult Show( - отображает Message Box
       string text, - содержимое 
       string caption, - заголовок
       MessageBoxButtons buttons, - enum кнопок
				    AbortRetryIgnore
 				    OK
				    OKCancel
 				    RetryCancel
				    YesNo
 				    YesNoCancel
       MessageBoxIcon icon - enum иконки
 				    Asterisk
 				    Error
 				    Exclamation
 				    Question
    );
    DialogResult определяет на какую кнопку нажал пользователь для закрытия Message Box.
 			    OK
 			    Cancel
 			    Ignore
*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Старт!", "Окна сообщений");
            bool play;

            do
            {
                int min = 1;
                int max = 100;
                int attempts = 0;
                bool end = false;

                MessageBox.Show("Задумайте число от 1 до 100",
                    "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (!end)
                {
                    int guess = (min + max) / 2;
                    attempts++;

                    DialogResult result = MessageBox.Show($"Ваше число {guess}?",
                        "Угадай число", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        end = true;
                        MessageBox.Show($"Ваше число: {guess}. Попытки: {attempts}.",
                            "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.No)
                    {
                        DialogResult highOrLow = MessageBox.Show($"Ваше число > {guess}?",
                            "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                        MessageBox.Show("Конец игры.",
                            "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (min > max)
                    {
                        MessageBox.Show("Ошибка. min > max.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult again = MessageBox.Show("Сыграем снова?",
                    "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                play = again == DialogResult.Yes;
            } while (play);

        }



    }
}

