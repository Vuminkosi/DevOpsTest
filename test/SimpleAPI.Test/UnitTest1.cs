using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController Controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
        //Given
             var returnValue = Controller.GetTest();

        //When
        
        //Then
                Assert.Equal("Vincent", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
