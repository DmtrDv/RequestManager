using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager
{
    public class RequestModel
    {
        [DisplayName("ИД")]
        public int Id_Request { get; set; } // id 
        [DisplayName("Заказчик")]
        public string Customer { get; set; }
        [DisplayName("Дата заявки")]
        public DateTime RequestDate { get; set; }
        [DisplayName("Состояние")]
        public string Condition { get; set; }
        [DisplayName("Описание требований")]
        public string Description { get; set; }

        public RequestModel() { }
        public RequestModel(int id) { Id_Request = id; }

        public RequestModel Clone()
        {
            return new RequestModel
            {
                Id_Request = this.Id_Request,
                Customer = this.Customer,
                RequestDate = this.RequestDate,
                Condition = this.Condition,
                Description = this.Description
            };
        }
    }
}
