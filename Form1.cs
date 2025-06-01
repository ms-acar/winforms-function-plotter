using ScottPlot;
using ScottPlot.Plottables;
using ScottPlot.WinForms;

namespace FunctionPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Function Plotter";
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            formsPlot1.Plot.Axes.Title.Label.Text = "Kartezyen Koordinat Düzlemi";
            formsPlot1.Plot.Axes.Bottom.Label.Text = "x-ekseni";
            formsPlot1.Plot.Axes.Left.Label.Text = "y-ekseni";
            pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\acer\Desktop\winFormsApps\FunctionPlotter\FunctionPlotter\logo.png");
            var xAxisLine = formsPlot1.Plot.Add.HorizontalLine(0);
            xAxisLine.Color = Colors.Black;
            xAxisLine.LineWidth = 2;
            xAxisLine.LinePattern = LinePattern.Solid;

            // Y ekseni çizgisi (x = 0)
            var yAxisLine = formsPlot1.Plot.Add.VerticalLine(0);
            yAxisLine.Color = Colors.Black;
            yAxisLine.LineWidth = 2;
            yAxisLine.LinePattern = LinePattern.Solid;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double b) &&
                double.TryParse(textBox2.Text, out double c))
            {
                // Fonksiyonu tanýmla
                Func<double, double> f = (x) => b * x + c;

                // Grafik temizle
                //formsPlot1.Plot.Clear();

                // Fonksiyonu ekle ve ayarla
                var curve = formsPlot1.Plot.Add.Function(f);
                curve.LineStyle.Color = new ScottPlot.Color(139, 0, 0);
                //curve.LineWidth = 1;
                curve.LegendText = $"y ={b}x + {c}";

                // Eksenler ve baþlýk
                formsPlot1.Plot.Axes.Title.Label.Text = "Ýkinci Dereceden Denklem Grafiði";
                formsPlot1.Plot.Axes.Bottom.Label.Text = "x";
                formsPlot1.Plot.Axes.Left.Label.Text = "y";

                // Legend görünür yap
                formsPlot1.Plot.Legend.IsVisible = true;

                // Yenile
                formsPlot1.Refresh();

                string t1 = textBox1.Text.Trim();
                string t2 = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(t1) || !string.IsNullOrEmpty(t2))
                {
                    string satir = $"y = {t1}x + {t2}";
                    listBox1.Items.Add(satir);

                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayýlar giriniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double a) &&
            double.TryParse(textBox4.Text, out double b) &&
            double.TryParse(textBox5.Text, out double c))
            {
                // Fonksiyonu tanýmla
                Func<double, double> f = (x) => a * x * x + b * x + c;

                // Fonksiyonu ekle ve ayarla
                var curve = formsPlot1.Plot.Add.Function(f);
                curve.LineStyle.Color = new ScottPlot.Color(139, 0, 0);
                curve.LegendText = $"y = {a}x² + {b}x + {c}";

                formsPlot1.Plot.Legend.IsVisible = true;


                // Yenile
                formsPlot1.Refresh();

                string t1 = textBox3.Text.Trim();
                string t2 = textBox4.Text.Trim();
                string t3 = textBox5.Text.Trim();

                if (!string.IsNullOrEmpty(t1) || !string.IsNullOrEmpty(t2) || !string.IsNullOrEmpty(t3))
                {
                    string satir = $"y = {t1}x² + {t2}x + {t3}";
                    listBox1.Items.Add(satir);

                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayýlar giriniz.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox9.Text, out double a) &&
            double.TryParse(textBox8.Text, out double b) &&
            double.TryParse(textBox7.Text, out double c) &&
            double.TryParse(textBox6.Text, out double d)
            )
            {
                // Fonksiyonu tanýmla
                Func<double, double> f = (x) => a * x * x * x + b * x * x + c * x + d;

                // Fonksiyonu ekle ve ayarla
                var curve = formsPlot1.Plot.Add.Function(f);
                curve.LineStyle.Color = new ScottPlot.Color(139, 0, 0);
                curve.LegendText = $"y = {a}x^3 + {b}x² + {c}x + {d}";

                // Eksenler ve baþlýk


                // Legend görünür yap
                formsPlot1.Plot.Legend.IsVisible = true;

                // Yenile
                formsPlot1.Refresh();

                string t1 = textBox6.Text.Trim();
                string t2 = textBox7.Text.Trim();
                string t3 = textBox8.Text.Trim();
                string t4 = textBox9.Text.Trim();

                if (!string.IsNullOrEmpty(t1) || !string.IsNullOrEmpty(t2) || !string.IsNullOrEmpty(t3) || !string.IsNullOrEmpty(t4))
                {
                    string satir = $"y = {t1}x^3 + {t2}x² + {t3}x + {t4}";
                    listBox1.Items.Add(satir);

                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayýlar giriniz.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            textBox1.Clear();
            textBox2.Clear();

            var xAxisLine = formsPlot1.Plot.Add.HorizontalLine(0);
            xAxisLine.Color = Colors.Black;
            xAxisLine.LineWidth = 2;
            xAxisLine.LinePattern = LinePattern.Solid;

            // Y ekseni çizgisi (x = 0)
            var yAxisLine = formsPlot1.Plot.Add.VerticalLine(0);
            yAxisLine.Color = Colors.Black;
            yAxisLine.LineWidth = 2;
            yAxisLine.LinePattern = LinePattern.Solid;

            formsPlot1.Refresh();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            var xAxisLine = formsPlot1.Plot.Add.HorizontalLine(0);
            xAxisLine.Color = Colors.Black;
            xAxisLine.LineWidth = 2;
            xAxisLine.LinePattern = LinePattern.Solid;

            // Y ekseni çizgisi (x = 0)
            var yAxisLine = formsPlot1.Plot.Add.VerticalLine(0);
            yAxisLine.Color = Colors.Black;
            yAxisLine.LineWidth = 2;
            yAxisLine.LinePattern = LinePattern.Solid;

            formsPlot1.Refresh();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            var xAxisLine = formsPlot1.Plot.Add.HorizontalLine(0);
            xAxisLine.Color = Colors.Black;
            xAxisLine.LineWidth = 2;
            xAxisLine.LinePattern = LinePattern.Solid;

            // Y ekseni çizgisi (x = 0)
            var yAxisLine = formsPlot1.Plot.Add.VerticalLine(0);
            yAxisLine.Color = Colors.Black;
            yAxisLine.LineWidth = 2;
            yAxisLine.LinePattern = LinePattern.Solid;

            formsPlot1.Refresh();
        }
        private IPlottable? ePlot;
        private IPlottable? lnPlot;
        private IPlottable? logPlot;
        private IPlottable? sinPlot;
        private IPlottable? cosPlot;
        private IPlottable? tanPlot;

        // X ekseni çizgisi (y = 0)


        private void button7_Click(object sender, EventArgs e)
        {
            // ex
            if (checkBox1.Checked)
            {
                if (double.TryParse(textBox10.Text, out double sayi))
                {
                    double sonuc = Math.Exp(sayi);
                    var ePlot = formsPlot1.Plot.Add.Function(t => t > 0 ? Math.Exp(t) : double.NaN);
                    ePlot.LegendText = $"Exp({sayi}) = {sonuc}";
                    ePlot.LineStyle.Color = new ScottPlot.Color(153, 0, 153);

                    var scatter = formsPlot1.Plot.Add.Scatter(
                        xs: new double[] { sayi },
                        ys: new double[] { sonuc }
                    );
                    scatter.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
                    scatter.MarkerSize = 10;
                    scatter.Color = ScottPlot.Colors.Red;
                    formsPlot1.Plot.Axes.AutoScale();
                    formsPlot1.Refresh();

                    string t1 = textBox10.Text.Trim();

                    if (!string.IsNullOrEmpty(t1))
                    {
                        string satir = $"y = e^{t1}";
                        listBox1.Items.Add(satir);

                        textBox10.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayý giriniz.");
                }

            }

            // lnx
            if (checkBox2.Checked)
            {
                if (double.TryParse(textBox11.Text, out double sayi))
                {
                    if (sayi > 0)
                    {
                        double sonuc = Math.Log(sayi);
                        var lnPlot = formsPlot1.Plot.Add.Function(t => t > 0 ? Math.Log(t) : double.NaN);
                        lnPlot.LegendText = $"ln({sayi}) = {sonuc}";
                        lnPlot.LineStyle.Color = new ScottPlot.Color(0, 102, 255);

                        var scatter = formsPlot1.Plot.Add.Scatter(
                            xs: new double[] { sayi },
                            ys: new double[] { sonuc }
                        );
                        scatter.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
                        scatter.MarkerSize = 10;
                        scatter.Color = ScottPlot.Colors.Red;
                        formsPlot1.Plot.Axes.AutoScale();
                        formsPlot1.Refresh();

                        string t1 = textBox11.Text.Trim();

                        if (!string.IsNullOrEmpty(t1))
                        {
                            string satir = $"y = ln({t1})";
                            listBox1.Items.Add(satir);

                            textBox11.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen deðer 0'dan büyük olmalýdýr.");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayý giriniz.");
                }
            }

            if (checkBox3.Checked)
            {
                if (double.TryParse(textBox12.Text, out double sayi1) && double.TryParse(textBox13.Text, out double sayi2))
                {
                    if (sayi1 > 0)
                    {
                        if (sayi2 > 1)
                        {
                            double sonuc = Math.Log(sayi1) / Math.Log(sayi2);
                            var logPlot = formsPlot1.Plot.Add.Function(t => t > 0 ? Math.Log(t) : double.NaN);
                            logPlot.LegendText = $"log({sayi1})^({sayi2}) = {sonuc}";
                            logPlot.LineStyle.Color = new ScottPlot.Color(150, 0, 0, 255);

                            var scatter = formsPlot1.Plot.Add.Scatter(
                                xs: new double[] { sayi2 },
                                ys: new double[] { sonuc }
                            );
                            scatter.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
                            scatter.MarkerSize = 10;
                            scatter.Color = ScottPlot.Colors.Red;
                            formsPlot1.Plot.Axes.AutoScale();
                            formsPlot1.Refresh();

                            string t1 = textBox12.Text.Trim();

                            if (!string.IsNullOrEmpty(t1))
                            {
                                string satir = $"y = log{t1}";
                                listBox1.Items.Add(satir);

                                textBox10.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girilen deðer 1'den büyük olmalýdýr.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen deðer 0'dan büyük olmalýdýr.");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayý giriniz.");
                }
            }
            if (checkBox4.Checked)
            {
                if (double.TryParse(textBox14.Text, out double sayi))
                {
                    double radyan = sayi * Math.PI / 180;
                    double sonuc = Math.Sin(radyan);
                    var cosPlot = formsPlot1.Plot.Add.Function(t => t > 0 ? Math.Sin(t) : double.NaN);
                    cosPlot.LegendText = $"Sin({sayi}) = {sonuc}";
                    cosPlot.LineStyle.Color = new ScottPlot.Color(255, 0, 255);

                    var scatter = formsPlot1.Plot.Add.Scatter(
                        xs: new double[] { radyan },
                        ys: new double[] { sonuc }
                    );
                    scatter.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
                    scatter.MarkerSize = 10;
                    scatter.Color = ScottPlot.Colors.Red;
                    formsPlot1.Plot.Axes.AutoScale();
                    formsPlot1.Refresh();

                    string t1 = textBox14.Text.Trim();

                    if (!string.IsNullOrEmpty(t1))
                    {
                        string satir = $"y = sin({t1})";
                        listBox1.Items.Add(satir);

                        textBox10.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayý giriniz.");
                }


            }

            // cos(x)
            if (checkBox5.Checked)
            {
                if (double.TryParse(textBox15.Text, out double sayi))
                {
                    double radyan = sayi * Math.PI / 180;
                    double sonuc = Math.Cos(radyan);
                    var cosPlot = formsPlot1.Plot.Add.Function(t => t > 0 ? Math.Cos(t) : double.NaN);
                    cosPlot.LegendText = $"Cos({sayi}) = {sonuc}";
                    cosPlot.LineStyle.Color = new ScottPlot.Color(102, 255, 102);

                    var scatter = formsPlot1.Plot.Add.Scatter(
                            xs: new double[] { radyan },
                            ys: new double[] { sonuc }
                        );
                    scatter.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
                    scatter.MarkerSize = 10;
                    scatter.Color = ScottPlot.Colors.Red;
                    formsPlot1.Plot.Axes.AutoScale();
                    formsPlot1.Refresh();

                    string t1 = textBox15.Text.Trim();

                    if (!string.IsNullOrEmpty(t1))
                    {
                        string satir = $"y = cos({t1})";
                        listBox1.Items.Add(satir);

                        textBox10.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayý giriniz.");
                }


            }
            if (checkBox6.Checked)
            {
                if (double.TryParse(textBox16.Text, out double sayi))
                {
                    double radyan = sayi * Math.PI / 180;
                    double sonuc = Math.Tan(radyan);
                    var tanPlot = formsPlot1.Plot.Add.Function(t => t > 0 ? Math.Tan(t) : double.NaN);
                    tanPlot.LegendText = $"Tan({sayi}) = {sonuc}";
                    tanPlot.LineStyle.Color = new ScottPlot.Color(204, 204, 0);

                    var scatter = formsPlot1.Plot.Add.Scatter(
                        xs: new double[] { radyan },
                        ys: new double[] { sonuc }
                    );
                    scatter.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
                    scatter.MarkerSize = 10;
                    scatter.Color = ScottPlot.Colors.Red;
                    formsPlot1.Plot.Axes.AutoScale();
                    formsPlot1.Refresh();
                    string t1 = textBox15.Text.Trim();

                    if (!string.IsNullOrEmpty(t1))
                    {
                        string satir = $"y = tan({t1})";
                        listBox1.Items.Add(satir);

                        textBox10.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayý giriniz.");
                }


            }
            if (checkBox7.Checked)
            {
                if (double.TryParse(textBox17.Text, out double sayi))
                {
                    double radyan = sayi * Math.PI / 180;
                    double sonuc = 1/Math.Tan(radyan);
                    var cotPlot = formsPlot1.Plot.Add.Function(t => t > 0 ? 1 / Math.Tan(t) : double.NaN);
                    cotPlot.LegendText = $"Cot({sayi}) = {sonuc}";
                    cotPlot.LineStyle.Color = new ScottPlot.Color(0, 153, 255);

                    var scatter = formsPlot1.Plot.Add.Scatter(
                            xs: new double[] { radyan },
                            ys: new double[] { sonuc }
                        );
                    scatter.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
                    scatter.MarkerSize = 10;
                    scatter.Color = ScottPlot.Colors.Red;
                    formsPlot1.Plot.Axes.AutoScale();
                    formsPlot1.Refresh();

                    string t1 = textBox15.Text.Trim();

                    if (!string.IsNullOrEmpty(t1))
                    {
                        string satir = $"y = cot({t1})";
                        listBox1.Items.Add(satir);

                        textBox10.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayý giriniz.");
                }


            }

            formsPlot1.Plot.Legend.IsVisible = checkBox1.Checked || checkBox2.Checked ||
                checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            var xAxisLine = formsPlot1.Plot.Add.HorizontalLine(0);
            xAxisLine.Color = Colors.Black;
            xAxisLine.LineWidth = 2;
            xAxisLine.LinePattern = LinePattern.Solid;

            // Y ekseni çizgisi (x = 0)
            var yAxisLine = formsPlot1.Plot.Add.VerticalLine(0);
            yAxisLine.Color = Colors.Black;
            yAxisLine.LineWidth = 2;
            yAxisLine.LinePattern = LinePattern.Solid;
            formsPlot1.Refresh();
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listBox1.SelectedItem != null)
        //    {
        //        string secilen = listBox1.SelectedItem.ToString();

        //        // "-" iþaretine göre böl
        //        string[] parcalar = secilen.Split('x');

        //        // Doluysa TextBox'lara ata (boþluklarý kýrp)
        //        if (parcalar.Length >= 2)
        //        {
        //            textBox1.Text = parcalar[0].Trim();
        //            textBox2.Text = parcalar[1].Trim();
        //        }
        //    }
        //}


        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var xAxisLine = formsPlot1.Plot.Add.HorizontalLine(0);
            xAxisLine.Color = Colors.Black;
            xAxisLine.LineWidth = 2;
            xAxisLine.LinePattern = LinePattern.Solid;

            // Y ekseni çizgisi (x = 0)
            var yAxisLine = formsPlot1.Plot.Add.VerticalLine(0);
            yAxisLine.Color = Colors.Black;
            yAxisLine.LineWidth = 2;
            yAxisLine.LinePattern = LinePattern.Solid;
        }
    }
}