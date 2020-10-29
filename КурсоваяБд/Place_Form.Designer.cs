namespace КурсоваяБд
{
    partial class Place_Form
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
            System.Windows.Forms.Label number_of_hallLabel;
            System.Windows.Forms.Label squareLabel;
            System.Windows.Forms.Label destinationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Place_Form));
            this.бД_Спортивная_школаDataSet = new КурсоваяБд.БД_Спортивная_школаDataSet();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.PlaceTableAdapter();
            this.tableAdapterManager = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager();
            this.placeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.placeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.number_of_hallTextBox = new System.Windows.Forms.TextBox();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            number_of_hallLabel = new System.Windows.Forms.Label();
            squareLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingNavigator)).BeginInit();
            this.placeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // number_of_hallLabel
            // 
            number_of_hallLabel.AutoSize = true;
            number_of_hallLabel.Location = new System.Drawing.Point(487, 180);
            number_of_hallLabel.Name = "number_of_hallLabel";
            number_of_hallLabel.Size = new System.Drawing.Size(90, 17);
            number_of_hallLabel.TabIndex = 1;
            number_of_hallLabel.Text = "Номер зала:";
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Location = new System.Drawing.Point(487, 208);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new System.Drawing.Size(72, 17);
            squareLabel.TabIndex = 3;
            squareLabel.Text = "Площадь:";
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new System.Drawing.Point(487, 236);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(93, 17);
            destinationLabel.TabIndex = 5;
            destinationLabel.Text = "Назначение:";
            // 
            // бД_Спортивная_школаDataSet
            // 
            this.бД_Спортивная_школаDataSet.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.бД_Спортивная_школаDataSet;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Group_of_usersTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.kind_of_sportTableAdapter = null;
            this.tableAdapterManager.LessonsTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = this.placeTableAdapter;
            this.tableAdapterManager.School_DataTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // placeBindingNavigator
            // 
            this.placeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.placeBindingNavigator.BindingSource = this.placeBindingSource;
            this.placeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.placeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.placeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.placeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.placeBindingNavigatorSaveItem});
            this.placeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.placeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.placeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.placeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.placeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.placeBindingNavigator.Name = "placeBindingNavigator";
            this.placeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.placeBindingNavigator.Size = new System.Drawing.Size(1303, 27);
            this.placeBindingNavigator.TabIndex = 0;
            this.placeBindingNavigator.Text = "bindingNavigator1";
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
            // placeBindingNavigatorSaveItem
            // 
            this.placeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.placeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("placeBindingNavigatorSaveItem.Image")));
            this.placeBindingNavigatorSaveItem.Name = "placeBindingNavigatorSaveItem";
            this.placeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.placeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.placeBindingNavigatorSaveItem.Click += new System.EventHandler(this.placeBindingNavigatorSaveItem_Click);
            // 
            // number_of_hallTextBox
            // 
            this.number_of_hallTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placeBindingSource, "Number_of_hall", true));
            this.number_of_hallTextBox.Location = new System.Drawing.Point(597, 177);
            this.number_of_hallTextBox.Name = "number_of_hallTextBox";
            this.number_of_hallTextBox.Size = new System.Drawing.Size(386, 22);
            this.number_of_hallTextBox.TabIndex = 2;
            // 
            // squareTextBox
            // 
            this.squareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placeBindingSource, "Square", true));
            this.squareTextBox.Location = new System.Drawing.Point(597, 205);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(386, 22);
            this.squareTextBox.TabIndex = 4;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placeBindingSource, "destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(597, 233);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(386, 22);
            this.destinationTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Place_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(number_of_hallLabel);
            this.Controls.Add(this.number_of_hallTextBox);
            this.Controls.Add(squareLabel);
            this.Controls.Add(this.squareTextBox);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.placeBindingNavigator);
            this.Name = "Place_Form";
            this.Text = "Place_Form";
            this.Load += new System.EventHandler(this.Place_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingNavigator)).EndInit();
            this.placeBindingNavigator.ResumeLayout(false);
            this.placeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.PlaceTableAdapter placeTableAdapter;
        private БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator placeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton placeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox number_of_hallTextBox;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Button button1;
    }
}