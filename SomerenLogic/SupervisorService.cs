using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class SupervisorService
    {
        SupervisorDao supervisordb;

        public SupervisorService()
        {
            supervisordb = new SupervisorDao();
        }

        public List<Supervisor> GetSupervisors()
        {
            try
            {
                List<Supervisor> supervisors = supervisordb.GetAllSupervisors();
                return supervisors;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void AddSupervisor(Teacher supervisor, Activity activities)
        {
            supervisordb.AddSupervisor(supervisor, activities);
        }

        public void RemoveSupervisor(Supervisor supervisor, Activity activities)
        {
            supervisordb.RemoveSupervisor(supervisor, activities);
        }
    }
}