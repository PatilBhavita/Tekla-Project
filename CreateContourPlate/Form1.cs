using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using System.Collections.Generic;

namespace CreateContourPlate
{
    public partial class Form1 : Form
    {
        Model myModel = new Model();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Contour Plate using contour class
            ContourPlate CP = new ContourPlate();
            double r = double.Parse(textBox1.Text);
            double s = r * 1.732; //side of triangle

            List<ContourPoint> Points = new List<ContourPoint>()
            {
                new ContourPoint(new Point(0, 4000, 0), null),
                new ContourPoint(new Point((0.866*s),(s/2)+4000,0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT)),
                new ContourPoint(new Point(0, s+4000, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT))
            };
            foreach(var point in Points)
            {
                CP.AddContourPoint(point);
                CP.Finish = "FOO";
                CP.Profile.ProfileString = "PL200";
                CP.Material.MaterialString = "Steel_Undefined";
               
            }
            CP.Insert();
            myModel.CommitChanges();


            /*Model teklaModel = new Model();

            if (teklaModel.GetConnectionStatus())
            {
                ContourPoint point = new ContourPoint(new Point(0, 4000, 0), null);
                ContourPoint point2 = new ContourPoint(new Point(2000, 4000, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));               
                ContourPoint point3 = new ContourPoint(new Point(2000, 6000, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
                ContourPoint point4 = new ContourPoint(new Point(0, 6000, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
                ContourPlate contourPlate = new ContourPlate();

                contourPlate.AddContourPoint(point);
                contourPlate.AddContourPoint(point2);
                contourPlate.AddContourPoint(point3);
                contourPlate.AddContourPoint(point4);

                contourPlate.Finish = "FOO";
                contourPlate.Profile.ProfileString = "PL20";
                contourPlate.Material.MaterialString = "K30-2";

                contourPlate.Insert();
            }

            teklaModel.CommitChanges();*/
  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Contour Plate using Beam
            double r = double.Parse(textBox1.Text);
            string s = "ROD" + r;
            Model model = new Model();
            Point p1 = new Point(20000, 20000, 0);
            Point p2 = new Point(20000, 20000, 300);
            var beam = new Beam(p1, p2);
            beam.Profile.ProfileString = s;
            beam.Insert();
            model.CommitChanges();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            //Contour Plate using Polybeam
            PolyBeam polybeam = new PolyBeam();
            double r = double.Parse(textBox1.Text);

            List<ContourPoint> Points = new List<ContourPoint>()
            {
                new ContourPoint(new Point(0, 4000, 0), null),
                new ContourPoint(new Point(0,8000,0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT)),
                new ContourPoint(new Point(4000, 8000, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT)),
                new ContourPoint(new Point(0, 4000, 0), null)
            };
            foreach (var point in Points)
            {
                polybeam.AddContourPoint(point);
                polybeam.Finish = "FOO";
                polybeam.Profile.ProfileString = "RHS400*300*6";
                polybeam.Material.MaterialString = "Steel_Undefined";

            }
            polybeam.Insert();
            myModel.CommitChanges();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
