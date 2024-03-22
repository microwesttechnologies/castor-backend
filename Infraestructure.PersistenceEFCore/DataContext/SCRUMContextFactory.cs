using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Infraestructure.PersistenceEFCore.DataContext
{
    internal class SCRUMContextFactory : IDesignTimeDbContextFactory<SCRUMContext>
    {
        public SCRUMContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<SCRUMContext>();

            OptionsBuilder.UseSqlServer(
                "Server=(localdb)\\microwest; database = SCRUMDB");

            return new SCRUMContext(OptionsBuilder.Options);
        }
    }
}
