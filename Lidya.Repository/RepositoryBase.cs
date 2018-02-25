using Lidya.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Repository
{
    public abstract class RepositoryBase<T> : IDisposable where T : class
    {
        protected LidyaEntities Context { get; set; }

        private DbSet<T> dbset
        {
            get
            {
                return Context.Set<T>();
            }
        }

        #region [ Constructor(s) ]


        public RepositoryBase()
        {
            Context = new LidyaEntities();
          
        }

        #endregion

        #region [ CRUD Actions ]

        /// <summary>
        /// Method to save t object in database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public virtual int Insert(T entity)
        {
            try
            {
                //ITrackableEntity ent = entity as ITrackableEntity;
                //if (ent != null)
                //{
                //    ((ITrackableEntity)entity).InsertDate = DateTime.Now;
                //    ((ITrackableEntity)entity).UpdateDate = DateTime.Now;
                //}
                //IActivableEntity entActivate = entity as IActivableEntity;
                //if (entActivate != null)
                //{
                //    ((IActivableEntity)entity).IsActive = true;
                //}

                this.dbset.Add(entity);
                return this.Context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                throw new Exception(string.Format("Error on insert {0}.", typeof(T).Name), e);
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on insert {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to delete t object from database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Delete(T entity)
        {
            try
            {
                dbset.Remove(entity);
                this.Context.SaveChanges();
                return true;
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on delete {0}.", typeof(T).Name), exc);

            }
        }

        public virtual void Delete(Func<T, Boolean> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
            this.Context.SaveChanges();
        }

        public virtual void Delete(params object[] keyValues)
        {
            var entity = dbset.Find(keyValues);
            dbset.Remove(entity);
            this.Context.SaveChanges();
        }

        /// <summary>
        /// Method to update t object in database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public virtual int Update(T entity)
        {
            try
            {
            //    ITrackableEntity ent = entity as ITrackableEntity;
            //    if (ent != null)
            //    {
            //        ((ITrackableEntity)entity).UpdateDate = DateTime.Now;
            //    }
                dbset.Attach(entity);
                this.Context.Entry<T>(entity).State = EntityState.Modified;
                return this.Context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(string.Format("Error on update {0}.", typeof(T).Name), ex);
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on update {0}.", typeof(T).Name), exc);
            }
        }

        #region [ Fetchs ]

        #region [ Get All ]

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return this.dbset;
        }

        public virtual IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = dbset;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate, params object[] includes)
        {

            try
            {
                IQueryable<T> query = dbset;// this.dbset;

                if (includes.Length > 0)
                {
                    query = query.Include(includes[0].ToString());
                    for (int i = 1; i < includes.Length; i++)
                    {
                        query = query.Include(includes[i].ToString());
                    }
                }

                return query.Where(predicate);

            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on find {0}.", typeof(T).Name), exc);
            }
        }

        #endregion

        #region [ Find ]

        /// <summary>
        /// Method to find first of entity via predicate
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual T Find(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return dbset.FirstOrDefault(predicate);
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on find {0}.", typeof(T).Name), exc);
            }
        }

        public virtual T Find(params object[] keyValues)
        {
            return this.dbset.Find(keyValues);
        }

        public virtual T Find<TKey>(Expression<Func<T, TKey>> sortExpression, bool isDesc, Expression<Func<T, bool>> predicate)
        {
            try
            {
                if (isDesc)
                {
                    return dbset.OrderBy(sortExpression).FirstOrDefault(predicate);

                }
                else
                {
                    return dbset.OrderByDescending(sortExpression).FirstOrDefault(predicate);
                }
                //return this.dbset.FirstOrDefault(predicate) as T;
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on find {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to find first of entity via predicate
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual T Find(Expression<Func<T, bool>> predicate, params object[] includes)
        {

            try
            {
                IQueryable<T> query = dbset;// this.dbset;
                //IQueryable<T> query =  this.dbset;
                if (includes.Length > 0)
                {
                    query = query.Include(includes[0].ToString());
                    for (int i = 1; i < includes.Length; i++)
                    {
                        query = query.Include(includes[i].ToString());
                    }
                }

                return query.FirstOrDefault<T>(predicate);

            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on find {0}.", typeof(T).Name), exc);
            }
        }

        #endregion

        #region [ Get List ]

        /// <summary>
        /// Method to get list of t object from database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public virtual List<T> GetList(Expression<Func<T, bool>> predicate)
        {
            try
            {

                return this.dbset.Where(predicate).ToList<T>();
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get list of {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to get list of t object from database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public virtual List<T> GetList(Expression<Func<T, bool>> predicate, params object[] includes)
        {
            try
            {
                IQueryable<T> query = this.dbset;
                if (includes.Length > 0)
                {
                    query = query.Include(includes[0].ToString());
                    for (int i = 1; i < includes.Length; i++)
                    {
                        query = query.Include(includes[i].ToString());
                    }
                }

                return query.Where(predicate).ToList<T>();
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get list of {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to get list of t object from database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public virtual List<T> GetList<TKey>(Expression<Func<T, TKey>> sortExpression)
        {
            try
            {
                return this.dbset.OrderByDescending(sortExpression).ToList<T>();
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get list of {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to get list of t object from database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public virtual List<T> GetList<TKey>(Expression<Func<T, TKey>> sortExpression, params object[] includes)
        {
            try
            {
                IQueryable<T> query = this.dbset;
                if (includes.Length > 0)
                {
                    query = query.Include(includes[0].ToString());
                    for (int i = 1; i < includes.Length; i++)
                    {
                        query = query.Include(includes[i].ToString());
                    }
                }


                return query.OrderByDescending(sortExpression).ToList<T>();
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get list of {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to get list of t object from database by paging
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        public virtual List<T> GetList<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> sortExpression, params object[] includes)
        {
            try
            {
                IQueryable<T> query = this.dbset;
                if (includes.Length > 0)
                {
                    query = query.Include(includes[0].ToString());
                    for (int i = 1; i < includes.Length; i++)
                    {
                        query = query.Include(includes[i].ToString());
                    }
                }

                return query.Where(predicate).OrderByDescending(sortExpression).ToList<T>();

            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get list of {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to get list of t object from database by paging
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        public virtual List<T> GetList<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> sortExpression, int pageSize, int pageIndex)
        {
            try
            {
                return this.dbset.Where(predicate).OrderByDescending(sortExpression).Skip(pageSize * pageIndex).Take(pageSize).ToList<T>();
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get list of {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to get list of t object from database by paging
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        public virtual List<T> GetList<TKey>(Expression<Func<T, TKey>> sortExpression, bool isDesc, int pageSize, int pageIndex)
        {
            try
            {
                if (isDesc)
                {
                    return this.dbset.OrderByDescending(sortExpression).Skip(pageSize * pageIndex).Take(pageSize).ToList<T>();
                }
                else
                {
                    return this.dbset.OrderBy(sortExpression).Skip(pageSize * pageIndex).Take(pageSize).ToList<T>();
                }

            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get list of {0}.", typeof(T).Name), exc);
            }

        }

        #endregion

        #endregion

        #region [ Scalars ]

        public virtual int CountOfRecord()
        {
            try
            {
                return this.dbset.Count();
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get count of {0}.", typeof(T).Name), exc);
            }
        }

        public virtual bool Exist(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return dbset.Any(predicate);
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on checking if data exists: {0}.", typeof(T).Name), exc);
            }
        }

        /// <summary>
        /// Method to get count of records. 
        /// This count may use for paging
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual int CountOfRecord(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return this.dbset.Count(predicate);
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Error on get count of {0}.", typeof(T).Name), exc);
            }
        }


        public virtual TResult GetMax<TResult>(Expression<Func<T, TResult>> selector)
        {
            return dbset.Max(selector);
        }


        #endregion

        #endregion

        #region [ Dispose ]

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }

        #endregion


        public static decimal GetNextSequence(Enumarations.Sequence sequence)
        {
            using (LidyaEntities db = new LidyaEntities())
            {
                string sql = String.Format("select {0}.nextval from dual", sequence.ToString());
                var testId = db.Database.SqlQuery<decimal>(sql).FirstOrDefault();
                return decimal.Parse(testId.ToString());
            }
        }
    }
}
