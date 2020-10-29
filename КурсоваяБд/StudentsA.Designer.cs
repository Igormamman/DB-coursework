namespace КурсоваяБд
{
    partial class StudentsA
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
            this.бД_Спортивная_школаDataSet = new КурсоваяБд.БД_Спортивная_школаDataSet();
            this.students_form_button = new System.Windows.Forms.Button();
            this.group_form_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.search__st_textBox = new System.Windows.Forms.TextBox();
            this.search_sc_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_Спортивная_школаDataSet
            // 
            this.бД_Спортивная_школаDataSet.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_form_button
            // 
            this.students_form_button.Location = new System.Drawing.Point(398, 51);
            this.students_form_button.Name = "students_form_button";
            this.students_form_button.Size = new System.Drawing.Size(322, 36);
            this.students_form_button.TabIndex = 0;
            this.students_form_button.Text = "Ученики";
            this.students_form_button.UseVisualStyleBackColor = true;
            this.students_form_button.Click += new System.EventHandler(this.students_form_button_Click);
            // 
            // group_form_button
            // 
            this.group_form_button.Location = new System.Drawing.Point(398, 116);
            this.group_form_button.Name = "group_form_button";
            this.group_form_button.Size = new System.Drawing.Size(322, 36);
            this.group_form_button.TabIndex = 1;
            this.group_form_button.Text = "Группы";
            this.group_form_button.UseVisualStyleBackColor = true;
            this.group_form_button.Click += new System.EventHandler(this.group_form_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(322, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Информация об ученике";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(322, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Подробное расписание группы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(398, 376);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(322, 36);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // search__st_textBox
            // 
            this.search__st_textBox.Location = new System.Drawing.Point(726, 197);
            this.search__st_textBox.Name = "search__st_textBox";
            this.search__st_textBox.Size = new System.Drawing.Size(322, 22);
            this.search__st_textBox.TabIndex = 5;
            // 
            // search_sc_textBox
            // 
            this.search_sc_textBox.Location = new System.Drawing.Point(726, 270);
            this.search_sc_textBox.Name = "search_sc_textBox";
            this.search_sc_textBox.Size = new System.Drawing.Size(322, 22);
            this.search_sc_textBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Информация о группах";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentsA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_sc_textBox);
            this.Controls.Add(this.search__st_textBox);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.group_form_button);
            this.Controls.Add(this.students_form_button);
            this.Name = "StudentsA";
            this.Text = "StudentsA";
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet;
        private System.Windows.Forms.Button students_form_button;
        private System.Windows.Forms.Button group_form_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox search__st_textBox;
        private System.Windows.Forms.TextBox search_sc_textBox;
        private System.Windows.Forms.Button button1;
    }
}