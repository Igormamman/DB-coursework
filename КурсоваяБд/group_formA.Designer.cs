namespace КурсоваяБд
{
    partial class group_formA
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
            System.Windows.Forms.Label id__of_GroupLabel;
            System.Windows.Forms.Label group_nameLabel;
            System.Windows.Forms.Label disciplineLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(group_formA));
            this.бД_Спортивная_школаDataSet = new КурсоваяБд.БД_Спортивная_школаDataSet();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.GroupTableAdapter();
            this.tableAdapterManager = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager();
            this.groupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id__of_GroupTextBox = new System.Windows.Forms.TextBox();
            this.group_nameTextBox = new System.Windows.Forms.TextBox();
            this.students_in_group_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kindOfSportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kind_of_sportTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.kind_of_sportTableAdapter();
            id__of_GroupLabel = new System.Windows.Forms.Label();
            group_nameLabel = new System.Windows.Forms.Label();
            disciplineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingNavigator)).BeginInit();
            this.groupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindOfSportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id__of_GroupLabel
            // 
            id__of_GroupLabel.AutoSize = true;
            id__of_GroupLabel.Location = new System.Drawing.Point(311, 165);
            id__of_GroupLabel.Name = "id__of_GroupLabel";
            id__of_GroupLabel.Size = new System.Drawing.Size(106, 17);
            id__of_GroupLabel.TabIndex = 1;
            id__of_GroupLabel.Text = "Индекс группы";
            // 
            // group_nameLabel
            // 
            group_nameLabel.AutoSize = true;
            group_nameLabel.Location = new System.Drawing.Point(311, 193);
            group_nameLabel.Name = "group_nameLabel";
            group_nameLabel.Size = new System.Drawing.Size(72, 17);
            group_nameLabel.TabIndex = 3;
            group_nameLabel.Text = "Название";
            // 
            // disciplineLabel
            // 
            disciplineLabel.AutoSize = true;
            disciplineLabel.Location = new System.Drawing.Point(311, 221);
            disciplineLabel.Name = "disciplineLabel";
            disciplineLabel.Size = new System.Drawing.Size(90, 17);
            disciplineLabel.TabIndex = 5;
            disciplineLabel.Text = "Дисциплина";
            // 
            // бД_Спортивная_школаDataSet
            // 
            this.бД_Спортивная_школаDataSet.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.бД_Спортивная_школаDataSet;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Group_of_usersTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = this.groupTableAdapter;
            this.tableAdapterManager.kind_of_sportTableAdapter = null;
            this.tableAdapterManager.LessonsTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.School_DataTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBindingNavigator
            // 
            this.groupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupBindingNavigator.BindingSource = this.groupBindingSource;
            this.groupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.groupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.groupBindingNavigatorSaveItem});
            this.groupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupBindingNavigator.Name = "groupBindingNavigator";
            this.groupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupBindingNavigator.Size = new System.Drawing.Size(1110, 31);
            this.groupBindingNavigator.TabIndex = 0;
            this.groupBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBindingNavigatorSaveItem
            // 
            this.groupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupBindingNavigatorSaveItem.Image")));
            this.groupBindingNavigatorSaveItem.Name = "groupBindingNavigatorSaveItem";
            this.groupBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.groupBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.groupBindingNavigatorSaveItem.Click += new System.EventHandler(this.groupBindingNavigatorSaveItem_Click);
            // 
            // id__of_GroupTextBox
            // 
            this.id__of_GroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Id_ of_Group", true));
            this.id__of_GroupTextBox.Location = new System.Drawing.Point(441, 160);
            this.id__of_GroupTextBox.Name = "id__of_GroupTextBox";
            this.id__of_GroupTextBox.Size = new System.Drawing.Size(325, 22);
            this.id__of_GroupTextBox.TabIndex = 2;
            // 
            // group_nameTextBox
            // 
            this.group_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Group_name", true));
            this.group_nameTextBox.Location = new System.Drawing.Point(441, 188);
            this.group_nameTextBox.Name = "group_nameTextBox";
            this.group_nameTextBox.Size = new System.Drawing.Size(325, 22);
            this.group_nameTextBox.TabIndex = 4;
            // 
            // students_in_group_button
            // 
            this.students_in_group_button.Location = new System.Drawing.Point(440, 293);
            this.students_in_group_button.Name = "students_in_group_button";
            this.students_in_group_button.Size = new System.Drawing.Size(193, 43);
            this.students_in_group_button.TabIndex = 7;
            this.students_in_group_button.Text = "Список учеников группы";
            this.students_in_group_button.UseVisualStyleBackColor = true;
            this.students_in_group_button.Click += new System.EventHandler(this.students_in_group_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(272, 293);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(129, 43);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupBindingSource, "discipline", true));
            this.comboBox1.DataSource = this.kindOfSportBindingSource;
            this.comboBox1.DisplayMember = "Sport_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(440, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id_of_sport";
            // 
            // kindOfSportBindingSource
            // 
            this.kindOfSportBindingSource.DataMember = "kind of sport";
            this.kindOfSportBindingSource.DataSource = this.бД_Спортивная_школаDataSet;
            // 
            // kind_of_sportTableAdapter
            // 
            this.kind_of_sportTableAdapter.ClearBeforeFill = true;
            // 
            // group_formA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 585);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.students_in_group_button);
            this.Controls.Add(id__of_GroupLabel);
            this.Controls.Add(this.id__of_GroupTextBox);
            this.Controls.Add(group_nameLabel);
            this.Controls.Add(this.group_nameTextBox);
            this.Controls.Add(disciplineLabel);
            this.Controls.Add(this.groupBindingNavigator);
            this.Name = "group_formA";
            this.Text = "group_formA";
            this.Load += new System.EventHandler(this.group_formA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingNavigator)).EndInit();
            this.groupBindingNavigator.ResumeLayout(false);
            this.groupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindOfSportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator groupBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton groupBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id__of_GroupTextBox;
        private System.Windows.Forms.TextBox group_nameTextBox;
        private System.Windows.Forms.Button students_in_group_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource kindOfSportBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.kind_of_sportTableAdapter kind_of_sportTableAdapter;
    }
}