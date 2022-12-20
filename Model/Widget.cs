using System.Drawing;

namespace TUCDashboardGrp1.Model
{
    public class Widget : UserControl
    {

        // ############
        // ## FIELDS ##
        // ############

        #region Fields

        private bool isShown = false;
        private int borderRadius = 50;
        private Color borderColor = Color.FromArgb(84, 84, 84);
        private int borderWidth = 2;
        private Color backgroundColor = Color.FromArgb(48, 48, 48);
        private bool isHighlighted;

        #endregion

        // ################
        // ## PROPERTIES ##
        // ################

        #region Properties

        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                if (isShown)
                {
                    UpdateColors();
                    Invalidate();
                }
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                if (isShown) Invalidate();
            }
        }

        public bool IsHighlighted
        {
            get => isHighlighted;
            set
            {
                if (isHighlighted == value) return;

                isHighlighted = value;
                if (isShown) Invalidate();
            }
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                if (isShown) Invalidate();
            }
        }

        public int BorderWidth
        {
            get => borderWidth;
            set
            {
                borderWidth = value;
                if (isShown) Invalidate();
            }
        }

        #endregion

        // ##################
        // ## CONSTRUCTORS ##
        // ##################

        #region Constructors

        public Widget()
        {
            Paint += Widget_Paint;
            Load += Widget_Load;
            Resize += Widget_Resize;
            DoubleBuffered = true;
        }

        #endregion

        // #####################
        // ## PRIVATE METHODS ##
        // #####################

        #region Private methods

        private void Widget_Resize(object? sender, EventArgs e)
        {
            // Redraw the widget when it's size has changed
            Invalidate();
        }

        private void Widget_Load(object? sender, EventArgs e)
        {
            // UpdateSlide the BackColor property for all controls that this widget contains
            UpdateColors();
        }

        private void Widget_Paint(object? sender, PaintEventArgs e)
        {
            // Set up the graphics object for high quality drawing
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            // Draw the body of the widget
            DrawBody(e);

            // Set the flag that indicates that the widget has been drawn
            // This is useful so we can invalidate the widget each time a setting is changed at runtime
            isShown = true;
        }

        private void DrawBody(PaintEventArgs e)
        {
            // Initialize pens and brushes
            Color tucRed = Color.FromArgb(226, 35, 26);
            Pen pen = new(IsHighlighted ? tucRed : BorderColor, BorderWidth);
            SolidBrush brush = new(BackgroundColor);
            SolidBrush borderBrush = IsHighlighted ? new(tucRed) : new(BorderColor);

            // Calculate offset
            int offset = BorderWidth / 2;
            int size = BorderRadius - offset * 2;

            // Clear the graphics with the color of the BackColor property
            e.Graphics.Clear(BackColor);

            // Fill circles in the corners
            e.Graphics.FillEllipse(brush, 0, 0, BorderRadius, BorderRadius);
            e.Graphics.FillEllipse(brush, Width - BorderRadius, 0, BorderRadius, BorderRadius);
            e.Graphics.FillEllipse(brush, Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius);
            e.Graphics.FillEllipse(brush, 0, Height - BorderRadius, BorderRadius, BorderRadius);

            // Draw circles in the corners (for the border)
            if (BorderWidth > 0)
            {
                e.Graphics.DrawEllipse(pen, offset, offset, size, size);
                e.Graphics.DrawEllipse(pen, Width - size - offset, offset, size, size);
                e.Graphics.DrawEllipse(pen, Width - size - offset, Height - size - offset, size, size);
                e.Graphics.DrawEllipse(pen, offset, Height - size - offset, size, size);
            }

            // Fill in the space between the corners
            e.Graphics.FillRectangle(brush, BorderRadius / 2, 0, Width - BorderRadius, BorderRadius);
            e.Graphics.FillRectangle(brush, Width - BorderRadius, BorderRadius / 2, BorderRadius, Height - BorderRadius);
            e.Graphics.FillRectangle(brush, BorderRadius / 2, Height - BorderRadius, Width - BorderRadius, BorderRadius);
            e.Graphics.FillRectangle(brush, 0, BorderRadius / 2, BorderRadius, Height - BorderRadius);

            // Fill in the space between the corners (Border)
            if (BorderWidth > 0)
            {
                e.Graphics.FillRectangle(borderBrush, BorderRadius / 2, 0, Width - BorderRadius, BorderWidth);
                e.Graphics.FillRectangle(borderBrush, Width - BorderWidth, BorderRadius / 2, BorderWidth, Height - BorderRadius);
                e.Graphics.FillRectangle(borderBrush, BorderRadius / 2, Height - BorderWidth, Width - BorderRadius, BorderWidth);
                e.Graphics.FillRectangle(borderBrush, 0, BorderRadius / 2, BorderWidth, Height - BorderRadius);
            }

            // Fill in the remaining gap
            e.Graphics.FillRectangle(brush, BorderRadius - 1, BorderRadius - 1, Width - (BorderRadius * 2) + 2, Height - (BorderRadius * 2) + 2);

            // Dispose of the pens and brushes
            pen.Dispose();
            brush.Dispose();
            borderBrush.Dispose();
        }

        private void UpdateColors()
        {
            foreach (Control control in GetAllControls())
            {
                control.BackColor = BackgroundColor;
            }
        }

        /// <summary>Get a list that contains all of the controls added to this widget</summary>
        /// <returns>A List of Widget</returns>
        private List<Control> GetAllControls()
        {
            List<Control> result = new();

            if (Controls.Count > 0)
            {
                foreach (Control control in Controls)
                    GetAllControls(control, result);
            }

            return result;
        }
        private void GetAllControls(Control control, List<Control> result)
        {
            result.Add(control);
            if (control.Controls.Count > 0) GetAllControls(control, result);
        }

        #endregion 

    }
}