namespace PerTester.SplashScreen
{
    partial class SpS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpS));
            label1 = new Label();
            progressBar1 = new ProgressBar();
            startLog = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 297);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "ready";
            label1.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 289);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(489, 23);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            // 
            // startLog
            // 
            startLog.BackColor = SystemColors.HighlightText;
            startLog.ForeColor = SystemColors.InfoText;
            startLog.FormattingEnabled = true;
            startLog.ItemHeight = 15;
            startLog.Location = new Point(1, 79);
            startLog.Name = "startLog";
            startLog.Size = new Size(489, 184);
            startLog.TabIndex = 2;
            startLog.SelectedIndexChanged += startLog_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1, 260);
            button1.Name = "button1";
            button1.Size = new Size(489, 23);
            button1.TabIndex = 3;
            button1.Text = "開く";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(490, 330);
            Controls.Add(button1);
            Controls.Add(startLog);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SpS";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private ListBox startLog;
        private Button button1;
    }
}