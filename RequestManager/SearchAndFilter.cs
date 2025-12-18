using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager
{
    public class SearchAndFilter
    {
        public BindingList<RequestModel> SearchByCustomer(BindingList<RequestModel> listRequests, string searchText)
        {
            BindingList<RequestModel> listOfFound = new BindingList<RequestModel>();
            for (int i = 0; i < listRequests.Count; i++)
            {
                if (listRequests[i].Customer.ToLower().Contains(searchText.ToLower()))
                {
                    listOfFound.Add(listRequests[i]);
                }
            }
            return listOfFound;
        }
    }
}
