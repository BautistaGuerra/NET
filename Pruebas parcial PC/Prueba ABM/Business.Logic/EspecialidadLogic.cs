using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entity;

namespace Business.Logic
{
    public class EspecialidadLogic
    {
        Data.Database.EspecialidadAdapter EspecialidadData;

        public Especialidad GetOne(int id)
        {
            EspecialidadData = new EspecialidadAdapter();
            return EspecialidadData.GetOne(id);

        }
        public List<Especialidad> GetAll()
        {
            EspecialidadData = new EspecialidadAdapter();
            return EspecialidadData.GetAll();
        }
        public void Save(Especialidad esp)
        {
            EspecialidadData = new EspecialidadAdapter();
            EspecialidadData.Save(esp);
        }
    }
}
