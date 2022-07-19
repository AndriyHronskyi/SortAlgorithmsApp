using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithmsApp
{
    class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }    
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }

        public SortedItem(int value, int number)
        { 
            Value = value;
            Number = number;
            StartNumber = number;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            var x = number * 20;


            // 
            // verticalProgressBar1
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = Color.SeaGreen;
            ProgressBar.Location = new Point(x, 7);
            ProgressBar.Margin = new Padding(0);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar1" + number;
            ProgressBar.Size = new Size(10, 137);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // label2
            // 
            Label.AutoSize = true;
            Label.Location = new Point(x, 143);
            Label.Name = "label2" + number;
            Label.Size = new Size(19, 13);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 20;
            ProgressBar.Location = new Point(x, 7);
            Label.Location = new Point(x, 143);

            //change name
            ProgressBar.Name = "ProgressBar1" + number;
            Label.Name = "label2" + number;
        }

        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 20;
            ProgressBar.Location = new Point(x, 7);
            Label.Location = new Point(x, 143);

            //change name
            ProgressBar.Name = "ProgressBar1" + Number;
            Label.Name = "label2" + Number;
        }

        public void SetColor(Color color)
        { 
            ProgressBar.Color = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
