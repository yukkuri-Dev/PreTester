namespace PerTester
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            SeedVex = new TextBox();
            label1 = new Label();
            SeedCheckBox = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            vScrollBar1 = new VScrollBar();
            FormRenamer = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBoxVex = new TextBox();
            Gen = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SeedVex);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(SeedCheckBox);
            groupBox1.Location = new Point(12, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "乱数";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // SeedVex
            // 
            SeedVex.Location = new Point(6, 62);
            SeedVex.Name = "SeedVex";
            SeedVex.Size = new Size(188, 23);
            SeedVex.TabIndex = 2;
            SeedVex.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "シード値";
            // 
            // SeedCheckBox
            // 
            SeedCheckBox.AutoSize = true;
            SeedCheckBox.Location = new Point(6, 22);
            SeedCheckBox.Name = "SeedCheckBox";
            SeedCheckBox.Size = new Size(128, 19);
            SeedCheckBox.TabIndex = 0;
            SeedCheckBox.Text = "シード値を 3407にする";
            SeedCheckBox.UseVisualStyleBackColor = true;
            SeedCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(218, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(192, 238);
            checkedListBox1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(413, 12);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(20, 238);
            vScrollBar1.TabIndex = 2;
            // 
            // FormRenamer
            // 
            FormRenamer.Location = new Point(6, 71);
            FormRenamer.Name = "FormRenamer";
            FormRenamer.Size = new Size(100, 23);
            FormRenamer.TabIndex = 3;
            FormRenamer.TextChanged += textBox1_TextChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(FormRenamer);
            groupBox2.Location = new Point(12, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "フォーム名";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(218, 259);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "キャンセル";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(355, 259);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "保存";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxVex
            // 
            textBoxVex.Location = new Point(12, 47);
            textBoxVex.Name = "textBoxVex";
            textBoxVex.Size = new Size(100, 23);
            textBoxVex.TabIndex = 5;
            textBoxVex.TextChanged += textBox1_TextChanged_2;
            // 
            // Gen
            // 
            Gen.Location = new Point(118, 47);
            Gen.Name = "Gen";
            Gen.Size = new Size(75, 23);
            Gen.TabIndex = 7;
            Gen.Text = "GenButton";
            Gen.UseVisualStyleBackColor = true;
            Gen.Click += Gen_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 294);
            Controls.Add(Gen);
            Controls.Add(textBoxVex);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(vScrollBar1);
            Controls.Add(checkedListBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox checkedListBox1;
        private VScrollBar vScrollBar1;
        private CheckBox SeedCheckBox;
        private TextBox SeedVex;
        private Label label1;
        private TextBox FormRenamer;
        private GroupBox groupBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBoxVex;
        private Button Gen;
    }
}