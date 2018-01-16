using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Records
{
    public class ShelterRecord : BaseRecord
    {
        [Column(Order = 2)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Requisites { get; set; }
        public string Phone { get; set; }
        public AddressRecord Adress { get; set; }
        public string Photo { get; set; }
        public State State { get; set; }
        public List<UserRecord> UsersWorkers { get; set; }
    }
}
