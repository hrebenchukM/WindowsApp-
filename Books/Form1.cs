namespace Books
{
    public partial class Form1 : Form
    {
        List<Author> authors = new List<Author>();
        Author a = null;
        Book b = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetBooks(Author a)
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked)
            {
                foreach (var book in a.Books)
                {
                    listBox1.Items.Add(book);
                }
            }
            else
            {
                foreach (var author in authors)
                {
                    foreach (var book in author.Books)
                    {
                        listBox1.Items.Add(book);
                    }
                }

            }


        }


        private void DeleteGood_Click(object sender, EventArgs e)
        {
            //�������� ����������� ��������
            if (comboBox1.SelectedIndex == -1)//���� ����� �� ������
            {
                MessageBox.Show("�� �� ������� ������");
                return;
            }
            DialogResult result = MessageBox.Show("�� ������������� ������ ������� ������?", "������� �������", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

        }


        private void AddGood_Click(object sender, EventArgs e)
        {
            //���������� ������
            a = new Author();
            Form2 addform = new Form2(a, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {//���� ������������ ����� ��, ��������� ����� � ������
                comboBox1.Items.Add(a);
                authors.Add(a);
                comboBox1.SelectedItem = a;
            }

        }

        private void EditGood_Click(object sender, EventArgs e)
        {
            a = (Author)comboBox1.SelectedItem;//�������� ������ �� ���������� �������

            //�������������� ������
            if (a == null)//���� ����� �� ������
            {
                MessageBox.Show("�� �� ������� ������"); return;
            }
            int n = comboBox1.SelectedIndex;//���������� ���������� �������
            Form2 editform = new Form2(a, false);
            editform.ShowDialog();
            comboBox1.Items.RemoveAt(n);//������� ���������� �������
            comboBox1.Items.Insert(n, a);//� ��������� ��� ����� � �� �� �������, ����� �� ������������� � ������
            comboBox1.SelectedIndex = n; //����� �������� ���� �������
        }






















        private void Delete2Good_Click(object sender, EventArgs e)
        {
            //�������� ����������� ��������
            if (listBox1.SelectedIndex == -1)//���� ����� �� ������
            {
                MessageBox.Show("�� �� ������� �����");
                return;
            }
            DialogResult result = MessageBox.Show("�� ������������� ������ ������� �����?", "������� ����", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            b = (Book)listBox1.SelectedItem; // �������� ������ �� �����
            a = (Author)comboBox1.SelectedItem; // �������� ������ �� ������
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            a.Books.Remove(b);// ������� ����� �� ������ ���� ������


        }

        private void Add2Good_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)//���� ����� �� ������
            {
                MessageBox.Show("�� �� ������� ������");
                return;
            }
            //���������� ������
            b = new Book();
            Form2 addform = new Form2(b, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {//���� ������������ ����� ��, ��������� ����� � ������
                listBox1.Items.Add(b);
                a = (Author)comboBox1.SelectedItem; // �������� ������ �� ������
                b.Author = a;//������������� ������ �� ���������� ������
                a.Books.Add(b); // ��������� ����� � ������ ���� ����� ������
            }

        }

        private void Edit2Good_Click(object sender, EventArgs e)
        {
            //�������������� ������
            if (listBox1.SelectedIndex == -1)//���� ����� �� ������
            {
                MessageBox.Show("�� �� ������� �����"); return;
            }

            int n = listBox1.SelectedIndex;//���������� ���������� �������
            b = (Book)listBox1.Items[n];//�������� ������ �� ���������� ������� �����
            Form2 editform = new Form2(b, false);
            editform.ShowDialog();
            listBox1.Items.RemoveAt(n);//������� ���������� �������
            listBox1.Items.Insert(n, b);//� ��������� ��� ����� � �� �� �������, ����� �� ������������� � ������
            listBox1.SelectedIndex = n; //����� �������� ���� �������

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBooks((Author)comboBox1.SelectedItem);
        }

























        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName, "���������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Save(saveFileDialog1.FileName);

            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\"; // ������� ��������� �����, ������������ ���������� ����� �����
            openFileDialog1.Multiselect = false; // ��������� ������������� ����� ������
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName, "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load(openFileDialog1.FileName);

            }
        }
        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path, false); 
            try
            {
                foreach (Author author in authors)
                {
                    sw.WriteLine(author.Name); 

                    foreach (Book book in author.Books)
                    {
                        sw.WriteLine(book.Name); 
                    }

                    sw.WriteLine(); 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("������ ����������: " + e.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sw.Close(); 
            }
        }

        public void Load(string path)
        {
            StreamReader sr = new StreamReader(path); 
            try
            {
                string line;
                comboBox1.Items.Clear(); 
                authors.Clear();       

                while ((line = sr.ReadLine()) != null)
                {
                   
                    Author author = new Author
                    {
                        Name = line 
                    };

                   
                    while ((line = sr.ReadLine()) != null && line != "")
                    {
                        Book book = new Book
                        {
                            Name = line 
                        };

                        author.Books.Add(book);
                    }

                    authors.Add(author);
                    comboBox1.Items.Add(author); 
                }
                ResetBooks(null);
            }
            catch (Exception e)
            {
                MessageBox.Show("������ ��������: " + e.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr.Close(); 
            }
        }



    }
}
