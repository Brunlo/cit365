using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        public decimal WidthUpDown { get; set; }
        public decimal HeightUpDown { get; set; }
        public int NumDrawers { get; set; }

        public enum DeskMaterial
        {
            Rosewood,
            Laminate,
            Veneer,
            Oak,
            Pine,
        }

        public DeskMaterial Material { get; set; }
    }
}