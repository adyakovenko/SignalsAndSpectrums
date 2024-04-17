using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace SignalsAndSpectrums
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetGraphicsStartingParameters();
            SetLabels();
            plotSpectrum.Location = new Point(plotSpectrum.Location.X, plotSignal.Location.Y + plotSignal.Height);
        }

        //начальная настройка холстов
        private void SetGraphicsStartingParameters()
        {
            plotSignal.Model = new PlotModel();
            plotSpectrum.Model = new PlotModel();
            plotSignal.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 1 });
            plotSignal.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = 1 });
            plotSpectrum.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 1 });
            plotSpectrum.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = 1 });
            plotSignal.Model.Axes[0].MajorGridlineColor = OxyColors.LightGray;
            plotSignal.Model.Axes[0].MinorGridlineColor = OxyColors.LightGray;
            plotSignal.Model.Axes[1].MajorGridlineColor = OxyColors.LightGray;
            plotSignal.Model.Axes[1].MinorGridlineColor = OxyColors.LightGray;
            plotSignal.Model.Axes[0].MinorGridlineStyle = LineStyle.Dash;
            plotSignal.Model.Axes[1].MinorGridlineStyle = LineStyle.Dash;
            plotSignal.Model.Axes[0].MajorGridlineStyle = LineStyle.Dash;
            plotSignal.Model.Axes[1].MajorGridlineStyle = LineStyle.Dash;
            plotSpectrum.Model.Axes[0].MajorGridlineColor = OxyColors.LightGray;
            plotSpectrum.Model.Axes[0].MinorGridlineColor = OxyColors.LightGray;
            plotSpectrum.Model.Axes[1].MajorGridlineColor = OxyColors.LightGray;
            plotSpectrum.Model.Axes[1].MinorGridlineColor = OxyColors.LightGray;
            plotSpectrum.Model.Axes[0].MinorGridlineStyle = LineStyle.Dash;
            plotSpectrum.Model.Axes[1].MinorGridlineStyle = LineStyle.Dash;
            plotSpectrum.Model.Axes[0].MajorGridlineStyle = LineStyle.Dash;
            plotSpectrum.Model.Axes[1].MajorGridlineStyle = LineStyle.Dash;
            plotSignal.Model.Axes[0].Title = "time, s";
            plotSignal.Model.Axes[1].Title = "Amplitude";
            plotSpectrum.Model.Axes[0].Title = "frequency, Hz";
            plotSpectrum.Model.Axes[1].Title = "Amplitude";
        }

        //настройка начальных значений при включении программы
        private void SetLabels()
        {
            textBoxFDom.Text = "20";
            textBoxP.Text = "20";
            textBoxQ.Text = "40";
            textBoxV.Text = "1500";
        }

        private void DoubleTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            TextBoxInputController.TextBoxDoublePositiveOnKeyPress(e, textBox.Text);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (textBoxFDom.Text == string.Empty)
                MessageBox.Show("Input dominant frequency");
            else if (textBoxV.Text == string.Empty)
                MessageBox.Show("Input velocity");
            else if (textBoxP.Text == string.Empty)
                MessageBox.Show("Input path");
            else if (textBoxQ.Text == string.Empty)
                MessageBox.Show("Input quality factor");
            else
            {
                if (float.TryParse(textBoxFDom.Text, out float fDom))
                {
                    if (float.TryParse(textBoxP.Text, out float x))
                    {
                        if (float.TryParse(textBoxQ.Text, out float q))
                        {
                            if (float.TryParse(textBoxV.Text, out float v))
                            {
                                if (!(v >= 600 && v <= 3000))
                                    MessageBox.Show("Allowed input velocity is 600-3000 m/s");
                                else if (!(x >= 0.5 && x <= 5000))
                                    MessageBox.Show("Allowed path length is 0.5-6000 m");
                                else if (!(q >= 5 && q <= 200))
                                    MessageBox.Show("Allowed quality factor is 5-200");
                                else if (!(fDom >= 10 && fDom <= 6000))
                                    MessageBox.Show("Allowed dominant frequency is 10-6000 Hz");
                                else
                                    RefreshFormData(v, x, q, fDom);
                            }
                            else
                                MessageBox.Show("Failed to read velocity");
                        }
                        else
                            MessageBox.Show("Failed to read quality factor");
                    }
                    else
                        MessageBox.Show("Failed to read path length");
                }
                else
                    MessageBox.Show("Failed to read dominant frequency");
            }
        }

        private void RefreshFormData(float v, float x, float q, float fDom)
        {
            //расчёт графиков по входным данным
            SpectralCalculator sc = new SpectralCalculator(Constants.df, Constants.dt, v, x, q, fDom);

            //очистка от предыдущих графиков
            plotSignal.Model.Series.Clear();
            plotSpectrum.Model.Series.Clear();

            //отрисовка новых графиков
            draw(plotSignal.Model, sc.Times, sc.Signal, OxyColors.Red);
            draw(plotSignal.Model, sc.Times, sc.SignalQ, OxyColors.Blue);
            draw(plotSpectrum.Model, sc.Frequencies, sc.SpectrumMagnitude, OxyColors.Red);
            draw(plotSpectrum.Model, sc.Frequencies, sc.SpectrumMagnitudeQ, OxyColors.Blue);

            //изменение границ под графики
            plotSignal.Model.Axes[0].Maximum = 1.2 / fDom;
            plotSignal.Model.Axes[0].Minimum = -plotSignal.Model.Axes[0].Maximum;
            plotSignal.Model.Axes[1].Minimum = sc.Signal.Min();
            plotSpectrum.Model.Axes[0].Maximum = 3 * fDom;

            //вычисление отношений амплитуд и сдвига по частоте
            labelARatioNumber.Text = Math.Round((sc.Signal.Max() - sc.Signal.Min()) / (sc.SignalQ.Max() - sc.SignalQ.Min()), 3).ToString();
            int max1 = 0, max2 = 0;
            for (int i = 0; i < sc.SpectrumMagnitude.Length / 2; i++)
            {
                if (sc.SpectrumMagnitude[i] > sc.SpectrumMagnitude[max1])
                    max1 = i;
                if (sc.SpectrumMagnitudeQ[i] > sc.SpectrumMagnitudeQ[max2])
                    max2 = i;
            }
            labelFShiftNumber.Text = ((float)(max1 - max2) * Constants.df).ToString();

            //обновление рисунков
            plotSignal.Model.InvalidatePlot(true);
            plotSpectrum.Model.InvalidatePlot(true);
        }

        //запись нового графика на выбираемый холст
        private void draw(OxyPlot.PlotModel model, float[] x, float[] y, OxyColor color)
        {
            OxyPlot.Series.FunctionSeries fs = new FunctionSeries();
            for (int i = 0; i < x.Length; i++)
                fs.Points.Add(new OxyPlot.DataPoint(x[i], y[i]));
            fs.Color = color;
            model.Series.Add(fs);
        }
        
        //обработка сохранения картинки
        private void buttonScreen_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, this.ClientRectangle);
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(SFD.FileName);
            }
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            
            plotSignal.Height = (this.Height - 100) / 2;
            plotSpectrum.Location = new Point(plotSpectrum.Location.X, plotSignal.Location.Y + plotSignal.Height);
            plotSpectrum.Height = plotSignal.Height;
        }
    }
}