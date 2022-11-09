using OpenSpartan.Grunt.Models.Halo5.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpartan.Grunt.Models.Halo5
{

    public class CommonContentProperties
    {
        public string Owner { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime ModifiedUtc { get; set; }
        public DateTime PublishedUtc { get; set; }
        public int Container { get; set; }
    }

}
