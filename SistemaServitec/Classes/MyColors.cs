using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Classes
{
    internal class MyColors: ProfessionalColorTable
    {
        public override Color MenuItemBorder
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemSelected
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.DimGray; }
        }
    }
}
