using System;

namespace ScheduleTest.Models
{
    public class ErrorViewModel
    {
        //getter and setter for requestId
        public string RequestId { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
