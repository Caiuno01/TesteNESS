using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNESS.Models;
using TesteNESS.Repositories.Context;

namespace TesteNESS.Repositories
{
    public class UsuarioRepository
    {
        private readonly NessContext context;

        public UsuarioRepository()
        {
            context = new NessContext();
        }

        public IList<UsuarioModel> FindAll()
        {
            IList<UsuarioModel> usuarios;
            using (context){
                usuarios = context.Usuario.ToList();
            }
            return usuarios;
        }

        public UsuarioModel FindById(int id)
        {
            UsuarioModel usuario;
            using (context){
                usuario = context.Usuario.SingleOrDefault(u => u.IdUsuario == id);
            }
            return usuario;
        }

        public void Insert(UsuarioModel usuario)
        {
            using (context)
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();
            }
        }

        public void Update(UsuarioModel usuario)
        {
            using (context)
            {
                context.Usuario.Update(usuario);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var usuario = new UsuarioModel()
            {
                IdUsuario = id
            };
            using (context)
            {
                context.Usuario.Remove(usuario);
                context.SaveChanges();
            }
        }
    }
}
