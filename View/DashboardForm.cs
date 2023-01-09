using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{

    public partial class DashboardForm : Form
    {

        // ############
        // ## FIELDS ##
        // ############

        #region Fields

        private readonly LoginForm login = new();
        private bool isMouseDown = false;
        private bool isDraggingWidget = false;
        private List<Widget> widgets = new();

        public const string ApplicationTitle = "TUC Dashboard";
        public const bool IsDebugging = true;

        #endregion

        // ##################
        // ## CONSTRUCTORS ##
        // ##################

        #region Constructors

        public DashboardForm()
        {

            InitializeComponent(); // Dont touch

            // Initialize the settings
            //LocalStorage ls = new();
            LocalStorage.Initialize();
            InitializeWidgetControl();
            Resize += DashboardForm_Resize;
            Shown += DashboardForm_Shown;
            GlobalTimer.Instance.RefreshWidget += Instance_RefreshWidget;
        }

        private void Instance_RefreshWidget(object? sender, EventArgs e)
        {
            BackColor = LocalStorage.Instance.Settings.BackgroundColor;
        }

        private void DashboardForm_Shown(object? sender, EventArgs e)
        {
            var test = GetControlsOfType<Widget>(sc_main);
            if (test.Count > 0) test[0].Focus();
        }

        private void DashboardForm_Resize(object? sender, EventArgs e)
        {
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            sc_main.SplitterDistance = sc_main.Height / 5;
            sc_top.SplitterDistance = sc_top.Width / 3;
            sc_top_left.SplitterDistance = sc_top_left.Width / 2;
            sc_top_right.SplitterDistance = sc_top_right.Width / 2;
            sc_bottom.SplitterDistance = sc_bottom.Width / 3;
            sc_right.SplitterDistance = sc_right.Height / 2;
        }

        #endregion

        // #####################
        // ## PRIVATE METHODS ##
        // #####################

        #region Private methods

        private void InitializeWidgetControl()
        {
            // Subscribe to target events
            foreach (Widget widget in GetControlsOfType<Widget>(sc_main))
            {
                widget.KeyDown += Widget_KeyDown;
                widget.MouseDown += Widget_MouseDown;
                widget.MouseUp += Widget_MouseUp;
                widget.MouseMove += Widget_MouseMove;
            }
        }

        private void Widget_MouseMove(object? sender, MouseEventArgs e)
        {
            // Set a flag that indicates if a target is being dragged
            isDraggingWidget = isMouseDown;

            // Check if dragging a target
            if (isDraggingWidget)
            {
                // Change the cursor to a hand
                if (Cursor != Cursors.Hand) Cursor = Cursors.Hand;

                // Try to get the target that is located below the cursor
                Widget? target = GetWidgetAtLocation(TranslateToClientCoordinates(e.Location, sender), widgets);

                // Reset all target backgrounds
                ResetWidgets();

                // Highlight the target below the cursor (if found)
                if (target is Widget widget && widget != sender)
                    widget.IsHighlighted = true;
            }
        }

        private void ResetWidgets()
        {
            foreach (Widget widget in widgets)
            {
                // Reset the IsHighlighted property
                widget.IsHighlighted = false;
            }
        }

        private void Widget_MouseUp(object? sender, MouseEventArgs e)
        {
            // Are we dragging a target?
            if (isDraggingWidget)
            {
                if (sender is Widget widget) // This check if so that we get access to the Widget members.
                                             // This method should only be called by Widgets
                {
                    // Try to find the target that is located below the mouse cursor
                    Widget? target = GetWidgetAtLocation(TranslateToClientCoordinates(e.Location, sender), widgets);

                    // If a target was found, swap places with the dragged target
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

        /// <summary>Translate from local target coordinates to client coordinates.</summary>
        /// <param name="location">The local coordinates to translate.</param>
        /// <param name="sender">The target that contains these coordinates.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private Point TranslateToClientCoordinates(Point location, object? sender)
        {
            if (sender is Widget widget)
                return this.PointToClient(widget.PointToScreen(location));

            throw new Exception("The sender must be a Widget.");
        }

        private void Widget_MouseDown(object? sender, MouseEventArgs e)
        {
            isMouseDown = true; // Set the flag that indicates that the mouse is currently down

            // Get a list of all of the widgets that are added to this form, and store it in a variable
            // (for optimization purposes)
            widgets = GetControlsOfType<Widget>(sc_main);
        }

        private void Widget_KeyDown(object? sender, KeyEventArgs e)
        {
            if (sender != null) DashboardForm_KeyDown(sender, e);
        }

        /// <summary>Get a list of all of the controls of the specified type that is contained within this form.</summary>
        /// <param name="control">The control to start the recursive search from.</param>
        /// <returns>A list of type T.</returns>
        private static List<T> GetControlsOfType<T>(Control control) => GetControlsOfType<T>(control, new());

        private static List<T> GetControlsOfType<T>(Control control, List<T> result)
        {
            // Loop through each control within the current control
            foreach (Control current in control.Controls)
            {
                // If the current control is of the target type, add it to the result
                // Otherwise recursivelly call this method to search all of the current controls children
                if (current is T target)
                    result.Add(target);
                else
                    GetControlsOfType<T>(current, result); // Do not return from this method
            }

            // Return the resulting list
            return result;
        }

        /// <summary>Swap the place of two widgets.</summary>
        /// <param name="widgetA">The first target to swap.</param>
        /// <param name="widgetB">The second target to swap.</param>
        private static void SwapWidgets(Widget widgetA, Widget widgetB)
        {
            (widgetA.Parent, widgetB.Parent) = (widgetB.Parent, widgetA.Parent);
            widgetA.Focus();
        }

        /// <summary>Return the target that is located within the specified client location, or null if none was found.</summary>
        /// <param name="location">The location (in client coordinates) to find the target.</param>
        /// <param name="widgets">Provide a list of all widgets that is contained within the form.</param>
        /// <returns></returns>
        private Widget? GetWidgetAtLocation(Point location, List<Widget> widgets)
        {
            foreach (Widget widget in widgets)
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
            if (e.KeyCode == Keys.F12)
                ShowLogin();
        }

        private void ShowLogin() => login.ShowDialog(this);

        #endregion

        private void weatherWidghet1_Load(object sender, EventArgs e)
        {
            GlobalTimer.Instance.Refresh();
            GlobalTimer.Instance.RefreshSettingsOnly();
        }

        private void feedWidget1_Load(object sender, EventArgs e)
        {

        }

        private void sc_top_left_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}