using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entity;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic
    {

        Data.Database.UsuarioAdapter UsuarioData = new UsuarioAdapter();

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public void Save(Usuario user)
        {
            UsuarioData.Save(user);
        }
    }
}
