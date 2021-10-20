﻿using data = P.DAL.DO.Objects;
using P.DAL.DO.Interfaces;
using P.DAL.EF;
using P.DAL.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace P.DAL
{
    public class Materiales : ICRUD<data.Materiales>
    {
        private RepositoryMateriales<data.Materiales> repo;


        public Materiales(CalculoMateContext _Db)
        {
            repo = new RepositoryMateriales<data.Materiales>(_Db);
        }
        public void Delete(data.Materiales t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Materiales> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Materiales>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Materiales GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Materiales> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Materiales t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Materiales t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
