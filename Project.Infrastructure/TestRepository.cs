using Project.Application.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project.Infrastructure
{
    public class TestRepository : ITestRepository
    {
        public static Domain.Test test = new Domain.Test()
        {
            Data = "Hello World"
        };

        public Domain.Test GetData()
        {
            return test;
        }

    }
}
