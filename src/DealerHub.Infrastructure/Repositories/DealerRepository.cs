using DealerHub.Domain;
using Microsoft.EntityFrameworkCore;

namespace DealerHub.Infrastructure.Repositories;
public class DealerRepository
{
    private readonly CoreDbContext _dbContext;

    public DealerRepository(CoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Dealer> AddAsync(Dealer dealer, CancellationToken cancellationToken)
    {
        await _dbContext.Dealers.AddAsync(dealer, cancellationToken);
        await _dbContext.SaveChangesAsync();

        return dealer;
    }

    public async Task<List<Dealer>> GetActiveListAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Dealers.ToListAsync(cancellationToken);
    }
}
