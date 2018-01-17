using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Records
{
    public class FavoritesRecord : BaseRecord
    {
        public UserRecord User { get; set; }
        public AnimalRecord Animal { get; set; }
    }
}
