using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.Prototype.Interfaces
{
    public interface IPrototype
    {
        Entity Clone();
    }
}
