using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumEntityFramework.Models
{
    class AquaticLife
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string AquaticLifeName { get; set; }
        public DateTime? DataAddedToTank { get; set; }
        public bool IsInQuarantine { get; set; }

        public virtual ICollection<Aquarium> Aquarium { get; set; } = new HashSet<Aquarium>();
        public virtual ICollection<Ocean> Ocean { get; set; } = new HashSet<Ocean>();

        public DateTime DateAddedToTank
        {
            get
            {
                return this.dateAddedToTank.HasValue
                    ? this.dateAddedToTank.Value
                    : DateTime.Now;
            }
            set { this.dateAddedToTank = value; }
        }
        private DateTime? dateAddedToTank = null;

        

    }
}
