namespace PracticeStrings
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
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblPalindrome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxWord
            // 
            this.textBoxWord.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWord.Location = new System.Drawing.Point(125, 100);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(292, 46);
            this.textBoxWord.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(48, 41);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(467, 45);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Type in a word and check if it is a Palindrome:";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(173, 173);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(185, 44);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter Word";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblPalindrome
            // 
            this.lblPalindrome.AutoSize = true;
            this.lblPalindrome.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalindrome.Location = new System.Drawing.Point(117, 271);
            this.lblPalindrome.Name = "lblPalindrome";
            this.lblPalindrome.Size = new System.Drawing.Size(0, 45);
            this.lblPalindrome.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 351);
            this.Controls.Add(this.lblPalindrome);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.textBoxWord);
            this.Name = "Form1";
            this.Text = "String Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblPalindrome;
    }
}

