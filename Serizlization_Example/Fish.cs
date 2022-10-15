using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serizlization_Example
{
    //[Serializable]
    public class Fish
    {

        public string name { get; set; }
        public string food { get; set; }
        public string gender { get; set; }

        public override string ToString()
        {
            return String.Format("fish:name {0},food {1},gender {2}", name, food, gender);
        }
    }
}
