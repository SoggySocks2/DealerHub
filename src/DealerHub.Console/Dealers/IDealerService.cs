using DealerHub.Domain;

namespace DealerHub.Console.Dealers;
public interface IDealerService
{
    Task<Dealer> AddAsync(Dealer dealer, CancellationToken cancellationToken);
    Task<List<Dealer>> GetListAsync(CancellationToken cancellationToken);
}
