using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace MagazynierApp.Server
{
    public class MachineMonitorService: IHostedService, IDisposable
    {

        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
