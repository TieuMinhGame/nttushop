namespace NttuShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory

    {
        private NttuShopDbContext dbContext;

        public NttuShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NttuShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}