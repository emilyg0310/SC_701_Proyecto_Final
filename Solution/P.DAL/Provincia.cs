﻿using data = P.DAL.DO.Objects;
using P.DAL.DO.Interfaces;
using P.DAL.EF;
using P.DAL.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace P.DAL
{
    public class Provincia : ICRUD<data.Provincia>
    {
        private RepositoryProvincia<data.Provincia> repo;

        public Provincia(CalculoMateContext _Db)
        {
            repo = new RepositoryProvincia<data.Provincia>(_Db);
        }
        public void Delete(data.Provincia t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Provincia> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Provincia>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Provincia GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Provincia> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Provincia t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Provincia t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
