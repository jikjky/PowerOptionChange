namespace Power
{
    partial class PowerForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HighPerfomanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PowerSaverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonHigh = new System.Windows.Forms.Button();
            this.buttonSavePower = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBalanced = new System.Windows.Forms.TextBox();
            this.buttonBalanced = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Power";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HighPerfomanceToolStripMenuItem,
            this.balancedToolStripMenuItem,
            this.PowerSaverToolStripMenuItem,
            this.toolStripSeparator1,
            this.SettingToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 148);
            // 
            // HighPerfomanceToolStripMenuItem
            // 
            this.HighPerfomanceToolStripMenuItem.Name = "HighPerfomanceToolStripMenuItem";
            this.HighPerfomanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HighPerfomanceToolStripMenuItem.Text = "High Perfomance";
            this.HighPerfomanceToolStripMenuItem.Click += new System.EventHandler(this.HighPerfomanceToolStripMenuItem_Click);
            // 
            // balancedToolStripMenuItem
            // 
            this.balancedToolStripMenuItem.Name = "balancedToolStripMenuItem";
            this.balancedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.balancedToolStripMenuItem.Text = "Balanced";
            this.balancedToolStripMenuItem.Click += new System.EventHandler(this.balancedToolStripMenuItem_Click);
            // 
            // PowerSaverToolStripMenuItem
            // 
            this.PowerSaverToolStripMenuItem.Name = "PowerSaverToolStripMenuItem";
            this.PowerSaverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PowerSaverToolStripMenuItem.Text = "Power Saver";
            this.PowerSaverToolStripMenuItem.Click += new System.EventHandler(this.PowerSaverToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingToolStripMenuItem.Text = "Setting";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(142, 115);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(246, 21);
            this.textBoxHigh.TabIndex = 1;
            this.textBoxHigh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHigh_KeyDown);
            this.textBoxHigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHigh_KeyPress);
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(142, 169);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(246, 21);
            this.textBoxSave.TabIndex = 2;
            this.textBoxSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSave_KeyDown);
            this.textBoxSave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSave_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 196);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(376, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 225);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(376, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonHigh
            // 
            this.buttonHigh.Location = new System.Drawing.Point(12, 46);
            this.buttonHigh.Name = "buttonHigh";
            this.buttonHigh.Size = new System.Drawing.Size(120, 23);
            this.buttonHigh.TabIndex = 5;
            this.buttonHigh.Text = "High Perfomance";
            this.buttonHigh.UseVisualStyleBackColor = true;
            this.buttonHigh.Click += new System.EventHandler(this.buttonHigh_Click);
            // 
            // buttonSavePower
            // 
            this.buttonSavePower.Location = new System.Drawing.Point(268, 46);
            this.buttonSavePower.Name = "buttonSavePower";
            this.buttonSavePower.Size = new System.Drawing.Size(120, 23);
            this.buttonSavePower.TabIndex = 6;
            this.buttonSavePower.Text = "Power Saver";
            this.buttonSavePower.UseVisualStyleBackColor = true;
            this.buttonSavePower.Click += new System.EventHandler(this.buttonSavePower_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 28);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "High Perfomance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 21);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "High Perfomance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(16, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 21);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Power Saver";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(14, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 21);
            this.panel4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Balanced";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBalanced
            // 
            this.textBoxBalanced.Location = new System.Drawing.Point(142, 142);
            this.textBoxBalanced.Name = "textBoxBalanced";
            this.textBoxBalanced.Size = new System.Drawing.Size(246, 21);
            this.textBoxBalanced.TabIndex = 10;
            this.textBoxBalanced.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBalanced_KeyDown);
            this.textBoxBalanced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBalanced_KeyPress);
            // 
            // buttonBalanced
            // 
            this.buttonBalanced.Location = new System.Drawing.Point(142, 46);
            this.buttonBalanced.Name = "buttonBalanced";
            this.buttonBalanced.Size = new System.Drawing.Size(120, 23);
            this.buttonBalanced.TabIndex = 12;
            this.buttonBalanced.Text = "Balanced";
            this.buttonBalanced.UseVisualStyleBackColor = true;
            this.buttonBalanced.Click += new System.EventHandler(this.buttonBalanced_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // PowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 260);
            this.Controls.Add(this.buttonBalanced);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxBalanced);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSavePower);
            this.Controls.Add(this.buttonHigh);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.textBoxHigh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(290, 299);
            this.Name = "PowerForm";
            this.Text = "Power";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HighPerfomanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PowerSaverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxHigh;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.Button buttonHigh;
        private System.Windows.Forms.Button buttonSavePower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBalanced;
        private System.Windows.Forms.Button buttonBalanced;
        private System.Windows.Forms.ToolStripMenuItem balancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

