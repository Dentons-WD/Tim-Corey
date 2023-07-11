namespace WinFormUI
{
    partial class ToDos
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
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.todoListBoxLabel = new System.Windows.Forms.Label();
            this.todoText = new System.Windows.Forms.TextBox();
            this.todoLabel = new System.Windows.Forms.Label();
            this.addUpdateTodo = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 29;
            this.todoListBox.Location = new System.Drawing.Point(46, 68);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(720, 555);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.DoubleClick += new System.EventHandler(this.TodoListBox_DoubleClick);
            this.todoListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.todoListBox_KeyDown);
            this.todoListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.todoListBox_PreviewKeyDown);
            // 
            // todoListBoxLabel
            // 
            this.todoListBoxLabel.AutoSize = true;
            this.todoListBoxLabel.Location = new System.Drawing.Point(41, 36);
            this.todoListBoxLabel.Name = "todoListBoxLabel";
            this.todoListBoxLabel.Size = new System.Drawing.Size(117, 29);
            this.todoListBoxLabel.TabIndex = 1;
            this.todoListBoxLabel.Text = "ToDo List";
            // 
            // todoText
            // 
            this.todoText.Location = new System.Drawing.Point(908, 217);
            this.todoText.Name = "todoText";
            this.todoText.Size = new System.Drawing.Size(301, 35);
            this.todoText.TabIndex = 2;
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Location = new System.Drawing.Point(903, 185);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(182, 29);
            this.todoLabel.TabIndex = 3;
            this.todoLabel.Text = "New ToDo Item";
            // 
            // addUpdateTodo
            // 
            this.addUpdateTodo.Location = new System.Drawing.Point(906, 258);
            this.addUpdateTodo.Name = "addUpdateTodo";
            this.addUpdateTodo.Size = new System.Drawing.Size(303, 55);
            this.addUpdateTodo.TabIndex = 4;
            this.addUpdateTodo.Text = "Add ToDo Item";
            this.addUpdateTodo.UseVisualStyleBackColor = true;
            this.addUpdateTodo.Click += new System.EventHandler(this.AddUpdateTodo_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(772, 217);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 42);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(772, 265);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 42);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ToDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 653);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addUpdateTodo);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.todoText);
            this.Controls.Add(this.todoListBoxLabel);
            this.Controls.Add(this.todoListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ToDos";
            this.Text = "ToDo List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Label todoListBoxLabel;
        private System.Windows.Forms.TextBox todoText;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.Button addUpdateTodo;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

