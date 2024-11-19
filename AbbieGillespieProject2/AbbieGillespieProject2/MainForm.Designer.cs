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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 592);
            Controls.Add(lettersTxtBox);
            Controls.Add(lettersLbl);
            Controls.Add(wordLbl);
            Controls.Add(submitBtn);
            Controls.Add(inputTxtBox);
            Controls.Add(letterLbl1);
            Name = "MainForm";
            Text = "Text Twist by Gillespie";
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
    }
}
