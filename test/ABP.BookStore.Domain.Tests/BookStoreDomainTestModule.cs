using ABP.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABP.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}