using data = P.DAL.DO.Objects;
using P.DAL.DO.Interfaces;
using P.DAL.EF;
using P.DAL.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace P.DAL
{
    public class Persona : ICRUD<data.Persona>
    {
        private RepositoryPersona repo;

        public Persona(CalculoMateContext _Db)
        {
            repo = new RepositoryPersona(_Db);
        }
        public void Delete(data.Persona t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Persona> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Persona>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Persona GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Persona> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Persona t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Persona t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
