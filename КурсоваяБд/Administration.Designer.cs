namespace КурсоваяБд
{
    partial class Administration
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
            this.studentsA_button = new System.Windows.Forms.Button();
            this.trainersA_button = new System.Windows.Forms.Button();
            this.scheduleA_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsA_button
            // 
            this.studentsA_button.Location = new System.Drawing.Point(499, 94);
            this.studentsA_button.Name = "studentsA_button";
            this.studentsA_button.Size = new System.Drawing.Size(360, 106);
            this.studentsA_button.TabIndex = 0;
            this.studentsA_button.Text = "Обучающиеся";
            this.studentsA_button.UseVisualStyleBackColor = true;
            this.studentsA_button.Click += new System.EventHandler(this.studentsA_button_Click);
            // 
            // trainersA_button
            // 
            this.trainersA_button.Location = new System.Drawing.Point(499, 232);
            this.trainersA_button.Name = "trainersA_button";
            this.trainersA_button.Size = new System.Drawing.Size(360, 106);
            this.trainersA_button.TabIndex = 1;
            this.trainersA_button.Text = "Тренеры";
            this.trainersA_button.UseVisualStyleBackColor = true;
            this.trainersA_button.Click += new System.EventHandler(this.trainersA_button_Click);
            // 
            // scheduleA_button
            // 
            this.scheduleA_button.Location = new System.Drawing.Point(499, 372);
            this.scheduleA_button.Name = "scheduleA_button";
            this.scheduleA_button.Size = new System.Drawing.Size(360, 106);
            this.scheduleA_button.TabIndex = 2;
            this.scheduleA_button.Text = "Общее расписание";
            this.scheduleA_button.UseVisualStyleBackColor = true;
            this.scheduleA_button.Click += new System.EventHandler(this.scheduleA_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(499, 511);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(360, 106);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 644);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.scheduleA_button);
            this.Controls.Add(this.trainersA_button);
            this.Controls.Add(this.studentsA_button);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentsA_button;
        private System.Windows.Forms.Button trainersA_button;
        private System.Windows.Forms.Button scheduleA_button;
        private System.Windows.Forms.Button back_button;
    }
}