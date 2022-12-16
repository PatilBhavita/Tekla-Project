using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
//using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Geometry3d;
using System.Net;

namespace AssemblyBeam
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
            if (myModel.GetConnectionStatus())
            {                
                Beam myBeam = new Beam(new Point(6000, 0, 0), new Point(6000, 6000, 0));                
                myBeam.Material.MaterialString = "Steel_Undefined";
                myBeam.Profile.ProfileString = "RHS400*300*6";
                myBeam.Class = "3";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                
                myBeam.Insert();               
                myModel.CommitChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContourPoint point = new ContourPoint(new Point(0, 6000, 0), null);
            ContourPoint point2 = new ContourPoint(new Point(0, 12000, 0), null);
            ContourPoint point3 = new ContourPoint(new Point(6000, 12000, 0), null);

            PolyBeam PolyBeam = new PolyBeam();

            PolyBeam.AddContourPoint(point);
            PolyBeam.AddContourPoint(point2);
            PolyBeam.AddContourPoint(point3);


            PolyBeam.Profile.ProfileString = "RHS400*300*6";
            PolyBeam.Finish = "PAINT";
            PolyBeam.Position.Depth = Position.DepthEnum.MIDDLE;
            PolyBeam.Class = "2";
            PolyBeam.Insert();
            myModel.CommitChanges();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myModel.GetConnectionStatus())
            {
                Beam myBeam = new Beam(new Point(12000, 0, 0), new Point(12000, 0, 12000));
                myBeam.Material.MaterialString = "Steel_Undefined";
                myBeam.Profile.ProfileString = "RHS400*300*6";
                myBeam.Class = "3";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;

                myBeam.Insert();
                myBeam.Modify();
                myModel.CommitChanges();
            }
        }
    }
}

