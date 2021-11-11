using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBForm
{
    public partial class MainForm : Form
    {
        public Color FirstColor { get; set; }
        public Color SecondColor { get; set; }
        public bool isSelectFirstColor { get; set; }
        public bool isSelectSecondColor { get; set; }
        public byte R_first { get; set; }
        public byte G_first { get; set; }
        public byte B_first { get; set; }
        public byte R_second { get; set; }
        public byte G_second { get; set; }
        public byte B_second { get; set; }
        public int ExportWidth;
        public int ExportHeight;
        public MainForm()
        {
            InitializeComponent();

            if(!isSelectFirstColor)
            {
                First_RLabel.Enabled = false;
                First_GLabel.Enabled = false;
                First_BLabel.Enabled = false;

                First_RScrollBar.Enabled = false;
                First_GScrollBar.Enabled = false;
                First_BScrollBar.Enabled = false;
            }

            if (!isSelectSecondColor)
            {
                Second_RLabel.Enabled = false;
                Second_GLabel.Enabled = false;
                Second_BLabel.Enabled = false;

                Second_RScrollBar.Enabled = false;
                Second_GScrollBar.Enabled = false;
                Second_BScrollBar.Enabled = false;
            }

            First_RLabel.Text = First_RScrollBar.Value.ToString();
            First_GLabel.Text = First_GScrollBar.Value.ToString();
            First_BLabel.Text = First_BScrollBar.Value.ToString();

            Second_RLabel.Text = Second_RScrollBar.Value.ToString();
            Second_GLabel.Text = Second_GScrollBar.Value.ToString();
            Second_BLabel.Text = Second_BScrollBar.Value.ToString();

            FirstColor = Color.FromArgb(255, 0, 0, 0);
            SecondColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void First_SelectColorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                isSelectFirstColor = true;

                First_RLabel.Enabled = true;
                First_GLabel.Enabled = true;
                First_BLabel.Enabled = true;

                First_RScrollBar.Enabled = true;
                First_GScrollBar.Enabled = true;
                First_BScrollBar.Enabled = true;

                FirstColor = colorDialog1.Color;
                R_first = FirstColor.R;
                G_first = FirstColor.G;
                B_first = FirstColor.B;
                First_RScrollBar.Value = FirstColor.R;
                First_GScrollBar.Value = FirstColor.G;
                First_BScrollBar.Value = FirstColor.B;
                AssembleColor();
            }
        }

        private void Second_SelectColorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                isSelectSecondColor = true;

                Second_RLabel.Enabled = true;
                Second_GLabel.Enabled = true;
                Second_BLabel.Enabled = true;

                Second_RScrollBar.Enabled = true;
                Second_GScrollBar.Enabled = true;
                Second_BScrollBar.Enabled = true;

                SecondColor = colorDialog2.Color;
                R_second = SecondColor.R;
                G_second = SecondColor.G;
                B_second = SecondColor.B;
                Second_RScrollBar.Value = SecondColor.R;
                Second_GScrollBar.Value = SecondColor.G;
                Second_BScrollBar.Value = SecondColor.B;
                AssembleColor();
            }
        }

        /// <summary>
        /// Заливает градиентом прямоугольник по размеру панели
        /// </summary>
        public  void GetGradients()
        {

            Rectangle rectangle = new Rectangle
            {
                Width = TopPanel.Width,
                Height = TopPanel.Height
            };

            if (rectangle.Width > 0 && rectangle.Height > 0)
            {
                LinearGradientBrush linGrBrush = new LinearGradientBrush(
                    rectangle,
                    FirstColor,
                    SecondColor,
                    LinearGradientMode.ForwardDiagonal);

                FirstColorPanel.BackColor = FirstColor;
                SecondColorPanel.BackColor = SecondColor;

                using (var graphics = TopPanel.CreateGraphics())
                {
                    graphics.FillRectangle(linGrBrush, 0, 0, TopPanel.Width, TopPanel.Height);
                };
            }
        }


        /// <summary>
        /// Собирает цвет из компонентов R G B
        /// </summary>
        public void AssembleColor()
        {
            FirstColor = Color.FromArgb(255, R_first, G_first, B_first);
            First_RLabel.Text = First_RScrollBar.Value.ToString();
            First_GLabel.Text = First_GScrollBar.Value.ToString();
            First_BLabel.Text = First_BScrollBar.Value.ToString();

            SecondColor = Color.FromArgb(255, R_second, G_second, B_second);
            Second_RLabel.Text = Second_RScrollBar.Value.ToString();
            Second_GLabel.Text = Second_GScrollBar.Value.ToString();
            Second_BLabel.Text = Second_BScrollBar.Value.ToString();


            GetGradients();
        }

        private void First_RScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            R_first = (byte)First_RScrollBar.Value;
            AssembleColor();
        }

        private void First_GScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            G_first = (byte)First_GScrollBar.Value;
            AssembleColor();
        }

        private void First_BScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            B_first = (byte)First_BScrollBar.Value;
            AssembleColor();
        }

        private void Second_RScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            R_second = (byte)Second_RScrollBar.Value;
            AssembleColor();
        }

        private void Second_GScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            G_second = (byte)Second_GScrollBar.Value;
            AssembleColor();
        }

        private void Second_BScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            B_second = (byte)Second_BScrollBar.Value;
            AssembleColor();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Предотвращаем падение приложения при сворачивании
            // т.к. при сворачивании формы rectangle становится {X=0, Y=0, Width=0, Height=0}
            if (WindowState != FormWindowState.Minimized)
                GetGradients();
        }

        private void TopPanel_DoubleClick(object sender, EventArgs e)
        {
            SelectScale selectScale = new SelectScale();
            selectScale.ShowDialog();
            int[] resolution = selectScale.ResolutionValue;

            Rectangle rectangle = new Rectangle
            {
                Width = resolution[0],
                Height = resolution[1]
            };

            if (rectangle.Width > 0 && rectangle.Height > 0)
            {
                LinearGradientBrush linGrBrush = new LinearGradientBrush(
                    rectangle,
                    FirstColor,
                    SecondColor,
                    LinearGradientMode.ForwardDiagonal);

                using (var bmp = new Bitmap(resolution[0], resolution[1]))
                using (var graphics = Graphics.FromImage(bmp))
                {
                    graphics.FillRectangle(linGrBrush, 0, 0, bmp.Width, bmp.Height);
                    var path = System.IO.Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                        "export.png");
                    bmp.Save(path);
                }
            }
            else
                MessageBox.Show("Не шали! Разрешение не может быть 0х0!");
        }
    }
}
