namespace MovieDatabase.Backend.Controllers.RoleManagement.Exceptions;

public class UserNotFoundException : Exception
{
    public const string Title = "User not found";
    public UserNotFoundException(string id) : base($"User with id {id} was not found.")
    {
    }
}