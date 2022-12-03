using System;
using System.Collections.Generic;

namespace TP.DMS.TestAPI.BusinessObjects
{
    public partial class Equipment
    {
        public int EquipmentId { get; set; }
        public Guid EquipmentGuid { get; set; }
        public string? EquipmentName { get; set; }
        public string? TypeOfEquipment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
