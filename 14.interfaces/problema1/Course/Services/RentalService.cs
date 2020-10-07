using System;
using Course.Entities;

namespace Course.Services {
    class RentalService {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        public TimeSpan Duration { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) {
            Duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (Duration.TotalHours <= 12) {
                basicPayment = PricePerHour * Math.Ceiling(Duration.TotalHours);
            } else {
                basicPayment = PricePerDay * Math.Ceiling(Duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
        public string DurationToString() {
            if (Duration.TotalHours <= 12) {
                return Math.Ceiling(Duration.TotalHours) + " horas";
            } else {
                return Math.Ceiling(Duration.TotalDays) + " dias";
            }
        }
    }
}
