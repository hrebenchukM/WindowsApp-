
namespace tic_tac_toe_MVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            уровеньToolStripMenuItem = new ToolStripMenuItem();
            easyToolStripMenuItem = new ToolStripMenuItem();
            hardToolStripMenuItem = new ToolStripMenuItem();
            первымХодитToolStripMenuItem = new ToolStripMenuItem();
            computerToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripStartButton1 = new ToolStripButton();
            toolStripExitButton2 = new ToolStripButton();
            toolStripEasyButton1 = new ToolStripButton();
            toolStripHardButton1 = new ToolStripButton();
            toolStripComputerButton1 = new ToolStripButton();
            toolStripPlayerButton1 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 69);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 96);
            button2.Name = "button2";
            button2.Size = new Size(75, 69);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(184, 96);
            button3.Name = "button3";
            button3.Size = new Size(75, 69);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(22, 171);
            button4.Name = "button4";
            button4.Size = new Size(75, 69);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(103, 171);
            button5.Name = "button5";
            button5.Size = new Size(75, 69);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(184, 171);
            button6.Name = "button6";
            button6.Size = new Size(75, 69);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(22, 246);
            button7.Name = "button7";
            button7.Size = new Size(75, 69);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(103, 246);
            button8.Name = "button8";
            button8.Size = new Size(75, 69);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(184, 246);
            button9.Name = "button9";
            button9.Size = new Size(75, 69);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, уровеньToolStripMenuItem, первымХодитToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(290, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 20);
            fileToolStripMenuItem.Text = "&Игра";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(141, 22);
            newToolStripMenuItem.Text = "&Начать игру";
            newToolStripMenuItem.Click += startGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // уровеньToolStripMenuItem
            // 
            уровеньToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { easyToolStripMenuItem, hardToolStripMenuItem });
            уровеньToolStripMenuItem.Name = "уровеньToolStripMenuItem";
            уровеньToolStripMenuItem.Size = new Size(65, 20);
            уровеньToolStripMenuItem.Text = "Уровень";
            // 
            // easyToolStripMenuItem
            // 
            easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            easyToolStripMenuItem.Size = new Size(128, 22);
            easyToolStripMenuItem.Text = "Легкий";
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            // 
            // hardToolStripMenuItem
            // 
            hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            hardToolStripMenuItem.Size = new Size(128, 22);
            hardToolStripMenuItem.Text = "Сложный";
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;
            // 
            // первымХодитToolStripMenuItem
            // 
            первымХодитToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { computerToolStripMenuItem, playerToolStripMenuItem });
            первымХодитToolStripMenuItem.Name = "первымХодитToolStripMenuItem";
            первымХодитToolStripMenuItem.Size = new Size(99, 20);
            первымХодитToolStripMenuItem.Text = "Первым ходит";
            // 
            // computerToolStripMenuItem
            // 
            computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            computerToolStripMenuItem.Size = new Size(180, 22);
            computerToolStripMenuItem.Text = "Компьютер";
            computerToolStripMenuItem.Click += computerToolStripMenuItem_Click;
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(180, 22);
            playerToolStripMenuItem.Text = "Игрок";
            playerToolStripMenuItem.Click += playerToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripStartButton1, toolStripExitButton2, toolStripEasyButton1, toolStripHardButton1, toolStripComputerButton1, toolStripPlayerButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(290, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripStartButton1
            // 
            toolStripStartButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripStartButton1.Image = (Image)resources.GetObject("toolStripStartButton1.Image");
            toolStripStartButton1.ImageTransparentColor = Color.Magenta;
            toolStripStartButton1.Name = "toolStripStartButton1";
            toolStripStartButton1.Size = new Size(23, 22);
            toolStripStartButton1.Text = "toolStripButton1";
            toolStripStartButton1.TextAlign = ContentAlignment.TopLeft;
            toolStripStartButton1.ToolTipText = "START";
            toolStripStartButton1.Click += startGameToolStripMenuItem_Click;
            // 
            // toolStripExitButton2
            // 
            toolStripExitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripExitButton2.Image = (Image)resources.GetObject("toolStripExitButton2.Image");
            toolStripExitButton2.ImageTransparentColor = Color.Magenta;
            toolStripExitButton2.Name = "toolStripExitButton2";
            toolStripExitButton2.Size = new Size(23, 22);
            toolStripExitButton2.Text = "toolStripButton2";
            toolStripExitButton2.ToolTipText = "EXIT";
            toolStripExitButton2.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripEasyButton1
            // 
            toolStripEasyButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripEasyButton1.Image = (Image)resources.GetObject("toolStripEasyButton1.Image");
            toolStripEasyButton1.ImageTransparentColor = Color.Magenta;
            toolStripEasyButton1.Name = "toolStripEasyButton1";
            toolStripEasyButton1.Size = new Size(23, 22);
            toolStripEasyButton1.Text = "toolStripButton1";
            toolStripEasyButton1.ToolTipText = "EASY";
            toolStripEasyButton1.Click += easyToolStripMenuItem_Click;
            // 
            // toolStripHardButton1
            // 
            toolStripHardButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripHardButton1.Image = (Image)resources.GetObject("toolStripHardButton1.Image");
            toolStripHardButton1.ImageTransparentColor = Color.Magenta;
            toolStripHardButton1.Name = "toolStripHardButton1";
            toolStripHardButton1.Size = new Size(23, 22);
            toolStripHardButton1.Text = "toolStripButton1";
            toolStripHardButton1.ToolTipText = "HARD";
            toolStripHardButton1.Click += hardToolStripMenuItem_Click;
            // 
            // toolStripComputerButton1
            // 
            toolStripComputerButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripComputerButton1.Image = (Image)resources.GetObject("toolStripComputerButton1.Image");
            toolStripComputerButton1.ImageTransparentColor = Color.Magenta;
            toolStripComputerButton1.Name = "toolStripComputerButton1";
            toolStripComputerButton1.Size = new Size(23, 22);
            toolStripComputerButton1.Text = "toolStripButton1";
            toolStripComputerButton1.ToolTipText = "COMPUTER";
            toolStripComputerButton1.Click += computerToolStripMenuItem_Click;
            // 
            // toolStripPlayerButton1
            // 
            toolStripPlayerButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripPlayerButton1.Image = (Image)resources.GetObject("toolStripPlayerButton1.Image");
            toolStripPlayerButton1.ImageTransparentColor = Color.Magenta;
            toolStripPlayerButton1.Name = "toolStripPlayerButton1";
            toolStripPlayerButton1.Size = new Size(23, 22);
            toolStripPlayerButton1.Text = "toolStripButton1";
            toolStripPlayerButton1.ToolTipText = "PLAYER";
            toolStripPlayerButton1.Click += playerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 336);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

     

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem уровеньToolStripMenuItem;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
        private ToolStripMenuItem первымХодитToolStripMenuItem;
        private ToolStripMenuItem computerToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripStartButton1;
        private ToolStripButton toolStripExitButton2;
        private ToolStripButton toolStripEasyButton1;
        private ToolStripButton toolStripHardButton1;
        private ToolStripButton toolStripComputerButton1;
        private ToolStripButton toolStripPlayerButton1;
    }
}
