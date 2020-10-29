namespace КурсоваяБд
{
    partial class Students
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
            this.schedule_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schedule_button
            // 
            this.schedule_button.Location = new System.Drawing.Point(416, 58);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(387, 82);
            this.schedule_button.TabIndex = 0;
            this.schedule_button.Text = "Расписание";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.schedule_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(416, 179);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(387, 82);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 547);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.schedule_button);
            this.Name = "Students";
            this.Text = "Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.Button back_button;
    }
}