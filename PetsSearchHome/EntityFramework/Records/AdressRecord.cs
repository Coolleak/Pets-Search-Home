using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Records
{
    public class AddressRecord : BaseRecord
    {
        [Column(Order = 2)]
        public string Street { get; set; }
        [Column(Order = 3)]
        public int House { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
