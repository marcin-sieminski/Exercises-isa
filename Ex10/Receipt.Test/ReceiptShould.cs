using Ex10;
using FluentAssertions;
using System;
using Xunit;

namespace ReceiptTests
{
    public class ReceiptShould
    {

        [Fact]
        public void Have_Total_Cost_Equal_To_Zero_When_Created()
        {
            var sut = new Receipt();

            var totalCost = sut.CalculateTotalCost();

            totalCost.Should().Be(0);
        }

        [Theory]
        [InlineData("orange", 2, 2, 4)]
        [InlineData("banana", 3, 1, 3)]
        [InlineData("apple", 5, 3, 15)]
        public void Return_Correct_TotalCost_When_Adding_Product(string title, int numberOfItems, int price, int expected)
        {
            var sut = new Receipt();
            sut.RecordLine(title, numberOfItems, price);

            var totalCost = sut.CalculateTotalCost();

            totalCost.Should().Be(expected);
        }

        [Fact]
        public void Return_Correct_TotalCost_When_Adding_More_Then_One_Product()
        {
            var sut = new Receipt();
            sut.RecordLine("eggs", 1, 3);
            sut.RecordLine("bread", 1, 2);

            var totalCost = sut.CalculateTotalCost();

            totalCost.Should().Be(5);
        }

        [Fact]
        public void Return_Correct_TotalCost_When_Reversing_Last_Product()
        {
            var sut = new Receipt();
            sut.RecordLine("eggs", 1, 3);
            sut.RecordLine("apples", 4, 2);
            sut.ReverseLastLine();

            var totalCost = sut.CalculateTotalCost();

            totalCost.Should().Be(3);
        }

        [Fact]
        public void Return_Zero_Number_Of_Lines_When_Receipt_Is_Empty()
        {
            var sut = new Receipt();

            var totalLines = sut.GetTotalNumberOfLines();

            totalLines.Should().Be(0);
        }

        [Fact]
        public void Return_Correct_Number_Of_Lines_When_Adding_Products()
        {
            var sut = new Receipt();
            sut.RecordLine("eggs", 1, 3);
            sut.RecordLine("apples", 4, 2);
            sut.RecordLine("milk", 1, 2);

            var totalLines = sut.GetTotalNumberOfLines();

            totalLines.Should().Be(3);
        }

        [Fact]
        public void Return_Correct_Number_Of_Lines_When_Reversing_Last_Product()
        {
            var sut = new Receipt();
            sut.RecordLine("eggs", 1, 3);
            sut.RecordLine("apples", 4, 2);
            sut.RecordLine("milk", 1, 2);
            sut.ReverseLastLine();

            var totalLines = sut.GetTotalNumberOfLines();

            totalLines.Should().Be(4);
        }

        [Fact]
        public void Throw_When_Reversing_Last_Line_If_Receipt_Is_Empty()
        {
            var sut = new Receipt();
            void ReverseLastLineWhenEmpty() => sut.ReverseLastLine();

            var exception = Assert.Throws<InvalidOperationException>(ReverseLastLineWhenEmpty);

            Assert.Contains("There is no lines. Nothing to reverse", exception.Message);
        }

        [Theory]
        [MemberData(nameof(TestData.Data), MemberType = typeof(TestData))]
        public void Return_Correct_TotalCost_When_Adding_Different_Products(string title, int numberOfItems, int price, int expected)
        {
            var sut = new Receipt();
            sut.RecordLine(title, numberOfItems, price);

            var totalCost = sut.CalculateTotalCost();

            totalCost.Should().Be(expected);
        }
    }
}
