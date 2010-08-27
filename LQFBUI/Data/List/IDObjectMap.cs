using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace LQFBUI.Data.List
{
    public class IDObjectMap<X, Y> : KeyedCollection<X, Y> where Y : IObjectWithID<X>
    {
        public IDObjectMap() : base() {}

        protected override X GetKeyForItem(Y item)
        {
            return item.ID;
        }

        public Y get(X key)
        {
            try
            {
                return this[key];
            }
            catch
            {
                return default(Y); // that should be null in most cases
            }
        }
        
    }
}
