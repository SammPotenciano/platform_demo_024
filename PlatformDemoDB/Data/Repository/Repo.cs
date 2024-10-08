using Microsoft.EntityFrameworkCore;
using PlatformDemoDB.Domain;
using PlatformDemoDB.Models;

namespace PlatformDemoDB.Data.Repository
{
    public abstract class Repo
    {
        public readonly AppDbContext Context;

        public Repo(AppDbContext dbContext)
        {
            Context = dbContext;
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}
