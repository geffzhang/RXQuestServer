﻿namespace RXQuestServer
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.InitDelmiaDocument = new System.Windows.Forms.Button();
            this.WeldSportTool = new System.Windows.Forms.Button();
            this.GotoOCR = new System.Windows.Forms.Button();
            this.ShowToPlc = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.InPutWorkTime = new System.Windows.Forms.ToolStripMenuItem();
            this.工时查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加班工时查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加班单导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitDelmiaDocument
            // 
            this.InitDelmiaDocument.Location = new System.Drawing.Point(12, 63);
            this.InitDelmiaDocument.Name = "InitDelmiaDocument";
            this.InitDelmiaDocument.Size = new System.Drawing.Size(125, 41);
            this.InitDelmiaDocument.TabIndex = 0;
            this.InitDelmiaDocument.Text = "Delmia初始化工具";
            this.InitDelmiaDocument.UseVisualStyleBackColor = true;
            this.InitDelmiaDocument.Click += new System.EventHandler(this.InitDelmiaDocument_Click);
            // 
            // WeldSportTool
            // 
            this.WeldSportTool.Location = new System.Drawing.Point(167, 63);
            this.WeldSportTool.Name = "WeldSportTool";
            this.WeldSportTool.Size = new System.Drawing.Size(125, 41);
            this.WeldSportTool.TabIndex = 0;
            this.WeldSportTool.Text = "焊点快捷工具";
            this.WeldSportTool.UseVisualStyleBackColor = true;
            this.WeldSportTool.Click += new System.EventHandler(this.WeldSportTool_Click);
            // 
            // GotoOCR
            // 
            this.GotoOCR.Location = new System.Drawing.Point(12, 125);
            this.GotoOCR.Name = "GotoOCR";
            this.GotoOCR.Size = new System.Drawing.Size(125, 41);
            this.GotoOCR.TabIndex = 0;
            this.GotoOCR.Text = "OCR工具";
            this.GotoOCR.UseVisualStyleBackColor = true;
            this.GotoOCR.Click += new System.EventHandler(this.GotoOCR_Click);
            // 
            // ShowToPlc
            // 
            this.ShowToPlc.Location = new System.Drawing.Point(167, 125);
            this.ShowToPlc.Name = "ShowToPlc";
            this.ShowToPlc.Size = new System.Drawing.Size(125, 41);
            this.ShowToPlc.TabIndex = 0;
            this.ShowToPlc.Text = "办公信息";
            this.ShowToPlc.UseVisualStyleBackColor = true;
            this.ShowToPlc.Click += new System.EventHandler(this.GotoOCR_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(304, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InPutWorkTime,
            this.工时查询ToolStripMenuItem,
            this.加班工时查询ToolStripMenuItem,
            this.加班单导出ToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // InPutWorkTime
            // 
            this.InPutWorkTime.Name = "InPutWorkTime";
            this.InPutWorkTime.Size = new System.Drawing.Size(148, 22);
            this.InPutWorkTime.Text = "工时入库";
            this.InPutWorkTime.Click += new System.EventHandler(this.InPutWorkTime_Click);
            // 
            // 工时查询ToolStripMenuItem
            // 
            this.工时查询ToolStripMenuItem.Name = "工时查询ToolStripMenuItem";
            this.工时查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.工时查询ToolStripMenuItem.Text = "工时查询";
            // 
            // 加班工时查询ToolStripMenuItem
            // 
            this.加班工时查询ToolStripMenuItem.Name = "加班工时查询ToolStripMenuItem";
            this.加班工时查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.加班工时查询ToolStripMenuItem.Text = "加班工时查询";
            // 
            // 加班单导出ToolStripMenuItem
            // 
            this.加班单导出ToolStripMenuItem.Name = "加班单导出ToolStripMenuItem";
            this.加班单导出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.加班单导出ToolStripMenuItem.Text = "加班单导出";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton1.Text = "办公";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(304, 211);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.WeldSportTool);
            this.Controls.Add(this.ShowToPlc);
            this.Controls.Add(this.GotoOCR);
            this.Controls.Add(this.InitDelmiaDocument);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 250);
            this.MinimumSize = new System.Drawing.Size(320, 250);
            this.Name = "Main";
            this.Text = "主入口";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InitDelmiaDocument;
        private System.Windows.Forms.Button WeldSportTool;
        private System.Windows.Forms.Button GotoOCR;
        private System.Windows.Forms.Button ShowToPlc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem InPutWorkTime;
        private System.Windows.Forms.ToolStripMenuItem 工时查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加班工时查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加班单导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
    }
}

