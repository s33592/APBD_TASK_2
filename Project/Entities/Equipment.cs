using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public abstract class Equipment
    {
        public int Id { get; }
        public string Name { get; }
        public bool IsAvailable { get; set; }
        protected Equipment(int id,string name)
        {
            this.Id = id;
            this.Name = name;
            this.IsAvailable = true;
        }

    }
}
