namespace gmail_checker
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
            domainsText = new RichTextBox();
            label1 = new Label();
            check = new Button();
            SuspendLayout();
            // 
            // domainsText
            // 
            domainsText.Location = new Point(12, 31);
            domainsText.Name = "domainsText";
            domainsText.Size = new Size(324, 411);
            domainsText.TabIndex = 0;
            domainsText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 1;
            label1.Text = "Domains:";
            // 
            // check
            // 
            check.Location = new Point(12, 449);
            check.Name = "check";
            check.Size = new Size(324, 36);
            check.TabIndex = 2;
            check.Text = "CHECK";
            check.UseVisualStyleBackColor = true;
            check.Click += Check_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 493);
            Controls.Add(check);
            Controls.Add(label1);
            Controls.Add(domainsText);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GMAIL DOMAINS BY MALOHTIE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox domainsText;
        private Label label1;
        private Button check;
    }
}