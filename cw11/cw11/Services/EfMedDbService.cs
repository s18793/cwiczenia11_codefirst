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

            var newdoc = new Doctor
            {
                FirstName = doc.FirstName, LastName = doc.LastName,
                Email = doc.Email
            };
            medDbContext.Add(newdoc);
            medDbContext.SaveChanges();
            return newdoc;
            
          
        }

        public Doctor DelecteDoctor(int idDoc)
        {

            var doc = medDbContext.Doctors.FirstOrDefault(d => d.IdDoctor == idDoc);
            medDbContext.Doctors.Remove(doc);
            medDbContext.SaveChanges();
            //lub ewnetulanie where. toList() i foreach
            return doc;
        }

        public IEnumerable<Doctor> GetDoctors()
        {

            var data = medDbContext.Doctors.ToList();
            return data;
        }

        public Doctor ModifDoc(Doctor doc)
        {
            var moddoc = medDbContext.Doctors.FirstOrDefault(d => d.IdDoctor == doc.IdDoctor);
            moddoc.LastName = doc.LastName;
            moddoc.FirstName = doc.FirstName;
            moddoc.Email = doc.Email;
            medDbContext.SaveChanges(); return moddoc;



        }
    }
}
