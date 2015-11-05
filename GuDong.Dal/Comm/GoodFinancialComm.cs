using GuDong.EF;
using GuDong.EF.GoodJr;
using GuDong.IDal;
using GuDong.Log;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Dal
{
    public class GoodFinancialComm<T>: IComm<T> where T : class,new()
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int TotalCount { get; set; }
        public  bool IsOrderDesc{get;set;}
        public bool IsThenDesc { get; set; }
        public DbContext ct{get;set;}
        public string ErrorStr { get; set; }
        [Dependency]
        public ILogHelper log { get; set; }

        public GoodFinancialComm()
        {
            this.Page = 1;
            this.Limit = 10;
            this.TotalCount = 0;
            this.IsOrderDesc = false;
            this.IsThenDesc = false;
            this.ErrorStr = "";
            this.ct = new GoodFinancialContext();
        }

        public virtual T Add(T data)
        {
            ct.Set<T>().Add(data);
            return ct.SaveChanges() > 0 ? data : null;
        }

        public virtual T Update(T data, object Id)
        {
            T Updatedata = ct.Set<T>().Find(Id);
            ct.Entry<T>(Updatedata).CurrentValues.SetValues(data);
            return ct.SaveChanges() > 0 ? data : null;
        }

        public virtual bool Delete(object Id)
        {
            T Deldata = ct.Set<T>().Find(Id);
            ct.Entry<T>(Deldata).State = EntityState.Deleted;
            int num = ct.SaveChanges();
            return num > 0 ? true : false;
        }


        public List<T> Find<Okey>(Expression<Func<T, bool>> Where, Expression<Func<T, Okey>> order, int limit)
        {
            this.Limit = limit;
            return Find(Where, order);
        }

        public List<T> Find<Okey>(Expression<Func<T, bool>> Where, Expression<Func<T, Okey>> Order)
        {
            var FindData = ct.Set<T>().Where(Where);
            if (IsOrderDesc)
            {
                FindData = FindData.OrderByDescending(Order);
            }
            else
            {
                FindData = FindData.OrderBy(Order);
            }
            this.TotalCount = FindData.Count();
            return FindData.Skip((this.Page - 1) * this.Limit).Take(this.Limit).ToList();
        }

        public List<T> Find<Okey, Tkey>(Expression<Func<T, bool>> Where, Expression<Func<T, Okey>> Order, Expression<Func<T, Tkey>> ThenOrder)
        {
            var FindData = ct.Set<T>().Where(Where);
            if (IsOrderDesc == false && IsThenDesc == false)
            {
                FindData = FindData.OrderBy(Order).ThenBy(ThenOrder);
            }
            else if (IsOrderDesc == false && IsThenDesc == true)
            {
                FindData = FindData.OrderBy(Order).ThenByDescending(ThenOrder);
            }
            else if (IsOrderDesc == true && IsThenDesc == false)
            {
                FindData = FindData.OrderByDescending(Order).ThenBy(ThenOrder);
            }
            else if (IsOrderDesc == true && IsThenDesc == true)
            {
                FindData = FindData.OrderByDescending(Order).ThenByDescending(ThenOrder);
            }
            this.TotalCount = FindData.Count();
            return FindData.Skip((this.Page - 1) * this.Limit).Take(this.Limit).ToList();
        }

        public T First(Expression<Func<T, bool>> Where)
        {
            return ct.Set<T>().FirstOrDefault(Where);
        }

        public T Find<Tkey>(Tkey Id)
        {
            return ct.Set<T>().Find(Id);
        }
    }
}
