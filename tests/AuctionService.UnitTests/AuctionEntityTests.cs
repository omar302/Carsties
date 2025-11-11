using AuctionService.Entities;

namespace AuctionService.UnitTests;

public class AuctionEntityTests
{
    [Fact]
    public void HasReservedPrice_ReservePriceGtZero_True()
    {
        // arrange
        var auction = new Auction { Id = Guid.NewGuid(), Seller = "bob", ReservePrice = 10 };

        // act
        var result = auction.HasReservedPrice();

        // assert
        Assert.True(result);
    }

    [Fact]
    public void HasReservedPrice_ReservePriceIsZero_False()
    {
        // arrange
        var auction = new Auction { Id = Guid.NewGuid(), Seller = "bob", ReservePrice = 0 };

        // act
        var result = auction.HasReservedPrice();

        // assert
        Assert.False(result);
    }
}