using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.FactoryMethod
{
    //todo: improve, or think of another example
    public abstract class Application
    {
        private int _returnValue;

        public abstract Window CreateMainWindow();
        public Window MainWindow { get; private set; }

        public int Run()
        {
            if (MainWindow != null)
                throw new InvalidOperationException("already running");

            // not shown: get windows handle, attach application event handlers,...
            MainWindow = CreateMainWindow();

            MainWindow.Show();

            // runs main loop
            Dispatcher.Run();

            return _returnValue;
        }
    }
}
