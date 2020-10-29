namespace КурсоваяБд
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.administration_button = new System.Windows.Forms.Button();
            this.students_button = new System.Windows.Forms.Button();
            this.trainers_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Спортивная_школаDataSet = new КурсоваяБд.БД_Спортивная_школаDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // administration_button
            // 
            this.administration_button.Location = new System.Drawing.Point(451, 77);
            this.administration_button.Name = "administration_button";
            this.administration_button.Size = new System.Drawing.Size(345, 71);
            this.administration_button.TabIndex = 0;
            this.administration_button.Text = "Администрация";
            this.administration_button.UseVisualStyleBackColor = true;
            this.administration_button.Click += new System.EventHandler(this.administration_button_Click);
            // 
            // students_button
            // 
            this.students_button.Location = new System.Drawing.Point(451, 207);
            this.students_button.Name = "students_button";
            this.students_button.Size = new System.Drawing.Size(345, 71);
            this.students_button.TabIndex = 1;
            this.students_button.Text = "Ученики";
            this.students_button.UseVisualStyleBackColor = true;
            this.students_button.Click += new System.EventHandler(this.students_button_Click);
            // 
            // trainers_button
            // 
            this.trainers_button.Location = new System.Drawing.Point(451, 338);
            this.trainers_button.Name = "trainers_button";
            this.trainers_button.Size = new System.Drawing.Size(345, 71);
            this.trainers_button.TabIndex = 2;
            this.trainers_button.Text = "Тренеры";
            this.trainers_button.UseVisualStyleBackColor = true;
            this.trainers_button.Click += new System.EventHandler(this.trainers_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(451, 461);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(345, 73);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Закрыть приложение";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.бД_Спортивная_школаDataSet;
            this.bindingSource1.Position = 0;
            // 
            // бД_Спортивная_школаDataSet
            // 
            this.бД_Спортивная_школаDataSet.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 631);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.trainers_button);
            this.Controls.Add(this.students_button);
            this.Controls.Add(this.administration_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button administration_button;
        private System.Windows.Forms.Button students_button;
        private System.Windows.Forms.Button trainers_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.BindingSource bindingSource1;
        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet;
    }
}

