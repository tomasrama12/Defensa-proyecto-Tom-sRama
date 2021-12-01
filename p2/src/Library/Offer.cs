using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<OfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<OfferItem>(this.items);
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(OfferItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }

        public Residue residuoDirecto {get; private set;} // Agregado por demeter, ya que si tengo un objeto directo, no viola la ley de demeter
        // La forma correcta o la que entiendo que se debe usar es aplicar el patrón Visitor, pero como no se pueden crear clases, hice que 
        // el objeto sea directo

        public string AsText()
        {
            StringBuilder builderTexto = new StringBuilder();
            foreach (OfferItem item in Items)
            {
                this.residuoDirecto = item.Residue; // Por demeter
                builderTexto.Append(this.residuoDirecto.Name);
                builderTexto.Append(item.Quantity);
                builderTexto.Append(item.Price);
            }
            return builderTexto.ToString();
        }
    }
}