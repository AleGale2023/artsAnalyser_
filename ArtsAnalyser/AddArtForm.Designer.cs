namespace ArtsAnalyser
{
    partial class NewArtView
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
            this.label1 = new System.Windows.Forms.Label();
            this.instancePropGrid = new System.Windows.Forms.PropertyGrid();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bAddValueToList = new System.Windows.Forms.Button();
            this.cbValuesList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // artPropGrid
            // 
            this.instancePropGrid.Location = new System.Drawing.Point(12, 12);
            this.instancePropGrid.Name = "artPropGrid";
            this.instancePropGrid.SelectedObject = this.instancePropGrid;
            this.instancePropGrid.Size = new System.Drawing.Size(416, 274);
            this.instancePropGrid.TabIndex = 1;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(308, 290);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(120, 33);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Выход";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(197, 290);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(106, 33);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bAddValueToList
            // 
            this.bAddValueToList.Location = new System.Drawing.Point(433, 12);
            this.bAddValueToList.Name = "bAddValueToList";
            this.bAddValueToList.Size = new System.Drawing.Size(24, 274);
            this.bAddValueToList.TabIndex = 3;
            this.bAddValueToList.Text = ">";
            this.bAddValueToList.UseVisualStyleBackColor = true;
            // 
            // cbValuesList
            // 
            this.cbValuesList.FormattingEnabled = true;
            this.cbValuesList.Location = new System.Drawing.Point(462, 12);
            this.cbValuesList.Name = "cbValuesList";
            this.cbValuesList.Size = new System.Drawing.Size(120, 274);
            this.cbValuesList.TabIndex = 4;
            // 
            // NewArtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 332);
            this.Controls.Add(this.cbValuesList);
            this.Controls.Add(this.bAddValueToList);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.instancePropGrid);
            this.Controls.Add(this.label1);
            this.Name = "NewArtView";
            this.Text = "Добавить артефакт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewArtView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private PropertyGrid instancePropGrid;
        private Button bClose;
        private Button bSave;
        private Button bAddValueToList;
        private CheckedListBox cbValuesList;
    }
}