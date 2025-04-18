﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormAufgaben : Form
    {
        public FormAufgaben()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aufgabe = new Aufgabe(10);
            aufgabe.AufgabeFertig += SetStatusLabel;
            aufgabe.AufgabeAbarbeiten();
            aufgabe.AufgabeFertig -= SetStatusLabel;
        }

        private void SetStatusLabel(object? sender, string message)
        {
            lblStatus.Text = message;
        }
    }
}
