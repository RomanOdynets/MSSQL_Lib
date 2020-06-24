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
            this.menu_st = new System.Windows.Forms.MenuStrip();
            this.aboutHeader_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.publicInformation_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.creators_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.status_pb = new System.Windows.Forms.ToolStripProgressBar();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.settings_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.status_pn.SuspendLayout();
            this.menu_st.SuspendLayout();
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
            // menu_st
            // 
            this.menu_st.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings_btn,
            this.aboutHeader_btn});
            this.menu_st.Location = new System.Drawing.Point(0, 0);
            this.menu_st.Name = "menu_st";
            this.menu_st.Size = new System.Drawing.Size(733, 24);
            this.menu_st.TabIndex = 1;
            this.menu_st.Text = "menuStrip1";
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
            this.Controls.Add(this.menu_st);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu_st;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel | Data Base Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.status_pn.ResumeLayout(false);
            this.status_pn.PerformLayout();
            this.menu_st.ResumeLayout(false);
            this.menu_st.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status_pn;
        private System.Windows.Forms.MenuStrip menu_st;
        private System.Windows.Forms.ToolStripMenuItem aboutHeader_btn;
        private System.Windows.Forms.ToolStripMenuItem publicInformation_btn;
        private System.Windows.Forms.ToolStripMenuItem creators_btn;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
        private System.Windows.Forms.ToolStripProgressBar status_pb;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl;
        private System.Windows.Forms.ToolStripMenuItem settings_btn;
    }
}

