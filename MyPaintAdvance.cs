using MyPaintAdvanced.Factories;
using MyPaintAdvanced.Interfaces;
using MyPaintAdvanced.Shapes;

namespace MyPaintAdvanced
{
    public partial class MyPaintAdvance : Form
    {
        private Graphics _graphic;
        private Graphics _clone;
        private Point _aPoint;
        private bool _moving;

        IShapeFactory shapeFactory;
        private IShape _shape;

        public MyPaintAdvance()
        {
            InitializeComponent();

            _graphic = mainPanel.CreateGraphics();
            _clone = clonePanel.CreateGraphics();


            _aPoint = new Point(-1, -1); // Điểm mặc định không đổi ban đầu

            _moving = false;

            DrawingPen.PenColor = cdPenColor.Color;
            DrawingPen.PenWidth = inpPenWidth.Value;
            DrawingPen.FillColor = cdBrushColor.Color;
            DrawingPen.S = _aPoint;
        }

        public IShape GetShape()
        {
            // Default shape
            if (rbNoFill.Checked)
            {
                shapeFactory = DefaultShapeFactory.Instance;
                if (rbRectangle.Checked)
                    return shapeFactory.CreateRectangle();
                if (rbCircle.Checked)
                    return shapeFactory.CreateCircle();
                if (rbTriangle.Checked)
                    return shapeFactory.CreateTriangle();
            }

            if (rbColorFill.Checked)
            {
                shapeFactory = FillShapeFactory.Instance;
                if (rbRectangle.Checked)
                    return shapeFactory.CreateRectangle();
                if (rbCircle.Checked)
                    return shapeFactory.CreateCircle();
                if (rbTriangle.Checked)
                    return shapeFactory.CreateTriangle();
            }

            if (rbPatternFill.Checked)
            {
                shapeFactory = PatternShapeFactory.Instance;
                if (rbRectangle.Checked)
                    return shapeFactory.CreateRectangle();
                if (rbCircle.Checked) 
                    return shapeFactory.CreateCircle();
                if ( rbTriangle.Checked)
                    return shapeFactory.CreateTriangle();
            }

            return shapeFactory.CreateRectangle();
        }

        private void UpdateText(MouseEventArgs e)
        {
            lbSPoint.Text = $"SPoint: ({DrawingPen.S.X}, {DrawingPen.S.Y})";
            lbEPoint.Text = $"EPoint: ({DrawingPen.E.X}, {DrawingPen.E.Y})";
            lbInstanceShape.Text = $"Shape's Instances: {DrawingControl.GetShapeCount()}";
            lbFactoryInstance.Text = $"Factory's Instances: {DefaultShapeFactory.TotalInstances + FillShapeFactory.TotalInstances + PatternShapeFactory.TotalInstances}";
        }

        public void RefreshPanel(Graphics g)
        {
            _graphic.Clear(Color.White);
            DrawingControl.Instance.DrawAll(g);
            _clone.Clear(Color.White);
        }

        /// <summary>
        /// Sau khi vẽ xong 1 hình
        /// </summary>
        /// <param name="e"></param>
        private void ResetAll(MouseEventArgs e)
        {
            DefaultShapeFactory.Instance.ResetRectangle();
            DefaultShapeFactory.Instance.ResetCircle();
            DefaultShapeFactory.Instance.ResetTriangle();

            FillShapeFactory.Instance.ResetRectangle();
            FillShapeFactory.Instance.ResetCircle();
            FillShapeFactory.Instance.ResetTriangle();

            PatternShapeFactory.Instance.ResetRectangle();
            PatternShapeFactory.Instance.ResetCircle();
            PatternShapeFactory.Instance.ResetTriangle();

            UpdateText(e);
        }

        /// <summary>
        /// Bắt đầu cố định vị trí ban đầu. <br/>
        /// Sau đó cố định loại hình sẽ vẽ. <br/>
        /// Trong quá trình vẽ, các nhà máy sẽ tự động bị loại bỏ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {

            if (rbClone.Checked)
            {
                DrawingControl.Instance.DrawClone(_graphic, e.Location);
            } else
            {
                _moving = true;
                DrawingPen.S = e.Location;

                _shape = GetShape();

                UpdateText(e);
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (DrawingPen.S == _aPoint))
            {
                return;
            }

            if (rbClone.Checked) return;

            if (_moving)
            {
                UpdateText(e);

                DrawingPen.E = e.Location;
                DrawingPen.GetPenShape(_shape);

                RefreshPanel(_graphic);

                // Draw 
                _shape.Draw(_graphic);
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (rbClone.Checked) return;

            if (_moving)
            {
                _moving = false;

                DrawingControl.Instance.AddShape(_shape);
            }
            DrawingPen.S = _aPoint;
            DrawingControl.Instance.DrawPrevShape(_clone, clonePanel.Width, clonePanel.Height);

            ResetAll(e);
        }

        private void inpPenWidth_ValueChanged(object sender, System.EventArgs e)
        {
            DrawingPen.PenWidth = inpPenWidth.Value;
        }

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            if (cdPenColor.ShowDialog() == DialogResult.OK)
            {
                DrawingPen.PenColor = cdPenColor.Color;
                lbPenColor.ForeColor = cdPenColor.Color;
            }
        }

        private void btnBrushColor_Click(object sender, EventArgs e)
        {
            if (cdBrushColor.ShowDialog() == DialogResult.OK)
            {
                DrawingPen.FillColor = cdBrushColor.Color;
                lbBrushColor.ForeColor = cdBrushColor.Color;
            }
        }
    }
}
