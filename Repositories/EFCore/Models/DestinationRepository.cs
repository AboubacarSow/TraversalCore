using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Models
{
    public class DestinationRepository : RepositoryBase<Destination>, IDestinationRepository
    {
        public DestinationRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(Destination model) => Insert(model);
        public void Delete(Destination model) => Remove(model);
        public async Task<IEnumerable<Destination>> GetAllDestinations(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();
        public async Task<Destination> GetById(int id, bool trackChanges) =>
            await FindByCondition(a => a.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
        public void Update(Destination model) => Edit(model);
    }
}
