using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entity;
using Data.Database;

namespace Business.Logic
{
    public class ModuloLogic
    {
        Data.Database.ModuloAdapter ModuloData;

        public Modulo GetOne(int id)
        {
            ModuloData = new ModuloAdapter();
            return ModuloData.GetOne(id);
        }
        public List<Modulo> GetAll()
        {
            ModuloData = new ModuloAdapter();
            return ModuloData.GetAll();
        }

        public void Save(Modulo mod)
        {
            ModuloData = new ModuloAdapter();
            ModuloData.Save(mod);
        }

    }
}
