namespace grpc_db_ops.Services
{
    public class AuthenticationService:AuthenticationServiceBase
    {
        private readonly StudentDatabase studentDatabase;
        public AuthenticationService(StudentDatabase studentDatabase)
        {
            this.studentDatabase = studentDatabase;
        }
    }
}
