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
            //Удаление выделенного элемента
            if (comboBox1.SelectedIndex == -1)//Если товар не выбран
            {
                MessageBox.Show("Вы не выбрали автора");
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить автора?", "Каталог авторов", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

        }


        private void AddGood_Click(object sender, EventArgs e)
        {
            //Добавление товара
            a = new Author();
            Form2 addform = new Form2(a, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {//если пользователь нажал ок, добавляем товар в список
                comboBox1.Items.Add(a);
                authors.Add(a);
                comboBox1.SelectedItem = a;
            }

        }

        private void EditGood_Click(object sender, EventArgs e)
        {
            a = (Author)comboBox1.SelectedItem;//Забираем ссылку на выделенный элемент

            //редактирование товара
            if (a == null)//Если товар не выбран
            {
                MessageBox.Show("Вы не выбрали автора"); return;
            }
            int n = comboBox1.SelectedIndex;//запоминаем выделенный элемент
            Form2 editform = new Form2(a, false);
            editform.ShowDialog();
            comboBox1.Items.RemoveAt(n);//Удаляем выделенный элемент
            comboBox1.Items.Insert(n, a);//и добавляем его снова в ту же позицию, чтобы он перерисовался в списке
            comboBox1.SelectedIndex = n; //Снова выделяем этот элемент
        }






















        private void Delete2Good_Click(object sender, EventArgs e)
        {
            //Удаление выделенного элемента
            if (listBox1.SelectedIndex == -1)//Если товар не выбран
            {
                MessageBox.Show("Вы не выбрали книгу");
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить книгу?", "Каталог книг", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            b = (Book)listBox1.SelectedItem; // Получаем ссылку на книгу
            a = (Author)comboBox1.SelectedItem; // Получаем ссылку на автора
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            a.Books.Remove(b);// Удаляем книгу из списка книг автора


        }

        private void Add2Good_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)//Если товар не выбран
            {
                MessageBox.Show("Вы не выбрали автора");
                return;
            }
            //Добавление товара
            b = new Book();
            Form2 addform = new Form2(b, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {//если пользователь нажал ок, добавляем товар в список
                listBox1.Items.Add(b);
                a = (Author)comboBox1.SelectedItem; // Получаем ссылку на автора
                b.Author = a;//Устанавливаем ссылку на выбранного автора
                a.Books.Add(b); // Добавляем книгу в список книг этого автора
            }

        }

        private void Edit2Good_Click(object sender, EventArgs e)
        {
            //редактирование товара
            if (listBox1.SelectedIndex == -1)//Если товар не выбран
            {
                MessageBox.Show("Вы не выбрали книгу"); return;
            }

            int n = listBox1.SelectedIndex;//запоминаем выделенный элемент
            b = (Book)listBox1.Items[n];//Забираем ссылку на выделенный элемент книгу
            Form2 editform = new Form2(b, false);
            editform.ShowDialog();
            listBox1.Items.RemoveAt(n);//Удаляем выделенный элемент
            listBox1.Items.Insert(n, b);//и добавляем его снова в ту же позицию, чтобы он перерисовался в списке
            listBox1.SelectedIndex = n; //Снова выделяем этот элемент

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBooks((Author)comboBox1.SelectedItem);
        }

























        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName, "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Save(saveFileDialog1.FileName);

            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\"; // зададим начальную папку, отображенную диалоговым окном файла
            openFileDialog1.Multiselect = false; // запретить множественный выбор файлов
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName, "Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ошибка сохранения: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ошибка загрузки: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr.Close(); 
            }
        }



    }
}
