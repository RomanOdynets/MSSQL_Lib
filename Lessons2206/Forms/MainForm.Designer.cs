namespace Lessons2206.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.status_pn = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutHeader_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.publicInformation_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.creators_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.status_pb = new System.Windows.Forms.ToolStripProgressBar();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.settings_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.status_pn.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_pn
            // 
            this.status_pn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_pb,
            this.status_lbl});
            this.status_pn.Location = new System.Drawing.Point(0, 535);
            this.status_pn.Name = "status_pn";
            this.status_pn.Size = new System.Drawing.Size(733, 22);
            this.status_pn.TabIndex = 0;
            this.status_pn.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings_btn,
            this.aboutHeader_btn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutHeader_btn
            // 
            this.aboutHeader_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicInformation_btn,
            this.creators_btn,
            this.about_btn});
            this.aboutHeader_btn.Name = "aboutHeader_btn";
            this.aboutHeader_btn.Size = new System.Drawing.Size(65, 20);
            this.aboutHeader_btn.Text = "Справка";
            // 
            // publicInformation_btn
            // 
            this.publicInformation_btn.Name = "publicInformation_btn";
            this.publicInformation_btn.Size = new System.Drawing.Size(211, 22);
            this.publicInformation_btn.Text = "Публичная информация";
            this.publicInformation_btn.Click += new System.EventHandler(this.publicInformation_btn_Click);
            // 
            // creators_btn
            // 
            this.creators_btn.Name = "creators_btn";
            this.creators_btn.Size = new System.Drawing.Size(211, 22);
            this.creators_btn.Text = "Создатели";
            this.creators_btn.Click += new System.EventHandler(this.creators_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(211, 22);
            this.about_btn.Text = "О программе";
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // status_pb
            // 
            this.status_pb.Name = "status_pb";
            this.status_pb.Size = new System.Drawing.Size(100, 16);
            // 
            // status_lbl
            // 
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 17);
            // 
            // settings_btn
            // 
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(79, 20);
            this.settings_btn.Text = "Настройки";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 557);
            this.Controls.Add(this.status_pn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel | Data Base Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.status_pn.ResumeLayout(false);
            this.status_pn.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status_pn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutHeader_btn;
        private System.Windows.Forms.ToolStripMenuItem publicInformation_btn;
        private System.Windows.Forms.ToolStripMenuItem creators_btn;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
        private System.Windows.Forms.ToolStripProgressBar status_pb;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl;
        private System.Windows.Forms.ToolStripMenuItem settings_btn;
    }
}

