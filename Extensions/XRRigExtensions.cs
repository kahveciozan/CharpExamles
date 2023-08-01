using CSharpExamples.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples.Extensions
{
    // This class has a extentions method for "string"
    public static class XRRigExtensions
    {
        public static string FindXRRigSpace(this XRRig rig)
        {
            return rig.Space;
        }

    }

    
} 
