namespace КурсоваяБд
{
    partial class Trainers
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
            this.trainers_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.search_st_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // trainers_button
            // 
            this.trainers_button.Location = new System.Drawing.Point(435, 39);
            this.trainers_button.Name = "trainers_button";
            this.trainers_button.Size = new System.Drawing.Size(324, 70);
            this.trainers_button.TabIndex = 0;
            this.trainers_button.Text = "Тренеры и их расписание";
            this.trainers_button.UseVisualStyleBackColor = true;
            this.trainers_button.Click += new System.EventHandler(this.trainers_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(435, 308);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(324, 70);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Списки учеников групп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_st_button
            // 
            this.search_st_button.Location = new System.Drawing.Point(435, 216);
            this.search_st_button.Name = "search_st_button";
            this.search_st_button.Size = new System.Drawing.Size(324, 70);
            this.search_st_button.TabIndex = 3;
            this.search_st_button.Text = "Информация об ученике";
            this.search_st_button.UseVisualStyleBackColor = true;
            this.search_st_button.Click += new System.EventHandler(this.search_st_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 535);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search_st_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.trainers_button);
            this.Name = "Trainers";
            this.Text = "Trainers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trainers_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button search_st_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}