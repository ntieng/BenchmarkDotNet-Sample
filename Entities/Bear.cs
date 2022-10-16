using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_Console.Entities;
public class Bear : Animal
{
    public override void DoNothing() { }
    public override int GetAge() => 4;
}