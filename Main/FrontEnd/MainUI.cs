using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSelector
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            this.Height = 450;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #region ExitApp
        private void CloseApp_Btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CloseH_Btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region MouseInputForColorChart
        private void RGBC_PB_MouseMove(object sender, MouseEventArgs e)
        {
            // Call RGB_Pixel_Data to get bitmap or pixel data of the image loaded.
            Bitmap RGBC_Pixel_Data = (Bitmap)RGBC_PB.Image;
            // Return pixel data of mouse location (X Y Coords = RGB Color)
            Color RGBC_Pixel_Color = RGBC_Pixel_Data.GetPixel(e.X, e.Y);
            // Show XY Values inside SmallScreen_Label or mini window RGB (Live RGB Color in mini window)
            SmallScreenC_Label.BackColor = RGBC_Pixel_Color;
            RGBCV_Read.Text = "R: " + RGBC_Pixel_Color.R.ToString() + " G: " + RGBC_Pixel_Color.G.ToString() + " B: " + RGBC_Pixel_Color.B.ToString();
        }

        private void RGBC_PB_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap RGB_Pixel_Data = (Bitmap)RGBC_PB.Image;
            Color RGB_Pixel_Color = RGB_Pixel_Data.GetPixel(e.X, e.Y);
            RC_TB.Text = RGB_Pixel_Color.R.ToString();
            GC_TB.Text = RGB_Pixel_Color.G.ToString();
            BC_TB.Text = RGB_Pixel_Color.B.ToString();
            SelectedScreenC_Panel.BackColor = RGB_Pixel_Color;

        }

        private void RGBH_PB_MouseMove(object sender, MouseEventArgs e)
        {
            // Call RGB_Pixel_Data to get bitmap or pixel data of the image loaded.
            Bitmap RGBH_Pixel_Data = (Bitmap)RGBH_PB.Image;
            // Return pixel data of mouse location (X Y Coords = RGB Color)
            Color RGBH_Pixel_Color = RGBH_Pixel_Data.GetPixel(e.X, e.Y);
            // Show XY Values inside SmallScreen_Label or mini window RGB (Live RGB Color in mini window)
            SmallScreenH_Label.BackColor = RGBH_Pixel_Color;
            RGBHV_Read.Text = "R: " + RGBH_Pixel_Color.R.ToString() + " G: " + RGBH_Pixel_Color.G.ToString() + " B: " + RGBH_Pixel_Color.B.ToString();
        }

        private void RGBH_PB_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap RGB_Pixel_Data = (Bitmap)RGBH_PB.Image;
            Color RGB_Pixel_Color = RGB_Pixel_Data.GetPixel(e.X, e.Y);
            RH_TB.Text = RGB_Pixel_Color.R.ToString();
            GH_TB.Text = RGB_Pixel_Color.G.ToString();
            BH_TB.Text = RGB_Pixel_Color.B.ToString();
            SelectedScreenH_Panel.BackColor = RGB_Pixel_Color;
        }
        private void MainUI_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainUI_TabControl.SelectedTab == ClassicTab)
            {
                ClassicTab.Show();
                this.Height = 450;
            }
            else if (MainUI_TabControl.SelectedTab == HexagonalTab)
            {
                HexagonalTab.Show();
                this.Height = 490;
            }
        }
        #endregion
    }
}
