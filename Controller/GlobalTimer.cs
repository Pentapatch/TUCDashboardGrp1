﻿namespace TUCDashboardGrp1.Controller
{
    public class GlobalTimer
    {
        // Fields

        private readonly System.Windows.Forms.Timer timer = new()
        {
            Interval = 1000,
            Enabled = true
        };

        private int secondTick;
        private int minuteTick = 0;

        // Properties

        public static GlobalTimer? Instance { get; private set; } = null;

        // Constructor

        public GlobalTimer()
        {
            timer.Tick += Timer_Tick;
            secondTick = DateTime.Now.Second;
        }

        // Events
        
        public event EventHandler? Tick10Seconds;
        public event EventHandler? Tick30Seconds;
        public event EventHandler? Tick60Seconds;
        public event EventHandler? Tick15Minutes;
        public event EventHandler? Tick60Minutes;
        public event EventHandler? RefreshWidget;

        // Event invokers
        protected virtual void OnTick10Seconds() => Tick10Seconds?.Invoke(this, EventArgs.Empty);
        protected virtual void OnTick30Seconds() => Tick30Seconds?.Invoke(this, EventArgs.Empty);
        protected virtual void OnTick60Seconds() => Tick60Seconds?.Invoke(this, EventArgs.Empty);
        protected virtual void OnTick15Minutes() => Tick15Minutes?.Invoke(this, EventArgs.Empty);
        protected virtual void OnTick60Minutes() => Tick60Minutes?.Invoke(this, EventArgs.Empty);
        protected virtual void OnRefreshWidget() => RefreshWidget?.Invoke(this, EventArgs.Empty);

        // Public methods

        public void Refresh() => OnRefreshWidget();

        private void Timer_Tick(object? sender, EventArgs e)
        {

            // Increment and wrap the tick counter around
            if (++secondTick > 60)
            {
                minuteTick++;
                secondTick = 0;
                OnTick60Seconds();
            }

            // Raise event every even 10 seconds
            if (secondTick % 10 == 0)
                OnTick10Seconds();

            // Raise event every even 30 seconds
            if (secondTick % 30 == 0)
                OnTick30Seconds();

            // Raise event every even 15 minutes
            if (minuteTick % 15 == 0)
                OnTick15Minutes();

            // Raise event every even hour and
            // wrap the minute ticker
            if (minuteTick > 60)
            {
                minuteTick = 0;
                OnTick60Minutes();
            }

        }

        public static void Initialize() => Instance = new();

    }

}
