﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesLab2
{
    public class A
    {
        public void F() { Console.WriteLine("A.F"); }
        public virtual void G() { Console.WriteLine("A.G"); }
    }
    public class B : A
    {
        public new void  F() { Console.WriteLine("B.F"); }
        public  new void G() { Console.WriteLine("B.G"); }
    }
}
