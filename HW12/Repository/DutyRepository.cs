using HW12.Container;
using HW12.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Repository
{
    public class DutyRepository : IDutyRepository
    {
        private readonly AppDbContext appContext;
        public DutyRepository()
        {
            appContext = new AppDbContext();
        }
        public void Add(Duty duty)
        {
            appContext.Duties.Add(duty);
            appContext.SaveChanges();
        }

        public void ChengStatus(int id, Duty duty)
        {
            var dutyId = appContext.Duties.FirstOrDefault(d => d.Id == id);
            if (dutyId != null)
            {
                dutyId.Status = duty.Status;
                appContext.SaveChanges();
            }
            else
            {
                throw new Exception("Id not found !!! ");
            }
        }

        public void Delete(int id)
        {
            var del = appContext.Duties.FirstOrDefault(d => d.Id == id);
            if (del != null)
            {
                appContext.Duties.Remove(del);
                appContext.SaveChanges();

            }
            else
            {
                throw new Exception("Id not found !!! ");
            }
        }

        public Duty Get(int id)
        {
            var duty = appContext.Duties.FirstOrDefault(d => d.Id == id);
            if (duty != null)
            {
                return duty;
            }
            else
            {
                throw new Exception("Id not found !!! ");
            }
        }

        public List<Duty> GetAll()
        {
            var duty = appContext.Duties.ToList();
            if (duty != null)
            {
                return duty;
            }
            else
            {
                throw new Exception("Dutis not found !!! ");
            }
        }

        public void Update(int id, Duty duty)
        {
            var dutyId = appContext.Duties.FirstOrDefault(d => d.Id == id);
            if (dutyId != null)
            {
                dutyId.Title = duty.Title;
                dutyId.Description = duty.Description;
                dutyId.Priority = duty.Priority;
                dutyId.EndTime = duty.EndTime;
                appContext.SaveChanges();
            }
            else
            {
                throw new Exception("Id not found !!! ");
            }
        }
    }
}
