using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Records
{
    public class AnimalRecord : BaseRecord
    {
        [Column(Order = 2)]
        public string Name { get; set; }
        [Column(Order = 3)]
        public AnimalType AnimalType { get; set; }
        [Column(Order = 4)]
        public Gender Gender { get; set; }
        [Column(Order = 5)]
        public string Breed { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public List<ColorRecord> Colors { get; set; }

    }
}
