using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Asigurari
{
    public partial class Pie : Form
    {
        public static List<Clienti> localList;
        public Pie(List<Clienti> lista)
        {
            InitializeComponent();
            localList = lista;
        }

        // Draw a pie chart.
        private static void DrawLabeledPieChart(Graphics gr,
            Rectangle rect, float initial_angle, Brush[] brushes,
            Pen[] pens, float[] values, string label_format,
            Font label_font, Brush label_brush)
        {
            // Get the total of all angles.
            float total = values.Sum();

            // Draw the slices.
            float start_angle = initial_angle;
            for (int i = 0; i < values.Length; i++)
            {
                float sweep_angle = values[i] * 360f / total;

                // Fill and outline the pie slice.
                gr.FillPie(brushes[i % brushes.Length],
                    rect, start_angle, sweep_angle);
                gr.DrawPie(pens[i % pens.Length],
                    rect, start_angle, sweep_angle);

                start_angle += sweep_angle;
            }

            // Label the slices.
            // We label the slices after drawing them all so one
            // slice doesn't cover the label on another very thin slice.
            using (StringFormat string_format = new StringFormat())
            {
                // Center text.
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;

                // Find the center of the rectangle.
                float cx = (rect.Left + rect.Right) / 2f;
                float cy = (rect.Top + rect.Bottom) / 2f;

                // Place the label about 2/3 of the way out to the edge.
                float radius = (rect.Width + rect.Height) / 2f * 0.33f;

                start_angle = initial_angle;
                for (int i = 0; i <localList.Count; i++)
                {
                    float sweep_angle = values[i] * 360f / total;

                    // Label the slice.
                    double label_angle =
                        Math.PI * (start_angle + sweep_angle / 2f) / 180f;
                    float x = cx + (float)(radius * Math.Cos(label_angle));
                    float y = cy + (float)(radius * Math.Sin(label_angle));
                    if((float)localList.ElementAt(i)!=0)
                    gr.DrawString(localList.ElementAt(i).Nume+" "+localList.ElementAt(i).Prenume,
                        label_font, label_brush, x, y, string_format);

                    start_angle += sweep_angle;
                }
            }
        }
        private Brush[] SliceBrushes =
        {
        Brushes.Red,
        Brushes.LightGreen,
        Brushes.Blue,
        Brushes.LightBlue,
        Brushes.Green,
        Brushes.Lime,
        Brushes.Orange,
        Brushes.Fuchsia,
        Brushes.Yellow,
        Brushes.Cyan,
        };

    // Pens used to outline pie slices.
    private Pen[] SlicePens = { Pens.Black };

    // The data values to chart.
    private float[] Values = new float[100];
    private void Pie_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            if ((ClientSize.Width < 20) || (ClientSize.Height < 20))
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(
                10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            DrawLabeledPieChart(e.Graphics, rect, -90, SliceBrushes,
                SlicePens, Values, "0.0", Font, Brushes.Black);
        }

        private void Pie_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < localList.Count; i++)
            {
                Values[i] = (float)localList.ElementAt(i);
            }
        }
    }
}
