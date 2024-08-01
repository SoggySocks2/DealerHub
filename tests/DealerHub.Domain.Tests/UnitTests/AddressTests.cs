using DealerHub.Shared.Tests.Customers;
using DealerHub.Shared.Tests.Dealers;
using DealerHub.Shared.Tests.Shared;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerHub.Domain.Tests.UnitTests;
public class AddressTests
{
    [Fact]
    public void UpdateAddressLine1_WhenTooLong_SetsAddress()
    {
        //Arranges
        //var address = new AddressBuilder().Build();

        //Act
        var act = () => new Address("1", "addressLine2", "addressLine3", "Postcode");

        //Assert
        act.Should().Throw<ArgumentException>();
    }
}
