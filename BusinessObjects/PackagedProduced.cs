using System;
using System.Collections.Generic;

namespace TP.DMS.TestAPI.BusinessObjects
{
    public partial class PackagedProduced
    {
        public int LineId { get; set; }
        public Guid LineGuid { get; set; }
        public string? LineName { get; set; }
        public DateTime DateProduction { get; set; }
        public TimeSpan ProductionTime { get; set; }
        public TimeSpan StopTime { get; set; }
        public TimeSpan OtherStopTime { get; set; }
        public TimeSpan OutsideProductionTime { get; set; }
        public int PackagesOut { get; set; }
    }
}
