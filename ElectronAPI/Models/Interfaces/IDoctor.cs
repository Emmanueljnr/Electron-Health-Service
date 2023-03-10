namespace ElectronAPI.Models.Interfaces
{
    public interface IDoctor
    {
        void PrescribeMedication();
        void ViewPatientHistory();
        void UpdatePatientHistory();
        void ViewLabResults();
        void AddLabResult();
    }
}
