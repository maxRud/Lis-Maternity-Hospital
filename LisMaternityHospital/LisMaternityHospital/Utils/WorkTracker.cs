using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Utils
{
    class WorkTracker
    {
        public DateTime StartTime { get; }
        public DateTime EndTime { set; get; } = DateTime.MinValue;

        public WorkTracker()
        {
            StartTime = DateTime.Now;
        }

        public WorkTracker(DateTime startTime)
        {
            StartTime = startTime;
        }

        public void FinishedWorking()
        {
            EndTime = DateTime.Now;
        }

        public void FinishedWorking(DateTime endTime)
        {
            EndTime = endTime;
        }


    }
}
