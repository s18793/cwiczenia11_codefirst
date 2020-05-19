using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IMedDbService
    {


        public IEnumerable<Doctor> GetDoctors();
        public Doctor AddDoctor(Doctor doc);
        public Doctor DelecteDoctor(int idDoc);
        public Doctor ModifDoc(Doctor doc);
    }
}
