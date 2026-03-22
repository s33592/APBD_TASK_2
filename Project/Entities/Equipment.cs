using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    abstract class Equipment
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; set; }

        public bool IsAvailable { get; set; }
        protected Equipment(int id,string name,string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.IsAvailable = true;
        }

    }
}
