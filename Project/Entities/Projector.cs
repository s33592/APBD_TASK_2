using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class Projector : Equipment
    {
        public int Lumens { get; }
        public bool Is4K { get; }
        public Projector(int id, string name, int lumens, bool is4K) : base(id, name) { 
            Lumens = lumens;
            Is4K = is4K;
        }

        public override string ToString() {
            return $"{Id} | {Name} | Brightness: {Lumens} Lm | 4K: {Is4K}";
        }
    }
}
