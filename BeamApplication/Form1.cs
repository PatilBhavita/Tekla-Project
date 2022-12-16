using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace BeamApplication
{
    public partial class Form1 : Form
    {
        Model myModel=new Model();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            if (model.GetConnectionStatus())
            {
                double len = double.Parse(textBox1.Text);

                double r =len/(Math.PI/2);

                PolyBeam polyBeam = new PolyBeam();
                ContourPoint startPoint = new ContourPoint(new Point(r, 0, 0), null);

                double x = r * Math.Cos(45);
                double y = r * Math.Sin(45);

                ContourPoint midPoint = new ContourPoint(new Point(x, y, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
                ContourPoint endPoint = new ContourPoint(new Point(0, r, 0), null);

                polyBeam.AddContourPoint(startPoint);
                polyBeam.AddContourPoint(midPoint);
                polyBeam.AddContourPoint(endPoint);

                //polyBeam.Profile.ProfileString = "UB360*51";
                polyBeam.Material.MaterialString = "Steel_Undefined";
                polyBeam.Profile.ProfileString = "RHS400*300*6";
                polyBeam.Insert();
            }

            model.CommitChanges();



            /*if (myModel.GetConnectionStatus())
            {
               // CurvedBeam cb = new CurvedBeam();
                Beam myBeam = new Beam(new Point(6000, 0, 0), new Point(6000, 6000, 0));
                myBeam.Material.MaterialString = "Steel_Undefined";
                myBeam.Profile.ProfileString = "RHS400*300*6";
                myBeam.Class = "3";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;



                myBeam.Insert();
                myModel.CommitChanges();
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
