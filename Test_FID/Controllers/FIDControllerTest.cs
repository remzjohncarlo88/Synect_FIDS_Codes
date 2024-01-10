using FidsCodingAssignment.Controllers;
using FidsCodingAssignment.Models;
using FidsCodingAssignment.Services;
using Microsoft.AspNetCore.Mvc;
using Test_FID.Services;

namespace Test_FID.Controllers
{
    public class FIDControllerTest
    {
        private readonly FIDController _controller;
        private readonly IFlightInfoService _service;

        /// <summary>
        /// FID Contoller Test
        /// </summary>
        public FIDControllerTest()
        {
            _service = new FIDServiceTest();
            _controller = new FIDController(_service);
        }

        [Fact]
        public void CheckFlightStatus_WhenCalled_ReturnsRightItem()
        {
            // Act
            var items = _controller.CheckFlightStatus("QR", 3905) as OkObjectResult;
            // Assert
            Assert.Equal("QR 3905", (items.Value as FlightDataDisplayModel).FlightId);
        }

        [Fact]
        public void CheckFlightStatus_WhenCalled_ReturnsNoContentResult()
        {
            // Act
            var items = _controller.CheckFlightStatus("QRI", 3905);
            // Act
            var noContentResponse = items;
            // Assert
            Assert.IsType<NotFoundResult>(noContentResponse);
        }

        [Fact]
        public void GetDelayedFlights_WhenCalled_ReturnsRightItem()
        {
            // Act
            var items = _controller.GetDelayedFlights() as OkObjectResult;
            // Assert
            var itemsEq = Assert.IsType<List<FlightDataDisplayModel>>(items.Value);
            Assert.Equal(3, itemsEq.Count);
        }

        [Fact]
        public void CheckActiveFlightAtGate_WhenCalled_ReturnsRightItem()
        {
            // Act
            var items = _controller.CheckActiveFlightAtGate("E2") as OkObjectResult;
            // Assert
            Assert.Equal("TK 8659", (items.Value as FlightDataDisplayModel).FlightId);
        }

        [Fact]
        public void CheckActiveFlightAtGate_WhenCalled_ReturnsNoContentResult()
        {
            // Act
            var items = _controller.CheckActiveFlightAtGate("E1");
            // Act
            var noContentResponse = items;
            // Assert
            Assert.IsType<NotFoundResult>(noContentResponse);
        }
    }
}
