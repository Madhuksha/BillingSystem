using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem.Models;
using System.Data.SqlClient;

namespace BillingSystem.Repository
{
    interface IData
    {
        void SaveBillDetails(BillDetail details);
        void SaveBillItems(List<Items> items, SqlConnection con, int id);

        List<BillDetail> GetAllDetails();

        BillDetail GetDetail(int Id);
    }
}
