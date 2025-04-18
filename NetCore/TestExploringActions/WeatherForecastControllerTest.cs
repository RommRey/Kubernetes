using ExploringActions;
using ExploringActions.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using Moq;

namespace TestExploringActions
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void Test_WeatherForecastController()
        {
            //arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            // act
            var result = controller.Get();

            //assert
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);

        }
    }
}