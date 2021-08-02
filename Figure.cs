using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDictionary
{
    public class Figure
    {
        public int SideCount { get; set; }
        public int SideLenght { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Figure))
            {
                return false;
            }

            Figure currentFigure = (Figure)obj;

            return SideCount == currentFigure.SideCount && SideLenght == currentFigure.SideLenght;
        }

        public override int GetHashCode()
        {
            return SideCount;
        }
    }
}
