using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.Builder
{
    public interface ITextBuilder
    {
        void BuildCharacter(char character);
        void BuildLineBreak();
        void BuildIndentation();
        void BuildColor(Color color);
        void BuildFont(Font font);
        void BuildSize(int size);
    }
}
