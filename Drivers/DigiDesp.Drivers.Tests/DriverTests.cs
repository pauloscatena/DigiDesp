using System;
using DigiDesp.Common.Types;
using DigiDesp.Drivers.Domain.Entities;
using Xunit;

namespace DigiDesp.Drivers.Tests
{
    public class DriverTests
    {
        [Theory]
        [InlineData("Paulo Scatena", "02-15-1978")]
        public void RegisterUserHappyPath(Name name, string birthDate)
        {
            DateTime bd = new DateTime();
            DateTime.TryParse(birthDate, out bd);
            Driver newDriver = new Driver(
                GlobalId.NewId(), 
                name, 
                string.Empty, 
                string.Empty, 
                bd, 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                new DateTime(2022,2, 20), 
                string.Empty,
                string.Empty, 
                string.Empty, 
                new DateTime(2018, 2, 20),
                string.Empty, 
                string.Empty);
            Assert.Equal(newDriver.Name, name);
            Assert.Equal(newDriver.BirthDate, bd);            
        }
    }
}
