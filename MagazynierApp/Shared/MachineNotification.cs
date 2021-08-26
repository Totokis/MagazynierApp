using System;

namespace MagazynierApp.Shared
{
    public class MachineNotification
    {
        public string MachineName { get; set; }

        public string ProductName { get; set; }

        public int ValueNow { get; set; }
        
        public int MaxValue { get; set; }

        public string DistributionPoint { get; set; }

        public DateTime AlertTime { get; set; }

        public string Message { get; set; }
    }
}
