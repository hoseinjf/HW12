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
        void Add(Duty duty);
        void Update(int id, Duty duty);
        void Delete(int id);
        List<Duty> GetAll();
        Duty Get(int id);
        void ChengStatus(int id, Duty duty);
    }
}
