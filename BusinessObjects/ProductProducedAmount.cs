using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class ProductProducedAmount
    {
        public int EquipmentId { get; set; }
        public Guid EquipmentGuid { get; set; }
        public string? EquipmentName { get; set; }
        public string ArticleName { get; set; } = null!;
        public int AmountLiters { get; set; }
        public int DurationProduceMinutes { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
