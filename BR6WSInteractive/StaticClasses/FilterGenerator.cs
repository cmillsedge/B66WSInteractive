using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Api;
using BioRails.Core.Client;
using BioRails.Core.Model;

namespace BR6WSInteractive
{
    public class FilterGenerator
    {
        public static FilterArray SimpleFilter(string field, string op, string val)
        {
            Filter filter = new Filter(field, op, new List<string>() { val });
            FilterArray filters = new FilterArray { filter };
            return filters;
        }
    }
}
