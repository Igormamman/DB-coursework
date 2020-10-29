namespace КурсоваяБд
{
    partial class ScheduleFormA
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
            System.Windows.Forms.Label id_of_lessonLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label trainerLabel;
            System.Windows.Forms.Label placeLabel;
            System.Windows.Forms.Label start_timeLabel;
            System.Windows.Forms.Label end_timeLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label sportLabel;
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label ratingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleFormA));
            this.бД_Спортивная_школаDataSet = new КурсоваяБд.БД_Спортивная_школаDataSet();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonsTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.LessonsTableAdapter();
            this.tableAdapterManager = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager();
            this.lessonsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lessonsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_of_lessonTextBox = new System.Windows.Forms.TextBox();
            this.start_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.durationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.GroupTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainersTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.TrainersTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindOfSportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kind_of_sportTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.kind_of_sportTableAdapter();
            this.placeTableAdapter = new КурсоваяБд.БД_Спортивная_школаDataSetTableAdapters.PlaceTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.sport_info_button = new System.Windows.Forms.Button();
            this.place_info_button = new System.Windows.Forms.Button();
            this.group_info_button = new System.Windows.Forms.Button();
            id_of_lessonLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            trainerLabel = new System.Windows.Forms.Label();
            placeLabel = new System.Windows.Forms.Label();
            start_timeLabel = new System.Windows.Forms.Label();
            end_timeLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            sportLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingNavigator)).BeginInit();
            this.lessonsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindOfSportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_of_lessonLabel
            // 
            id_of_lessonLabel.AutoSize = true;
            id_of_lessonLabel.Location = new System.Drawing.Point(270, 90);
            id_of_lessonLabel.Name = "id_of_lessonLabel";
            id_of_lessonLabel.Size = new System.Drawing.Size(60, 17);
            id_of_lessonLabel.TabIndex = 1;
            id_of_lessonLabel.Text = "Индекс:";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(270, 118);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(59, 17);
            groupLabel.TabIndex = 3;
            groupLabel.Text = "Группа:";
            // 
            // trainerLabel
            // 
            trainerLabel.AutoSize = true;
            trainerLabel.Location = new System.Drawing.Point(270, 146);
            trainerLabel.Name = "trainerLabel";
            trainerLabel.Size = new System.Drawing.Size(61, 17);
            trainerLabel.TabIndex = 5;
            trainerLabel.Text = "Тренер:";
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new System.Drawing.Point(270, 174);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(136, 17);
            placeLabel.TabIndex = 7;
            placeLabel.Text = "Место проведения:";
            // 
            // start_timeLabel
            // 
            start_timeLabel.AutoSize = true;
            start_timeLabel.Location = new System.Drawing.Point(270, 203);
            start_timeLabel.Name = "start_timeLabel";
            start_timeLabel.Size = new System.Drawing.Size(104, 17);
            start_timeLabel.TabIndex = 9;
            start_timeLabel.Text = "время начала:";
            // 
            // end_timeLabel
            // 
            end_timeLabel.AutoSize = true;
            end_timeLabel.Location = new System.Drawing.Point(270, 231);
            end_timeLabel.Name = "end_timeLabel";
            end_timeLabel.Size = new System.Drawing.Size(95, 17);
            end_timeLabel.TabIndex = 11;
            end_timeLabel.Text = "время конца:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(270, 259);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(103, 17);
            durationLabel.TabIndex = 13;
            durationLabel.Text = "длительность:";
            // 
            // sportLabel
            // 
            sportLabel.AutoSize = true;
            sportLabel.Location = new System.Drawing.Point(270, 286);
            sportLabel.Name = "sportLabel";
            sportLabel.Size = new System.Drawing.Size(87, 17);
            sportLabel.TabIndex = 15;
            sportLabel.Text = "Вид спорта:";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(270, 315);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(46, 17);
            dayLabel.TabIndex = 17;
            dayLabel.Text = "День:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(270, 342);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(65, 17);
            ratingLabel.TabIndex = 19;
            ratingLabel.Text = "Рейтинг:";
            // 
            // бД_Спортивная_школаDataSet
            // 
            this.бД_Спортивная_школаDataSet.DataSetName = "БД_Спортивная_школаDataSet";
            this.бД_Спортивная_школаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this.бД_Спортивная_школаDataSet;
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
            // lessonsBindingNavigator
            // 
            this.lessonsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lessonsBindingNavigator.BindingSource = this.lessonsBindingSource;
            this.lessonsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lessonsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lessonsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lessonsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lessonsBindingNavigatorSaveItem});
            this.lessonsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lessonsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lessonsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lessonsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lessonsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lessonsBindingNavigator.Name = "lessonsBindingNavigator";
            this.lessonsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lessonsBindingNavigator.Size = new System.Drawing.Size(1321, 27);
            this.lessonsBindingNavigator.TabIndex = 0;
            this.lessonsBindingNavigator.Text = "bindingNavigator1";
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
            // lessonsBindingNavigatorSaveItem
            // 
            this.lessonsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lessonsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lessonsBindingNavigatorSaveItem.Image")));
            this.lessonsBindingNavigatorSaveItem.Name = "lessonsBindingNavigatorSaveItem";
            this.lessonsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.lessonsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.lessonsBindingNavigatorSaveItem.Click += new System.EventHandler(this.lessonsBindingNavigatorSaveItem_Click);
            // 
            // id_of_lessonTextBox
            // 
            this.id_of_lessonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Id_of_lesson", true));
            this.id_of_lessonTextBox.Location = new System.Drawing.Point(413, 90);
            this.id_of_lessonTextBox.Name = "id_of_lessonTextBox";
            this.id_of_lessonTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_of_lessonTextBox.TabIndex = 2;
            // 
            // start_timeDateTimePicker
            // 
            this.start_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lessonsBindingSource, "start_time", true));
            this.start_timeDateTimePicker.Location = new System.Drawing.Point(413, 202);
            this.start_timeDateTimePicker.Name = "start_timeDateTimePicker";
            this.start_timeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.start_timeDateTimePicker.TabIndex = 10;
            // 
            // end_timeDateTimePicker
            // 
            this.end_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lessonsBindingSource, "end_time", true));
            this.end_timeDateTimePicker.Location = new System.Drawing.Point(413, 230);
            this.end_timeDateTimePicker.Name = "end_timeDateTimePicker";
            this.end_timeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.end_timeDateTimePicker.TabIndex = 12;
            // 
            // durationDateTimePicker
            // 
            this.durationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lessonsBindingSource, "duration", true));
            this.durationDateTimePicker.Location = new System.Drawing.Point(413, 258);
            this.durationDateTimePicker.Name = "durationDateTimePicker";
            this.durationDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.durationDateTimePicker.TabIndex = 14;
            // 
            // dayDateTimePicker
            // 
            this.dayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lessonsBindingSource, "Day", true));
            this.dayDateTimePicker.Location = new System.Drawing.Point(413, 314);
            this.dayDateTimePicker.Name = "dayDateTimePicker";
            this.dayDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dayDateTimePicker.TabIndex = 18;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(413, 342);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(200, 22);
            this.ratingTextBox.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lessonsBindingSource, "Group", true));
            this.comboBox1.DataSource = this.groupBindingSource;
            this.comboBox1.DisplayMember = "Group_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(413, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "Id_ of_Group";
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
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lessonsBindingSource, "Trainer", true));
            this.comboBox2.DataSource = this.trainersBindingSource;
            this.comboBox2.DisplayMember = "Full_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(413, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "Id_of_trainer";
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
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lessonsBindingSource, "Place", true));
            this.comboBox3.DataSource = this.placeBindingSource;
            this.comboBox3.DisplayMember = "Number_of_hall";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(412, 176);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 24);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.ValueMember = "Number_of_hall";
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.бД_Спортивная_школаDataSet;
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
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lessonsBindingSource, "Sport", true));
            this.comboBox4.DataSource = this.kindOfSportBindingSource;
            this.comboBox4.DisplayMember = "Sport_name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(413, 286);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 24);
            this.comboBox4.TabIndex = 24;
            this.comboBox4.ValueMember = "Id_of_sport";
            // 
            // sport_info_button
            // 
            this.sport_info_button.Location = new System.Drawing.Point(784, 213);
            this.sport_info_button.Name = "sport_info_button";
            this.sport_info_button.Size = new System.Drawing.Size(267, 35);
            this.sport_info_button.TabIndex = 25;
            this.sport_info_button.Text = "Информация о виде спорта";
            this.sport_info_button.UseVisualStyleBackColor = true;
            this.sport_info_button.Click += new System.EventHandler(this.sport_info_button_Click);
            // 
            // place_info_button
            // 
            this.place_info_button.Location = new System.Drawing.Point(784, 259);
            this.place_info_button.Name = "place_info_button";
            this.place_info_button.Size = new System.Drawing.Size(267, 35);
            this.place_info_button.TabIndex = 26;
            this.place_info_button.Text = "Место проведения занятий";
            this.place_info_button.UseVisualStyleBackColor = true;
            this.place_info_button.Click += new System.EventHandler(this.place_info_button_Click);
            // 
            // group_info_button
            // 
            this.group_info_button.Location = new System.Drawing.Point(784, 310);
            this.group_info_button.Name = "group_info_button";
            this.group_info_button.Size = new System.Drawing.Size(267, 35);
            this.group_info_button.TabIndex = 27;
            this.group_info_button.Text = "Информация о группе";
            this.group_info_button.UseVisualStyleBackColor = true;
            this.group_info_button.Click += new System.EventHandler(this.group_info_button_Click);
            // 
            // ScheduleFormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 560);
            this.Controls.Add(this.group_info_button);
            this.Controls.Add(this.place_info_button);
            this.Controls.Add(this.sport_info_button);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_of_lessonLabel);
            this.Controls.Add(this.id_of_lessonTextBox);
            this.Controls.Add(groupLabel);
            this.Controls.Add(trainerLabel);
            this.Controls.Add(placeLabel);
            this.Controls.Add(start_timeLabel);
            this.Controls.Add(this.start_timeDateTimePicker);
            this.Controls.Add(end_timeLabel);
            this.Controls.Add(this.end_timeDateTimePicker);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationDateTimePicker);
            this.Controls.Add(sportLabel);
            this.Controls.Add(dayLabel);
            this.Controls.Add(this.dayDateTimePicker);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.lessonsBindingNavigator);
            this.Name = "ScheduleFormA";
            this.Text = "ScheduleA";
            this.Load += new System.EventHandler(this.ScheduleA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_Спортивная_школаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingNavigator)).EndInit();
            this.lessonsBindingNavigator.ResumeLayout(false);
            this.lessonsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindOfSportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_Спортивная_школаDataSet бД_Спортивная_школаDataSet;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private БД_Спортивная_школаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lessonsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lessonsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_of_lessonTextBox;
        private System.Windows.Forms.DateTimePicker start_timeDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_timeDateTimePicker;
        private System.Windows.Forms.DateTimePicker durationDateTimePicker;
        private System.Windows.Forms.DateTimePicker dayDateTimePicker;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.TrainersTableAdapter trainersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource kindOfSportBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.kind_of_sportTableAdapter kind_of_sportTableAdapter;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private БД_Спортивная_школаDataSetTableAdapters.PlaceTableAdapter placeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button sport_info_button;
        private System.Windows.Forms.Button place_info_button;
        private System.Windows.Forms.Button group_info_button;
    }
}