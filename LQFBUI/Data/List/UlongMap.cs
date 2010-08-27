using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQFBUI.Data.List
{
    public class UlongMap<X> : IDObjectMap<ulong,X> where X : IObjectWithID<ulong>
    {
        public UlongMap() : base() { }
    }
}
