
namespace FastBan
{
    partial class ManagementWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementWindow));
            this.danmaku_all = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ban1Hour_BanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.run = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomnumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.RichTextBox();
            this.danmaku_hit = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // danmaku_all
            // 
            this.danmaku_all.ContextMenuStrip = this.contextMenuStrip1;
            this.danmaku_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danmaku_all.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.danmaku_all.FormattingEnabled = true;
            this.danmaku_all.Location = new System.Drawing.Point(0, 0);
            this.danmaku_all.Name = "danmaku_all";
            this.danmaku_all.Size = new System.Drawing.Size(252, 519);
            this.danmaku_all.TabIndex = 0;
            this.danmaku_all.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.danmaku_all_DrawItem);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ClearToolStripMenuItem,
            this.Ban1Hour_BanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 清空ClearToolStripMenuItem
            // 
            this.清空ClearToolStripMenuItem.Name = "清空ClearToolStripMenuItem";
            this.清空ClearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清空ClearToolStripMenuItem.Text = "清空(&Clear)";
            this.清空ClearToolStripMenuItem.Click += new System.EventHandler(this.清空ClearToolStripMenuItem_Click);
            // 
            // Ban1Hour_BanToolStripMenuItem
            // 
            this.Ban1Hour_BanToolStripMenuItem.Name = "Ban1Hour_BanToolStripMenuItem";
            this.Ban1Hour_BanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Ban1Hour_BanToolStripMenuItem.Text = "封禁一小时(&Ban)";
            this.Ban1Hour_BanToolStripMenuItem.Click += new System.EventHandler(this.Ban1Hour_BanToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.danmaku_all);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(758, 519);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.filter);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.danmaku_hit);
            this.splitContainer2.Size = new System.Drawing.Size(502, 519);
            this.splitContainer2.SplitterDistance = 230;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.run);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.roomnumber);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "直播间";
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.Location = new System.Drawing.Point(8, 47);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(72, 16);
            this.run.TabIndex = 2;
            this.run.Text = "开始运行";
            this.run.UseVisualStyleBackColor = true;
            this.run.CheckedChanged += new System.EventHandler(this.run_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "房间号";
            // 
            // roomnumber
            // 
            this.roomnumber.Location = new System.Drawing.Point(53, 20);
            this.roomnumber.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Size = new System.Drawing.Size(160, 21);
            this.roomnumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regex表达式    满足条件的会触发提示";
            // 
            // filter
            // 
            this.filter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filter.Location = new System.Drawing.Point(2, 93);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(224, 423);
            this.filter.TabIndex = 0;
            this.filter.Text = "";
            // 
            // danmaku_hit
            // 
            this.danmaku_hit.ContextMenuStrip = this.contextMenuStrip1;
            this.danmaku_hit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danmaku_hit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.danmaku_hit.FormattingEnabled = true;
            this.danmaku_hit.ItemHeight = 12;
            this.danmaku_hit.Location = new System.Drawing.Point(0, 0);
            this.danmaku_hit.Name = "danmaku_hit";
            this.danmaku_hit.Size = new System.Drawing.Size(268, 519);
            this.danmaku_hit.TabIndex = 1;
            this.danmaku_hit.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.danmaku_all_DrawItem);
            // 
            // ManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 519);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementWindow";
            this.Text = "弹幕管理窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementWindow_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomnumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox danmaku_all;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox danmaku_hit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown roomnumber;
        private System.Windows.Forms.CheckBox run;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ban1Hour_BanToolStripMenuItem;
    }
}