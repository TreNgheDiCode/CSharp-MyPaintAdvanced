namespace MyPaintAdvanced
{
    partial class MyPaintAdvance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbSPoint = new Label();
            lbEPoint = new Label();
            mainPanel = new Panel();
            gbPen = new GroupBox();
            btnPenColor = new Button();
            lbPenColor = new Label();
            lbPenWidth = new Label();
            inpPenWidth = new NumericUpDown();
            lbBrushColor = new Label();
            gbBrush = new GroupBox();
            rbPatternFill = new RadioButton();
            rbColorFill = new RadioButton();
            rbNoFill = new RadioButton();
            btnBrushColor = new Button();
            gbShape = new GroupBox();
            rbTriangle = new RadioButton();
            rbCircle = new RadioButton();
            rbRectangle = new RadioButton();
            cdPenColor = new ColorDialog();
            cdBrushColor = new ColorDialog();
            lbInstanceShape = new Label();
            lbFactoryInstance = new Label();
            gbPrevShape = new GroupBox();
            clonePanel = new Panel();
            gbMode = new GroupBox();
            dbDefault = new RadioButton();
            rbClone = new RadioButton();
            gbPen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpPenWidth).BeginInit();
            gbBrush.SuspendLayout();
            gbShape.SuspendLayout();
            gbPrevShape.SuspendLayout();
            gbMode.SuspendLayout();
            SuspendLayout();
            // 
            // lbSPoint
            // 
            lbSPoint.AutoSize = true;
            lbSPoint.Location = new Point(12, 9);
            lbSPoint.Name = "lbSPoint";
            lbSPoint.Size = new Size(53, 20);
            lbSPoint.TabIndex = 0;
            lbSPoint.Text = "SPoint:";
            // 
            // lbEPoint
            // 
            lbEPoint.AutoSize = true;
            lbEPoint.Location = new Point(127, 9);
            lbEPoint.Name = "lbEPoint";
            lbEPoint.Size = new Size(53, 20);
            lbEPoint.TabIndex = 1;
            lbEPoint.Text = "EPoint:";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(12, 32);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(593, 630);
            mainPanel.TabIndex = 2;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            mainPanel.MouseUp += mainPanel_MouseUp;
            // 
            // gbPen
            // 
            gbPen.Controls.Add(btnPenColor);
            gbPen.Controls.Add(lbPenColor);
            gbPen.Controls.Add(lbPenWidth);
            gbPen.Controls.Add(inpPenWidth);
            gbPen.Location = new Point(611, 86);
            gbPen.Name = "gbPen";
            gbPen.Size = new Size(272, 106);
            gbPen.TabIndex = 3;
            gbPen.TabStop = false;
            gbPen.Text = "Pen";
            // 
            // btnPenColor
            // 
            btnPenColor.BackColor = Color.White;
            btnPenColor.Location = new Point(75, 63);
            btnPenColor.Name = "btnPenColor";
            btnPenColor.Size = new Size(94, 29);
            btnPenColor.TabIndex = 6;
            btnPenColor.Text = "Pick color";
            btnPenColor.UseVisualStyleBackColor = false;
            btnPenColor.Click += btnPenColor_Click;
            // 
            // lbPenColor
            // 
            lbPenColor.AutoSize = true;
            lbPenColor.Location = new Point(24, 67);
            lbPenColor.Name = "lbPenColor";
            lbPenColor.Size = new Size(45, 20);
            lbPenColor.TabIndex = 5;
            lbPenColor.Text = "Color";
            // 
            // lbPenWidth
            // 
            lbPenWidth.AutoSize = true;
            lbPenWidth.Location = new Point(24, 29);
            lbPenWidth.Name = "lbPenWidth";
            lbPenWidth.Size = new Size(49, 20);
            lbPenWidth.TabIndex = 1;
            lbPenWidth.Text = "Width";
            // 
            // inpPenWidth
            // 
            inpPenWidth.Location = new Point(80, 26);
            inpPenWidth.Name = "inpPenWidth";
            inpPenWidth.Size = new Size(91, 27);
            inpPenWidth.TabIndex = 0;
            inpPenWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inpPenWidth.ValueChanged += inpPenWidth_ValueChanged;
            // 
            // lbBrushColor
            // 
            lbBrushColor.AutoSize = true;
            lbBrushColor.Location = new Point(24, 119);
            lbBrushColor.Name = "lbBrushColor";
            lbBrushColor.Size = new Size(45, 20);
            lbBrushColor.TabIndex = 4;
            lbBrushColor.Text = "Color";
            // 
            // gbBrush
            // 
            gbBrush.Controls.Add(rbPatternFill);
            gbBrush.Controls.Add(rbColorFill);
            gbBrush.Controls.Add(rbNoFill);
            gbBrush.Controls.Add(btnBrushColor);
            gbBrush.Controls.Add(lbBrushColor);
            gbBrush.Location = new Point(611, 198);
            gbBrush.Name = "gbBrush";
            gbBrush.Size = new Size(272, 150);
            gbBrush.TabIndex = 4;
            gbBrush.TabStop = false;
            gbBrush.Text = "Brush";
            // 
            // rbPatternFill
            // 
            rbPatternFill.AutoSize = true;
            rbPatternFill.Location = new Point(24, 86);
            rbPatternFill.Name = "rbPatternFill";
            rbPatternFill.Size = new Size(99, 24);
            rbPatternFill.TabIndex = 10;
            rbPatternFill.Text = "Pattern Fill";
            rbPatternFill.UseVisualStyleBackColor = true;
            // 
            // rbColorFill
            // 
            rbColorFill.AutoSize = true;
            rbColorFill.Location = new Point(24, 56);
            rbColorFill.Name = "rbColorFill";
            rbColorFill.Size = new Size(89, 24);
            rbColorFill.TabIndex = 9;
            rbColorFill.Text = "Color Fill";
            rbColorFill.UseVisualStyleBackColor = true;
            // 
            // rbNoFill
            // 
            rbNoFill.AutoSize = true;
            rbNoFill.Checked = true;
            rbNoFill.Location = new Point(24, 26);
            rbNoFill.Name = "rbNoFill";
            rbNoFill.Size = new Size(73, 24);
            rbNoFill.TabIndex = 8;
            rbNoFill.TabStop = true;
            rbNoFill.Text = "No Fill";
            rbNoFill.UseVisualStyleBackColor = true;
            // 
            // btnBrushColor
            // 
            btnBrushColor.BackColor = Color.White;
            btnBrushColor.Location = new Point(75, 115);
            btnBrushColor.Name = "btnBrushColor";
            btnBrushColor.Size = new Size(94, 29);
            btnBrushColor.TabIndex = 7;
            btnBrushColor.Text = "Pick color";
            btnBrushColor.UseVisualStyleBackColor = false;
            btnBrushColor.Click += btnBrushColor_Click;
            // 
            // gbShape
            // 
            gbShape.Controls.Add(rbTriangle);
            gbShape.Controls.Add(rbCircle);
            gbShape.Controls.Add(rbRectangle);
            gbShape.Location = new Point(611, 354);
            gbShape.Name = "gbShape";
            gbShape.Size = new Size(272, 118);
            gbShape.TabIndex = 5;
            gbShape.TabStop = false;
            gbShape.Text = "Shape";
            // 
            // rbTriangle
            // 
            rbTriangle.AutoSize = true;
            rbTriangle.Location = new Point(24, 86);
            rbTriangle.Name = "rbTriangle";
            rbTriangle.Size = new Size(83, 24);
            rbTriangle.TabIndex = 13;
            rbTriangle.Text = "Triangle";
            rbTriangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            rbCircle.AutoSize = true;
            rbCircle.Location = new Point(24, 56);
            rbCircle.Name = "rbCircle";
            rbCircle.Size = new Size(67, 24);
            rbCircle.TabIndex = 12;
            rbCircle.Text = "Circle";
            rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            rbRectangle.AutoSize = true;
            rbRectangle.Checked = true;
            rbRectangle.Location = new Point(24, 26);
            rbRectangle.Name = "rbRectangle";
            rbRectangle.Size = new Size(96, 24);
            rbRectangle.TabIndex = 11;
            rbRectangle.TabStop = true;
            rbRectangle.Text = "Rectangle";
            rbRectangle.UseVisualStyleBackColor = true;
            // 
            // lbInstanceShape
            // 
            lbInstanceShape.AutoSize = true;
            lbInstanceShape.Location = new Point(251, 9);
            lbInstanceShape.Name = "lbInstanceShape";
            lbInstanceShape.Size = new Size(126, 20);
            lbInstanceShape.TabIndex = 13;
            lbInstanceShape.Text = "Shape's Instances:";
            // 
            // lbFactoryInstance
            // 
            lbFactoryInstance.AutoSize = true;
            lbFactoryInstance.Location = new Point(396, 9);
            lbFactoryInstance.Name = "lbFactoryInstance";
            lbFactoryInstance.Size = new Size(132, 20);
            lbFactoryInstance.TabIndex = 14;
            lbFactoryInstance.Text = "Factory's Instances:";
            // 
            // gbPrevShape
            // 
            gbPrevShape.Controls.Add(clonePanel);
            gbPrevShape.Location = new Point(611, 478);
            gbPrevShape.Name = "gbPrevShape";
            gbPrevShape.Size = new Size(272, 184);
            gbPrevShape.TabIndex = 14;
            gbPrevShape.TabStop = false;
            gbPrevShape.Text = "Previous Shape";
            // 
            // clonePanel
            // 
            clonePanel.BackColor = Color.White;
            clonePanel.Location = new Point(6, 26);
            clonePanel.Name = "clonePanel";
            clonePanel.Size = new Size(260, 152);
            clonePanel.TabIndex = 14;
            // 
            // gbMode
            // 
            gbMode.Controls.Add(rbClone);
            gbMode.Controls.Add(dbDefault);
            gbMode.Location = new Point(611, 32);
            gbMode.Name = "gbMode";
            gbMode.Size = new Size(272, 48);
            gbMode.TabIndex = 14;
            gbMode.TabStop = false;
            gbMode.Text = "Mode";
            // 
            // dbDefault
            // 
            dbDefault.AutoSize = true;
            dbDefault.Checked = true;
            dbDefault.Location = new Point(75, 18);
            dbDefault.Name = "dbDefault";
            dbDefault.Size = new Size(79, 24);
            dbDefault.TabIndex = 11;
            dbDefault.Text = "Default";
            dbDefault.UseVisualStyleBackColor = true;
            // 
            // rbClone
            // 
            rbClone.AutoSize = true;
            rbClone.Location = new Point(160, 18);
            rbClone.Name = "rbClone";
            rbClone.Size = new Size(68, 24);
            rbClone.TabIndex = 12;
            rbClone.Text = "Clone";
            rbClone.UseVisualStyleBackColor = true;
            // 
            // MyPaintAdvance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 674);
            Controls.Add(gbMode);
            Controls.Add(gbPrevShape);
            Controls.Add(lbFactoryInstance);
            Controls.Add(lbInstanceShape);
            Controls.Add(gbShape);
            Controls.Add(gbBrush);
            Controls.Add(gbPen);
            Controls.Add(mainPanel);
            Controls.Add(lbEPoint);
            Controls.Add(lbSPoint);
            Name = "MyPaintAdvance";
            Text = "MyPaintAdvance";
            gbPen.ResumeLayout(false);
            gbPen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inpPenWidth).EndInit();
            gbBrush.ResumeLayout(false);
            gbBrush.PerformLayout();
            gbShape.ResumeLayout(false);
            gbShape.PerformLayout();
            gbPrevShape.ResumeLayout(false);
            gbMode.ResumeLayout(false);
            gbMode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSPoint;
        private Label lbEPoint;
        private Panel mainPanel;
        private GroupBox gbPen;
        private NumericUpDown inpPenWidth;
        private Button btnPenColor;
        private Label lbPenColor;
        private Label lbPenWidth;
        private Label lbBrushColor;
        private GroupBox gbBrush;
        protected RadioButton rbNoFill;
        private Button btnBrushColor;
        protected RadioButton rbPatternFill;
        protected RadioButton rbColorFill;
        private GroupBox gbShape;
        protected RadioButton rbCircle;
        protected RadioButton rbRectangle;
        private ColorDialog cdPenColor;
        private ColorDialog cdBrushColor;
        private Label lbInstanceShape;
        private Label lbFactoryInstance;
        protected RadioButton rbTriangle;
        private GroupBox gbPrevShape;
        private Panel clonePanel;
        private GroupBox gbMode;
        protected RadioButton dbDefault;
        protected RadioButton rbClone;
    }
}