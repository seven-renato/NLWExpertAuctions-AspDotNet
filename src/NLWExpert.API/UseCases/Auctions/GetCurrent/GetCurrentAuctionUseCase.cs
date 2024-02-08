using Microsoft.EntityFrameworkCore;
using NLWExpert.API.Entities;
using NLWExpert.API.Repositories;

namespace NLWExpert.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase // Contém apenas uma regra de negocio
{
    public Auction? Execute ()
    {
        var repositorty = new NLWExpertAuctionDbContext();

        var today = DateTime.Now;

        return repositorty
            .Auctions
            .Include(auction => auction.Items) // Precisa incluir os items
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends); // Se encontrar traz se não encontrar retorna nulo ao invés de uma exception
    }
}
