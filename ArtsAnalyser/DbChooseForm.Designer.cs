namespace ArtsAnalyser
{
    partial class DbChooseForm
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
            this.rbArt = new System.Windows.Forms.RadioButton();
            this.rbReliq = new System.Windows.Forms.RadioButton();
            this.bConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbArt
            // 
            this.rbArt.AutoSize = true;
            this.rbArt.Location = new System.Drawing.Point(12, 12);
            this.rbArt.Name = "rbArt";
            this.rbArt.Size = new System.Drawing.Size(86, 19);
            this.rbArt.TabIndex = 0;
            this.rbArt.TabStop = true;
            this.rbArt.Text = "Артефакты";
            this.rbArt.UseVisualStyleBackColor = true;
            // 
            // rbReliq
            // 
            this.rbReliq.AutoSize = true;
            this.rbReliq.Location = new System.Drawing.Point(104, 12);
            this.rbReliq.Name = "rbReliq";
            this.rbReliq.Size = new System.Drawing.Size(78, 19);
            this.rbReliq.TabIndex = 0;
            this.rbReliq.TabStop = true;
            this.rbReliq.Text = "Реликвии";
            this.rbReliq.UseVisualStyleBackColor = true;
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(12, 37);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(170, 32);
            this.bConfirm.TabIndex = 1;
            this.bConfirm.Text = "Подтвердить";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // DbChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 76);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.rbReliq);
            this.Controls.Add(this.rbArt);
            this.Name = "DbChooseForm";
            this.Text = "Выбор БД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbArt;
        private RadioButton rbReliq;
        private Button bConfirm;
    }
}