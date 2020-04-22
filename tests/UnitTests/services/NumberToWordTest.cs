using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Services.Interfaces;
using Services.Services;
using Xunit;

namespace UnitTests.services
{
    public class NumberToWordTest
    {
        private readonly INumberToWord _numberToWord = new NumberToWord();

        [Fact]
        public void Number_1_should_return_one()
        {
            _numberToWord
                .ToWord(1)
                .Should()
                .Be("one");
        }

        [Theory]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(4, "four")]
        public void Number_X_should_return_string(int number, string numberInFull)
        {
            _numberToWord
                .ToWord(number)
                .Should()
                .Be(numberInFull);
        }
    }
}
