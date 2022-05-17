namespace GrpcServer.Services
{
    public interface IUserAuthRepository
    {
        object Register(User user, string password);
    }
}