using Microsoft.EntityFrameworkCore;
using OnlinePayment.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePayment.SQL
{
    public class OnlinePaymentDataContext:DbContext
    {
        public OnlinePaymentDataContext(DbContextOptions<OnlinePaymentDataContext> options) : base(options)
        {
        }

        public DbSet<PaymentDataModel> PaymentDataModels { get; set; }
    }
}
