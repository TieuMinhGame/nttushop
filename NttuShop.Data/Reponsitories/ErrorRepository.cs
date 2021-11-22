using NttuShop.Data.Infrastructure;
using NttuShop.Model.Models;

namespace NttuShop.Data.Reponsitories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}