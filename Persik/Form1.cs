using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Persik
{
    public partial class Form1 : Form
    {
        private Color VidCol = Color.White;
        private double VidDou = 0;
        private Pers2 pers = new Pers2();
        public double Answ=0;
        public double Delitel = 0;


        public Form1() { InitializeComponent(); }

        private void RisPol_Paint(object sender, MouseEventArgs e) {
            ((Panel)sender).BackColor = VidCol;
            pers.Vhod_neiron[((Panel)sender).TabIndex] = VidDou;
        }

        private void ColorBut_Click(object sender, EventArgs e) {
            VidCol = ((Button)sender).BackColor;
            VidDou = ((Button)sender).TabIndex * 1d / 10;
        }

        private void ShowDann_Click(object sender, EventArgs e) {
            MessageBox.Show(pers.ToString());
        }

        private void Learn_Click(object sender, EventArgs e)
        {
            pers.UtchiUtchiUthciUthci(this.Paterns.ToArray());
        }

        private void Sprosit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Paterns[ParserCaster(pers.Sprosi_Otvetchu(pers.Vhod_neiron) * Paterns.Count)].ToString());
        }

        private void очиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++) {
                pers.Vhod_neiron[i] = 0;
                RisPol[i].BackColor = Color.White;
            }
        }

        private void AddObject_Click(object sender, EventArgs e)
        {
            this.AllPata.VerticalScroll.Value = 0;
            Pattern p = new Pattern(pers.Vhod_neiron, WhatIsIt.Text, 0);

            p.Location = new System.Drawing.Point(14, 5 + Paterns.Count * 65);
            Paterns.Add(p);
            this.AllPata.Controls.Add(p);
        }

        private void AddBaseObject_Click(object sender, EventArgs e) {
            Pattern p = new Pattern(stringToDoubleArray("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"), "Пустое поле", 0);
            p.Location = new System.Drawing.Point(14, 5 + Paterns.Count * 65); Paterns.Add(p);
            this.AllPata.Controls.Add(p);
            p = new Pattern(stringToDoubleArray("1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1"), "Квадрат", 0.25);
            p.Location = new System.Drawing.Point(14, 5 + Paterns.Count * 65); Paterns.Add(p);
            this.AllPata.Controls.Add(p);
            p = new Pattern(stringToDoubleArray("0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1"), "Треугольник", 0.5);
            p.Location = new System.Drawing.Point(14, 5 + Paterns.Count * 65); Paterns.Add(p);
            this.AllPata.Controls.Add(p);
            p = new Pattern(stringToDoubleArray("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,1,1,0,0,0,0,1,1,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"), "Смайл", 0.75);
            p.Location = new System.Drawing.Point(14, 5 + Paterns.Count * 65); Paterns.Add(p);
            this.AllPata.Controls.Add(p);
            p = new Pattern(stringToDoubleArray("1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1"), "Линия", 1);
            p.Location = new System.Drawing.Point(14, 5 + Paterns.Count * 65); Paterns.Add(p);
            this.AllPata.Controls.Add(p);
        }

        private void NewPers_Click(object sender, EventArgs e)
        {
            //this.pers.NewPers(this.Paterns.Count);
            this.Delitel = 1d / Paterns.Count;
            for (int i = 0; i < Paterns.Count; Paterns[i].Answers = Delitel*i, i++ ) ;
            //this.pers.NewNeiron();
        }

        private double[] stringToDoubleArray(string str) {
            string[] ch = str.Split(',');
            double[] du = new double[ch.Length];
            for (int d = 0; d < du.Length; du[d] = Double.Parse(ch[d]), d++ ) ;
            return du;
        }

        private void ShowConsoleObject_Click(object sender, EventArgs e) {

        }
        public int ParserCaster(double d) {
            int o = (int)d;
            if (Math.Abs(d - o) > 0.5) o++;
            return o;
        }
    }
}
