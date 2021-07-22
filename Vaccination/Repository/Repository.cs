using System;
using System.Collections.Generic;
using System.Text;

namespace Vaccination
{
    class Repository
    {
        public int AddVaccinationUsers(Vaccination_Details VaccinationUsers)
        {
            int Result = 0;
            try
            {
                if (VaccinationUsers != null)
                {
                    formRegistration.display_Users.Add(VaccinationUsers);
                    Result = 1;
                }
            }
            catch (Exception ex)
            {
                Result = -1;
                Console.WriteLine(ex.ToString());
            }
            return Result;
        }

        public List<Vaccination_Details> GetVaccinationUsers()
        {
            return formRegistration.display_Users;
        }
    }
}
