using CountryResource.Controllers;
using CountryResource.Infrastructure.Implementation;
using System;
using Xunit;

namespace CountryResourse.Test
{
    public class UnitTest1
    {
        private readonly CountryServiceFake _service;
        private CountryRepository countryManager;
        public UnitTest1()
        {
            _service = new CountryServiceFake();
            //countryManager = new CountryManager();
            //countryManager = new CountryController(_service);
        }

        //    [Fact]
        //    public void Get_WhenCalled_ReturnsOkResult()
        //    {
        //        // Act
        //        var okResult = _controller.Get();

        //        // Assert
        //        Assert.IsType<OkObjectResult>(okResult.Result);
        //    }
        //}
    }
}
