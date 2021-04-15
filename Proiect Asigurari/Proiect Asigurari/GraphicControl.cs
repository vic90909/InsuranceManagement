using Proiect_Asigurari.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Asigurari
{
    public partial class GraphicControl : Control
    {
        private Graphic[] _data;
        public Graphic[] Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public GraphicControl()
        {
            InitializeComponent();
            ResizeRedraw = true ;

            Data = new[]
            {
                new Graphic("2015",39),
                new Graphic("2016",60),
                new Graphic("2018",90)
            };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void GraphicControl_Paint(object sender, PaintEventArgs e)
        {
            //get the drawing context
            Graphics graphics = e.Graphics;
            //get the drawing area
            Rectangle clipRectangle = e.ClipRectangle;

            //determine the width of the bars
            var barWidth = clipRectangle.Width / Data.Length;
            //compute the maximum bar height
            var maxBarHeight = clipRectangle.Height * 0.9;
            //compute the scaling factor based on the maximum value that we want to represent
            var scalingFactor = maxBarHeight / Data.Max(x => x.Value);

            Brush redBrush = new SolidBrush(Color.Red);

            for (int i = 0; i < Data.Length; i++)
            {
                var barHeight = Data[i].Value * scalingFactor;

                graphics.FillRectangle(
                    redBrush,
                    i * barWidth,
                    (float)(clipRectangle.Height - barHeight),
                    (float)(0.8 * barWidth),
                    (float)barHeight);
            }
        }
    }
}
