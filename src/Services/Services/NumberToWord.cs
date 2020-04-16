using Humanizer;
using Services.Interfaces;

namespace Services.Services
{
    public class NumberToWord : INumberToWord
    {
        public string ToWord(int number) => number.ToWords();
    }
}
