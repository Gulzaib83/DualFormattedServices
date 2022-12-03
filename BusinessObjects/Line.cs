using System;
using System.Collections.Generic;

namespace TP.DMS.TestAPI.BusinessObjects
{
    public partial class Line
    {
        public int LineId { get; set; }
        public Guid LineGuid { get; set; }
        public string? LineName { get; set; }
        public string? SerialNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
