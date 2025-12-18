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

        public BindingList<RequestModel> FilterCondition(BindingList<RequestModel> listRequests, string condition)
        {
            BindingList<RequestModel> listFilterCondition = new BindingList<RequestModel>();

            if (condition != "")
            {
                for (int i = 0; i < listRequests.Count; i++)
                {
                    if (listRequests[i].Condition.Contains(condition))
                    {
                        listFilterCondition.Add(listRequests[i]);
                    }
                }
            }
            return listFilterCondition;
        }
        public BindingList<RequestModel> FilterDate(BindingList<RequestModel> listRequests, DateTime start, DateTime end)
        {
            BindingList<RequestModel> listFilterCondition = new BindingList<RequestModel>();
            for (int i = 0; i < listRequests.Count; i++)
            {
                if (listRequests[i].RequestDate.Date >= start && listRequests[i].RequestDate.Date <= end)
                {
                    listFilterCondition.Add(listRequests[i]);
                }
            }
            return listFilterCondition;
        }
    }
}
