namespace PerTester
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            aAToolStripMenuItem = new ToolStripMenuItem();
            callSplashToolStripMenuItem = new ToolStripMenuItem();
            生成ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem1 = new ToolStripMenuItem();
            設定ToolStripMenuItem2 = new ToolStripMenuItem();
            developeroptionTool = new ToolStripMenuItem();
            developeroptionHide = new ToolStripMenuItem();
            コンソールの表示ToolStripMenuItem = new ToolStripMenuItem();
            このソフトウェアについてToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aAToolStripMenuItem, 生成ToolStripMenuItem, 設定ToolStripMenuItem1, developeroptionTool });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aAToolStripMenuItem
            // 
            aAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { callSplashToolStripMenuItem });
            aAToolStripMenuItem.Name = "aAToolStripMenuItem";
            aAToolStripMenuItem.Size = new Size(37, 20);
            aAToolStripMenuItem.Text = "File";
            aAToolStripMenuItem.Click += aAToolStripMenuItem_Click;
            // 
            // callSplashToolStripMenuItem
            // 
            callSplashToolStripMenuItem.Name = "callSplashToolStripMenuItem";
            callSplashToolStripMenuItem.Size = new Size(180, 22);
            callSplashToolStripMenuItem.Text = "★Call splash";
            callSplashToolStripMenuItem.Click += callSplashToolStripMenuItem_Click;
            // 
            // 生成ToolStripMenuItem
            // 
            生成ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 設定ToolStripMenuItem });
            生成ToolStripMenuItem.Name = "生成ToolStripMenuItem";
            生成ToolStripMenuItem.Size = new Size(43, 20);
            生成ToolStripMenuItem.Text = "生成";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(180, 22);
            設定ToolStripMenuItem.Text = "生成オプション";
            設定ToolStripMenuItem.Click += 設定ToolStripMenuItem_Click;
            // 
            // 設定ToolStripMenuItem1
            // 
            設定ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 設定ToolStripMenuItem2, このソフトウェアについてToolStripMenuItem });
            設定ToolStripMenuItem1.Name = "設定ToolStripMenuItem1";
            設定ToolStripMenuItem1.Size = new Size(43, 20);
            設定ToolStripMenuItem1.Text = "設定";
            // 
            // 設定ToolStripMenuItem2
            // 
            設定ToolStripMenuItem2.Name = "設定ToolStripMenuItem2";
            設定ToolStripMenuItem2.Size = new Size(180, 22);
            設定ToolStripMenuItem2.Text = "設定";
            設定ToolStripMenuItem2.Click += 設定ToolStripMenuItem2_Click;
            // 
            // developeroptionTool
            // 
            developeroptionTool.Checked = true;
            developeroptionTool.CheckState = CheckState.Checked;
            developeroptionTool.DropDownItems.AddRange(new ToolStripItem[] { developeroptionHide, コンソールの表示ToolStripMenuItem });
            developeroptionTool.Name = "developeroptionTool";
            developeroptionTool.Size = new Size(122, 20);
            developeroptionTool.Text = "★開発者用オプション";
            developeroptionTool.Visible = false;
            developeroptionTool.Click += developeroptionTool_Click;
            // 
            // developeroptionHide
            // 
            developeroptionHide.Name = "developeroptionHide";
            developeroptionHide.Size = new Size(211, 22);
            developeroptionHide.Text = "開発者用オプションの非表示";
            developeroptionHide.Click += 開発者用オプションの非表示ToolStripMenuItem_Click;
            // 
            // コンソールの表示ToolStripMenuItem
            // 
            コンソールの表示ToolStripMenuItem.Name = "コンソールの表示ToolStripMenuItem";
            コンソールの表示ToolStripMenuItem.Size = new Size(211, 22);
            コンソールの表示ToolStripMenuItem.Text = "コンソールの表示";
            コンソールの表示ToolStripMenuItem.Click += コンソールの表示ToolStripMenuItem_Click;
            // 
            // このソフトウェアについてToolStripMenuItem
            // 
            このソフトウェアについてToolStripMenuItem.Name = "このソフトウェアについてToolStripMenuItem";
            このソフトウェアについてToolStripMenuItem.Size = new Size(180, 22);
            このソフトウェアについてToolStripMenuItem.Text = "このソフトウェアについて";
            このソフトウェアについてToolStripMenuItem.Click += このソフトウェアについてToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aAToolStripMenuItem;
        private ToolStripMenuItem callSplashToolStripMenuItem;
        private ToolStripMenuItem 生成ToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem1;
        private ToolStripMenuItem 設定ToolStripMenuItem2;
        private ToolStripMenuItem developeroptionTool;
        private ToolStripMenuItem developeroptionHide;
        private ToolStripMenuItem コンソールの表示ToolStripMenuItem;
        private ToolStripMenuItem このソフトウェアについてToolStripMenuItem;
    }
}