using System;

namespace CS_Intermediate.Intermediate_Projects.Stopwatch
{

    class Stopwatch
    {
        private bool _isRunning; //Defaults to false
        private DateTime _startTime;
        private DateTime _stopTime;

        public Stopwatch()
        {
            _isRunning = false;
        }

        public void Start() // Method for starting
        {
            if (_isRunning)
                throw new InvalidOperationException("Already running"); // Error code for starting twice

            _isRunning = true;
            _startTime = DateTime.Now; // Using Date time now to prevent having some other time be passed
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Not running");

            _isRunning = false;
            _stopTime = DateTime.Now;
        }

        public TimeSpan Difference()
        {
            return _stopTime - _startTime;
        }
    }
}