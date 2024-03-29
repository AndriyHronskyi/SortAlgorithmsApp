﻿using Algorithm;
using Algorithm.DataStructures;
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

        private void AlgorithmSwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Aqua);
            e.Item2.SetColor(Color.Brown);
            panel3.Refresh();

            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel3.Refresh();

            Thread.Sleep(20);

            //Return default color after Swop
            e.Item1.SetColor(Color.SeaGreen);
            e.Item2.SetColor(Color.SeaGreen);
            panel3.Refresh();

            Thread.Sleep(20);
        }

        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Blue);

            panel3.Refresh();
            Thread.Sleep(20);

            //Return default color after Swop
            e.Item1.SetColor(Color.SeaGreen);
            e.Item2.SetColor(Color.SeaGreen);
            panel3.Refresh();

            Thread.Sleep(20);
        }

        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e) 
        {
            e.Item2.SetColor(Color.Red);
            panel3.Refresh();

            Thread.Sleep(20);

            e.Item2.SetPosition(e.Item1);
            panel3.Refresh();

            Thread.Sleep(20);

            //Return default color after Swop
            e.Item2.SetColor(Color.SeaGreen);
            panel3.Refresh();

            Thread.Sleep(20);
        }

        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel3.Refresh();

            algorithm.CompareEvent += AlgorithmCompareEvent;
            algorithm.SwopEvent += AlgorithmSwopEvent;
            algorithm.SetEvent += AlgorithmSetEvent;
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

        private void InsertSortBtn_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BtnClick(insert);
        }

        private void ShellSortBtn_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void SelectSortBtn_Click(object sender, EventArgs e)
        {
            var select = new SelectionSort<SortedItem>(items);
            BtnClick(select);
        }

        private void TreeSortBtn_Click(object sender, EventArgs e)
        {
            var tree = new Tree<SortedItem>(items);
            BtnClick(tree);
        }

        private void HeapSortBtn_Click(object sender, EventArgs e)
        {
            var heap = new Heap<SortedItem>(items);
            BtnClick(heap);
        }

        private void GnomeSortBtn_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            BtnClick(gnome);
        }

        private void LsdRedixSortBtn_Click(object sender, EventArgs e)
        {
            var LsdRedix = new LsdRedixSort<SortedItem>(items);
            BtnClick(LsdRedix);
        }

        private void MsdRedixSortBtn_Click(object sender, EventArgs e)
        {
            var MsdRedix = new MsdRedixSort<SortedItem>(items);
            BtnClick(MsdRedix);
        }

        private void MergeSortBtn_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);
            BtnClick(merge);
        }

        private void quickSortBtn_Click(object sender, EventArgs e)
        {
            var quickS = new QuickSort<SortedItem>(items);
            BtnClick(quickS);
        }
    }
}
