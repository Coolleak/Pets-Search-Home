using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;



namespace DAL.EF.Records
{
   public class UserRecord:BaseRecord
    {
        [Column(Order = 2)]
        public string Name { get; set; }
        [Column(Order = 3)]
        public string Surname { get; set; }
        [Column(Order = 4)]
        public string Email  { get; set; }
        [Column(Order = 5)]
        public string Password { get; set; }
        public AddressRecord Adress { get; set; }
        public string Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public State State { get; set; }
        public ShelterRecord Shelter { get; set; }
        public List<PostRecord> UserPosts { get; set; }
    }
}
