namespace КурсоваяБд
{
    partial class ScheduleStudent
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
            this.components = new System.ComponentModel.Container();
            this.бД_Спортивная_школаDataSet1 = new КурсоваяБд.БД_Спортивная_школаDataSet();
            this.копия_Group_s_scheduleBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.копия_Список_учеников_группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.копия_Список_учеников_группыTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.Копия_Список_учеников_группыTableAdapter();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonsTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.LessonsTableAdapter();
            this.tableAdapterManager = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.копия_Group_s_scheduleBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.копия_Список_учеников_группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_Спортивная_школаDataSet1
            // 
            this.бД_Спортивная_школаDataSet1.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // копия_Group_s_scheduleBindingSource5
            // 
            this.копия_Group_s_scheduleBindingSource5.DataMember = "Копия Group\'s schedule";
            this.копия_Group_s_scheduleBindingSource5.DataSource = this.бД_Спортивная_школаDataSet1;
            // 
            // копия_Список_учеников_группыBindingSource
            // 
            this.копия_Список_учеников_группыBindingSource.DataMember = "Копия Список учеников группы";
            this.копия_Список_учеников_группыBindingSource.DataSource = this.бД_Спортивная_школаDataSet1;
            // 
            // копия_Список_учеников_группыTableAdapter
            // 
            this.копия_Список_учеников_группыTableAdapter.ClearBeforeFill = true;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this.бД_Спортивная_школаDataSet1;
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Group_of_usersTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.kind_of_sportTableAdapter = null;
            this.tableAdapterManager.LessonsTableAdapter = this.lessonsTableAdapter;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.School_DataTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(422, 432);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(244, 54);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ScheduleStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 542);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScheduleStudent";
            this.Text = "ScheduleStudent";
            this.Load += new System.EventHandler(this.ScheduleStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.копия_Group_s_scheduleBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.копия_Список_учеников_группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet1;
        private System.Windows.Forms.BindingSource копия_Group_s_scheduleBindingSource5;
        private System.Windows.Forms.BindingSource копия_Список_учеников_группыBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.Копия_Список_учеников_группыTableAdapter копия_Список_учеников_группыTableAdapter;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_button;
    }
}