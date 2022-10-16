using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_Console.Entities;

public class Animal
{
    public virtual void DoNothing() { }
    public virtual int GetAge() => -1;
    public static string Walk() => "I'm walking..";
}

