using Domains;
using Domains.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface IService<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(int pageNum,int pageSize);
        T GetById(int id);
        List<T> GetByCategory(int catId);
        Task Add(T t);
        List<T> GetRelatedJobs(int KindId);
        public int totalCount();
    }
}
