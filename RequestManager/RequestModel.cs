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
        public int Id_Request { get; } // id 
        [DisplayName("Заказчик")]
        public string Сustomer { get; set; }
        [DisplayName("Дата заявки")]
        public DateTime RequestDate { get; set; }
        [DisplayName("Состояние")]
        public string Condition { get; set; }
        [DisplayName("Описание требований")]
        public string Description { get; set; }
    }
}
