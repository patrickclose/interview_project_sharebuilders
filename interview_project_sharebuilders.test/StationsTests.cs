using interview_project_sharebuilder.Pages;
using interview_project_sharebuilders.Models;
using interview_project_sharebuilders.Services;
using Bunit;
using Xunit;
using Moq;
using Microsoft.Extensions.DependencyInjection;

namespace interview_project_sharebuilders.test
{
    public class StationsTests
    {
        [Fact]
        public void StationsComponentRendersCorrectly()
        {
            // Arrange
            var mockService = new Mock<IStationService>();
            var mockStations = new List<Station>
            {
                new Station("KTLA-TV", "Los Angeles", "CW"),
                new Station("KABC-TV", "Los Angeles", "ABC"),
                new Station("WABC-TV", "New York", "ABC"),
                new Station("KNBC", "Los Angeles", "NBC")
            };
            mockService.Setup(service => service.GetStationsAsync()).ReturnsAsync(mockStations);

            using var ctx = new TestContext();
            ctx.Services.AddSingleton(mockService.Object);

            // Act
            var component = ctx.RenderComponent<Stations>();

            // Assert
            Assert.NotNull(component.Find("select"));
            Assert.Equal(4, component.FindAll("option").Count);
        }

        [Fact]
        public void StationSelectionUpdatesSelectedStation()
        {
            // Arrange
            var mockService = new Mock<IStationService>();
            var mockStations = new List<Station>
            {
                new Station("KTLA-TV", "Los Angeles", "CW"),
                new Station("KABC-TV", "Los Angeles", "ABC"),
                new Station("WABC-TV", "New York", "ABC"),
                new Station("KNBC", "Los Angeles", "NBC")
            };
            mockService.Setup(service => service.GetStationsAsync()).ReturnsAsync(mockStations);

            using var ctx = new TestContext();
            ctx.Services.AddSingleton(mockService.Object);

            // Act
            var component = ctx.RenderComponent<Stations>();
            var selectElement = component.Find("select");
            selectElement.Change("KTLA-TV");

            // Assert
            Assert.Contains("KTLA-TV", component.Markup);
        }
    }
}
