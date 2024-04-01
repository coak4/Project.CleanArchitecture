using Project.Application.Interfaces;

namespace Project.Application.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepository testRepository;

        public TestService(ITestRepository testRepository)
        {
            this.testRepository = testRepository;
        }

        Domain.Test ITestService.GetData()
        {
            return testRepository.GetData();
        }
    }
}
