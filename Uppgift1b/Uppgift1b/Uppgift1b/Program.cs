using System;

namespace Uppgift1b
{
    class Program
    {

        //Lös uppgifterna som står i kommentarerna.
        //All kod ska ligga inne i Main-funktionen nedan.
        //Tips: Lägg en Console.Readline längst ner i Main-funktionen så att inte konsolen 
        //stängs direkt.
        static void Main(string[] args)
        {
            //Variabel deklarationer.
            //Inga variabler förutom dessa ska användas.
            //Man får inte ändra på typerna av dessa variabler.
            int i, tal1, tal2;
            long l;
            decimal d;
            float f;
            bool b;
            string sant, input1, input2;


            //1. tilldela variabel i värdet 10
            //Kod här

            i = 10;
            Console.WriteLine("tilldela variabel i värdet 10");
            Console.WriteLine(i);

            Console.ReadKey();

            //2. Använd implicit konvertering för att tilldela variabel "l" värdet av "i"
            //Kod här

            l = i;

            Console.WriteLine("använd implicit konvertering för att tilldela variabel 1 värdet av i", l);
            Console.WriteLine(l);
            Console.ReadKey();

            //3. Addera 1 till variabeln "l" mha inkrement operatorn.
            //Kod här

            l = l + 1;

            Console.WriteLine("Addera l till variabeln 1 mha inkrement operatorn", l);
            Console.WriteLine(l);
            Console.ReadKey();


            //4. Använd compound assignment för att multiplicera värdet av variabel "l" med 2
            //Kod här

            l *= 2;
            Console.WriteLine(" Använd compound assignment för att multiplicera värdet av variabel 'l' med 2", l);
            Console.WriteLine(l);
            Console.ReadKey();

            //5. Avänd explicit konvertering för att tilldela variabel "i" värdet av "l"
            //Kod här
            i = (int)l;
            Console.WriteLine("Avänd explicit konvertering för att tilldela variabel 'i' värdet av 'l'", i);
            Console.WriteLine(i);
            Console.ReadKey();

            //6. Skriv ut värdet av variabeln i konsolen. Talet 22 bör skrivas ut
            //Kod här
            Console.WriteLine("Skriv ut värdet av variabeln i konsolen. Talet 22 bör skrivas ut");
            Console.WriteLine(i);
            Console.ReadKey();
            //7. Tilldela variabeln "f" värdet 3.14
            //Kod här

            f = 3.14f;
            Console.WriteLine("Tilldela variabeln 'f' värdet 3.14");
            Console.WriteLine(f);
            Console.ReadKey();
            //8. Använd explicit konvertering för att tilldela variabeln "d" värdet av variabeln "f"
            //Kod här

            d = (decimal)f;
            f = (float)d;

            Console.WriteLine("Använd explicit konvertering för att tilldela variabeln 'd' värdet av variabeln 'f'", d);
            Console.WriteLine(d);
            Console.ReadKey();
            //9. Använd dekrement operatorn för att subtrahera värdet av "d" med 1
            //Kod här
            d--;
            Console.WriteLine(" Använd dekrement operatorn för att subtrahera värdet av 'd' med 1", d);
            Console.WriteLine(d);
            Console.ReadKey();
            //10. Använd compound assignment för att multiplicera värdet av variabel "d" med 3
            //Kod här
            d *= 3;

           
           Console.WriteLine("Använd compound assignment för att multiplicera värdet av variabel 'd' med 3", d); ;
            Console.WriteLine(d);
            Console.ReadKey();
            //11. Använd explicit konvertering för att tilldela "i" värdet av "d" modulo 5 (restvärdet)
            //Kod här
            i = (int)d;
            i = (int)(i % 5);
           

            //12. Skriv ut värdet av "i" i konsolen. Bör vara 1.
            //Kod här
            Console.WriteLine(i);


            //13. Tilldela variabeln "sant" värdet true som en sträng
            //Kod här
            sant = "true";

            //14. Använd en hjälp klass för att konvertera 
            //och tilldela variabeln "b" värdet av variabeln "sant"
            //Kod här

            b = false;
            sant = Convert.ToString(b);


            //15. Sätt variabel "b":s värde till falskt
            //Kod här
            b = false;

            //16. Använd en hjälp klass för att konvertera 
            //och tilldela variabeln "sant" värdet av variabeln "b"
            //Kod här

            b = Convert.ToBoolean(sant);

            //17. Skriv ut värdet av variabeln "sant" i konsolen. Bör vara False.
            //Kod här
            Console.WriteLine(sant);

            //18. Skriv ut till konsolen texten: Ange ett heltal:
            //Kod här
            Console.WriteLine("Ange ett heltal:");

            //19. Läs in ett heltal från konsolen tilldela värdet till variabel "input1"
            //Kod här
            input1 = Console.ReadLine();



            //20. Skriv ut till konsolen texten: Ange ett annat heltal:
            //Kod här
            Console.WriteLine("Ange ett annat heltal:");

            //21. Läs in ett annat heltal från konsolen tilldela värdet till variabel "input2"
            //Kod här
            input2 = Console.ReadLine();

            //22. Använd datatypen ints Parse funktion för att konvertera och tilldela
            //värdet av "input1" till variabeln "tal1"
            //Kod här

            tal1 = int.Parse(input1);

            //23. Använd datatypen ints Parse funktion för att konvertera och tilldela 
            //värdet av "input2" till variabeln "tal2"
            //Kod här
            tal2 = int.Parse(input2);


            //24. På en kod-rad skriv ut i konsolen mha string interpolation resultatet man 
            //får av att multiplicera "tal1" och "tal2" med varandra.
            //Exempel: Givet att "tal1" = 2 och "tal2" = 10 ska det skrivas ut i konsolen:
            //Produkten av talen 2 och 10 är: 20
            //Kod här

            int resualt = tal1 * tal2;

            Console.Write($"Produkten av talen {tal1} och {tal2} är: " + resualt);

        }
    }
}
