using TUCDashboardGrp1.Controller;

namespace TUCDashboardGrp1
{
    public partial class DashboardForm : Form
    {
        private readonly LoginForm login = new();
        private bool isMouseDown = false;
        private bool isDraggingWidget = false;

        public DashboardForm()
        {

            InitializeComponent(); // Dont touch
            ApiHelper.InitializeClient();
            InitializeWidgetControl();

         
            

        }

        private void InitializeWidgetControl()
        {
            // Subscribe to widget events
            foreach (UserControl widget in GetWidgets(splitContainer1))
            {
                widget.KeyDown += Widget_KeyDown;
                widget.MouseDown += Widget_MouseDown;
                widget.MouseUp += Widget_MouseUp;
                widget.MouseMove += Widget_MouseMove;
            }
        }

        private void Widget_MouseMove(object? sender, MouseEventArgs e)
        {
            // Set a flag that indicates if a widget is being dragged
            isDraggingWidget = isMouseDown;

            // Check if dragging a widget
            if (isDraggingWidget)
            {
                // Change the cursor to a hand
                if (Cursor != Cursors.Hand) Cursor = Cursors.Hand;

                // Try to get the widget that is located below the cursor
                UserControl? target = GetWidgetAtLocation(TranslateToClientCoordinates(e.Location, sender), GetWidgets(splitContainer1));

                // Reset all widget backgrounds
                ResetWidgets();

                // Highlight the widget below the cursor (if found)
                if (target is UserControl widget && widget != sender)
                    widget.BackColor = Color.Yellow; // For visual confirmation (debugging)
            }
        }

        private void ResetWidgets()
        {
            foreach (UserControl widget in GetWidgets(splitContainer1))
            {
                // Store the widget's original Backcolor
                widget.Tag ??= widget.BackColor;

                // Reset the backcolor
                widget.BackColor = (Color)widget.Tag;
            }
        }

        private void Widget_MouseUp(object? sender, MouseEventArgs e)
        {
            // Are we dragging a widget?
            if (isDraggingWidget)
            {
                if (sender is UserControl widget) // This check if so that we get access to the UserControl object.
                                                  // This method should only be called by UserControls
                {
                    // Try to find the widget that is located below the mouse cursor
                    UserControl? target = GetWidgetAtLocation(TranslateToClientCoordinates(e.Location, sender), GetWidgets(splitContainer1));

                    // If a widget was found, swap places with the dragged widget
                    if (target != null)
                        SwapWidgets(widget, target);
                }
            }

            // Reset
            isMouseDown = false;
            isDraggingWidget = false;
            Cursor = Cursors.Default;
            ResetWidgets();
        }

        /// <summary>Translate from local widget coordinates to client coordinates.</summary>
        /// <param name="location">The local coordinates to translate.</param>
        /// <param name="sender">The widget that contains these coordinates.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private Point TranslateToClientCoordinates(Point location, object? sender)
        {
            if (sender is UserControl widget)
                return this.PointToClient(widget.PointToScreen(location));

            throw new Exception("The sender must be a UserControl.");
        }

        private void Widget_MouseDown(object? sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void Widget_KeyDown(object? sender, KeyEventArgs e)
        {
            if (sender != null) DashboardForm_KeyDown(sender, e);
        }

        /// <summary>Get all of the widgets that is added to this form.</summary>
        /// <param name="control">The control to start the recursive search from.</param>
        /// <returns></returns>
        private static List<UserControl> GetWidgets(Control control) => GetWidgets(control, new());

        private static List<UserControl> GetWidgets(Control control, List<UserControl> result)
        {
            // Loop through each control within the current control
            foreach (Control current in control.Controls)
            {
                // If the current control is a widget, add it to the result
                // Otherwise recursivelly call this method to search all of the current controls children
                if (current is UserControl widget)
                    result.Add(widget);
                else
                    GetWidgets(current, result); // Do not return from this method
            }

            // Return the resulting list
            return result;
        }

        /// <summary>Swap the place of two widgets.</summary>
        /// <param name="widgetA">The first widget to swap.</param>
        /// <param name="widgetB">The second widget to swap.</param>
        private void SwapWidgets(UserControl widgetA, UserControl widgetB) => 
            (widgetA.Parent, widgetB.Parent) = (widgetB.Parent, widgetA.Parent);

        /// <summary>Return the widget that is located within the specified client location, or null if none was found.</summary>
        /// <param name="location">The location (in client coordinates) to find the widget.</param>
        /// <param name="widgets">Provide a list of all widgets that is contained within the form.</param>
        /// <returns></returns>
        private UserControl? GetWidgetAtLocation(Point location, List<UserControl> widgets)
        {
            foreach (UserControl widget in widgets)
            {
                Point clientLocation = TranslateToClientCoordinates(widget.Location, widget);
                if (location.X >= clientLocation.X && location.X <= clientLocation.X + widget.Width &&
                    location.Y >= clientLocation.Y && location.Y <= clientLocation.Y + widget.Height)
                {
                    return widget;
                }
            }

            return null;
        }

        private void DashboardForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Note: Now working
            if (e.KeyCode == Keys.F12)
                ShowLogin();
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void ShowLogin() => login.ShowDialog();

    
    }
}