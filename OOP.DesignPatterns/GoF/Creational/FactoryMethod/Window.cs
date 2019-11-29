using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.FactoryMethod
{
    public abstract class Window
    {
        public bool IsVisible { get; private set; }
        public void Show()
        {
            IsVisible = true;
        }
    }
}
