namespace WinFormsUI
{
    partial class ToDoForm
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
            this.ToDoListBox = new System.Windows.Forms.ListBox();
            this.AddToDoTextBox = new System.Windows.Forms.TextBox();
            this.AddToDoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToDoListBox
            // 
            this.ToDoListBox.BackColor = System.Drawing.Color.DimGray;
            this.ToDoListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToDoListBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListBox.ForeColor = System.Drawing.Color.White;
            this.ToDoListBox.FormattingEnabled = true;
            this.ToDoListBox.ItemHeight = 24;
            this.ToDoListBox.Location = new System.Drawing.Point(12, 12);
            this.ToDoListBox.Name = "ToDoListBox";
            this.ToDoListBox.Size = new System.Drawing.Size(422, 576);
            this.ToDoListBox.Sorted = true;
            this.ToDoListBox.TabIndex = 0;
            this.ToDoListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToDoListBox_KeyDown);
            // 
            // AddToDoTextBox
            // 
            this.AddToDoTextBox.Location = new System.Drawing.Point(148, 608);
            this.AddToDoTextBox.Multiline = true;
            this.AddToDoTextBox.Name = "AddToDoTextBox";
            this.AddToDoTextBox.Size = new System.Drawing.Size(287, 50);
            this.AddToDoTextBox.TabIndex = 1;
            // 
            // AddToDoButton
            // 
            this.AddToDoButton.BackColor = System.Drawing.Color.Gray;
            this.AddToDoButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToDoButton.Location = new System.Drawing.Point(12, 608);
            this.AddToDoButton.Name = "AddToDoButton";
            this.AddToDoButton.Size = new System.Drawing.Size(130, 50);
            this.AddToDoButton.TabIndex = 2;
            this.AddToDoButton.Text = "Add";
            this.AddToDoButton.UseVisualStyleBackColor = false;
            this.AddToDoButton.Click += new System.EventHandler(this.AddToDoButton_Click);
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(446, 670);
            this.Controls.Add(this.AddToDoButton);
            this.Controls.Add(this.AddToDoTextBox);
            this.Controls.Add(this.ToDoListBox);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToDoForm";
            this.ShowIcon = false;
            this.Text = "ToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ToDoListBox;
        private System.Windows.Forms.TextBox AddToDoTextBox;
        private System.Windows.Forms.Button AddToDoButton;
    }
}

