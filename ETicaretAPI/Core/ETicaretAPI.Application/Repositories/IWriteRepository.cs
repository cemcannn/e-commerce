using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model); //Tekli ekleme yapacağımız zaman kullanıyoruz.FirstOrDefault asenkron fonksiyonunu kullanacağı için fonksiyon sonuna Async tag ını ekliyoruz.
        Task<bool> AddRangeAsync(List<T> datas);    //Liste şekklinde ekleme yapacağımız zaman kullanıyoruz.FirstOrDefault asenkron fonksiyonunu kullanacağı için fonksiyon sonuna Async tag ını ekliyoruz.
        bool Remove(T model); //Async çalışmadığı için Task eklemiyoruz.
        bool RemoveRange(List<T> datas); //Liste şekklinde silme yapacağımız zaman kullanıyoruz. Async çalışmadığı için Task eklemiyoruz.
        Task<bool> RemoveAsync(string id); //FirstOrDefault asenkron fonksiyonunu kullanacağı için fonksiyon sonuna Async tag ını ekliyoruz.
        bool Update(T model); //Async çalışmadığı için Task eklemiyoruz.
        Task<int> SaveAsync();
    }
}
