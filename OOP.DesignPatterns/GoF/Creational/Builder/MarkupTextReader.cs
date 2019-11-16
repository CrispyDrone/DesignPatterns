using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.Builder
{
    public class MarkupTextReader : ITextReader
    {
        public MarkupTextReader(ITextBuilder textBuilder)
        {
            TextBuilder = textBuilder;
        }

        public ITextBuilder TextBuilder { get; set; }

        public void Parse(string text)
        {
            var isLiteral = false;

            for (int i = 0; i < text.Length; i++)
            {
                var @char = text[i];

                if (isLiteral)
                {
                    TextBuilder.BuildCharacter(@char);
                    isLiteral = false;
                    continue;
                }

                switch (@char)
                {
                    case '*':
                        TextBuilder.BuildFont(Font.Bold);
                        break;

                    case '_':
                        TextBuilder.BuildFont(Font.Italic);
                        break;

                    case '\t':
                        TextBuilder.BuildIndentation();
                        break;

                    case '\n':
                        TextBuilder.BuildLineBreak();
                        break;

                    case '\\':
                        isLiteral = true;
                        break;

                    default:
                        TextBuilder.BuildCharacter(@char);
                        break;
                }
            }
        }
    }
}
