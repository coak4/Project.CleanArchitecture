namespace Project.Application
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
            return this.testRepository.GetData();
        }
    }
}
