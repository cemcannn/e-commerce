using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository //ReadRepository ile içerisindeki tüm metodları implement ediyoruz, ICustomerRepository ile de CustomerReadRepository'nin abstractionu olarak uyguluyoruz. Yani ICustomerReadRepository CustomerReadRepository'nin doğrulayıcısı/imzası oluyor, ReadRepository ile de uygulanmış oluyor.
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context) //Constructor oluşturmak zorundasın, burada base sınıfa bir context nesne vermen gerekir.
        {
        }
    }
}
