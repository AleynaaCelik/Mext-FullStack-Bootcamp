using MextFullStack.Persistence.Services;

namespace MextFullStack.WebApi.Services
{
    public class RootPathManager:IRoothPathService
    {
        private readonly string RootPath;
        private readonly RequestCounterManager _requestCounterManager;

        public RootPathManager(string rootPath, RequestCounterManager requestCounterManager)
        {

            RootPath = rootPath;
            _requestCounterManager = requestCounterManager;
        }

        public string GetRoothPath()
        {
            return RootPath;
        }

        
        public void WriteTotalCount()
        {
            var path = Path.Combine(RootPath, "requestCount.txt");
            File.WriteAllText(path,_requestCounterManager.GetTotalCount().ToString());
        }
    }
}
