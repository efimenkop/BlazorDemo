using BlazorDemo.Pages;
using Bunit;
using Xunit;

namespace BlazorDemo.UnitTests.ComponentTests
{
    public class CounterTests
    {
        [Fact]
        public void CounterShouldIncrementWhenSelected()
        {
            // Arrange
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();
            var paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();
            var paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 1");
        }
    }
}
