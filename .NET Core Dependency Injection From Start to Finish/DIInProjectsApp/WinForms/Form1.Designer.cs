namespace WinForms
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
            helloText = new System.Windows.Forms.Label();
            goodbyeText = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // helloText
            // 
            helloText.AutoSize = true;
            helloText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            helloText.Location = new System.Drawing.Point(12, 9);
            helloText.Name = "helloText";
            helloText.Size = new System.Drawing.Size(90, 37);
            helloText.TabIndex = 0;
            helloText.Text = "label1";
            // 
            // goodbyeText
            // 
            goodbyeText.AutoSize = true;
            goodbyeText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            goodbyeText.Location = new System.Drawing.Point(12, 46);
            goodbyeText.Name = "goodbyeText";
            goodbyeText.Size = new System.Drawing.Size(90, 37);
            goodbyeText.TabIndex = 1;
            goodbyeText.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 395);
            Controls.Add(goodbyeText);
            Controls.Add(helloText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label helloText;
        private System.Windows.Forms.Label goodbyeText;
    }
}
