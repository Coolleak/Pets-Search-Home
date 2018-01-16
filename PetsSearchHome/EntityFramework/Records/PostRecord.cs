using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Records
{
    public class PostRecord : BaseRecord
    {
        [Column(Order = 2)]
        public PostType PostType { get; set; }
        public AnimalRecord Animal { get; set; }
        public DateTime When { get; set; }
        public AddressRecord Where { get; set; }
        public State State { get; set; }

    }
}
