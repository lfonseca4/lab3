namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(436, 206);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(164, 67);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLabel.Location = new System.Drawing.Point(82, 102);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(200, 48);
            this.PromptLabel.TabIndex = 1;
            this.PromptLabel.Text = "What is:";
            this.PromptLabel.Click += new System.EventHandler(this.PromptLabel_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(506, 9);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(94, 25);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(450, 124);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(114, 26);
            this.AnswerTextBox.TabIndex = 5;
            this.AnswerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBox_TextChanged);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(90, 206);
            this.NewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(154, 67);
            this.NewButton.TabIndex = 6;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(85, 9);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(97, 25);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Time: 10";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 299);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PromptLabel);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Form1";
            this.Text = "The Multiplication Game";
            this.Load += new System.EventHandler(this.Lab3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

            #endregion

            private System.Windows.Forms.Button SubmitButton;
            private System.Windows.Forms.Label PromptLabel;
            private System.Windows.Forms.Label ScoreLabel;
            private System.Windows.Forms.TextBox AnswerTextBox;
            private System.Windows.Forms.Button NewButton;
            private System.Windows.Forms.Label TimeLabel;       


    }
}

