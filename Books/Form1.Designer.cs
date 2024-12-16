namespace Books
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            опцииToolStripMenuItem = new ToolStripMenuItem();
            AddGood = new ToolStripMenuItem();
            DeleteGood = new ToolStripMenuItem();
            EditGood = new ToolStripMenuItem();
            Add2Good = new ToolStripMenuItem();
            Delete2Good = new ToolStripMenuItem();
            Edit2Good = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(463, 169);
            listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, опцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(487, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenToolStripMenuItem, SaveToolStripMenuItem, выйтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(180, 22);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(180, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(180, 22);
            выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // опцииToolStripMenuItem
            // 
            опцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddGood, DeleteGood, EditGood, Add2Good, Delete2Good, Edit2Good });
            опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            опцииToolStripMenuItem.Size = new Size(56, 20);
            опцииToolStripMenuItem.Text = "Опции";
            // 
            // AddGood
            // 
            AddGood.Name = "AddGood";
            AddGood.Size = new Size(194, 22);
            AddGood.Text = "Добавить автора";
            AddGood.Click += AddGood_Click;
            // 
            // DeleteGood
            // 
            DeleteGood.Name = "DeleteGood";
            DeleteGood.Size = new Size(194, 22);
            DeleteGood.Text = "Удалить автора";
            DeleteGood.Click += DeleteGood_Click;
            // 
            // EditGood
            // 
            EditGood.Name = "EditGood";
            EditGood.Size = new Size(194, 22);
            EditGood.Text = "Редактировать автора";
            EditGood.Click += EditGood_Click;
            // 
            // Add2Good
            // 
            Add2Good.Name = "Add2Good";
            Add2Good.Size = new Size(194, 22);
            Add2Good.Text = "Добавить книгу";
            Add2Good.Click += Add2Good_Click;
            // 
            // Delete2Good
            // 
            Delete2Good.Name = "Delete2Good";
            Delete2Good.Size = new Size(194, 22);
            Delete2Good.Text = "Удалить книгу";
            Delete2Good.Click += Delete2Good_Click;
            // 
            // Edit2Good
            // 
            Edit2Good.Name = "Edit2Good";
            Edit2Good.Size = new Size(194, 22);
            Edit2Good.Text = "Редактировать книгу";
            Edit2Good.Click += Edit2Good_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(192, 253);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Фильтрация";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(463, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "All files|*.*|Text files|*.txt";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "All files|*.*|Text files|*.txt";
            saveFileDialog1.InitialDirectory = "c:\\";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 281);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Авторы и книги";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private ToolStripMenuItem AddGood;
        private ToolStripMenuItem DeleteGood;
        private ToolStripMenuItem EditGood;
        private ToolStripMenuItem Add2Good;
        private ToolStripMenuItem Delete2Good;
        private ToolStripMenuItem Edit2Good;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
