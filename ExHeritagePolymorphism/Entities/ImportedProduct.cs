using System.Globalization;

namespace ExHeritagePolymorphism.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomsFee = customFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InstalledUICulture) + "(Custom fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
