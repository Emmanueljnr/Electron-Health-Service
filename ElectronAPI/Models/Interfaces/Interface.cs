namespace ElectronAPI.Models.Interfaces
{
    public interface IAdmin
    {
        void AddDoctor();
        void RemoveDoctor();
        void AddNurse();
        void RemoveNurse();
        void ViewSystemLogs();
        void GenerateReports();
    }
}
