using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPredictionPerceptron
{
    public partial class Form1 : Form
    {
        private RgbColor rgbColor = new RgbColor(0, 0, 0);
        private SingleLayerPerceptron network = new SingleLayerPerceptron();
        int maxValue;

        public Form1()
        {
            InitializeComponent();
            trueColorCombo.DataSource = Enum.GetValues(typeof(TargetColor));
            gridView.AutoGenerateColumns = true;
        }

        private void UpdateBox()
        {
            ColorDispayBox.BackColor = RgbToSystemColor();
        }

        private void UpdateTable()
        {
            int index = 0;
            double value = Double.MinValue;
            GridRow row;
            List<GridRow> data = new List<GridRow>();
            for (int i = 0; i < SingleLayerPerceptron.neuronCount; i++)
            {
                if (network.neurons[i].y >= value)
                {
                    value = network.neurons[i].y;
                    index = i;
                }
                row = new GridRow(network.neurons[i].w[0], network.neurons[i].w[1], network.neurons[i].w[2],
                        network.neurons[i].y, (TargetColor)i);
                data.Add(row);
            }
            maxValue = index;
            gridView.DataSource = data;
            gridView.Rows[maxValue].DefaultCellStyle.BackColor = Color.Green;
        }

        private System.Drawing.Color RgbToSystemColor()
        {
            return System.Drawing.Color.FromArgb
                ((byte)(rgbColor.R * 255),
                 (byte)(rgbColor.G * 255),
                 (byte)(rgbColor.B * 255));
        }

        private void rTrackBar_Scroll(object sender, EventArgs e)
        {
            rgbColor.R = rTrackBar.Value / 1000.0;
            network.GetNetworkResult(new double[] { rgbColor.R, rgbColor.G, rgbColor.B });
            UpdateBox();
            UpdateTable();
        }

        private void gTrackBar_Scroll(object sender, EventArgs e)
        {
            rgbColor.G = gTrackBar.Value / 1000.0;
            network.GetNetworkResult(new double[] { rgbColor.R, rgbColor.G, rgbColor.B });
            UpdateBox();
            UpdateTable();
        }

        private void bTrackBar_Scroll(object sender, EventArgs e)
        {
            rgbColor.B = bTrackBar.Value / 1000.0;
            network.GetNetworkResult(new double[] { rgbColor.R, rgbColor.G, rgbColor.B });
            UpdateBox();
            UpdateTable();
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            network.Teach((int)trueColorCombo.SelectedValue);
            UpdateTable();
        }

        private void autotrainBtn_Click(object sender, EventArgs e)
        {
            network.Teach();
            UpdateTable();
        }
    }
}
