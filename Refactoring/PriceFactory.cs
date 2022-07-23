namespace Refactoring;

static class PriceFactory
{
    public static Price CreatePrice(PriceType type)
    {
        switch (type)
        {
            case PriceType.Regular: return CreateRegularPrice();
            case PriceType.NewRelease: return CreateNewReleasePrice();
            case PriceType.Children: return CreateChildrenPrice();
            default:throw new ArgumentOutOfRangeException(nameof(type));
        }
    }

    public static RegularPrice CreateRegularPrice() => new RegularPrice();

    public static NewReleasePrice CreateNewReleasePrice() => new NewReleasePrice();

    public static ChildrenPrice CreateChildrenPrice() => new ChildrenPrice();
}