using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public class EfMedDbService : IMedDbService
    {

        private MedDbContext medDbContext;
        public EfMedDbService(MedDbContext medcont)
        {
            medDbContext = medcont;
        }
        public Doctor AddDoctor(Doctor doc)
        {

            
            throw new NotImplementedException();
        }

        public Doctor DelecteDoctor(int idDoc)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetDoctors()
        {

            var data = medDbContext.Doctors.ToList();
            return data;
        }

        public Doctor ModifDoc(Doctor doc)
        {
            throw new NotImplementedException();
        }
    }
}
