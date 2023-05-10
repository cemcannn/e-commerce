using ETicaretAPI.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true); //Ne varsa getir.
        IQueryable<T> GetWhere(Expression<Func<T, bool >> method, bool tracking = true); //Bir şart vereceğiz şarta uygun birden fazla veri gelecek.
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true); //Bir şart vereceğiz şarta uygun il veri gelecek. FirstOrDefault asenkron fonksiyonunu kullancağı için fonksiyon sonuna Async tag ını ekliyoruz.
        Task<T> GetByIdAsync(string id, bool tracking = true); //Id'ye ait veriyi getirir. FirstOrDefault asenkron fonksiyonunu kullancağı için fonksiyon sonuna Async tag ını ekliyoruz.
    }
}
