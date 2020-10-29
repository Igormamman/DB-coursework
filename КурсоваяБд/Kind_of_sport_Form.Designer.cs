namespace КурсоваяБд
{
    partial class Kind_of_sport_Form
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
            System.Windows.Forms.Label id_of_sportLabel;
            System.Windows.Forms.Label sport_nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kind_of_sport_Form));
            this.бД_Спортивная_школаDataSet = new КурсоваяБд.БД_Спортивная_школаDataSet();
            this.kind_of_sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kind_of_sportTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.kind_of_sportTableAdapter();
            this.tableAdapterManager = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager();
            this.kind_of_sportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kind_of_sportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_of_sportTextBox = new System.Windows.Forms.TextBox();
            this.sport_nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            id_of_sportLabel = new System.Windows.Forms.Label();
            sport_nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kind_of_sportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kind_of_sportBindingNavigator)).BeginInit();
            this.kind_of_sportBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_of_sportLabel
            // 
            id_of_sportLabel.AutoSize = true;
            id_of_sportLabel.Location = new System.Drawing.Point(282, 156);
            id_of_sportLabel.Name = "id_of_sportLabel";
            id_of_sportLabel.Size = new System.Drawing.Size(60, 17);
            id_of_sportLabel.TabIndex = 1;
            id_of_sportLabel.Text = "Индекс:";
            // 
            // sport_nameLabel
            // 
            sport_nameLabel.AutoSize = true;
            sport_nameLabel.Location = new System.Drawing.Point(282, 184);
            sport_nameLabel.Name = "sport_nameLabel";
            sport_nameLabel.Size = new System.Drawing.Size(76, 17);
            sport_nameLabel.TabIndex = 3;
            sport_nameLabel.Text = "Название:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(282, 212);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 17);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Описание:";
            // 
            // бД_Спортивная_школаDataSet
            // 
            this.бД_Спортивная_школаDataSet.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kind_of_sportBindingSource
            // 
            this.kind_of_sportBindingSource.DataMember = "kind of sport";
            this.kind_of_sportBindingSource.DataSource = this.бД_Спортивная_школаDataSet;
            // 
            // kind_of_sportTableAdapter
            // 
            this.kind_of_sportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Group_of_usersTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.kind_of_sportTableAdapter = this.kind_of_sportTableAdapter;
            this.tableAdapterManager.LessonsTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.School_DataTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kind_of_sportBindingNavigator
            // 
            this.kind_of_sportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kind_of_sportBindingNavigator.BindingSource = this.kind_of_sportBindingSource;
            this.kind_of_sportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kind_of_sportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kind_of_sportBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kind_of_sportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kind_of_sportBindingNavigatorSaveItem});
            this.kind_of_sportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kind_of_sportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kind_of_sportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kind_of_sportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kind_of_sportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kind_of_sportBindingNavigator.Name = "kind_of_sportBindingNavigator";
            this.kind_of_sportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kind_of_sportBindingNavigator.Size = new System.Drawing.Size(1257, 27);
            this.kind_of_sportBindingNavigator.TabIndex = 0;
            this.kind_of_sportBindingNavigator.Text = "bindingNavigator1";
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
            // kind_of_sportBindingNavigatorSaveItem
            // 
            this.kind_of_sportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kind_of_sportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kind_of_sportBindingNavigatorSaveItem.Image")));
            this.kind_of_sportBindingNavigatorSaveItem.Name = "kind_of_sportBindingNavigatorSaveItem";
            this.kind_of_sportBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.kind_of_sportBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kind_of_sportBindingNavigatorSaveItem.Click += new System.EventHandler(this.kind_of_sportBindingNavigatorSaveItem_Click);
            // 
            // id_of_sportTextBox
            // 
            this.id_of_sportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kind_of_sportBindingSource, "Id_of_sport", true));
            this.id_of_sportTextBox.Location = new System.Drawing.Point(373, 153);
            this.id_of_sportTextBox.Name = "id_of_sportTextBox";
            this.id_of_sportTextBox.Size = new System.Drawing.Size(435, 22);
            this.id_of_sportTextBox.TabIndex = 2;
            // 
            // sport_nameTextBox
            // 
            this.sport_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kind_of_sportBindingSource, "Sport_name", true));
            this.sport_nameTextBox.Location = new System.Drawing.Point(373, 181);
            this.sport_nameTextBox.Name = "sport_nameTextBox";
            this.sport_nameTextBox.Size = new System.Drawing.Size(435, 22);
            this.sport_nameTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kind_of_sportBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(373, 209);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(435, 22);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(930, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Kind_of_sport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_of_sportLabel);
            this.Controls.Add(this.id_of_sportTextBox);
            this.Controls.Add(sport_nameLabel);
            this.Controls.Add(this.sport_nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.kind_of_sportBindingNavigator);
            this.Name = "Kind_of_sport_Form";
            this.Text = "Kind_of_sport_Form";
            this.Load += new System.EventHandler(this.Kind_of_sport_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kind_of_sportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kind_of_sportBindingNavigator)).EndInit();
            this.kind_of_sportBindingNavigator.ResumeLayout(false);
            this.kind_of_sportBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet;
        private System.Windows.Forms.BindingSource kind_of_sportBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.kind_of_sportTableAdapter kind_of_sportTableAdapter;
        private БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kind_of_sportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kind_of_sportBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_of_sportTextBox;
        private System.Windows.Forms.TextBox sport_nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}