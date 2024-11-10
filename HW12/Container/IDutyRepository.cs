using HW12.Entity;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Container
{
    public interface IDutyRepository
    {
        void Add();
        void Update(int id);
        void Delete(int id);
        List<Duty> GetAll();
        Duty Get(int id);
        void ChengStatus(int id);
    }
}
