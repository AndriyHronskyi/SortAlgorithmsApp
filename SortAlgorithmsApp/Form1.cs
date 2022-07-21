using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithmsApp
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);  
            }
            RefreshItems();

            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(0,100), items.Count);
                    items.Add(item);
                }
            }

            RefreshItems();
            FillTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();

            foreach (var item in items)
            {

                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }
            panel3.Refresh();
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void Algorithm_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel3.Refresh();

            //Return default color after Swop
            e.Item1.SetColor(Color.SeaGreen);
            e.Item2.SetColor(Color.SeaGreen);
            panel3.Refresh();
        }

        private void Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Blue);

            panel3.Refresh();
        }

        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwopEvent += Algorithm_SwopEvent;
            var time = algorithm.Sort();

            DurationLbl.Text = "Duration: " + time.Seconds + " sec.";
            SwopLbl.Text = "Number of swop: " + algorithm.SwopCount;
            CompareLbl.Text = "Number of compares: " + algorithm.ComparisonCount;
            panel4.Refresh();
        }

        private void bubleSortBtn_Click(object sender, EventArgs e)
        {
            var bubble = new BubleSort<SortedItem>(items);
            BtnClick(bubble);
        }

        private void ShakeSortBtn_Click(object sender, EventArgs e)
        {
            var shake = new ShakeSort<SortedItem>(items);
            BtnClick(shake);
        }

        
    }
}
