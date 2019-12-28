using System;

namespace First
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Oef_1");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Naam Oefening  \t\t Verwacht Resultaat \tJouw Resultaat");
            Console.WriteLine("ToonKwartaal \t\t 1 \t\t\t" + Oef_1.ToonKwartaal(2));
            Console.WriteLine("ToonKwartaal \t\t 2 \t\t\t" + Oef_1.ToonKwartaal(6));
            Console.WriteLine("ToonKwartaal \t\t 3 \t\t\t" + Oef_1.ToonKwartaal(7));
            Console.WriteLine("ToonKwartaal \t\t 4 \t\t\t" + Oef_1.ToonKwartaal(11));
            Console.WriteLine("ToonKwartaal \t\t 0 \t\t\t" + Oef_1.ToonKwartaal(13));
            Console.WriteLine("BerekenBelastbaar \t 10000 \t\t\t" + Oef_1.BerekenBelastbaar(10000, 0));
            Console.WriteLine("BerekenBelastbaar \t 9972 \t\t\t" + Oef_1.BerekenBelastbaar(10000, 1));
            Console.WriteLine("BerekenBelastbaar \t 9947 \t\t\t" + Oef_1.BerekenBelastbaar(10000, 2));
            Console.WriteLine("BerekenBelastbaar \t 9917 \t\t\t" + Oef_1.BerekenBelastbaar(10000, 3));
            Console.WriteLine("BerekenBelastbaar \t 9883 \t\t\t" + Oef_1.BerekenBelastbaar(10000, 4));
            Console.WriteLine("BerekenBelastbaar \t 9781 \t\t\t" + Oef_1.BerekenBelastbaar(10000, 7));
            Console.WriteLine("BerekenProvisie \t 350 \t\t\t" + Oef_1.BerekenProvisie(10000, 1));
            Console.WriteLine("BerekenProvisie \t 400 \t\t\t" + Oef_1.BerekenProvisie(10000, 5));
            Console.WriteLine("BerekenProvisie \t 425 \t\t\t" + Oef_1.BerekenProvisie(10000, 7));
            Console.WriteLine("BerekenProvisie \t 475 \t\t\t" + Oef_1.BerekenProvisie(10000, 10));
            Console.WriteLine("BerekenProvisie \t 550 \t\t\t" + Oef_1.BerekenProvisie(10000, 15));
            Console.WriteLine();
            Console.WriteLine("Oef_2");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("GeefAlarm \t Geen actie vereist. \t\t" + Oef_2.GeefAlarm(Priority.Zero));
            Console.WriteLine("GeefAlarm \t Stand by. \t\t\t" + Oef_2.GeefAlarm(Priority.Low));
            Console.WriteLine("GeefAlarm \t Activeer basisprotocol. \t" + Oef_2.GeefAlarm(Priority.Medium));
            Console.WriteLine("GeefAlarm \t Activeer uitgebreid protocol. \t" + Oef_2.GeefAlarm(Priority.Important));
            Console.WriteLine("GeefAlarm \t Evacueer het gebouw. \t\t" + Oef_2.GeefAlarm(Priority.Critical));
            Console.WriteLine("WijzigVolume \t 3 \t\t\t\t" + Oef_2.WijzigVolume(Volume.Low));
            Console.WriteLine("WijzigVolume \t 5 \t\t\t\t" + Oef_2.WijzigVolume(Volume.Medium));
            Console.WriteLine("WijzigVolume \t 7 \t\t\t\t" + Oef_2.WijzigVolume(Volume.High));
            Console.ReadKey();
        }
    }
}
