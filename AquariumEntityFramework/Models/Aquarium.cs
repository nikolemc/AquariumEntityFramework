using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumEntityFramework.Models
{
    class Aquarium
    {
        public int Id { get; set; }
        public string AquariumName { get; set; }
        public string City { get; set; }
        public object OceanName { get; internal set; }

        public virtual ICollection<AquaticLife> AquaticLife { get; set; } = new HashSet<AquaticLife>();

    }
}
