using Grpc.Net.Client;
using GrpcServer;
using GrpcStudentTableClient;
using StudentTable;

var chanel1 = GrpcChannel.ForAddress("https://localhost:7024");
var student=new Student.StudentClient(chanel1);
var studentRequest1 = new StudentRegistration { };
var studentRequest2 = new StudentLogin { };
var reply = await student.UserRegAsync(studentRequest1);
var reply2 = await student.UserLogAsync(studentRequest2);

DbContextClass db = new DbContextClass();
StudentInfo studentInfo=new StudentInfo();
int fInput = 0;
int sInput = 0;
Console.WriteLine("What do you want?\n1.Make a registration\n2.Make a Login\n3.Exit ");

do
{
    fInput = Convert.ToInt32(Console.ReadLine());

    switch (fInput)
    {

        case 1:

            Console.WriteLine("Enter Student First Name:\n");
            studentInfo.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            studentInfo.LastName = Console.ReadLine();
            Console.WriteLine("Enter UserName");
            studentInfo.UserName = Console.ReadLine();
            Console.WriteLine("Enter Email Address");
            studentInfo.Email = Console.ReadLine();
            Console.WriteLine("Enter Password:\n");
            studentInfo.Password = Console.ReadLine();

            db.Students.Add(studentInfo);
            db.SaveChanges();
            break;
        case 2:
            {
                Console.WriteLine("Please Enter Email:");
                string un = Console.ReadLine();
                Console.WriteLine("Please Enter Password:");
                string pw = Console.ReadLine();

                studentInfo = db.Students.Where(x => x.Email == un && x.Password == pw).FirstOrDefault();
                if (studentInfo != null)
                {
                    Console.WriteLine("Login Successful");

                }
                else
                {
                    Console.WriteLine("Invalid Username or Password");
                }
                break;

            }

    }

    break;

}while(fInput == 3);

