using DealerHub.Domain;
using DealerHub.Infrastructure.Repositories;

namespace DealerHub.Console.Dealers;
public class DealerService : IDealerService
{
    private readonly DealerRepository _dealerRepository;

    public DealerService(DealerRepository dealerRepository)
    {
        _dealerRepository = dealerRepository;
    }
    public async Task<Dealer> AddAsync(Dealer dealer, CancellationToken cancellationToken)
    {
        return await _dealerRepository.AddAsync(dealer, cancellationToken);
    }

    public async Task<List<Dealer>> GetListAsync(CancellationToken cancellationToken)
    {
        return await _dealerRepository.GetActiveListAsync(cancellationToken);
    }
}
