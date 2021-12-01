using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode: IOfferItem
    {
        private string code {get;set;}
        private int amount;


        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentException("Es mayor que 0");
                }
                else
                {
                    this.amount = value;
                }
                
            }
        }

        public Residue Residue { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public PromoCode(string code, int amount)
        {
            this.code = code;
            if (amount > 0)
            {
                throw new ArgumentException("Es mayor que 0");
            }
            else
            {
                this.SubTotal = amount;
            }
            
        }
    }
}