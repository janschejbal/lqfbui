using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQFBUI.Data
{
    public interface IObjectWithID<X>
    {
        X ID { get; }
    }
}
