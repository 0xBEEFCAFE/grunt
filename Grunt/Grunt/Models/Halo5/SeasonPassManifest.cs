using OpenSpartan.Grunt.Models.Halo5.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpartan.Grunt.Models.Halo5
{

    public class SeasonPassManifest
    {
        public Image Image { get; set; }
        public GenericAsset Entitlement { get; set; }
        public string XboxLiveMarketplaceID { get; set; }
        public GenericAsset GrantProgram { get; set; }
    }

}
