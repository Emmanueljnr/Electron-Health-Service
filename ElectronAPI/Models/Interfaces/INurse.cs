namespace ElectronAPI.Models.Interfaces
{
    public interface INurse
    {
        void AdministerMedication();
        void UpdateVitalSigns();
        void ViewPatientHistory();
        void UpdatePatientHistory();
        void ViewLabResults();
    }
}
