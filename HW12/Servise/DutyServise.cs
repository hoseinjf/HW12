using HW12.Container;
using HW12.Entity;
using HW12.Repository;
using HW12.Servise.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Servise
{
    public class DutyServise : IDutyServise
    {
        private readonly IDutyRepository _repository;
        public DutyServise()
        {
            _repository = new DutyRepository();
        }
        public void Add(Duty duty)
        {
            _repository.Add(duty);
        }

        public void ChengStatus(int id, Duty duty)
        {
            _repository.ChengStatus(id, duty);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Duty Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Duty> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(int id, Duty duty)
        {
            _repository.Update(id, duty);
        }
    }
}
