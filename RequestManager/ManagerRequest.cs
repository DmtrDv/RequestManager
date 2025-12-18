using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager
{
    public class ManagerRequest
    {
        private IRequestManager storage_;

        public ManagerRequest(IRequestManager storage)
        {
            storage_ = storage;
        }

        public string AddRequest(RequestModel request)
        {
            if (string.IsNullOrEmpty(request.Customer))
            {
                return "Введите заказчика";
            }
            if (string.IsNullOrEmpty(request.Condition))
            {
                return "Введите состояние заявки";
            }
            if (string.IsNullOrEmpty(request.Description))
            {
                return "Введите описание заявки";
            }            

            storage_.AddRequest(request);
            return "Новая заявка успешно добавлена";
        }

        public string UpdateRequests(RequestModel request)
        {
            if (string.IsNullOrEmpty(request.Customer))
            {
                return "Введите заказчика";
            }
            if (string.IsNullOrEmpty(request.Condition))
            {
                return "Введите состояние заявки";
            }
            if (string.IsNullOrEmpty(request.Description))
            {
                return "Введите описание заявки";
            }

            storage_.UpdateRequests(request);
            return "Заявка успешно обновлена";
        }
    }
}
