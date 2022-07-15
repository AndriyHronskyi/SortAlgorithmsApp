﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithmsApp
{
    class SortedItem
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }    
        public int Value { get; set; }

        public SortedItem(int value)
        { 
            Value = value;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            // 
            // verticalProgressBar1
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.SeaGreen;
            ProgressBar.Location = new System.Drawing.Point(3, 7);
            ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar1";
            ProgressBar.Size = new System.Drawing.Size(10, 137);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = 5;
            ProgressBar.Value = Value;
            // 
            // label2
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(0, 143);
            Label.Name = "label2";
            Label.Size = new System.Drawing.Size(19, 13);
            Label.TabIndex = 6;
            Label.Text = Value.ToString();
        }
    
    }
}