using PostgresCRUD.Models;
using System.Collections.Generic;

namespace PostgresCRUD.DataAccess
{
    public interface IDataAccessProvider
    {
        void AddPatientRecord(Patient patient);
        void UpdatePatientRecord(Patient patient);
        void DeletePatientRecord(string id);
        Patient GetPatientSingleRecord(string id);
        List<Patient> GetPatientRecords();
    }
}
