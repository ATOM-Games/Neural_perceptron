using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Persik
{
    class Pers_G
    {
        public double[] VhodDann = new double[2];
        public double[] VihodDann;
        public double[] hiddetDann;
        public double[][] wIH, wHO;
        Random rand = new Random();
        public void NewPers(int Vih)
        {
            this.VihodDann = new double[Vih];
            this.hiddetDann = new double[(int)((VhodDann.Length + VihodDann.Length) / 2)];
            //---------------------------------
            wIH = new double[VhodDann.Length][]; wHO = new double[hiddetDann.Length][];
            for (int v = 0; v < VhodDann.Length; v++)
            {
                wIH[v] = new double[hiddetDann.Length];
                for (int g = 0; g < wIH[v].Length; wIH[v][g] = rand.NextDouble(), g++) ;
            }
            for (int v = 0; v < hiddetDann.Length; v++)
            {
                wHO[v] = new double[VihodDann.Length];
                for (int g = 0; g < wHO[v].Length; wHO[v][g] = rand.NextDouble(), g++) ;
            }
            MessageBox.Show("Новый перец готов (" + hiddetDann.Length + " " + VihodDann.Length + ") [" + wIH[wIH.Length - 1][wIH[wIH.Length - 1].Length - 1] + " " + wHO[wHO.Length - 1][wHO[wHO.Length - 1].Length - 1] + "]");
        }


        public void SprosiOtvechu()
        {
            for (int j = 0; j < hiddetDann.Length; hiddetDann[j] = 0, j++) ;//--обнляем скрытые нейроны
            for (int j = 0; j < VihodDann.Length; VihodDann[j] = 0, j++) ;//--обнляем выходные дынне

            for (int j = 0; j < hiddetDann.Length; j++)
            {
                for (int i = 0; i < VhodDann.Length; i++)
                {
                    hiddetDann[j] += VhodDann[i] * wIH[i][j]; // расчитываем веса скрытого нейрона
                }
            }

            for (int i = 0; i < hiddetDann.Length; i++)
            {
                for (int j = 0; j < VihodDann.Length; j++)
                {
                    VihodDann[j] += hiddetDann[i] * wHO[i][j];
                }
            }
        }

        public void VnikayVnikayVnikayVnikay(Pattern[] patterns)
        {
            double[] err = new double[hiddetDann.Length];
            double gErr = 0;

            do
            {
                gErr = 0;
                for (int p = 0; p < patterns.Length; p++)
                {
                    for (int i = 0; i < VhodDann.Length; i++)
                    {
                        VhodDann[i] = patterns[p].PatValues[i];
                    }
                    SprosiOtvechu();
                    double lErr = patterns[p].Answers - VihodDann[p];
                    gErr += Math.Abs(lErr);

                    //-------------
                    for (int i = 0; i < hiddetDann.Length; i++)
                    {
                        for (int v = 0; v < VihodDann.Length; v++)
                        {
                            err[i] += lErr * wHO[i][v];
                        }
                    }

                    for (int i = 0; i < VhodDann.Length; i++)
                    {
                        for (int g = 0; g < hiddetDann.Length; g++)
                        {
                            wIH[i][g] += 0.1 * err[g] * VhodDann[i];
                        }
                    }
                    for (int o = 0; o < VihodDann.Length; o++)
                    {
                        for (int h = 0; h < hiddetDann.Length; h++)
                        {
                            wHO[h][o] += 0.1 * lErr * hiddetDann[h];
                        }
                    }
MessageBox.Show("Срань");
                this.ShowPersInCons();
                }
                
                
            } while (Math.Abs(gErr) > 2);
            MessageBox.Show("Готово!");
        }

        public string Iktojeeto(Pattern[] paterns)
        {
            double max = -500000; int mi = -1;
            for (int o = 0; o < VihodDann.Length; o++)
            {
                if (max < VihodDann[o])
                {
                    max = VihodDann[o];
                    mi = o;
                }
            }
            if (mi < 0)
            {
                return "Ошибка какая-то";
            }
            else
            {
                return "Это скорее всего " + paterns[mi].Nazvanie.Text;
            }

        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < 100; i++)
            {
                str += (VhodDann[i] + "\t");
                if (i % 10 == 9) { str += "\n"; }
            }
            return str;
        }

        public void ShowPersInCons()
        {
            string STwr = "ABC 0.1 \n";
            for (int vh = 0; vh < VhodDann.Length; STwr += (VhodDann[vh] + " "), vh++) ;
            STwr += "\n";
            for (int h = 0; h < hiddetDann.Length; STwr += (hiddetDann[h] + " "), h++) ;
            STwr += "\n";
            for (int vih = 0; vih < VihodDann.Length; STwr += (VihodDann[vih] + " "), vih++) ;
            STwr += "\n\n";
            for (int vh = 0; vh < wIH.Length; vh++)
            {
                for (int hi = 0; hi < wIH[vh].Length; STwr += String.Format("{0:0.#####}   ", wIH[vh][hi]), hi++) ;
                STwr += "\n";
            }
            STwr += "\n\n";
            for (int hi = 0; hi < wHO.Length; hi++)
            {
                for (int vh = 0; vh < wHO[hi].Length; STwr += String.Format("{0:0.#####}   ", wHO[hi][vh]), vh++) ;
                STwr += "\n";
            }/**/
            MyConsole myco = new MyConsole(STwr);
            myco.Show();

        }
    }
}
