using System;
using System.Text;

namespace OOP.DesignPatterns.GoF.Creational.Builder
{
    public class PlainTextBuilder : ITextBuilder
    {
        private StringBuilder _result = new StringBuilder();

        public void BuildCharacter(char character)
        {
            _result.Append(character);
        }

        public void BuildColor(Color color) { }

        public void BuildFont(Font font) { }

        public void BuildIndentation()
        {
            _result.Append('\t');
        }

        public void BuildLineBreak()
        {
            _result.AppendLine();
        }

        public void BuildSize(int size) { }

        public string Build()
        {
            return _result.ToString();
        }
    }
}
