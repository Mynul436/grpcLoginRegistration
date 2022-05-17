using Grpc.Core;
using static GrpcServer.Student;

namespace GrpcServer.Services
{
    public class StudentService:StudentBase
    {
        private readonly ILogger _logger;
        private readonly IUserAuthRepository _userAuth;
        public StudentService(ILogger<StudentService>logger,IUserAuthRepository userAuth)
        {
            _logger = logger;
            _userAuth = userAuth;
        }


        //public override Task<UserDtoModel> UserReg(StudentRegistration request, StudentLogin context)
        //{
        //    var user = new User()
        //    {
        //        Username = request.UserName,
        //        Email = request.Email,
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,
        //    };
        //    var userRepo =_userAuth.Pass
        //}

        public override Task<UserDtoModel> UserReg(StudentRegistration request, ServerCallContext context)
        {
            var user = new User()
            {
                Username = request.UserName,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Password=request.Password,  
            };
            var userRepo = _userAuth.Register(user , request.Password);
            
            return Task.FromResult(new UserDtoModel { Data=userRepo.ToString()
            
            });
        }
    }

    public class User
    {
        public User()
        {
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; internal set; }
    }
}
