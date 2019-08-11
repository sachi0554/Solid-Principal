namespace Solid_Princial_O
{
    public interface IApplicatntModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountCreate { get; set; } 

    }
}