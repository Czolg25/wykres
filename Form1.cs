using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wykres
{
    public partial class Form1 : Form
    {
        struct Value{
            private double x;
            private double y;

            public Value(double x,double y)
            {
                this.x = x;
                this.y = y;
            }

            public double X()
            {
                return x;
            }
            public double Y()
            {
                return y;
            }
        }

        double xMin = 0;
        double xMax = 0;
        int xSpace = 10;
        int ySpace = 10;

        int panelX;
        int panelY;

        double scaleX;
        double scaleY;

        public Form1()
        {
            InitializeComponent();

            panelX = panel1.Size.Width-xSpace;
            panelY = panel1.Size.Height-ySpace;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (xMax == xMin) return;
            Value[] values = getValues(xMin,xMax);
            double[] rangeY = getRangeY(values);

            scaleX = ((double)panelX) / ((double)Math.Abs(xMax - xMin));

            Point[] points = GetPoints(values, xMin,xMax,rangeY[0],rangeY[1]);
            

            Graphics graphics = e.Graphics;
            

            graphics.DrawCurve(new Pen(new SolidBrush(System.Drawing.Color.Red)), points);

            if(checkBox2.Checked){
                double xRange = ((double)Math.Abs(xMax - xMin));
                double stepX = getStep(xRange);
                drawMarker(graphics, stepX, xMin, panelY, scaleX, true);
            }

            if (checkBox1.Checked)
            {
                double yRange = (double)Math.Abs(rangeY[0] - rangeY[1]);
                double stepY = getStep(yRange);
                drawMarker(graphics, stepY, rangeY[0], panelX, scaleY, false);
            }
        }

        private double getStep(double range)
        {
            double step =(int) Math.Log10(range);
            if (step == 0) step = 1;
            if (isInRange(range / step)) return step;
            if (isInRange(range / (step * 5))) return step * 5;
            if (isInRange(range / (step * 10))) return step * 10;
            if (isInRange(range / (step * 25))) return step * 25;
            if (isInRange(range / (step * 100))) return step * 100;
            if (isInRange(range / (step * 2.5))) return step * 2.5;
            if (isInRange(range / (step / 2))) return step / 2;
            if (isInRange(range / (step / 10))) return step / 10;
            if (isInRange(range / (step / 25))) return step / 25;
            if (isInRange(range / (step / 100))) return step / 100;

            return step / 4;
        }

        private bool isInRange(double number)
        {
            return number >= 4 && number <= 10;
        }


        private void drawMarker(Graphics graphics,double step,double min,int size,double scale,bool inX)
        {
            Pen pen = new Pen(new SolidBrush(Color.Black));
            var font = new Font(new FontFamily("Times New Roman"), 10, FontStyle.Regular, GraphicsUnit.Pixel);
            var solidBrush = new SolidBrush(Color.Black);

            double value = min - min % step;
            double start = Math.Abs(min -value);
            int i = (int)( start*scale) ;

            while (i <= panelX)
            {
                Point startPoint;
                Point endPoint;
                if (inX)
                {
                    graphics.DrawString(Convert.ToString(value), font, solidBrush, new PointF(i, size));
                    startPoint = new Point(i, 0); 
                    endPoint = new Point(i, size);
                }
                else
                {
                    graphics.DrawString(Convert.ToString(value), font, solidBrush, new PointF(0, panelY - i));
                    startPoint = new Point(xSpace,panelY - i); 
                    endPoint = new Point(size, panelY - i);
                }
                value += step;
                start += step;

                graphics.DrawLine(pen,startPoint,endPoint);
                i += (int)(step * scale);
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if(assing()) panel1.Refresh();
            panel2.Refresh();

            String description = tittleTextBox.Text;
            if (description != null && description != "") titleLabel.Text = description;
            String xDescription = xTextBox.Text;
            if (xDescription != null && xDescription != "") xLabel.Text = xDescription;
        }

        private bool assing()
        {
            try
            {

               
                xMin = Convert.ToDouble(xMinBox.Text);
                xMax = Convert.ToDouble(xMaxBox.Text);
            }
            catch(FormatException exeption)
            {
                return false;
            }

            if(xMin >= xMax) return false;

            return true;
        }

        private double getY(double x)
        {
            return Math.Cos(x)+0.2*x;
        }

        private Value[] getValues(double xMin,double xMax)
        {
            int numberOfValues = panelX*10;
            double step = (xMax - xMin) / numberOfValues;

            Value[] values = new Value[numberOfValues];

            for (int i = 0; i < numberOfValues; i++)
            {
                double x = xMin + i * step;
                Value value = new Value(x,getY(x));

                values[i] = value;
            }
            return values;
        }

        private double[] getRangeY(Value[] values)
        {
            double[] valuesR = new double[2];
            double minY = values[0].Y();
            double maxY = values[0].Y();

            for (int i = 0; i < values.Length; i++)
            {
                double y = values[i].Y();

                if(y< minY) minY = y;
                else if(y> maxY) maxY = y;
            }

            Console.WriteLine(minY + " " + maxY);
            valuesR[0] = minY;
            valuesR[1] = maxY;
            return valuesR;
        }

        private Point[] GetPoints(Value[] values,double xMin,double xMax,double yMin,double yMax)
        {
            Point[] points = new Point[values.Length];
            scaleY = ((double)panelY) / ((double)Math.Abs(yMax - yMin));

            for (int i = 0;i < values.Length; i++)
            {
                Value value = values[i];
                int x = (int) (Math.Abs(value.X() - xMin)*scaleX);
                int y = (int) (Math.Abs(value.Y()-yMin)*scaleY);

                y = panelY-y;

                points[i] = new Point(x, y);
            }

            return points;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            String text = yTextBox.Text;
            if (text == null || text=="") text = "Oś Y";

            setYDescription(graphics,text);
        }
        private void setYDescription(Graphics graphics,String text)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            graphics.DrawString(text, new Font("Times New Roman", 10), new SolidBrush(Color.Black),0,0,stringFormat);
        }
    }
}
