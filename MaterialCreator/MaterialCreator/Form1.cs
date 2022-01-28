using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MaterialCreator
{
    public partial class Form1 : Form
    {
        Bitmap preview;
        byte[] prevRgb;

        Bitmap albedo;
        byte[] albedoRgb;

        Bitmap normal;
        byte[] normalRgb;

        Bitmap final;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Update Preview Image effected by all textures map
        /// </summary>
        private void UpdatePrevImg()
        {
            BitmapData prevData = preview.LockBits(new Rectangle(0, 0, preview.Width, preview.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr prevAddres = prevData.Scan0;
            int bytes = Math.Abs(prevData.Stride) * preview.Height;
            prevRgb = new byte[bytes];
            Marshal.Copy(prevAddres, prevRgb, 0, bytes);
            int l = prevRgb.Length;
            float bright = (float)BrightNum.Value / 50.0f;
            for (int p = 0; p< l; p +=3)
            {
                if (albedo != null && normal != null)
                {
                    Color np = Color.FromArgb(255, normalRgb[p + 2], normalRgb[p + 1], normalRgb[p]);
                    float vel = np.GetSaturation();
                    float r = albedoRgb[p + 2] * vel * bright;
                    float g = albedoRgb[p + 1] * vel * bright;
                    float b = albedoRgb[p] * vel * bright;
                    prevRgb[p + 2] =(byte)r;
                    prevRgb[p + 1] = (byte)g;
                    prevRgb[p ] = (byte)b;
                }
                else if(albedo !=null)
                {
                    prevRgb[p] = (byte)(albedoRgb[p] * bright);
                    prevRgb[p + 1] = (byte)(albedoRgb[p + 1] * bright);
                    prevRgb[p + 2] = (byte)(albedoRgb[p + 2] * bright);
                }
            }
            Marshal.Copy(prevRgb, 0, prevAddres, bytes);
            preview.UnlockBits(prevData);
            final = ResizeImg();
            PrevImg.Image = final;
        }

        /// <summary>
        /// Return Rgb array from bitmap
        /// </summary>
        /// <param name="bm"></param>
        /// <returns></returns>
        private byte[] GetRgb(Bitmap bm)
        {
            BitmapData prevData = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            IntPtr prevAddres = prevData.Scan0;
            int bytes = Math.Abs(prevData.Stride) * bm.Height;
            byte[] ret = new byte[bytes];
            Marshal.Copy(prevAddres, ret, 0, bytes);
            bm.UnlockBits(prevData);
            return ret;
        }

        /// <summary>
        /// Resize preview image by fixed width and height
        /// </summary>
        /// <returns></returns>
        private Bitmap ResizeImg()
        {
            Bitmap final = new Bitmap((int)WidthNum.Value, (int)HeightNum.Value);
            Graphics g = Graphics.FromImage(final);
            g.DrawImage(preview, 0, 0, final.Width, final.Height);
            return final;
        }

        /// <summary>
        /// Load Bitmap from folder
        /// </summary>
        /// <returns></returns>
        private Bitmap LoadFromDialog()
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            d.Multiselect = false;
            DialogResult res = d.ShowDialog();
            if(res == DialogResult.OK)
                return new Bitmap(d.FileName);
            return null;
        }
        /// <summary>
        /// Set Albedo when loading image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlbedoImg_Click(object sender, EventArgs e)
        {
            albedo = LoadFromDialog();
            if (albedo != null)
            {
                AlbedoImg.Image = albedo;
                albedoRgb = GetRgb(albedo);
                preview = new Bitmap(albedo);
                UpdatePrevImg();
            }
        }

        /// <summary>
        /// Set Normal when loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NormalImg_Click(object sender, EventArgs e)
        {
            normal = LoadFromDialog();
            if (normal != null)
            {
                NormalImg.Image = normal;
                normalRgb = GetRgb(normal);
                if(albedo != null)
                   UpdatePrevImg();
            }
        }
        /// <summary>
        /// Width change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthNum_ValueChanged(object sender, EventArgs e)
        {
            if (preview != null)
                UpdatePrevImg();
        }

        /// <summary>
        /// Height change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightNum_ValueChanged(object sender, EventArgs e)
        {
            if(preview != null)
                UpdatePrevImg();
        }

        private void BrightNum_ValueChanged(object sender, EventArgs e)
        {
            if(preview != null)
                UpdatePrevImg();
        }

        private void MakeBtn_Click(object sender, EventArgs e)
        {
            if (final != null)
            {
                UpdatePrevImg();
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "Bmp(*.BMP)|*.BMP;|Jpg(*.JPG)|*.JPG|Png(*.PNG)|*.PNG|All files (*.*)|*.*";
                s.FileName = "Material";
                DialogResult res = s.ShowDialog();
                if (res == DialogResult.OK)
                    final.Save(s.FileName);
            }
            else MessageBox.Show("Cant save empty material");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
        }
    }
}
