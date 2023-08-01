using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples.Objects
{
    // This is a example class. We will extend this class
    public class XRRig
    {
        private string spaceType;
        private float floorPosition;

        public string Space{ get{ return spaceType; } }
        //public string Space => spaceType;                       // same as the line above


        public XRRig(string spaceType, float floorPosition) 
        {
            this.spaceType = spaceType;
            this.floorPosition = floorPosition;


        }
    }
}
