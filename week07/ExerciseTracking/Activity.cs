using System;

public abstract class Activity
    {
        private DateTime _date;
        private int _duration;

        public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public virtual double GetDurationInMinutes()
        {
            return _duration;
        }

        public DateTime GetDate()
    {
        return _date;
    }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} ({_duration} min)";
        }
    }