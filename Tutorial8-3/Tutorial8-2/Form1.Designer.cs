namespace Tutorial8_2
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unformatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(52, 51);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(133, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a telephone number in the format (XXX)XXX-XXX and I will unformat it";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unformatButton
            // 
            this.unformatButton.Location = new System.Drawing.Point(12, 198);
            this.unformatButton.Name = "unformatButton";
            this.unformatButton.Size = new System.Drawing.Size(64, 23);
            this.unformatButton.TabIndex = 3;
            this.unformatButton.Text = "unformat";
            this.unformatButton.UseVisualStyleBackColor = true;
            this.unformatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(160, 198);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(67, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(101, 100);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 233);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.unformatButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button unformatButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

