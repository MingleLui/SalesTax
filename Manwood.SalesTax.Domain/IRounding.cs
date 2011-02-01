using System;
namespace Manwood.SalesTax.Domain
{
    public interface IRounding
    {
        decimal Round(decimal valToRound);
    }
}
