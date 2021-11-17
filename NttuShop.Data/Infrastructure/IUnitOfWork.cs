namespace NttuShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}