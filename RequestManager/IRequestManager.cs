using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager
{
    public interface IRequestManager
    {
        string AddRequest(RequestModel requestModel);
        string UpdateRequests(RequestModel requestModel);
    }
}
