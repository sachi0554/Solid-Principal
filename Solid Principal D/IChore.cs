namespace Solid_Principal_D
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool isCOmpleted { get; }
        IPerson Owner { get; set; }

        void ComplteChore();
        void PerformeWork(double hours);
    }
}