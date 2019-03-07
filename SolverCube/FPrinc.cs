using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using WIA;


namespace SolverCube
{
    public partial class FPrinc : Form
    {
        int mouseX;
        int mouseY;

        #region ColorsRange

        private int redCenter, greenCenter, blueCenter, whiteCenter = 100;
        private int colorRange = 20; 



        public struct VectorRGD
        {
            public int[] coordenate;
        }

        public struct ColorRegion
        {
            public VectorRGD Initial_point;
            public VectorRGD Final_point;
        }
        public ColorRegion redRegion = new ColorRegion();
        public ColorRegion greenRegion = new ColorRegion();
        public ColorRegion blueRegion = new ColorRegion();
        public ColorRegion orangeRegion = new ColorRegion();
        public ColorRegion yellowRegion = new ColorRegion();
        public ColorRegion whiteRegion = new ColorRegion();



        #endregion

        public FPrinc()
        {
            InitializeComponent();
        }

        private void FPrinc_Load(object sender, EventArgs e)
        {
            ucWebCam1.imgWebCam.Click += new EventHandler(imgWebCam_Click);
            ucWebCam1.imgWebCam.MouseMove += new MouseEventHandler(FPrinc_MouseMove);

            DefineRegionColors();
        }

        public void DefineRegionColors()
        {
            //define red region
            redRegion.Initial_point.coordenate = new int[3] { redCenter - colorRange, 0, 0 };
            redRegion.Final_point.coordenate = new int[3] { redCenter + colorRange, colorRange*2, colorRange*2 };

            //define green region
            greenRegion.Initial_point.coordenate = new int[3] { 0, greenCenter - colorRange, 0 };
            greenRegion.Final_point.coordenate = new int[3] { colorRange, greenCenter + colorRange, colorRange*2};

            //define blue region
            blueRegion.Initial_point.coordenate = new int[3] { 0, 0, blueCenter - colorRange };
            blueRegion.Final_point.coordenate = new int[3] { colorRange*2, colorRange*2, blueCenter + colorRange };

            //define orange region
            orangeRegion.Initial_point.coordenate = new int[3] { redCenter - colorRange, (greenCenter / 2) - colorRange, 0 };
            orangeRegion.Final_point.coordenate = new int[3] { redCenter + colorRange, (greenCenter / 2) + colorRange, colorRange*2 };


            //define orange region
            yellowRegion.Initial_point.coordenate = new int[3] { redCenter - colorRange, greenCenter - colorRange, 0 };
            yellowRegion.Final_point.coordenate = new int[3] { redCenter + colorRange, greenCenter + colorRange, colorRange*2 };

            //define white region
            whiteRegion.Initial_point.coordenate = new int[3] { 255 - (colorRange * 2), 255 - (colorRange * 2), 255 - (colorRange * 2) };
            whiteRegion.Final_point.coordenate = new int[3] { 255, 255, 255 };            
        }
        

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btFechar_Click(sender, e);            
        }

        private void btInit_Click(object sender, EventArgs e)
        {
            ucWebCam1.Start();
        }

        private void btEncerrar_Click(object sender, EventArgs e)
        {
            ucWebCam1.Stop();
        }

        private void btTakePicture_Click(object sender, EventArgs e)
        {
            ucWebCam1.TakePicture();
         
        }

        
        private void imgWebCam_Click(object sender, EventArgs e)
        {
            lbx.Text = mouseX.ToString();
            lby.Text = mouseY.ToString();
            Bitmap myBitmap = (Bitmap)ucWebCam1.imgWebCam.Image;
            Color mycolor = myBitmap.GetPixel(mouseX, mouseY);
            PaintPicturebox(pictureBox1, mycolor);

            //pictureBox1.BackColor = mycolor;
            //lbred.Text = mycolor.R.ToString();
            //lbgreen.Text = mycolor.G.ToString();
            //lbblue.Text = mycolor.B.ToString();
        }

        private void FPrinc_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            lbMouseX.Text = e.X.ToString();
            lbMouseY.Text = e.Y.ToString();
        }

        public bool BelongColorRegion(ColorRegion colorRegion, VectorRGD vectorRGD)
        {
            bool resultado = false;
            if ((vectorRGD.coordenate[0] >= colorRegion.Initial_point.coordenate[0] &&
                vectorRGD.coordenate[0] <= colorRegion.Final_point.coordenate[0]) &&
                (vectorRGD.coordenate[1] >= colorRegion.Initial_point.coordenate[1] &&
                vectorRGD.coordenate[1] <= colorRegion.Final_point.coordenate[1]) &&
                (vectorRGD.coordenate[2] >= colorRegion.Initial_point.coordenate[2] &&
                vectorRGD.coordenate[2] <= colorRegion.Final_point.coordenate[2]))
            {
                resultado = true;
            }
            return resultado;
        }

        public void PaintPicturebox(PictureBox p1, Color color)
        {
            VectorRGD v1 = new VectorRGD();
            lbred.Text = color.R.ToString();
            lbgreen.Text = color.G.ToString();
            lbblue.Text = color.B.ToString();
            v1.coordenate = new int[3]{color.R, color.G, color.B};
            if (BelongColorRegion(redRegion, v1)) p1.BackColor = Color.Red;
            if (BelongColorRegion(greenRegion, v1)) p1.BackColor = Color.Green;
            if (BelongColorRegion(blueRegion, v1)) p1.BackColor = Color.Blue;
            if (BelongColorRegion(orangeRegion, v1)) p1.BackColor = Color.Orange;
            if (BelongColorRegion(yellowRegion, v1)) p1.BackColor = Color.Yellow;
            if (BelongColorRegion(whiteRegion, v1)) p1.BackColor = Color.White;
        }

        private void sensibilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            unsafe{
                FSensibility fsensibility = new FSensibility(ref &redCenter, ref &greenCenter, ref &blueCenter, ref &colorRange);
            }
        }






        
            
   
    }
}
