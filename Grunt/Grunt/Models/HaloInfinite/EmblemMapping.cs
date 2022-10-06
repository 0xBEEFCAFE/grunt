using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    [IsAutomaticallySerializable]
    public class EmblemMapping
    {
        public string? EmblemCmsPath { get; set; }
        public string? NameplateCmsPath { get; set; }
        public string? TextColor { get; set; }
    }
}
