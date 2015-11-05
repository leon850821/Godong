using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface IComm<T> where T : class,new()
    {
        int Page { get; set; }
        int Limit { get; set; }
        int TotalCount { get; set; }
        bool IsOrderDesc{get;set;}
        bool IsThenDesc { get; set; }
        string ErrorStr { get; set; }
        T Add(T data);
        T Update(T data, object Id);
        bool Delete(object Id);

        List<T> Find<Okey>(Expression<Func<T, bool>> Where, Expression<Func<T, Okey>> order, int limit);
        List<T> Find<Okey>(Expression<Func<T, bool>> Where, Expression<Func<T, Okey>> Order);
        List<T> Find<Okey, Tkey>(Expression<Func<T, bool>> Where, Expression<Func<T, Okey>> Order, Expression<Func<T, Tkey>> ThenOrder);
        T First(Expression<Func<T, bool>> Where);
        T Find<Tkey>(Tkey Id);
    }
}
