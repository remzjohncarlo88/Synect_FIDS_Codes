using FidsCodingAssignment.Controllers;
using FidsCodingAssignment.Models;
using FidsCodingAssignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
