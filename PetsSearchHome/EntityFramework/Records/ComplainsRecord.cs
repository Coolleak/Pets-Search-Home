using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Records
{
    public class ComplainsRecord : BaseRecord
    {
        public UserRecord User { get; set; }
        public ShelterRecord Shelter { get; set; }
    }
}
