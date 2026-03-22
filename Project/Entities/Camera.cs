using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public enum LensType
    {
        Prime,
        Zoom,
        WideAngle,
        Telephoto
    }
    public class Camera : Equipment
    {
        public int MegaPixels { get; }
        public LensType Lens { get; }
        public Camera(int id, string name,int megaPixels, LensType lens) : base(id, name)
        {
             MegaPixels = megaPixels;
             Lens = lens;
        }
        public override string ToString()
        {
            return $"{Id} | {Name} | Resolution: {MegaPixels} MP | Lens: {Lens}";
        } 
    }
}
