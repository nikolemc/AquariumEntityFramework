using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumEntityFramework.Models
{
    class Ocean
    {
        public int Id{ get; set; }
        public string OceanName { get; set; }
        public double AverageTemp { get; set; }

        public virtual ICollection<AquaticLife> AquaticLife { get; set; } = new HashSet<AquaticLife>();
    }
}
