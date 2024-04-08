using System;
using System.Collections.Generic;

namespace SystemExt
{
    public class ItemData
    {
        public DateTime date { get; set; }
        public decimal date_old { get; set; }

        public IEnumerable<string> Marks { get; set; }
        public decimal sumPerDay { get; set; }


    }
}