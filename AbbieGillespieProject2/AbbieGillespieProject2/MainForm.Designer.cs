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
            invalidWordsListBox = new ListBox();
            validWordsLbl = new Label();
            invalidWordsLbl = new Label();
            highScoreBoardBtn = new Button();
            label1 = new Label();
            playerNameTxtBox = new TextBox();
            resetHighScoresBtn = new Button();
            exportStatsBtn = new Button();
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
            submitBtn.Location = new Point(352, 265);
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
            validWordsListBox.Location = new Point(545, 43);
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
            startNewGameBtn.Location = new Point(12, 137);
            startNewGameBtn.Name = "startNewGameBtn";
            startNewGameBtn.Size = new Size(156, 34);
            startNewGameBtn.TabIndex = 11;
            startNewGameBtn.Text = "Start New Game";
            startNewGameBtn.UseVisualStyleBackColor = true;
            startNewGameBtn.Click += startNewGameBtn_Click;
            // 
            // exitGameBtn
            // 
            exitGameBtn.Location = new Point(12, 466);
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
            // invalidWordsListBox
            // 
            invalidWordsListBox.FormattingEnabled = true;
            invalidWordsListBox.ItemHeight = 25;
            invalidWordsListBox.Location = new Point(545, 282);
            invalidWordsListBox.Name = "invalidWordsListBox";
            invalidWordsListBox.Size = new Size(416, 204);
            invalidWordsListBox.TabIndex = 14;
            // 
            // validWordsLbl
            // 
            validWordsLbl.AutoSize = true;
            validWordsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            validWordsLbl.Location = new Point(547, 15);
            validWordsLbl.Name = "validWordsLbl";
            validWordsLbl.Size = new Size(119, 25);
            validWordsLbl.TabIndex = 15;
            validWordsLbl.Text = "Valid Words:";
            // 
            // invalidWordsLbl
            // 
            invalidWordsLbl.AutoSize = true;
            invalidWordsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            invalidWordsLbl.Location = new Point(545, 254);
            invalidWordsLbl.Name = "invalidWordsLbl";
            invalidWordsLbl.Size = new Size(135, 25);
            invalidWordsLbl.TabIndex = 16;
            invalidWordsLbl.Text = "Invalid Words:";
            // 
            // highScoreBoardBtn
            // 
            highScoreBoardBtn.Location = new Point(12, 179);
            highScoreBoardBtn.Name = "highScoreBoardBtn";
            highScoreBoardBtn.Size = new Size(169, 34);
            highScoreBoardBtn.TabIndex = 17;
            highScoreBoardBtn.Text = "High Score Board";
            highScoreBoardBtn.UseVisualStyleBackColor = true;
            highScoreBoardBtn.Click += highScoreBoardBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 33);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 18;
            label1.Text = "Player Name:";
            // 
            // playerNameTxtBox
            // 
            playerNameTxtBox.Location = new Point(329, 30);
            playerNameTxtBox.Name = "playerNameTxtBox";
            playerNameTxtBox.Size = new Size(150, 31);
            playerNameTxtBox.TabIndex = 19;
            // 
            // resetHighScoresBtn
            // 
            resetHighScoresBtn.Location = new Point(13, 336);
            resetHighScoresBtn.Name = "resetHighScoresBtn";
            resetHighScoresBtn.Size = new Size(168, 34);
            resetHighScoresBtn.TabIndex = 20;
            resetHighScoresBtn.Text = "Reset High Scores";
            resetHighScoresBtn.UseVisualStyleBackColor = true;
            resetHighScoresBtn.Click += resetHighScoresBtn_Click;
            // 
            // exportStatsBtn
            // 
            exportStatsBtn.Location = new Point(12, 406);
            exportStatsBtn.Name = "exportStatsBtn";
            exportStatsBtn.Size = new Size(116, 34);
            exportStatsBtn.TabIndex = 21;
            exportStatsBtn.Text = "Export Stats";
            exportStatsBtn.UseVisualStyleBackColor = true;
            exportStatsBtn.Click += exportStatsBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 512);
            Controls.Add(exportStatsBtn);
            Controls.Add(resetHighScoresBtn);
            Controls.Add(playerNameTxtBox);
            Controls.Add(label1);
            Controls.Add(highScoreBoardBtn);
            Controls.Add(invalidWordsLbl);
            Controls.Add(validWordsLbl);
            Controls.Add(invalidWordsListBox);
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
        private ListBox invalidWordsListBox;
        private Label validWordsLbl;
        private Label invalidWordsLbl;
        private Button highScoreBoardBtn;
        private Label label1;
        private TextBox playerNameTxtBox;
        private Button resetHighScoresBtn;
        private Button exportStatsBtn;
    }
}
