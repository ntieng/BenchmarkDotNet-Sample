using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_Console.Entities;
public sealed class Husky : Animal
{
    public override void DoNothing() { }
    public override int GetAge() => 11;
}