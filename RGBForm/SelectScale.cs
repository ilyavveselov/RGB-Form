using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RGBForm
{
    public partial class SelectScale : Form
    {
        public string CheckedRadioButton { get; set; }
        public int InputHeight { get; set; }
        public int InputWidth { get; set; }
        int[] resolution;
        public int[] ResolutionValue
        {
            get { return resolution; }
        }

        List<int[]> res;

        public SelectScale()
        {
            InitializeComponent();

            res = new List<int[]>
            {
                new int[] { 1366, 768 },
                new int[] { 1440, 900 },
                new int[] { 1536, 864 },
                new int[] { 1600, 900 },
                new int[] { 1920, 1080 },
                new int[] { 640, 960 },
                new int[] { 640, 1136 },
                new int[] { 720, 1280 },
                new int[] { 800, 1280 },
                new int[] { 1080, 1920 },
                new int[] { 1440, 2560 },
                new int[] { 1024, 768 },
                new int[] { 2048, 1536 },
                new int[] { 2732, 2048 }
            };
        }

        private void SelectScale_Load(object sender, EventArgs e)
        {
            r0.Checked = true;

            if (!r14.Checked)
            {
                HeightTextBox.Enabled = false;
                WidthTextBox.Enabled = false;
            }

            var displayRes = SystemInformation.PrimaryMonitorSize;

            WidthTextBox.Text = displayRes.Width.ToString();
            HeightTextBox.Text = displayRes.Height.ToString();
        }
        private void r14_CheckedChanged(object sender, EventArgs e)
        {
            if (r14.Checked)
            {
                HeightTextBox.Enabled = true;
                WidthTextBox.Enabled = true;
            }
            else
            {
                HeightTextBox.Enabled = false;
                WidthTextBox.Enabled = false;
            }
        }
        public void radioButtons_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            CheckedRadioButton = radioButton.Name;

            int index = Convert.ToInt32(CheckedRadioButton.Substring(1));

            if (res != null && index != 14)
                resolution = res[index];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (r14.Checked)
            {
                try
                {
                    resolution[0] = Convert.ToInt32(WidthTextBox.Text);
                    resolution[1] = Convert.ToInt32(HeightTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Только цифры без пробелов! Результат не был сохранен!");
                }
            }
            Close();
        }
    }
}
