namespace Taschenrechner_2_Nick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Lösung;
        int Klammer;
        int IndexKlAuf;
        int IndexKlZu;
        int zähler;
        int zähler2;
        int potenz;
        double rechnungg;




        List<String> list1 = new List<String>();
        List<String> list2 = new List<String>();



        private void button1_Click(object sender, EventArgs e)
        {
            tb1.AppendText("1");
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.AppendText("2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb1.AppendText("3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb1.AppendText("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb1.AppendText("5");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb1.AppendText("6");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tb1.AppendText("7");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tb1.AppendText("8");
            //
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tb1.AppendText("9");
            //
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            tb1.AppendText(" + ");



        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            tb1.AppendText(" / ");


        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            tb1.AppendText(" - ");


        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            tb1.AppendText(" x ");

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            list1 = tb1.Text.Split(null).ToList();
            for(int i = 0; i < list1.Count; i++)
            {
                if (list1[i].Contains("^"))
                {
                    potenz = Int32.Parse(list1[i + 1]);
                    for (int j = 0; j < potenz; j++)
                    {
                         rechnungg = double.Parse(list1[i - 1]) * double.Parse(list1[i - 1]);
                        list1[i - 1] = Convert.ToString(rechnungg);
                    }
                    
                    list1.RemoveRange(i, 2);
                    

                }
            }

            for (int y = 0; y < list1.Count; y++)
            {
                if (list1[y].Contains("("))
                {

                    zähler++;
                }
            }

            for (int z = 0; z < zähler; z++)
            {
                for (int k = 0; k < list1.Count; k++)
                {
                    if (list1[k].Contains(")"))
                    {
                        Klammer = 0;
                        list1.RemoveAt(k);
                        break;
                    }

                    else if (list1[k].Contains("("))
                    {
                        Klammer = 1;
                        IndexKlAuf = list1.IndexOf("(");

                    }
                    else if (Klammer == 1)
                    {
                        if (list1[k].Contains("("))
                        {
                            Klammer = 0;
                            zähler2++;
                            break;
                        }

                        list2.Add(list1[k]);
                        list1.RemoveAt(k);
                        k -= 1;

                    }
                }
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list2[i].Contains('x'))
                    {
                        double produkt = Double.Parse(list2[i + 1]) * Double.Parse(list2[i - 1]);
                        list2[i - 1] = Convert.ToString(produkt);

                        list2.RemoveRange(i, 2);
                        i = 0;





                        produkt = 0;
                    }
                    else if (list2[i].Contains('/'))
                    {
                        double produkt = Double.Parse(list2[i - 1]) / Double.Parse(list2[i + 1]);
                        list2[i - 1] = Convert.ToString(produkt);

                        list2.RemoveRange(i, 2);
                        i = 0;

                        produkt = 0;
                    }
                }
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list2[j].Contains('+'))
                    {
                        double add = Double.Parse(list2[j - 1]);
                        double summe = add + Double.Parse(list2[j + 1]);
                        list2[j - 1] = Convert.ToString(summe);
                        summe = 0;
                        add = 0;
                        list2.RemoveRange(j, 2);
                        j = 0;
                    }
                    else if (list2[j].Contains('-'))
                    {
                        double add = double.Parse(list2[j - 1]);
                        double summe = add - double.Parse(list2[j + 1]);
                        list2[j - 1] = Convert.ToString(summe);
                        summe = 0;
                        add = 0;
                        list2.RemoveRange(j, 2);
                        j = 0;

                    }

                }
                list1[IndexKlAuf] = list2[0];
                list2.Clear();
            }

















            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].Contains('x'))
                {
                    double produkt = Double.Parse(list1[i + 1]) * Double.Parse(list1[i - 1]);
                    list1[i - 1] = Convert.ToString(produkt);

                    list1.RemoveRange(i, 2);
                    i = 0;





                    produkt = 0;
                }
                else if (list1[i].Contains('/'))
                {
                    double produkt = Double.Parse(list1[i - 1]) / Double.Parse(list1[i + 1]);
                    list1[i - 1] = Convert.ToString(produkt);

                    list1.RemoveRange(i, 2);
                    i = 0;

                    produkt = 0;
                }
            }
            for (int j = 0; j < list1.Count; j++)
            {
                if (list1[j].Contains('+'))
                {
                    double add = Double.Parse(list1[j - 1]);
                    double summe = add + Double.Parse(list1[j + 1]);
                    list1[j - 1] = Convert.ToString(summe);
                    summe = 0;
                    add = 0;
                    list1.RemoveRange(j, 2);
                    j = 0;
                }
                else if (list1[j].Contains('-'))
                {
                    double add = Double.Parse(list1[j - 1]);
                    double summe = add - Double.Parse(list1[j + 1]);
                    list1[j - 1] = Convert.ToString(summe);
                    summe = 0;
                    add = 0;
                    list1.RemoveRange(j, 2);
                    j = 0;
                }

            }
            tb2.AppendText(list1[0]);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Lösung = 0;
            tb2.Clear();
            tb1.Clear();

            Klammer = 0;
            IndexKlAuf = 0;
            IndexKlZu = 0;
            list1.Clear();
            list2.Clear();



        }


        private void buttonKlAuf_Click(object sender, EventArgs e)
        {
            tb1.AppendText("( ");
        }
        private void buttonKlZu_Click(object sender, EventArgs e)
        {
            tb1.AppendText(" )");
        }

        private void buttonHoch_Click(object sender, EventArgs e)
        {
            tb1.AppendText(" ^ ");
        }
    }
}



