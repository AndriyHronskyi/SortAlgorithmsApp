﻿using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithmsApp
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BubleSort<int>();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
