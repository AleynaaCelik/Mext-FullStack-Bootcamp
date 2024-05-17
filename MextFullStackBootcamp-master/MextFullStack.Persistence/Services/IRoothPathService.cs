using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStack.Persistence.Services
{
    public interface IRoothPathService
    {
        string GetRoothPath();
        void WriteTotalCount();
    }
}
