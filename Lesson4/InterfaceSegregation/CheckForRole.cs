using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation;

public class RoleChecker : IPerson
{

    public Guid CheckUser(Guid user)
    {
        return user;
    }

    public Guid CheckRole(Guid role)
    {
        return role;
    }
}