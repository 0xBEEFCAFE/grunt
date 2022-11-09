using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpartan.Grunt.Models.Halo5.Foundation
{
    public class AssetBase
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Identity { get; set; }

        public Link[] Links { get; set; }

        public int ChildrenCount { get; set; }

        public CommonContentProperties? Common { get; set; }

        public string? Status { get; set; }

        public string Title { get; set; }
    }
}
