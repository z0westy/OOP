namespace Lab_2
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            tsBtnBrush = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsBtnLine = new ToolStripButton();
            tsMain = new ToolStrip();
            toolStripSeparator2 = new ToolStripSeparator();
            tsBtnSquare = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsBtnRectangle = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsBtnTriangle = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            tsBtnCircle = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            tsBtnEllipse = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            tsBtnClear = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            pbMain = new PictureBox();
            sfdMain = new SaveFileDialog();
            msMain = new MenuStrip();
            tsmiMenu = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            tsmiSaveAs = new ToolStripMenuItem();
            tsmiImportPlugin = new ToolStripMenuItem();
            tsmiImportFigure = new ToolStripMenuItem();
            tsmiImportFunction = new ToolStripMenuItem();
            ofdMain = new OpenFileDialog();
            lbFigures = new ListBox();
            ofdImportPlugin = new OpenFileDialog();
            imMain = new ImageList(components);
            tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // tsBtnBrush
            // 
            tsBtnBrush.CheckOnClick = true;
            tsBtnBrush.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnBrush.Image = (Image)resources.GetObject("tsBtnBrush.Image");
            tsBtnBrush.ImageTransparentColor = Color.Magenta;
            tsBtnBrush.Name = "tsBtnBrush";
            tsBtnBrush.Size = new Size(51, 52);
            tsBtnBrush.Text = "Кисть";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(51, 6);
            // 
            // tsBtnLine
            // 
            tsBtnLine.CheckOnClick = true;
            tsBtnLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnLine.Image = (Image)resources.GetObject("tsBtnLine.Image");
            tsBtnLine.ImageTransparentColor = Color.Magenta;
            tsBtnLine.Name = "tsBtnLine";
            tsBtnLine.Size = new Size(51, 52);
            tsBtnLine.Text = "Линия";
            tsBtnLine.Click += tsBtnLine_Click;
            // 
            // tsMain
            // 
            tsMain.BackColor = Color.FromArgb(224, 224, 224);
            tsMain.Dock = DockStyle.Left;
            tsMain.GripMargin = new Padding(0);
            tsMain.GripStyle = ToolStripGripStyle.Hidden;
            tsMain.ImageScalingSize = new Size(48, 48);
            tsMain.Items.AddRange(new ToolStripItem[] { tsBtnBrush, toolStripSeparator1, tsBtnLine, toolStripSeparator2, tsBtnSquare, toolStripSeparator3, tsBtnRectangle, toolStripSeparator4, tsBtnTriangle, toolStripSeparator5, tsBtnCircle, toolStripSeparator7, tsBtnEllipse, toolStripSeparator8, tsBtnClear, toolStripSeparator6 });
            tsMain.Location = new Point(0, 28);
            tsMain.Name = "tsMain";
            tsMain.Padding = new Padding(0);
            tsMain.Size = new Size(52, 625);
            tsMain.Stretch = true;
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(51, 6);
            // 
            // tsBtnSquare
            // 
            tsBtnSquare.CheckOnClick = true;
            tsBtnSquare.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnSquare.Image = (Image)resources.GetObject("tsBtnSquare.Image");
            tsBtnSquare.ImageTransparentColor = Color.Magenta;
            tsBtnSquare.Name = "tsBtnSquare";
            tsBtnSquare.Size = new Size(51, 52);
            tsBtnSquare.Text = "Квадрат";
            tsBtnSquare.Click += tsBtnSquare_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(51, 6);
            // 
            // tsBtnRectangle
            // 
            tsBtnRectangle.CheckOnClick = true;
            tsBtnRectangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnRectangle.Image = (Image)resources.GetObject("tsBtnRectangle.Image");
            tsBtnRectangle.ImageTransparentColor = Color.Magenta;
            tsBtnRectangle.Name = "tsBtnRectangle";
            tsBtnRectangle.Size = new Size(51, 52);
            tsBtnRectangle.Text = "Прямоугольник";
            tsBtnRectangle.Click += tsBtnRectangle_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(51, 6);
            // 
            // tsBtnTriangle
            // 
            tsBtnTriangle.CheckOnClick = true;
            tsBtnTriangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnTriangle.Image = (Image)resources.GetObject("tsBtnTriangle.Image");
            tsBtnTriangle.ImageTransparentColor = Color.Magenta;
            tsBtnTriangle.Name = "tsBtnTriangle";
            tsBtnTriangle.Size = new Size(51, 52);
            tsBtnTriangle.Text = "Треугольник";
            tsBtnTriangle.Click += tsBtnTriangle_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(51, 6);
            // 
            // tsBtnCircle
            // 
            tsBtnCircle.CheckOnClick = true;
            tsBtnCircle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnCircle.Image = (Image)resources.GetObject("tsBtnCircle.Image");
            tsBtnCircle.ImageTransparentColor = Color.Magenta;
            tsBtnCircle.Name = "tsBtnCircle";
            tsBtnCircle.Size = new Size(51, 52);
            tsBtnCircle.Text = "Круг";
            tsBtnCircle.Click += tsBtnCircle_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(51, 6);
            // 
            // tsBtnEllipse
            // 
            tsBtnEllipse.CheckOnClick = true;
            tsBtnEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnEllipse.Image = (Image)resources.GetObject("tsBtnEllipse.Image");
            tsBtnEllipse.ImageTransparentColor = Color.Magenta;
            tsBtnEllipse.Name = "tsBtnEllipse";
            tsBtnEllipse.Size = new Size(51, 52);
            tsBtnEllipse.Text = "Эллипс";
            tsBtnEllipse.Click += tsBtnEllipse_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(51, 6);
            // 
            // tsBtnClear
            // 
            tsBtnClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnClear.Image = (Image)resources.GetObject("tsBtnClear.Image");
            tsBtnClear.ImageTransparentColor = Color.Magenta;
            tsBtnClear.Name = "tsBtnClear";
            tsBtnClear.Size = new Size(51, 52);
            tsBtnClear.Text = "Очистить всё";
            tsBtnClear.Click += tsBtnClear_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(51, 6);
            // 
            // pbMain
            // 
            pbMain.BackColor = Color.White;
            pbMain.BorderStyle = BorderStyle.FixedSingle;
            pbMain.Dock = DockStyle.Fill;
            pbMain.Location = new Point(52, 28);
            pbMain.Margin = new Padding(0);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(1010, 625);
            pbMain.TabIndex = 1;
            pbMain.TabStop = false;
            pbMain.Paint += pbMain_Paint;
            pbMain.MouseDown += pbMain_MouseDown;
            pbMain.MouseMove += pbMain_MouseMove;
            pbMain.MouseUp += pbMain_MouseUp;
            // 
            // sfdMain
            // 
            sfdMain.DefaultExt = "bin";
            sfdMain.Filter = "Двоичные файлы (*.bin)|*.bin|Все файлы (*.*)|*.*";
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { tsmiMenu });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1062, 28);
            msMain.TabIndex = 2;
            msMain.Text = "menuStrip1";
            // 
            // tsmiMenu
            // 
            tsmiMenu.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpen, tsmiSaveAs, tsmiImportPlugin });
            tsmiMenu.Name = "tsmiMenu";
            tsmiMenu.Size = new Size(59, 24);
            tsmiMenu.Text = "Файл";
            // 
            // tsmiOpen
            // 
            tsmiOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new Size(257, 26);
            tsmiOpen.Text = "Открыть...";
            tsmiOpen.Click += tsmiOpen_Click;
            // 
            // tsmiSaveAs
            // 
            tsmiSaveAs.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiSaveAs.Name = "tsmiSaveAs";
            tsmiSaveAs.Size = new Size(257, 26);
            tsmiSaveAs.Text = "Сохранить как...";
            tsmiSaveAs.Click += tsmiSaveAs_Click;
            // 
            // tsmiImportPlugin
            // 
            tsmiImportPlugin.DropDownItems.AddRange(new ToolStripItem[] { tsmiImportFigure, tsmiImportFunction });
            tsmiImportPlugin.Name = "tsmiImportPlugin";
            tsmiImportPlugin.Size = new Size(257, 26);
            tsmiImportPlugin.Text = "Импортировать плагин";
            // 
            // tsmiImportFigure
            // 
            tsmiImportFigure.Name = "tsmiImportFigure";
            tsmiImportFigure.Size = new Size(219, 26);
            tsmiImportFigure.Text = "с новой фигурой";
            tsmiImportFigure.Click += tsmiImportFigure_Click;
            // 
            // tsmiImportFunction
            // 
            tsmiImportFunction.Name = "tsmiImportFunction";
            tsmiImportFunction.Size = new Size(219, 26);
            tsmiImportFunction.Text = "с новой функцией";
            tsmiImportFunction.Click += tsmiImportFunction_Click;
            // 
            // ofdMain
            // 
            ofdMain.DefaultExt = "bin";
            // 
            // lbFigures
            // 
            lbFigures.Dock = DockStyle.Right;
            lbFigures.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFigures.FormattingEnabled = true;
            lbFigures.Location = new Point(812, 28);
            lbFigures.Name = "lbFigures";
            lbFigures.Size = new Size(250, 625);
            lbFigures.TabIndex = 3;
            lbFigures.DoubleClick += lbFigures_DoubleClick;
            lbFigures.KeyDown += lbFigures_KeyDown;
            // 
            // ofdImportPlugin
            // 
            ofdImportPlugin.DefaultExt = "dll";
            ofdImportPlugin.Filter = "Плагин (*dll)|*.dll";
            // 
            // imMain
            // 
            imMain.ColorDepth = ColorDepth.Depth32Bit;
            imMain.ImageStream = (ImageListStreamer)resources.GetObject("imMain.ImageStream");
            imMain.TransparentColor = Color.Transparent;
            imMain.Images.SetKeyName(0, "free-icon-new-891509.png");
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 653);
            Controls.Add(lbFigures);
            Controls.Add(pbMain);
            Controls.Add(tsMain);
            Controls.Add(msMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = msMain;
            Name = "fMain";
            Text = "GREBY";
            WindowState = FormWindowState.Maximized;
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripButton tsBtnBrush;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsBtnLine;
        private ToolStrip tsMain;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsBtnSquare;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsBtnRectangle;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsBtnTriangle;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton tsBtnCircle;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton tsBtnEllipse;
        private ToolStripSeparator toolStripSeparator8;
        private PictureBox pbMain;
        private ToolStripButton tsBtnClear;
        private ToolStripSeparator toolStripSeparator6;
        private SaveFileDialog sfdMain;
        private MenuStrip msMain;
        private ToolStripMenuItem tsmiMenu;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiSaveAs;
        private OpenFileDialog ofdMain;
        private ListBox lbFigures;
        private ToolStripMenuItem tsmiImportPlugin;
        private OpenFileDialog ofdImportPlugin;
        private ImageList imMain;
        private ToolStripMenuItem tsmiImportFigure;
        private ToolStripMenuItem tsmiImportFunction;
    }
}
