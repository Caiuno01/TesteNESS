using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNESS.Models;
using TesteNESS.Repositories;

namespace TesteNESS.Business
{
    public class UsuarioBusiness
    {
        private readonly UsuarioRepository repository;

        public UsuarioBusiness()
        {
            repository = new UsuarioRepository();
        }

        public IList<UsuarioModel> FindAll()
        {
            return repository.FindAll();
        }

        public UsuarioModel FindById(int id)
        {
            return repository.FindById(id);
        }

        public void Insert(UsuarioModel usuario)
        {
            repository.Insert(usuario);
        }

        public void Update(UsuarioModel usuario)
        {
            repository.Update(usuario);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
