namespace КурсоваяБд
{
    partial class Schedule_A
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
            this.schedule_form_button = new System.Windows.Forms.Button();
            this.day_schedule_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schedule_form_button
            // 
            this.schedule_form_button.Location = new System.Drawing.Point(454, 60);
            this.schedule_form_button.Name = "schedule_form_button";
            this.schedule_form_button.Size = new System.Drawing.Size(338, 61);
            this.schedule_form_button.TabIndex = 0;
            this.schedule_form_button.Text = "Расписание";
            this.schedule_form_button.UseVisualStyleBackColor = true;
            this.schedule_form_button.Click += new System.EventHandler(this.schedule_form_button_Click);
            // 
            // day_schedule_button
            // 
            this.day_schedule_button.Location = new System.Drawing.Point(454, 142);
            this.day_schedule_button.Name = "day_schedule_button";
            this.day_schedule_button.Size = new System.Drawing.Size(338, 61);
            this.day_schedule_button.TabIndex = 1;
            this.day_schedule_button.Text = "Расписание определенного дня";
            this.day_schedule_button.UseVisualStyleBackColor = true;
            this.day_schedule_button.Click += new System.EventHandler(this.day_schedule_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 2;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(454, 233);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(338, 61);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Schedule_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 534);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.day_schedule_button);
            this.Controls.Add(this.schedule_form_button);
            this.Name = "Schedule_A";
            this.Text = "Schedule_A";
            this.Load += new System.EventHandler(this.Schedule_A_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button schedule_form_button;
        private System.Windows.Forms.Button day_schedule_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button back_button;
    }
}