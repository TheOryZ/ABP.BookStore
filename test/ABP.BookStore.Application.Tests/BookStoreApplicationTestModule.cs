using Volo.Abp.Modularity;

namespace ABP.BookStore
{
    [DependsOn(
        typeof(BookStoreApplicationModule),
        typeof(BookStoreDomainTestModule)
        )]
    public class BookStoreApplicationTestModule : AbpModule
    {

    }
}