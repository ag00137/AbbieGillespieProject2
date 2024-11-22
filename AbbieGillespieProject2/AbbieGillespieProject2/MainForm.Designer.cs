namespace AbbieGillespieProject2
{
    partial class MainForm
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
            letterLbl1 = new Label();
            inputTxtBox = new TextBox();
            submitBtn = new Button();
            wordLbl = new Label();
            lettersLbl = new Label();
            lettersTxtBox = new TextBox();
            validWordsListBox = new ListBox();
            timeLbl = new Label();
            timeLeftLbl = new Label();
            menuStrip1 = new MenuStrip();
            timerOptionsToolStripMenuItem = new ToolStripMenuItem();
            oneMinuteToolStripMenuItem = new ToolStripMenuItem();
            twoMinutesToolStripMenuItem = new ToolStripMenuItem();
            threeMinutesToolStripMenuItem = new ToolStripMenuItem();
            startGameBtn = new Button();
            startNewGameBtn = new Button();
            exitGameBtn = new Button();
            twistLettersBtn = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // letterLbl1
            // 
            letterLbl1.AutoSize = true;
            letterLbl1.Location = new Point(216, 97);
            letterLbl1.Name = "letterLbl1";
            letterLbl1.Size = new Size(0, 25);
            letterLbl1.TabIndex = 0;
            // 
            // inputTxtBox
            // 
            inputTxtBox.Location = new Point(289, 228);
            inputTxtBox.Name = "inputTxtBox";
            inputTxtBox.Size = new Size(237, 31);
            inputTxtBox.TabIndex = 1;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(289, 312);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(112, 34);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // wordLbl
            // 
            wordLbl.AutoSize = true;
            wordLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            wordLbl.Location = new Point(158, 234);
            wordLbl.Name = "wordLbl";
            wordLbl.Size = new Size(125, 25);
            wordLbl.TabIndex = 3;
            wordLbl.Text = "Enter a word:";
            // 
            // lettersLbl
            // 
            lettersLbl.AutoSize = true;
            lettersLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            lettersLbl.Location = new Point(208, 188);
            lettersLbl.Name = "lettersLbl";
            lettersLbl.Size = new Size(75, 25);
            lettersLbl.TabIndex = 4;
            lettersLbl.Text = "Letters:";
            // 
            // lettersTxtBox
            // 
            lettersTxtBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lettersTxtBox.Location = new Point(289, 172);
            lettersTxtBox.Name = "lettersTxtBox";
            lettersTxtBox.ReadOnly = true;
            lettersTxtBox.Size = new Size(237, 47);
            lettersTxtBox.TabIndex = 5;
            lettersTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // validWordsListBox
            // 
            validWordsListBox.FormattingEnabled = true;
            validWordsListBox.ItemHeight = 25;
            validWordsListBox.Location = new Point(545, 25);
            validWordsListBox.Name = "validWordsListBox";
            validWordsListBox.Size = new Size(416, 204);
            validWordsListBox.TabIndex = 6;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Location = new Point(12, 43);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(54, 25);
            timeLbl.TabIndex = 7;
            timeLbl.Text = "Time:";
            // 
            // timeLeftLbl
            // 
            timeLeftLbl.AutoSize = true;
            timeLeftLbl.Location = new Point(72, 43);
            timeLeftLbl.Name = "timeLeftLbl";
            timeLeftLbl.Size = new Size(32, 25);
            timeLeftLbl.TabIndex = 8;
            timeLeftLbl.Text = "60";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { timerOptionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(983, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // timerOptionsToolStripMenuItem
            // 
            timerOptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oneMinuteToolStripMenuItem, twoMinutesToolStripMenuItem, threeMinutesToolStripMenuItem });
            timerOptionsToolStripMenuItem.Name = "timerOptionsToolStripMenuItem";
            timerOptionsToolStripMenuItem.Size = new Size(141, 29);
            timerOptionsToolStripMenuItem.Text = "Timer Options";
            timerOptionsToolStripMenuItem.Click += timerOptionsToolStripMenuItem_Click;
            // 
            // oneMinuteToolStripMenuItem
            // 
            oneMinuteToolStripMenuItem.Name = "oneMinuteToolStripMenuItem";
            oneMinuteToolStripMenuItem.Size = new Size(222, 34);
            oneMinuteToolStripMenuItem.Text = " one minute";
            oneMinuteToolStripMenuItem.Click += oneMinuteToolStripMenuItem_Click;
            // 
            // twoMinutesToolStripMenuItem
            // 
            twoMinutesToolStripMenuItem.Name = "twoMinutesToolStripMenuItem";
            twoMinutesToolStripMenuItem.Size = new Size(222, 34);
            twoMinutesToolStripMenuItem.Text = "two minutes";
            twoMinutesToolStripMenuItem.Click += twoMinutesToolStripMenuItem_Click;
            // 
            // threeMinutesToolStripMenuItem
            // 
            threeMinutesToolStripMenuItem.Name = "threeMinutesToolStripMenuItem";
            threeMinutesToolStripMenuItem.Size = new Size(222, 34);
            threeMinutesToolStripMenuItem.Text = "three minutes";
            threeMinutesToolStripMenuItem.Click += threeMinutesToolStripMenuItem_Click;
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(12, 97);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(112, 34);
            startGameBtn.TabIndex = 10;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // startNewGameBtn
            // 
            startNewGameBtn.Location = new Point(12, 546);
            startNewGameBtn.Name = "startNewGameBtn";
            startNewGameBtn.Size = new Size(156, 34);
            startNewGameBtn.TabIndex = 11;
            startNewGameBtn.Text = "Start New Game";
            startNewGameBtn.UseVisualStyleBackColor = true;
            startNewGameBtn.Click += startNewGameBtn_Click;
            // 
            // exitGameBtn
            // 
            exitGameBtn.Location = new Point(494, 532);
            exitGameBtn.Name = "exitGameBtn";
            exitGameBtn.Size = new Size(112, 34);
            exitGameBtn.TabIndex = 12;
            exitGameBtn.Text = "Exit Game";
            exitGameBtn.UseVisualStyleBackColor = true;
            exitGameBtn.Click += exitGameBtn_Click;
            // 
            // twistLettersBtn
            // 
            twistLettersBtn.Location = new Point(338, 132);
            twistLettersBtn.Name = "twistLettersBtn";
            twistLettersBtn.Size = new Size(139, 34);
            twistLettersBtn.TabIndex = 13;
            twistLettersBtn.Text = "Twist Letters";
            twistLettersBtn.UseVisualStyleBackColor = true;
            twistLettersBtn.Click += twistLettersBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 592);
            Controls.Add(twistLettersBtn);
            Controls.Add(exitGameBtn);
            Controls.Add(startNewGameBtn);
            Controls.Add(startGameBtn);
            Controls.Add(timeLeftLbl);
            Controls.Add(timeLbl);
            Controls.Add(validWordsListBox);
            Controls.Add(lettersTxtBox);
            Controls.Add(lettersLbl);
            Controls.Add(wordLbl);
            Controls.Add(submitBtn);
            Controls.Add(inputTxtBox);
            Controls.Add(letterLbl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Text Twist by Gillespie";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label letterLbl1;
        private TextBox inputTxtBox;
        private Button submitBtn;
        private Label wordLbl;
        private Label lettersLbl;
        private TextBox lettersTxtBox;
        private ListBox validWordsListBox;
        private Label timeLbl;
        private Label timeLeftLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem timerOptionsToolStripMenuItem;
        private ToolStripMenuItem oneMinuteToolStripMenuItem;
        private ToolStripMenuItem twoMinutesToolStripMenuItem;
        private ToolStripMenuItem threeMinutesToolStripMenuItem;
        private Button startGameBtn;
        private Button startNewGameBtn;
        private Button exitGameBtn;
        private Button twistLettersBtn;
    }
}
