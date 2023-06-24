namespace PerTester
{
    partial class console
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
            menuStrip1 = new MenuStrip();
            fwToolStripMenuItem = new ToolStripMenuItem();
            ログを保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            閉じるToolStripMenuItem = new ToolStripMenuItem();
            コンソールToolStripMenuItem = new ToolStripMenuItem();
            ログToolStripMenuItem = new ToolStripMenuItem();
            ログの収集を開始ToolStripMenuItem = new ToolStripMenuItem();
            ログの収集を終了ToolStripMenuItem = new ToolStripMenuItem();
            ログを消去ToolStripMenuItem = new ToolStripMenuItem();
            情報ToolStripMenuItem = new ToolStripMenuItem();
            コンソールについてToolStripMenuItem = new ToolStripMenuItem();
            Loglist = new ListBox();
            ログを10列追加ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fwToolStripMenuItem, コンソールToolStripMenuItem, 情報ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fwToolStripMenuItem
            // 
            fwToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ログを保存ToolStripMenuItem, toolStripMenuItem2, 閉じるToolStripMenuItem });
            fwToolStripMenuItem.Name = "fwToolStripMenuItem";
            fwToolStripMenuItem.Size = new Size(37, 20);
            fwToolStripMenuItem.Text = "File";
            fwToolStripMenuItem.Click += fwToolStripMenuItem_Click;
            // 
            // ログを保存ToolStripMenuItem
            // 
            ログを保存ToolStripMenuItem.Name = "ログを保存ToolStripMenuItem";
            ログを保存ToolStripMenuItem.Size = new Size(180, 22);
            ログを保存ToolStripMenuItem.Text = "ログを保存...";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // 閉じるToolStripMenuItem
            // 
            閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            閉じるToolStripMenuItem.Size = new Size(180, 22);
            閉じるToolStripMenuItem.Text = "閉じる";
            閉じるToolStripMenuItem.Click += 閉じるToolStripMenuItem_Click;
            // 
            // コンソールToolStripMenuItem
            // 
            コンソールToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ログToolStripMenuItem });
            コンソールToolStripMenuItem.Name = "コンソールToolStripMenuItem";
            コンソールToolStripMenuItem.Size = new Size(63, 20);
            コンソールToolStripMenuItem.Text = "コンソール";
            // 
            // ログToolStripMenuItem
            // 
            ログToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ログの収集を開始ToolStripMenuItem, ログの収集を終了ToolStripMenuItem, ログを消去ToolStripMenuItem, ログを10列追加ToolStripMenuItem });
            ログToolStripMenuItem.Name = "ログToolStripMenuItem";
            ログToolStripMenuItem.Size = new Size(180, 22);
            ログToolStripMenuItem.Text = "ログ";
            // 
            // ログの収集を開始ToolStripMenuItem
            // 
            ログの収集を開始ToolStripMenuItem.Name = "ログの収集を開始ToolStripMenuItem";
            ログの収集を開始ToolStripMenuItem.Size = new Size(180, 22);
            ログの収集を開始ToolStripMenuItem.Text = "ログの収集を開始";
            // 
            // ログの収集を終了ToolStripMenuItem
            // 
            ログの収集を終了ToolStripMenuItem.Name = "ログの収集を終了ToolStripMenuItem";
            ログの収集を終了ToolStripMenuItem.Size = new Size(180, 22);
            ログの収集を終了ToolStripMenuItem.Text = "ログの収集を終了";
            // 
            // ログを消去ToolStripMenuItem
            // 
            ログを消去ToolStripMenuItem.Name = "ログを消去ToolStripMenuItem";
            ログを消去ToolStripMenuItem.Size = new Size(180, 22);
            ログを消去ToolStripMenuItem.Text = "ログを消去";
            // 
            // 情報ToolStripMenuItem
            // 
            情報ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { コンソールについてToolStripMenuItem });
            情報ToolStripMenuItem.Name = "情報ToolStripMenuItem";
            情報ToolStripMenuItem.Size = new Size(43, 20);
            情報ToolStripMenuItem.Text = "情報";
            // 
            // コンソールについてToolStripMenuItem
            // 
            コンソールについてToolStripMenuItem.Name = "コンソールについてToolStripMenuItem";
            コンソールについてToolStripMenuItem.Size = new Size(180, 22);
            コンソールについてToolStripMenuItem.Text = "コンソールについて";
            コンソールについてToolStripMenuItem.Click += コンソールについてToolStripMenuItem_Click;
            // 
            // Loglist
            // 
            Loglist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Loglist.BackColor = SystemColors.InfoText;
            Loglist.ForeColor = SystemColors.Info;
            Loglist.FormattingEnabled = true;
            Loglist.ItemHeight = 15;
            Loglist.Location = new Point(0, 27);
            Loglist.Name = "Loglist";
            Loglist.Size = new Size(800, 424);
            Loglist.TabIndex = 2;
            Loglist.SelectedIndexChanged += Loglist_SelectedIndexChanged;
            // 
            // ログを10列追加ToolStripMenuItem
            // 
            ログを10列追加ToolStripMenuItem.Name = "ログを10列追加ToolStripMenuItem";
            ログを10列追加ToolStripMenuItem.Size = new Size(180, 22);
            ログを10列追加ToolStripMenuItem.Text = "ログを10列追加";
            ログを10列追加ToolStripMenuItem.Click += ログを10列追加ToolStripMenuItem_Click;
            // 
            // console
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Loglist);
            Controls.Add(menuStrip1);
            Name = "console";
            ShowIcon = false;
            Text = "コンソール";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Log;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fwToolStripMenuItem;
        private ToolStripMenuItem ログを保存ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem 閉じるToolStripMenuItem;
        private ToolStripMenuItem 情報ToolStripMenuItem;
        private ToolStripMenuItem コンソールについてToolStripMenuItem;
        private ToolStripMenuItem コンソールToolStripMenuItem;
        private ToolStripMenuItem ログToolStripMenuItem;
        private ToolStripMenuItem ログの収集を開始ToolStripMenuItem;
        private ToolStripMenuItem ログの収集を終了ToolStripMenuItem;
        private ToolStripMenuItem ログを消去ToolStripMenuItem;
        private ListBox Loglist;
        private ToolStripMenuItem ログを10列追加ToolStripMenuItem;
    }
}