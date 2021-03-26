using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Persik
{
    class Pers2
    {
        public int Vhod_size = 100;
        public int Hidden_size = 57;
        public double[] Vhod_neiron;
        private double[] Hidden_neiron;
        private double[][] Rebro_vhod_to_hid;
        private double[] Rebro_hid_to_output;
        Random rand = new Random();

        public void UtchiUtchiUthciUthci(Pattern[] pater){
            double[] errors = new double[Hidden_size];
            double gError;
            double step=0;
            do
            {
                gError = 0;
                step++;
                for (int p = 0; p < pater.Length; p++)
                {
                    double lError = pater[p].Answers - Sprosi_Otvetchu(pater[p].PatValues);
                    gError += Math.Abs(lError);
                    for (int i = 0; i < Hidden_size; i++)
                    {
                        errors[i] = lError * Rebro_hid_to_output[i];
                        Rebro_hid_to_output[i] += 0.1 * lError * Hidden_neiron[i];
                    }
                    for (int i = 0; i < Vhod_size; i++)
                    {
                        for (int j = 0; j < Hidden_size; j++)
                        {
                            Rebro_vhod_to_hid[i][j] += 0.1 * errors[j] * pater[p].PatValues[i];
                        }
                    }
                }
            } while (Math.Abs(gError) > 0.001);
        }


        public double Sprosi_Otvetchu(double[] Vhod){
            for (int i = 0; i < Hidden_size; i++) {
                double sum_1=0;
                for (int j = 0; j < Vhod_size; j++) {
                    sum_1+=Vhod[j]*Rebro_vhod_to_hid[j][i];
                }
                Hidden_neiron[i] = sum_1>0.5?1:0;
            }
            double sum_2=0;
            for (int i = 0; i < Hidden_size; i++) {
                sum_2+=Hidden_neiron[i]*Rebro_hid_to_output[i];
            }
            return sum_2;
        }

        public Pers2() {
            Vhod_neiron = new double[Vhod_size];
            Hidden_neiron = new double[Hidden_size];
            Rebro_vhod_to_hid = new double[Vhod_neiron.Length][];
            for (int i = 0; i < Vhod_neiron.Length; Rebro_vhod_to_hid[i] = new double[Hidden_size], i++) ;
            Rebro_hid_to_output = new double[Hidden_size];
            for (int i = 0; i < Vhod_neiron.Length; i++)
            {
                for (int j = 0; j < Hidden_size; j++) {
                    Rebro_vhod_to_hid[i][j]=rand.NextDouble();
                }
            }
            for (int i = 0; i < Hidden_size; i++) {
                Rebro_hid_to_output[i]=rand.NextDouble();
            }
        }
    }
}
