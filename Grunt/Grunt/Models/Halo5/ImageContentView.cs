using OpenSpartan.Grunt.Models.Halo5.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpartan.Grunt.Models.Halo5
{

    public class ImageContentView : AssetBase
    {
        public string Status { get; set; }
        public CommonContentProperties Common { get; set; }
        public ContentMedia Media { get; set; }
        public ContentImage Image { get; set; }
        public string Title { get; set; }
    }

}
