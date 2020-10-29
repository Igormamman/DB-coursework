namespace КурсоваяБд
{
    partial class TrainersA
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
            System.Windows.Forms.Label id_of_trainerLabel;
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label tel_numberLabel;
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainersA));
            this.бД_Спортивная_школаDataSet = new КурсоваяБд.БД_Спортивная_школаDataSet();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainersTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TrainersTableAdapter();
            this.tableAdapterManager = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager();
            this.trainersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.trainersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_of_trainerTextBox = new System.Windows.Forms.TextBox();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.tel_numberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.trainer_sc_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            id_of_trainerLabel = new System.Windows.Forms.Label();
            full_nameLabel = new System.Windows.Forms.Label();
            tel_numberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingNavigator)).BeginInit();
            this.trainersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_of_trainerLabel
            // 
            id_of_trainerLabel.AutoSize = true;
            id_of_trainerLabel.Location = new System.Drawing.Point(228, 131);
            id_of_trainerLabel.Name = "id_of_trainerLabel";
            id_of_trainerLabel.Size = new System.Drawing.Size(60, 17);
            id_of_trainerLabel.TabIndex = 1;
            id_of_trainerLabel.Text = "Индекс:";
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(228, 159);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(46, 17);
            full_nameLabel.TabIndex = 3;
            full_nameLabel.Text = "ФИО:";
            // 
            // tel_numberLabel
            // 
            tel_numberLabel.AutoSize = true;
            tel_numberLabel.Location = new System.Drawing.Point(228, 187);
            tel_numberLabel.Name = "tel_numberLabel";
            tel_numberLabel.Size = new System.Drawing.Size(143, 17);
            tel_numberLabel.TabIndex = 5;
            tel_numberLabel.Text = "Телефонный номер:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(228, 215);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(52, 17);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Адрес:";
            // 
            // бД_Спортивная_школаDataSet
            // 
            this.бД_Спортивная_школаDataSet.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainersBindingSource
            // 
            this.trainersBindingSource.DataMember = "Trainers";
            this.trainersBindingSource.DataSource = this.бД_Спортивная_школаDataSet;
            // 
            // trainersTableAdapter
            // 
            this.trainersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Group_of_usersTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.kind_of_sportTableAdapter = null;
            this.tableAdapterManager.LessonsTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.School_DataTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = this.trainersTableAdapter;
            this.tableAdapterManager.UpdateOrder = КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trainersBindingNavigator
            // 
            this.trainersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.trainersBindingNavigator.BindingSource = this.trainersBindingSource;
            this.trainersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trainersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.trainersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trainersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.trainersBindingNavigatorSaveItem});
            this.trainersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trainersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trainersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trainersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trainersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trainersBindingNavigator.Name = "trainersBindingNavigator";
            this.trainersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trainersBindingNavigator.Size = new System.Drawing.Size(1199, 27);
            this.trainersBindingNavigator.TabIndex = 0;
            this.trainersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // trainersBindingNavigatorSaveItem
            // 
            this.trainersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trainersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trainersBindingNavigatorSaveItem.Image")));
            this.trainersBindingNavigatorSaveItem.Name = "trainersBindingNavigatorSaveItem";
            this.trainersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.trainersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.trainersBindingNavigatorSaveItem.Click += new System.EventHandler(this.trainersBindingNavigatorSaveItem_Click);
            // 
            // id_of_trainerTextBox
            // 
            this.id_of_trainerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Id_of_trainer", true));
            this.id_of_trainerTextBox.Location = new System.Drawing.Point(381, 131);
            this.id_of_trainerTextBox.Name = "id_of_trainerTextBox";
            this.id_of_trainerTextBox.Size = new System.Drawing.Size(276, 22);
            this.id_of_trainerTextBox.TabIndex = 2;
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Full_name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(381, 159);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(276, 22);
            this.full_nameTextBox.TabIndex = 4;
            // 
            // tel_numberTextBox
            // 
            this.tel_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Tel_number", true));
            this.tel_numberTextBox.Location = new System.Drawing.Point(381, 187);
            this.tel_numberTextBox.Name = "tel_numberTextBox";
            this.tel_numberTextBox.Size = new System.Drawing.Size(276, 22);
            this.tel_numberTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(381, 215);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(276, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // trainer_sc_button
            // 
            this.trainer_sc_button.Location = new System.Drawing.Point(397, 291);
            this.trainer_sc_button.Name = "trainer_sc_button";
            this.trainer_sc_button.Size = new System.Drawing.Size(228, 57);
            this.trainer_sc_button.TabIndex = 9;
            this.trainer_sc_button.Text = "Расписание";
            this.trainer_sc_button.UseVisualStyleBackColor = true;
            this.trainer_sc_button.Click += new System.EventHandler(this.trainer_sc_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrainersA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trainer_sc_button);
            this.Controls.Add(id_of_trainerLabel);
            this.Controls.Add(this.id_of_trainerTextBox);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Controls.Add(tel_numberLabel);
            this.Controls.Add(this.tel_numberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.trainersBindingNavigator);
            this.Name = "TrainersA";
            this.Text = "TrainersA";
            this.Load += new System.EventHandler(this.TrainersA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingNavigator)).EndInit();
            this.trainersBindingNavigator.ResumeLayout(false);
            this.trainersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.TrainersTableAdapter trainersTableAdapter;
        private БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator trainersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton trainersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_of_trainerTextBox;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.TextBox tel_numberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button trainer_sc_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}