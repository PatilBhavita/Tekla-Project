using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using System.Collections;
using Tekla.Structures.Model.Operations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace CreateComponent
{
    public partial class Form1 : Form
    {
        Model myModel = new Model();
        // List<string> obj = new List<string>();
        List<string> profile = new List<string>();
        List<Part> parts = new List<Part>();
        ArrayList selectedItem = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            //this.DataBindings.Clear();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

            if (myModel.GetConnectionStatus())
            {
                Beam myBeam = new Beam(new Point(0, 0, 0), new Point(0, 3000, 0));
                myBeam.Material.MaterialString = "Steel_Undefined";
                myBeam.Profile.ProfileString = "RHS400*300*6";
                myBeam.Class = "2";
                myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam.Name = "Beam1";
                parts.Add(myBeam);
                comboBox1.Items.Add(myBeam.Name);
                profile.Add(myBeam.Profile.ProfileString);
                myBeam.Insert();
                myModel.CommitChanges();

                Beam myBeam1 = new Beam(new Point(0, 4000, 0), new Point(0, 7000, 0));
                myBeam1.Material.MaterialString = "Steel_Undefined";
                myBeam1.Profile.ProfileString = "ISMB300";
                myBeam1.Class = "3";
                myBeam1.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam1.Name = "Beam2";
                parts.Add(myBeam1);
                comboBox1.Items.Add(myBeam1.Name);
                profile.Add(myBeam1.Profile.ProfileString);
                myBeam1.Insert();
                myModel.CommitChanges();

                Beam myBeam2 = new Beam(new Point(0, 8000, 0), new Point(0, 11000, 0));
                myBeam2.Material.MaterialString = "Steel_Undefined";
                myBeam2.Profile.ProfileString = "TUBE300*6";
                myBeam2.Class = "4";
                myBeam2.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam2.Name = "Beam3";
                parts.Add(myBeam2);
                comboBox1.Items.Add(myBeam2.Name);
                profile.Add(myBeam2.Profile.ProfileString);
                myBeam2.Insert();
                myModel.CommitChanges();

                Beam myBeam3 = new Beam(new Point(0, 12000, 0), new Point(0, 15000, 0));
                myBeam3.Material.MaterialString = "Steel_Undefined";
                myBeam3.Profile.ProfileString = "SHS300*300*6";
                myBeam3.Class = "5";
                myBeam3.Position.Depth = Position.DepthEnum.MIDDLE;
                myBeam3.Name = "Beam4";
                parts.Add(myBeam3);
                comboBox1.Items.Add(myBeam3.Name);
                profile.Add(myBeam3.Profile.ProfileString);
                myBeam3.Insert();
                myModel.CommitChanges();

                Beam myBeam4 = new Beam(new Point(3000, 0, 0), new Point(3000, 0, 5000));
                myBeam4.Material.MaterialString = "Steel_Undefined";
                myBeam4.Profile.ProfileString = "WI300-15-20*300";
                myBeam4.Class = "6";
                myBeam4.Name = "Column1";
                myBeam4.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam4);
                comboBox1.Items.Add(myBeam4.Name);
                profile.Add(myBeam4.Profile.ProfileString);
                myBeam4.Insert();
                myModel.CommitChanges();

                Beam myBeam5 = new Beam(new Point(3000, 2000, 0), new Point(3000, 2000, 5000));
                myBeam5.Material.MaterialString = "Steel_Undefined";
                myBeam5.Profile.ProfileString = "CFCHS200*10";
                myBeam5.Class = "7";
                myBeam5.Name = "Column2";
                myBeam5.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam5);
                comboBox1.Items.Add(myBeam5.Name);
                profile.Add(myBeam5.Profile.ProfileString);
                myBeam5.Insert();
                myModel.CommitChanges();

                Beam myBeam6 = new Beam(new Point(3000, 4000, 0), new Point(3000, 4000, 5000));
                myBeam6.Material.MaterialString = "Steel_Undefined";
                myBeam6.Profile.ProfileString = "BLL300*300*5";
                myBeam6.Class = "8";
                myBeam6.Name = "Column3";
                myBeam6.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam6);
                comboBox1.Items.Add(myBeam6.Name);
                profile.Add(myBeam6.Profile.ProfileString);
                myBeam6.Insert();
                myModel.CommitChanges();

                Beam myBeam7 = new Beam(new Point(3000, 6000, 0), new Point(3000, 6000, 5000));
                myBeam7.Material.MaterialString = "Steel_Undefined";
                myBeam7.Profile.ProfileString = "I_HEM200*200*40*4.5*6";
                myBeam7.Class = "9";
                myBeam7.Name = "Column4";
                myBeam7.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam7);
                comboBox1.Items.Add(myBeam7.Name);
                profile.Add(myBeam7.Profile.ProfileString);
                myBeam7.Insert();
                myModel.CommitChanges();

                Beam myBeam8 = new Beam(new Point(3000, 8000, 0), new Point(3000, 8000, 5000));
                myBeam8.Material.MaterialString = "Steel_Undefined";
                myBeam8.Profile.ProfileString = "BF200*15*100*30";
                myBeam8.Class = "10";
                myBeam8.Name = "Column5";
                myBeam8.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam8);
                comboBox1.Items.Add(myBeam8.Name);
                profile.Add(myBeam8.Profile.ProfileString);
                myBeam8.Insert();
                myModel.CommitChanges();

                Beam myBeam9 = new Beam(new Point(3000, 10000, 0), new Point(3000, 10000, 5000));
                myBeam9.Material.MaterialString = "Steel_Undefined";
                myBeam9.Profile.ProfileString = "C200*5*30*100";
                myBeam9.Class = "11";
                myBeam9.Name = "Column6";
                myBeam9.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam9);
                comboBox1.Items.Add(myBeam9.Name);
                profile.Add(myBeam9.Profile.ProfileString);
                myBeam9.Insert();
                myModel.CommitChanges();

                Beam myBeam10 = new Beam(new Point(3000, 12000, 0), new Point(3000, 12000, 5000));
                myBeam10.Material.MaterialString = "Steel_Undefined";
                myBeam10.Profile.ProfileString = "T200*10*15*100";
                myBeam10.Class = "12";
                myBeam10.Name = "Column7";
                myBeam10.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam10);
                comboBox1.Items.Add(myBeam10.Name);
                profile.Add(myBeam10.Profile.ProfileString);
                myBeam10.Insert();
                myModel.CommitChanges();

                Beam myBeam11 = new Beam(new Point(3000, 14000, 0), new Point(3000, 14000, 5000));
                myBeam11.Material.MaterialString = "Steel_Undefined";
                myBeam11.Profile.ProfileString = "IRR_A490*400*300*100*100";
                myBeam11.Class = "13";
                myBeam11.Name = "Column8";
                myBeam11.Position.Depth = Position.DepthEnum.MIDDLE;
                parts.Add(myBeam11);
                comboBox1.Items.Add(myBeam11.Name);
                profile.Add(myBeam11.Profile.ProfileString);
                myBeam11.Insert();
                myModel.CommitChanges();

                ContourPlate contourPlate = new ContourPlate();
                double r;
                r = 2000 * (1.732);
                ContourPoint p1 = new ContourPoint(new Point(5000, 0, 0), null);
                ContourPoint p2 = new ContourPoint(new Point(5000 + r, 0, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
                ContourPoint p3 = new ContourPoint(new Point(5000 + (r / 2), (0.866 * r), 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
                contourPlate.AddContourPoint(p1);
                contourPlate.AddContourPoint(p2);
                contourPlate.AddContourPoint(p3);
                contourPlate.Profile.ProfileString = "PL100";
                contourPlate.Name = "Plate1";
                parts.Add(contourPlate);
                comboBox1.Items.Add(contourPlate.Name);
                profile.Add(contourPlate.Profile.ProfileString);
                contourPlate.Insert();
                myModel.CommitChanges();

                double x = 4000;
                string s = "ROD" + x;
                Point P1 = new Point(5000, 10000, 0);
                Point P2 = new Point(5000, 10000, 300);
                var beam = new Beam(P1, P2);
                beam.Profile.ProfileString = s;
                beam.Name = "Plate2";
                parts.Add(beam);
                comboBox1.Items.Add(beam.Name);
                profile.Add(beam.Profile.ProfileString);
                beam.Insert();
                myModel.CommitChanges();

                double y = (10000 / (Math.PI / 2));
                double a = y * Math.Cos(45);
                double b = y * Math.Sin(45);
                ContourPoint point3 = new ContourPoint(new Point(y, 0, 0), null);
                ContourPoint point4 = new ContourPoint(new Point(a, b, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_ARC_POINT));
                ContourPoint point5 = new ContourPoint(new Point(0, y, 0), null);
                PolyBeam PolyBeam = new PolyBeam();
                PolyBeam.AddContourPoint(point3);
                PolyBeam.AddContourPoint(point4);
                PolyBeam.AddContourPoint(point5);
                PolyBeam.Name = "CurvedBeam";
                PolyBeam.Profile.ProfileString = "SPD200*10";
                parts.Add(PolyBeam);
                comboBox1.Items.Add(PolyBeam.Name);
                profile.Add(PolyBeam.Profile.ProfileString);
                PolyBeam.Insert();
                myModel.CommitChanges();

                ContourPoint point = new ContourPoint(new Point(15000, 6000, 0), null);
                ContourPoint point2 = new ContourPoint(new Point(15000, 12000, 0), null);
                ContourPoint point6 = new ContourPoint(new Point(20000, 12000, 0), null);
                PolyBeam PolyBeam1 = new PolyBeam();
                PolyBeam1.AddContourPoint(point);
                PolyBeam1.AddContourPoint(point2);
                PolyBeam1.AddContourPoint(point6);
                PolyBeam1.Profile.ProfileString = "RHS400*300*6";
                PolyBeam1.Position.Depth = Position.DepthEnum.MIDDLE;
                PolyBeam1.Class = "5";
                parts.Add(PolyBeam1);
                comboBox1.Items.Add(PolyBeam1.Name);
                profile.Add(PolyBeam1.Profile.ProfileString);
                PolyBeam1.Insert();
                myModel.CommitChanges();

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (myModel.GetConnectionStatus())
            {
                if (comboBox1.SelectedItem == null)
                {
                    string s = textBox1.Text;
                    
                    for (int j = 0; j < parts.Count; j++)
                    {
                        if (s == parts[j].Profile.ProfileString.Substring(0, s.Length))
                        {
                            selectedItem.Add(parts[j]);
                            Tekla.Structures.Model.UI.ModelObjectSelector MS = new Tekla.Structures.Model.UI.ModelObjectSelector();
                            MS.Select(selectedItem);
                        }
                       /* else
                        {
                            if (txt == parts[j].Name)
                            {
                                selectedItem.Add(parts[j]);
                                Tekla.Structures.Model.UI.ModelObjectSelector MS = new Tekla.Structures.Model.UI.ModelObjectSelector();
                                MS.Select(selectedItem);
                            }
                        }*/

                    }
                }

                else
                {
                    string txt = comboBox1.SelectedItem.ToString();
                    for (int i = 0; i < parts.Count; i++)
                    {
                        if (parts[i].Name == txt)
                        {
                            selectedItem.Add(parts[i]);
                            Tekla.Structures.Model.UI.ModelObjectSelector MS = new Tekla.Structures.Model.UI.ModelObjectSelector();
                            MS.Select(selectedItem);
                        }
                    }
                }
                Operation.ShowOnlySelected(Operation.UnselectedModeEnum.Hidden);
                myModel.CommitChanges();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var part in parts)
            {

                part.Insert();
                myModel.CommitChanges();
            }
        }
    }
}
