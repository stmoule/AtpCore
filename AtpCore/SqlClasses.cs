using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtpCore
{
    public class SqlClass
    {
        public string Name { get; set; }
        public string FavoriteMovie { get; set; }
        public string RowId { get; set; }
        public string DateCreated { get; set; }

    }

    public class NoSqlClass
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string id { get; set; }
        public string Time { get; set; }

    }
}
