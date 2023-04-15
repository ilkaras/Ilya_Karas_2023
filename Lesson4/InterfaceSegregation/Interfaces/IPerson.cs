namespace InterfaceSegregation.Interfaces;

public interface IPerson
{
    public Guid CheckRole(Guid role);
    public Guid CheckUser(Guid user);
}