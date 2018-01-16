using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace DAL.EF.Records
{
    public abstract class BaseRecord 
    {
        [Key]
        [Column(Order = 2)]
        public long Id { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
