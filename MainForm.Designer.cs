namespace PalBreeding
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            label8 = new Label();
            label7 = new Label();
            MotherDescTextBox = new TextBox();
            FatherDescTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            EggTypeComboBox = new ComboBox();
            EggSizeComboBox = new ComboBox();
            EnterButton = new Button();
            SwapButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MotherNameBox = new TextBox();
            FatherNameBox = new TextBox();
            MotherNoTextBox = new TextBox();
            FatherNoTextBox = new TextBox();
            splitContainer2 = new SplitContainer();
            dataGridView1 = new DataGridView();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(MotherDescTextBox);
            splitContainer1.Panel1.Controls.Add(FatherDescTextBox);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(EggTypeComboBox);
            splitContainer1.Panel1.Controls.Add(EggSizeComboBox);
            splitContainer1.Panel1.Controls.Add(EnterButton);
            splitContainer1.Panel1.Controls.Add(SwapButton);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(MotherNameBox);
            splitContainer1.Panel1.Controls.Add(FatherNameBox);
            splitContainer1.Panel1.Controls.Add(MotherNoTextBox);
            splitContainer1.Panel1.Controls.Add(FatherNoTextBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(141, 236);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 17;
            label8.Text = "母亲特性：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 51);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 16;
            label7.Text = "父亲特性：";
            // 
            // MotherDescTextBox
            // 
            MotherDescTextBox.Location = new Point(141, 259);
            MotherDescTextBox.Name = "MotherDescTextBox";
            MotherDescTextBox.Size = new Size(125, 27);
            MotherDescTextBox.TabIndex = 15;
            // 
            // FatherDescTextBox
            // 
            FatherDescTextBox.Location = new Point(141, 74);
            FatherDescTextBox.Name = "FatherDescTextBox";
            FatherDescTextBox.Size = new Size(125, 27);
            FatherDescTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 343);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 13;
            label6.Text = "蛋种类";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 289);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 12;
            label5.Text = "蛋大小";
            // 
            // EggTypeComboBox
            // 
            EggTypeComboBox.FormattingEnabled = true;
            EggTypeComboBox.Location = new Point(10, 366);
            EggTypeComboBox.Name = "EggTypeComboBox";
            EggTypeComboBox.Size = new Size(151, 28);
            EggTypeComboBox.TabIndex = 11;
            // 
            // EggSizeComboBox
            // 
            EggSizeComboBox.FormattingEnabled = true;
            EggSizeComboBox.Location = new Point(10, 312);
            EggSizeComboBox.Name = "EggSizeComboBox";
            EggSizeComboBox.Size = new Size(151, 28);
            EggSizeComboBox.TabIndex = 10;
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(10, 409);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(94, 29);
            EnterButton.TabIndex = 9;
            EnterButton.Text = "录入";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // SwapButton
            // 
            SwapButton.Location = new Point(10, 130);
            SwapButton.Name = "SwapButton";
            SwapButton.Size = new Size(94, 29);
            SwapButton.TabIndex = 8;
            SwapButton.Text = "父母交换";
            SwapButton.UseVisualStyleBackColor = true;
            SwapButton.Click += SwapButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 183);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 7;
            label4.Text = "母亲编号：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 236);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "母亲种类：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 51);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "父亲种类：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 1);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "父亲编号：";
            // 
            // MotherNameBox
            // 
            MotherNameBox.Location = new Point(10, 259);
            MotherNameBox.Name = "MotherNameBox";
            MotherNameBox.Size = new Size(125, 27);
            MotherNameBox.TabIndex = 3;
            // 
            // FatherNameBox
            // 
            FatherNameBox.Location = new Point(10, 74);
            FatherNameBox.Name = "FatherNameBox";
            FatherNameBox.Size = new Size(125, 27);
            FatherNameBox.TabIndex = 2;
            // 
            // MotherNoTextBox
            // 
            MotherNoTextBox.Location = new Point(10, 206);
            MotherNoTextBox.Name = "MotherNoTextBox";
            MotherNoTextBox.Size = new Size(125, 27);
            MotherNoTextBox.TabIndex = 1;
            MotherNoTextBox.TextChanged += MotherNoTextBox_TextChanged;
            // 
            // FatherNoTextBox
            // 
            FatherNoTextBox.Location = new Point(10, 21);
            FatherNoTextBox.Name = "FatherNoTextBox";
            FatherNoTextBox.Size = new Size(125, 27);
            FatherNoTextBox.TabIndex = 0;
            FatherNoTextBox.TextChanged += FatherNoTextBox_TextChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(DeleteButton);
            splitContainer2.Size = new Size(530, 450);
            splitContainer2.SplitterDistance = 372;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(530, 372);
            dataGridView1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(3, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 0;
            DeleteButton.Text = "删除";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox FatherNoTextBox;
        private TextBox MotherNoTextBox;
        private TextBox MotherNameBox;
        private TextBox FatherNameBox;
        private Button SwapButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button EnterButton;
        private Label label6;
        private Label label5;
        private ComboBox EggTypeComboBox;
        private ComboBox EggSizeComboBox;
        private Label label8;
        private Label label7;
        private TextBox MotherDescTextBox;
        private TextBox FatherDescTextBox;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView1;
        private Button DeleteButton;
    }
}
