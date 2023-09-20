namespace ArtsAnalyser
{
    partial class MainForm
    {
        private NewArtView addArtView;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArts = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCritmass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsLeg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bExit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИзменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сетАртефактовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типАртефактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.верхнийСтатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подстатАртефактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.артефактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArts
            // 
            this.dgvArts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colType,
            this.colState,
            this.colLevel,
            this.colSet,
            this.colCritmass,
            this.colEst,
            this.colIsLeg});
            this.dgvArts.Location = new System.Drawing.Point(13, 31);
            this.dgvArts.Name = "dgvArts";
            this.dgvArts.RowHeadersVisible = false;
            this.dgvArts.RowTemplate.Height = 25;
            this.dgvArts.Size = new System.Drawing.Size(912, 360);
            this.dgvArts.TabIndex = 1;
            // 
            // colID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colID.DefaultCellStyle = dataGridViewCellStyle1;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 35;
            // 
            // colType
            // 
            this.colType.HeaderText = "Тип";
            this.colType.Name = "colType";
            // 
            // colState
            // 
            this.colState.HeaderText = "Верхний стат";
            this.colState.Name = "colState";
            this.colState.Width = 200;
            // 
            // colLevel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLevel.DefaultCellStyle = dataGridViewCellStyle2;
            this.colLevel.HeaderText = "Уровень";
            this.colLevel.Name = "colLevel";
            this.colLevel.Width = 70;
            // 
            // colSet
            // 
            this.colSet.HeaderText = "Сет";
            this.colSet.Name = "colSet";
            this.colSet.Width = 300;
            // 
            // colCritmass
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCritmass.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCritmass.HeaderText = "Критмасса";
            this.colCritmass.Name = "colCritmass";
            this.colCritmass.Width = 80;
            // 
            // colEst
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colEst.DefaultCellStyle = dataGridViewCellStyle4;
            this.colEst.HeaderText = "Оценка";
            this.colEst.Name = "colEst";
            this.colEst.Width = 80;
            // 
            // colIsLeg
            // 
            this.colIsLeg.HeaderText = "Лег";
            this.colIsLeg.Name = "colIsLeg";
            this.colIsLeg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsLeg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsLeg.Width = 40;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(757, 434);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(167, 46);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(13, 434);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(266, 46);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Добавить артефакт";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(149, 398);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(130, 33);
            this.bRemove.TabIndex = 4;
            this.bRemove.Text = "Удалить";
            this.bRemove.UseVisualStyleBackColor = true;
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(13, 398);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(130, 33);
            this.bShow.TabIndex = 5;
            this.bShow.Text = "Показать";
            this.bShow.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.добавитьИзменитьToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(935, 24);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьДанныеToolStripMenuItem,
            this.перезагрузитьДанныеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            // 
            // перезагрузитьДанныеToolStripMenuItem
            // 
            this.перезагрузитьДанныеToolStripMenuItem.Name = "перезагрузитьДанныеToolStripMenuItem";
            this.перезагрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.перезагрузитьДанныеToolStripMenuItem.Text = "Перезагрузить данные";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // добавитьИзменитьToolStripMenuItem
            // 
            this.добавитьИзменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сетАртефактовToolStripMenuItem,
            this.типАртефактаToolStripMenuItem,
            this.верхнийСтатToolStripMenuItem,
            this.подстатАртефактаToolStripMenuItem,
            this.артефактToolStripMenuItem});
            this.добавитьИзменитьToolStripMenuItem.Name = "добавитьИзменитьToolStripMenuItem";
            this.добавитьИзменитьToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.добавитьИзменитьToolStripMenuItem.Text = "Добавить/Изменить";
            // 
            // сетАртефактовToolStripMenuItem
            // 
            this.сетАртефактовToolStripMenuItem.Name = "сетАртефактовToolStripMenuItem";
            this.сетАртефактовToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.сетАртефактовToolStripMenuItem.Text = "Сет артефактов";
            // 
            // типАртефактаToolStripMenuItem
            // 
            this.типАртефактаToolStripMenuItem.Name = "типАртефактаToolStripMenuItem";
            this.типАртефактаToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.типАртефактаToolStripMenuItem.Text = "Тип артефакта";
            // 
            // верхнийСтатToolStripMenuItem
            // 
            this.верхнийСтатToolStripMenuItem.Name = "верхнийСтатToolStripMenuItem";
            this.верхнийСтатToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.верхнийСтатToolStripMenuItem.Text = "Верхний стат артефакта";
            // 
            // подстатАртефактаToolStripMenuItem
            // 
            this.подстатАртефактаToolStripMenuItem.Name = "подстатАртефактаToolStripMenuItem";
            this.подстатАртефактаToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.подстатАртефактаToolStripMenuItem.Text = "Подстат артефакта";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem1.Text = "Выход";
            // 
            // артефактToolStripMenuItem
            // 
            this.артефактToolStripMenuItem.Name = "артефактToolStripMenuItem";
            this.артефактToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.артефактToolStripMenuItem.Text = "Артефакт";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(935, 493);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.dgvArts);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Анализатор артефактов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArts)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvArts;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colState;
        private DataGridViewTextBoxColumn colLevel;
        private DataGridViewTextBoxColumn colSet;
        private DataGridViewTextBoxColumn colCritmass;
        private DataGridViewTextBoxColumn colEst;
        private DataGridViewCheckBoxColumn colIsLeg;
        private Button bExit;
        private Button bAdd;
        private Button bRemove;
        private Button bShow;
        private MenuStrip mainMenu;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private ToolStripMenuItem перезагрузитьДанныеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem добавитьИзменитьToolStripMenuItem;
        private ToolStripMenuItem сетАртефактовToolStripMenuItem;
        private ToolStripMenuItem типАртефактаToolStripMenuItem;
        private ToolStripMenuItem верхнийСтатToolStripMenuItem;
        private ToolStripMenuItem подстатАртефактаToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private ToolStripMenuItem артефактToolStripMenuItem;
    }
}