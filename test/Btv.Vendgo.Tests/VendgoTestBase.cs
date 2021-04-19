using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Btv.Vendgo.EntityFrameworkCore;
using Btv.Vendgo.Tests.TestDatas;

namespace Btv.Vendgo.Tests
{
    public class VendgoTestBase : AbpIntegratedTestBase<VendgoTestModule>
    {
        public VendgoTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<VendgoDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<VendgoDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<VendgoDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<VendgoDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<VendgoDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<VendgoDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<VendgoDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<VendgoDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
