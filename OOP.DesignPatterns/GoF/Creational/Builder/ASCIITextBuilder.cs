using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.Builder
{
    public class ASCIITextBuilder : ITextBuilder
    {
        private const int CHAR_HEIGHT = 9;
        private const int CHAR_WIDTH = 8;
        private readonly CharacterMapping _characterMapping;

        private StringBuilder _result = new StringBuilder();

        public ASCIITextBuilder(CharacterMapping characterMapping)
        {
            _characterMapping = characterMapping;
        }

        public void BuildCharacter(char character)
        {
            var mappedCharacter = _characterMapping.GetCharacter(character);
            var rowWidth = _result.Length / CHAR_HEIGHT;

            for (int i = CHAR_HEIGHT; i > 0; i--)
            {
                for (int j = CHAR_WIDTH; j > 0; j--)
                {
                    _result.Insert(rowWidth * i, mappedCharacter[(i-1) * CHAR_WIDTH + j-1]);
                }
            }
        }

        public void BuildColor(Color color) { }

        public void BuildFont(Font font) { }

        public void BuildIndentation()
        {
            var rowWidth = _result.Length / CHAR_HEIGHT;

            for (int i = CHAR_HEIGHT; i > 0; i--)
            {
                _result.Insert(rowWidth * i, '\t');
            }
        }

        public void BuildLineBreak()
        {
            var rowWidth = _result.Length / CHAR_HEIGHT;

            for (int i = CHAR_HEIGHT; i > 0; i--)
            {
                _result.Insert(rowWidth * i, '\n');
            }
        }

        public void BuildSize(int size) { }

        public string GetResult()
        {
            return _result.ToString();
        }
    }
}
