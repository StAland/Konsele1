﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



namespace Konsole1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sbyte zahl1 = 127;
            bool geklappt = sbyte.TryParse("Hallo", out zahl1);
            short zahl2 = 32767;
            int zahl3 = 214748364;
            
            long zahl4 = 9223372036854775807;
            byte zahl5 = 255;
            ushort zahl6 = 65535;
            uint zahl7 = 4294967295;
            ulong zahl8 = 18446744073709551615;

            float zahl9 = 1.4f;
            float zahl10 = 10000000000000000000000000f;
            float zahl11 = 10000000000000000000000020f;
            double zahl12 = 10000000000000000000000000d;
            double zahl13 = 10000000000000000000000020d;
            decimal zahl14 = 10000000000000000000000000m;
            decimal zahl15 = 10000000000000000000000002m;
            var gleich = zahl14 == zahl15;

            bool var1 = false;
            bool var2 = true;

            bool var3 = var1 && var2;
            bool var4 = var2 || var1;

            string var5 = "Hallo \t \\ \n \" Hallo test";
            char var6 = '\n';
            string var7 = $" {var1} && {var2} = {var3}";

            DateTime zeit = DateTime.Parse("2024-12-24");
            TimeSpan zeitspanne = TimeSpan.FromDays(2);

            Console.WriteLine(zahl2);

        }
    }
}