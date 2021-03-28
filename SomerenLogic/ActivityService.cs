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
    public class ActivityService
    {
        ActivitiesDao activitiesdb;

        public ActivityService()
        {
            activitiesdb = new ActivitiesDao();
        }

        public List<Activity> GetActivities()
        {
            try
            {
                List<Activity> activities = activitiesdb.GetAllActivities();
                return activities;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void ChangeActivity(Activity activities)
        {

            activitiesdb.Change(activities);
        }

        public void DeleteActivity(Activity activities)
        {

            activitiesdb.Delete(activities);
        }

        public void AddActivity(Activity activities)
        {

            activitiesdb.Add(activities);
        }
    }
}