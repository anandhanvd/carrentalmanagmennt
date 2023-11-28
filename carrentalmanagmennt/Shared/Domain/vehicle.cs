using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrentalmanagmennt.Shared.Domain
{
    public class vehicle : Class1
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public virtual make? Make { get; set; }
        public int ModelId { get; set; }
        public virtual Model? Model { get; set; }
        public int ColourId { get; set; }
        public virtual color? color { get; set; }
        public virtual List<Booking>? Bookings { get; set; }

    }
}