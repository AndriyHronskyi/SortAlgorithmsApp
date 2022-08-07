namespace SortAlgorithmsApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bubleSortBtn = new System.Windows.Forms.Button();
            this.DurationLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertSortBtn = new System.Windows.Forms.Button();
            this.ShakeSortBtn = new System.Windows.Forms.Button();
            this.ShellSortBtn = new System.Windows.Forms.Button();
            this.SelectSortBtn = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortBtn = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.LsdRedixSortBtn = new System.Windows.Forms.Button();
            this.MsdRedixSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add number";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(123, 22);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(61, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(11, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(102, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 54);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fill array random numbers";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(124, 22);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(61, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(11, 25);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(104, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(204, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 162);
            this.panel3.TabIndex = 4;
            // 
            // bubleSortBtn
            // 
            this.bubleSortBtn.Location = new System.Drawing.Point(204, 180);
            this.bubleSortBtn.Name = "bubleSortBtn";
            this.bubleSortBtn.Size = new System.Drawing.Size(65, 23);
            this.bubleSortBtn.TabIndex = 5;
            this.bubleSortBtn.Text = "Buble Sort";
            this.bubleSortBtn.UseVisualStyleBackColor = true;
            this.bubleSortBtn.Click += new System.EventHandler(this.bubleSortBtn_Click);
            // 
            // DurationLbl
            // 
            this.DurationLbl.AutoSize = true;
            this.DurationLbl.Location = new System.Drawing.Point(12, 23);
            this.DurationLbl.Name = "DurationLbl";
            this.DurationLbl.Size = new System.Drawing.Size(50, 13);
            this.DurationLbl.TabIndex = 6;
            this.DurationLbl.Text = "Duration:";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(12, 61);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(108, 13);
            this.CompareLbl.TabIndex = 7;
            this.CompareLbl.Text = "Number of compares:";
            // 
            // SwopLbl
            // 
            this.SwopLbl.AutoSize = true;
            this.SwopLbl.Location = new System.Drawing.Point(12, 42);
            this.SwopLbl.Name = "SwopLbl";
            this.SwopLbl.Size = new System.Drawing.Size(87, 13);
            this.SwopLbl.TabIndex = 8;
            this.SwopLbl.Text = "Number of swop:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.CompareLbl);
            this.panel4.Controls.Add(this.SwopLbl);
            this.panel4.Controls.Add(this.DurationLbl);
            this.panel4.Location = new System.Drawing.Point(5, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 90);
            this.panel4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Results";
            // 
            // InsertSortBtn
            // 
            this.InsertSortBtn.Location = new System.Drawing.Point(356, 180);
            this.InsertSortBtn.Name = "InsertSortBtn";
            this.InsertSortBtn.Size = new System.Drawing.Size(68, 23);
            this.InsertSortBtn.TabIndex = 10;
            this.InsertSortBtn.Text = "Insert Sort";
            this.InsertSortBtn.UseVisualStyleBackColor = true;
            this.InsertSortBtn.Click += new System.EventHandler(this.InsertSortBtn_Click);
            // 
            // ShakeSortBtn
            // 
            this.ShakeSortBtn.Location = new System.Drawing.Point(275, 180);
            this.ShakeSortBtn.Name = "ShakeSortBtn";
            this.ShakeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.ShakeSortBtn.TabIndex = 11;
            this.ShakeSortBtn.Text = "Shake Sort";
            this.ShakeSortBtn.UseVisualStyleBackColor = true;
            this.ShakeSortBtn.Click += new System.EventHandler(this.ShakeSortBtn_Click);
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.Location = new System.Drawing.Point(430, 180);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(64, 23);
            this.ShellSortBtn.TabIndex = 12;
            this.ShellSortBtn.Text = "Shell Sort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.Click += new System.EventHandler(this.ShellSortBtn_Click);
            // 
            // SelectSortBtn
            // 
            this.SelectSortBtn.Location = new System.Drawing.Point(500, 180);
            this.SelectSortBtn.Name = "SelectSortBtn";
            this.SelectSortBtn.Size = new System.Drawing.Size(83, 23);
            this.SelectSortBtn.TabIndex = 13;
            this.SelectSortBtn.Text = "Selection Sort";
            this.SelectSortBtn.UseVisualStyleBackColor = true;
            this.SelectSortBtn.Click += new System.EventHandler(this.SelectSortBtn_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(659, 180);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(64, 23);
            this.HeapSortBtn.TabIndex = 14;
            this.HeapSortBtn.Text = "Heap Sort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // GnomeSortBtn
            // 
            this.GnomeSortBtn.Location = new System.Drawing.Point(729, 180);
            this.GnomeSortBtn.Name = "GnomeSortBtn";
            this.GnomeSortBtn.Size = new System.Drawing.Size(71, 23);
            this.GnomeSortBtn.TabIndex = 15;
            this.GnomeSortBtn.Text = "Gnome Sort";
            this.GnomeSortBtn.UseVisualStyleBackColor = true;
            this.GnomeSortBtn.Click += new System.EventHandler(this.GnomeSortBtn_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(589, 180);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(64, 23);
            this.TreeSortBtn.TabIndex = 16;
            this.TreeSortBtn.Text = "Tree Sort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // LsdRedixSortBtn
            // 
            this.LsdRedixSortBtn.Location = new System.Drawing.Point(807, 181);
            this.LsdRedixSortBtn.Name = "LsdRedixSortBtn";
            this.LsdRedixSortBtn.Size = new System.Drawing.Size(75, 23);
            this.LsdRedixSortBtn.TabIndex = 17;
            this.LsdRedixSortBtn.Text = "LsdRedix Sort";
            this.LsdRedixSortBtn.UseVisualStyleBackColor = true;
            this.LsdRedixSortBtn.Click += new System.EventHandler(this.LsdRedixSortBtn_Click);
            // 
            // MsdRedixSortBtn
            // 
            this.MsdRedixSortBtn.Location = new System.Drawing.Point(807, 211);
            this.MsdRedixSortBtn.Name = "MsdRedixSortBtn";
            this.MsdRedixSortBtn.Size = new System.Drawing.Size(75, 23);
            this.MsdRedixSortBtn.TabIndex = 18;
            this.MsdRedixSortBtn.Text = "MsdRedix Sort";
            this.MsdRedixSortBtn.UseVisualStyleBackColor = true;
            this.MsdRedixSortBtn.Click += new System.EventHandler(this.MsdRedixSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.MsdRedixSortBtn);
            this.Controls.Add(this.LsdRedixSortBtn);
            this.Controls.Add(this.TreeSortBtn);
            this.Controls.Add(this.GnomeSortBtn);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.SelectSortBtn);
            this.Controls.Add(this.ShellSortBtn);
            this.Controls.Add(this.ShakeSortBtn);
            this.Controls.Add(this.InsertSortBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bubleSortBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bubleSortBtn;
        private System.Windows.Forms.Label DurationLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label SwopLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertSortBtn;
        private System.Windows.Forms.Button ShakeSortBtn;
        private System.Windows.Forms.Button ShellSortBtn;
        private System.Windows.Forms.Button SelectSortBtn;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button GnomeSortBtn;
        private System.Windows.Forms.Button TreeSortBtn;
        private System.Windows.Forms.Button LsdRedixSortBtn;
        private System.Windows.Forms.Button MsdRedixSortBtn;
    }
}

