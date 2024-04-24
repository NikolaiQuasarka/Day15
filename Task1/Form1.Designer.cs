namespace Task1
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
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonSaveFile = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Dock = DockStyle.Top;
            monthCalendar1.Location = new Point(0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 219);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 54);
            textBox1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 279);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(141, 279);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Location = new Point(281, 279);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(94, 29);
            buttonSaveFile.TabIndex = 4;
            buttonSaveFile.Text = "SAVE FILE";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 314);
            Controls.Add(buttonSaveFile);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(textBox1);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private Button buttonDelete;
        private Button buttonSave;
        private Button buttonSaveFile;
    }
}
