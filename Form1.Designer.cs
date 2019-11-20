namespace DistanceConverterZafar
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.FromListBox = new System.Windows.Forms.ListBox();
            this.ToDistanceListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(228, 35);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumberTextBox.TabIndex = 1;
            // 
            // FromListBox
            // 
            this.FromListBox.FormattingEnabled = true;
            this.FromListBox.ItemHeight = 16;
            this.FromListBox.Location = new System.Drawing.Point(30, 105);
            this.FromListBox.Name = "FromListBox";
            this.FromListBox.Size = new System.Drawing.Size(120, 68);
            this.FromListBox.TabIndex = 2;
            // 
            // ToDistanceListBox
            // 
            this.ToDistanceListBox.FormattingEnabled = true;
            this.ToDistanceListBox.ItemHeight = 16;
            this.ToDistanceListBox.Location = new System.Drawing.Point(208, 105);
            this.ToDistanceListBox.Name = "ToDistanceListBox";
            this.ToDistanceListBox.Size = new System.Drawing.Size(120, 68);
            this.ToDistanceListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted Distance";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(30, 254);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 29);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(253, 254);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 29);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(146, 254);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 29);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Location = new System.Drawing.Point(208, 196);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(120, 30);
            this.AnswerLabel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(406, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToDistanceListBox);
            this.Controls.Add(this.FromListBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.ListBox FromListBox;
        private System.Windows.Forms.ListBox ToDistanceListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

