﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AisOfTheRailwayStationDispatcherMy
{
    public partial class Main : Form
    {
        public static Main main;

        public Main()
        {
            InitializeComponent();
            main = this;
        }
        //продажа билетов
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //списки маршрутов
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //области
        private void button3_Click(object sender, EventArgs e)
        {
            showArea();
        }
        //районы
        private void button4_Click(object sender, EventArgs e)
        {
            showRegion();
        }
        //пункты назначения
        private void button5_Click(object sender, EventArgs e)
        {

        }
        //маршруты
        private void button6_Click(object sender, EventArgs e)
        {

        }
        //поезда
        private void button7_Click(object sender, EventArgs e)
        {

        }
        //сотрудники
        private void button8_Click(object sender, EventArgs e)
        {

        }
        //должности
        private void button9_Click(object sender, EventArgs e)
        {

        }
        //клиенты
        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void showArea() {
            this.Hide();
            new Area().Show();
        }
        private void showRegion()
        {
            this.Hide();
            new Region().Show();
        }
    }
}