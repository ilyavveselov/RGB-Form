namespace RGBForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.First_SelectColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.First_RScrollBar = new System.Windows.Forms.HScrollBar();
            this.First_RLabel = new System.Windows.Forms.Label();
            this.First_GScrollBar = new System.Windows.Forms.HScrollBar();
            this.First_GLabel = new System.Windows.Forms.Label();
            this.First_BScrollBar = new System.Windows.Forms.HScrollBar();
            this.First_BLabel = new System.Windows.Forms.Label();
            this.R1Label = new System.Windows.Forms.Label();
            this.G1Label = new System.Windows.Forms.Label();
            this.B1Label = new System.Windows.Forms.Label();
            this.Second_RScrollBar = new System.Windows.Forms.HScrollBar();
            this.Second_GScrollBar = new System.Windows.Forms.HScrollBar();
            this.Second_BScrollBar = new System.Windows.Forms.HScrollBar();
            this.Second_RLabel = new System.Windows.Forms.Label();
            this.Second_GLabel = new System.Windows.Forms.Label();
            this.Second_BLabel = new System.Windows.Forms.Label();
            this.R2Label = new System.Windows.Forms.Label();
            this.G2Label = new System.Windows.Forms.Label();
            this.B2Label = new System.Windows.Forms.Label();
            this.Second_SelectColorButton = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.FirstColorPanel = new System.Windows.Forms.Panel();
            this.SecondColorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.Location = new System.Drawing.Point(12, 12);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(776, 166);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.DoubleClick += new System.EventHandler(this.TopPanel_DoubleClick);
            // 
            // First_SelectColorButton
            // 
            this.First_SelectColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.First_SelectColorButton.Location = new System.Drawing.Point(22, 226);
            this.First_SelectColorButton.Name = "First_SelectColorButton";
            this.First_SelectColorButton.Size = new System.Drawing.Size(211, 23);
            this.First_SelectColorButton.TabIndex = 1;
            this.First_SelectColorButton.Text = "Выбрать цвет верхнего градиента";
            this.First_SelectColorButton.UseVisualStyleBackColor = true;
            this.First_SelectColorButton.Click += new System.EventHandler(this.First_SelectColorButton_Click);
            // 
            // First_RScrollBar
            // 
            this.First_RScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.First_RScrollBar.Location = new System.Drawing.Point(37, 181);
            this.First_RScrollBar.Maximum = 255;
            this.First_RScrollBar.Name = "First_RScrollBar";
            this.First_RScrollBar.Size = new System.Drawing.Size(180, 14);
            this.First_RScrollBar.TabIndex = 8;
            this.First_RScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.First_RScrollBar_Scroll);
            // 
            // First_RLabel
            // 
            this.First_RLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.First_RLabel.AutoSize = true;
            this.First_RLabel.Location = new System.Drawing.Point(220, 181);
            this.First_RLabel.Name = "First_RLabel";
            this.First_RLabel.Size = new System.Drawing.Size(13, 13);
            this.First_RLabel.TabIndex = 9;
            this.First_RLabel.Text = "0";
            // 
            // First_GScrollBar
            // 
            this.First_GScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.First_GScrollBar.Location = new System.Drawing.Point(37, 195);
            this.First_GScrollBar.Maximum = 255;
            this.First_GScrollBar.Name = "First_GScrollBar";
            this.First_GScrollBar.Size = new System.Drawing.Size(180, 14);
            this.First_GScrollBar.TabIndex = 10;
            this.First_GScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.First_GScrollBar_Scroll);
            // 
            // First_GLabel
            // 
            this.First_GLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.First_GLabel.AutoSize = true;
            this.First_GLabel.Location = new System.Drawing.Point(220, 196);
            this.First_GLabel.Name = "First_GLabel";
            this.First_GLabel.Size = new System.Drawing.Size(13, 13);
            this.First_GLabel.TabIndex = 11;
            this.First_GLabel.Text = "0";
            // 
            // First_BScrollBar
            // 
            this.First_BScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.First_BScrollBar.Location = new System.Drawing.Point(37, 209);
            this.First_BScrollBar.Maximum = 255;
            this.First_BScrollBar.Name = "First_BScrollBar";
            this.First_BScrollBar.Size = new System.Drawing.Size(180, 14);
            this.First_BScrollBar.TabIndex = 12;
            this.First_BScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.First_BScrollBar_Scroll);
            // 
            // First_BLabel
            // 
            this.First_BLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.First_BLabel.AutoSize = true;
            this.First_BLabel.Location = new System.Drawing.Point(220, 210);
            this.First_BLabel.Name = "First_BLabel";
            this.First_BLabel.Size = new System.Drawing.Size(13, 13);
            this.First_BLabel.TabIndex = 13;
            this.First_BLabel.Text = "0";
            // 
            // R1Label
            // 
            this.R1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.R1Label.AutoSize = true;
            this.R1Label.Location = new System.Drawing.Point(19, 181);
            this.R1Label.Name = "R1Label";
            this.R1Label.Size = new System.Drawing.Size(15, 13);
            this.R1Label.TabIndex = 14;
            this.R1Label.Text = "R";
            // 
            // G1Label
            // 
            this.G1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.G1Label.AutoSize = true;
            this.G1Label.Location = new System.Drawing.Point(19, 196);
            this.G1Label.Name = "G1Label";
            this.G1Label.Size = new System.Drawing.Size(15, 13);
            this.G1Label.TabIndex = 15;
            this.G1Label.Text = "G";
            // 
            // B1Label
            // 
            this.B1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B1Label.AutoSize = true;
            this.B1Label.Location = new System.Drawing.Point(19, 210);
            this.B1Label.Name = "B1Label";
            this.B1Label.Size = new System.Drawing.Size(14, 13);
            this.B1Label.TabIndex = 16;
            this.B1Label.Text = "B";
            // 
            // Second_RScrollBar
            // 
            this.Second_RScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Second_RScrollBar.Location = new System.Drawing.Point(582, 180);
            this.Second_RScrollBar.Maximum = 255;
            this.Second_RScrollBar.Name = "Second_RScrollBar";
            this.Second_RScrollBar.Size = new System.Drawing.Size(180, 14);
            this.Second_RScrollBar.TabIndex = 17;
            this.Second_RScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Second_RScrollBar_Scroll);
            // 
            // Second_GScrollBar
            // 
            this.Second_GScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Second_GScrollBar.Location = new System.Drawing.Point(582, 195);
            this.Second_GScrollBar.Maximum = 255;
            this.Second_GScrollBar.Name = "Second_GScrollBar";
            this.Second_GScrollBar.Size = new System.Drawing.Size(180, 14);
            this.Second_GScrollBar.TabIndex = 18;
            this.Second_GScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Second_GScrollBar_Scroll);
            // 
            // Second_BScrollBar
            // 
            this.Second_BScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Second_BScrollBar.Location = new System.Drawing.Point(582, 209);
            this.Second_BScrollBar.Maximum = 255;
            this.Second_BScrollBar.Name = "Second_BScrollBar";
            this.Second_BScrollBar.Size = new System.Drawing.Size(180, 14);
            this.Second_BScrollBar.TabIndex = 19;
            this.Second_BScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Second_BScrollBar_Scroll);
            // 
            // Second_RLabel
            // 
            this.Second_RLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Second_RLabel.AutoSize = true;
            this.Second_RLabel.Location = new System.Drawing.Point(765, 181);
            this.Second_RLabel.Name = "Second_RLabel";
            this.Second_RLabel.Size = new System.Drawing.Size(13, 13);
            this.Second_RLabel.TabIndex = 21;
            this.Second_RLabel.Text = "0";
            // 
            // Second_GLabel
            // 
            this.Second_GLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Second_GLabel.AutoSize = true;
            this.Second_GLabel.Location = new System.Drawing.Point(765, 196);
            this.Second_GLabel.Name = "Second_GLabel";
            this.Second_GLabel.Size = new System.Drawing.Size(13, 13);
            this.Second_GLabel.TabIndex = 22;
            this.Second_GLabel.Text = "0";
            // 
            // Second_BLabel
            // 
            this.Second_BLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Second_BLabel.AutoSize = true;
            this.Second_BLabel.Location = new System.Drawing.Point(765, 210);
            this.Second_BLabel.Name = "Second_BLabel";
            this.Second_BLabel.Size = new System.Drawing.Size(13, 13);
            this.Second_BLabel.TabIndex = 23;
            this.Second_BLabel.Text = "0";
            // 
            // R2Label
            // 
            this.R2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.R2Label.AutoSize = true;
            this.R2Label.Location = new System.Drawing.Point(564, 180);
            this.R2Label.Name = "R2Label";
            this.R2Label.Size = new System.Drawing.Size(15, 13);
            this.R2Label.TabIndex = 24;
            this.R2Label.Text = "R";
            // 
            // G2Label
            // 
            this.G2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G2Label.AutoSize = true;
            this.G2Label.Location = new System.Drawing.Point(564, 194);
            this.G2Label.Name = "G2Label";
            this.G2Label.Size = new System.Drawing.Size(15, 13);
            this.G2Label.TabIndex = 25;
            this.G2Label.Text = "G";
            // 
            // B2Label
            // 
            this.B2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B2Label.AutoSize = true;
            this.B2Label.Location = new System.Drawing.Point(564, 209);
            this.B2Label.Name = "B2Label";
            this.B2Label.Size = new System.Drawing.Size(14, 13);
            this.B2Label.TabIndex = 26;
            this.B2Label.Text = "B";
            // 
            // Second_SelectColorButton
            // 
            this.Second_SelectColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Second_SelectColorButton.Location = new System.Drawing.Point(567, 226);
            this.Second_SelectColorButton.Name = "Second_SelectColorButton";
            this.Second_SelectColorButton.Size = new System.Drawing.Size(211, 23);
            this.Second_SelectColorButton.TabIndex = 27;
            this.Second_SelectColorButton.Text = "Выбрать цвет нижнего градиента";
            this.Second_SelectColorButton.UseVisualStyleBackColor = true;
            this.Second_SelectColorButton.Click += new System.EventHandler(this.Second_SelectColorButton_Click);
            // 
            // FirstColorPanel
            // 
            this.FirstColorPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FirstColorPanel.Location = new System.Drawing.Point(336, 184);
            this.FirstColorPanel.Name = "FirstColorPanel";
            this.FirstColorPanel.Size = new System.Drawing.Size(61, 65);
            this.FirstColorPanel.TabIndex = 28;
            // 
            // SecondColorPanel
            // 
            this.SecondColorPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SecondColorPanel.Location = new System.Drawing.Point(403, 184);
            this.SecondColorPanel.Name = "SecondColorPanel";
            this.SecondColorPanel.Size = new System.Drawing.Size(61, 65);
            this.SecondColorPanel.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.SecondColorPanel);
            this.Controls.Add(this.FirstColorPanel);
            this.Controls.Add(this.Second_SelectColorButton);
            this.Controls.Add(this.B2Label);
            this.Controls.Add(this.G2Label);
            this.Controls.Add(this.R2Label);
            this.Controls.Add(this.Second_BLabel);
            this.Controls.Add(this.Second_GLabel);
            this.Controls.Add(this.Second_RLabel);
            this.Controls.Add(this.Second_BScrollBar);
            this.Controls.Add(this.Second_GScrollBar);
            this.Controls.Add(this.Second_RScrollBar);
            this.Controls.Add(this.B1Label);
            this.Controls.Add(this.G1Label);
            this.Controls.Add(this.R1Label);
            this.Controls.Add(this.First_BLabel);
            this.Controls.Add(this.First_BScrollBar);
            this.Controls.Add(this.First_GLabel);
            this.Controls.Add(this.First_GScrollBar);
            this.Controls.Add(this.First_RLabel);
            this.Controls.Add(this.First_RScrollBar);
            this.Controls.Add(this.First_SelectColorButton);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 200);
            this.Name = "MainForm";
            this.Text = "Flex Color v0.0.1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button First_SelectColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.HScrollBar First_RScrollBar;
        private System.Windows.Forms.Label First_RLabel;
        private System.Windows.Forms.HScrollBar First_GScrollBar;
        private System.Windows.Forms.Label First_GLabel;
        private System.Windows.Forms.HScrollBar First_BScrollBar;
        private System.Windows.Forms.Label First_BLabel;
        private System.Windows.Forms.Label R1Label;
        private System.Windows.Forms.Label G1Label;
        private System.Windows.Forms.Label B1Label;
        private System.Windows.Forms.HScrollBar Second_RScrollBar;
        private System.Windows.Forms.HScrollBar Second_GScrollBar;
        private System.Windows.Forms.HScrollBar Second_BScrollBar;
        private System.Windows.Forms.Label Second_RLabel;
        private System.Windows.Forms.Label Second_GLabel;
        private System.Windows.Forms.Label Second_BLabel;
        private System.Windows.Forms.Label R2Label;
        private System.Windows.Forms.Label G2Label;
        private System.Windows.Forms.Label B2Label;
        private System.Windows.Forms.Button Second_SelectColorButton;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel FirstColorPanel;
        private System.Windows.Forms.Panel SecondColorPanel;
    }
}

