using System;

namespace ImprovedPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            DeliveryTruck deliveryTruck = new DeliveryTruck() { GrossWeightClass = 8000, Passangers = 2 };

            Console.WriteLine(CalculateToll(deliveryTruck));
            //Console.WriteLine(CalculateToll2(deliveryTruck));
        }

        // Simple pattern
        public static decimal CalculateToll(object vehicle) =>
            vehicle switch
            {
                DeliveryTruck t when t.GrossWeightClass > 5000 => 10.00m + 5.00m,
                DeliveryTruck t when t.GrossWeightClass < 3000 => 10.00m - 2.00m,
                DeliveryTruck _ => 10.00m,
                _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
            };

        // Relational pattern
        public static decimal CalculateToll2(object vehicle) =>
            vehicle switch
            {
                DeliveryTruck t => t.GrossWeightClass switch
                {
                    > 5000 => 10.00m + 5.00m,
                    < 3000 => 10.00m - 2.00m,
                    _ => 10.00m,
                },

                _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
            };

        // Logical pattern and keywork not
        public static decimal CalculateToll3(object vehicle) =>
            vehicle switch
            {
                DeliveryTruck t => t.GrossWeightClass switch
                {
                    > 5000 => 10.00m + 5.00m,
                    > 3000 and < 5000 => 10.00m,
                    < 3000 => 10.00m - 2.00m,
                    _ => 20.00m,
                },
                not null => throw new ArgumentException($"Not a known vehicle type: {vehicle}", nameof(vehicle)),
                _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
            };
    }
}