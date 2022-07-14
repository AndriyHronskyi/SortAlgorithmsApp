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
            this.verticalProgressBar1 = new VerticalProgressBar.VerticalProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add number";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(310, 22);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(16, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(284, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 68);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fill array random numbers";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(310, 22);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(16, 25);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(284, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.verticalProgressBar1);
            this.panel3.Location = new System.Drawing.Point(436, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 158);
            this.panel3.TabIndex = 4;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.verticalProgressBar1.Color = System.Drawing.Color.SeaGreen;
            this.verticalProgressBar1.Location = new System.Drawing.Point(3, 7);
            this.verticalProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.verticalProgressBar1.Maximum = 100;
            this.verticalProgressBar1.Minimum = 0;
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(10, 137);
            this.verticalProgressBar1.Step = 1;
            this.verticalProgressBar1.Style = VerticalProgressBar.Styles.Solid;
            this.verticalProgressBar1.TabIndex = 5;
            this.verticalProgressBar1.Value = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private VerticalProgressBar.VerticalProgressBar verticalProgressBar1;
    }
}

