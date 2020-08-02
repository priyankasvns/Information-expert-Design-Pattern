using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_expert
{
    //One of the information expert who is responsible for calculating the total amount.
    class Sale
    {
        private DateTime saleDateTime;
        private List<SalesLineItem> currentSaleLineItem;

        public DateTime SaleDateTime
        {
            get => DateTime.Now;
            set => saleDateTime = DateTime.Now;
        }

        public Sale(List<SalesLineItem> currentSaleLineItem)
        {
            this.currentSaleLineItem = currentSaleLineItem;

        }

        public double getTotal()
        {
            double total = 0;
            foreach (SalesLineItem sale in currentSaleLineItem)
            {
                total += sale.GetSubTotal();
            }

            return total;
        }

    }
}
