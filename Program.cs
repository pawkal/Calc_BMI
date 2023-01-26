using System;

namespace BMI_calculator
{
    class Bmi
    {
        int masa;
        double wzrost;
        public double ObliczBmi()
        {
            return masa / (wzrost * wzrost);
        }

        public void Kategoria(double bmi)
        {
            //Funcja klasyfikuje stopień otyłości
            if (bmi < 16.0)
                Console.WriteLine("Jesteś wygłodzony!");
            else if (bmi >= 16.0 && bmi <= 16.99)
                Console.WriteLine("Jesteś wychudzony!");
            else if (bmi >= 17.0 && bmi <= 18.49)
                Console.WriteLine("Masz niedowagę!");
            else if (bmi >= 18.5 && bmi < +24.99)
                Console.WriteLine("Mieścisz się w normie!");
            else if (bmi >= 30.0 && bmi <= 34.99)
                Console.WriteLine("Masz I stopień otyłości");
            else if (bmi >= 35.0 && bmi <= 39.99)
                Console.WriteLine("Masz II stopień otyłości(otyłość kliniczna)");
            else if (bmi >= 40.0)
                Console.WriteLine("Masz III stopień otyłości(otyłość skrajna)");
        }

        public Bmi(int masa, double wzrost)
        {
            this.masa = masa;
            this.wzrost = wzrost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj ile ważysz w kg");
                int kg = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj twój wzrost w metrach");
                double mtr = Double.Parse(Console.ReadLine());

                Bmi o1 = new Bmi(kg, mtr);
                double wynik = o1.ObliczBmi();
                Console.WriteLine("BMI wynosi {0}", Math.Round(wynik, 2));

                o1.Kategoria(wynik);
            }
            catch
            {
                Console.WriteLine("Wprowadzono nieprawidłowe wartości!");
            }

            Console.ReadKey();

        }
    }
}
