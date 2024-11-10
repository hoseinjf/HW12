using HW12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Servise.Contract
{
    public interface IDutyServise
    {
        void Add();
        void Update(int id);
        void Delete(int id);
        List<Duty> GetAll();
        Duty Get(int id);
        void ChengStatus(int id);
    }
}
