using System.Globalization;

namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }

        //public override string ToString()
        //{
        //    return $"{Name} - $ {this.Payment().ToString("F2", CultureInfo.InvariantCulture)}";
        //}
    }
}
