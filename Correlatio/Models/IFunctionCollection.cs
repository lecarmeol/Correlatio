using RICPFitter.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Models
{
    public interface IFunctionCollection : ICloneable
    {
        List<IFittable> Functions { get; }

        IFittable FindByName(string name, string category = null);
    }
}
