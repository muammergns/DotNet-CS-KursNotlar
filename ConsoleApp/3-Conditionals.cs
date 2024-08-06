namespace KursApp
{
    public class Conditionals
    {
        public Conditionals(){
            int number = 1;
            if (number == 1)
            {
                Console.WriteLine("Number is 1");
                // if bloğu: number 1'e eşit olduğu için bu blok çalışır ve "Number is 1" yazdırılır.
            }

            int number2 = 1;
            if (number2 == 1)
            {
                Console.WriteLine("Number2 is 1");
                number2 = 2;
                // if bloğu: number2 1'e eşit olduğu için bu blok çalışır, "Number2 is 1" yazdırılır ve number2 değeri 2 olarak güncellenir.
            }
            if (number2 == 2)
            {
                Console.WriteLine("Number2 is 2");
                // if bloğu: number2 artık 2 olduğu için bu blok çalışır ve "Number2 is 2" yazdırılır.
            }

            int number3 = 1;
            if (number3 == 1)
            {
                Console.WriteLine("Number3 is 1");
                number3 = 2;
                // if bloğu: number3 1'e eşit olduğu için bu blok çalışır, "Number3 is 1" yazdırılır ve number3 değeri 2 olarak güncellenir.
            }
            else if (number3 == 2)
            {
                Console.WriteLine("Number3 is 2");
                // else if bloğu: İlk if bloğu çalıştığı için bu else if bloğu atlanır, yani çalışmaz.
            }

            int number4 = 2;
            if (number4 == 1)
            {
                Console.WriteLine("Number4 is 1");
                // if bloğu: number4 1'e eşit olmadığı için bu blok çalışmaz.
            }
            else
            {
                Console.WriteLine("Number4 is not 1");
                // else bloğu: if bloğu çalışmadığı için bu else bloğu çalışır ve "Number4 is not 1" yazdırılır.
            }

            int number5 = 3;
            if (number5 == 1)
            {
                Console.WriteLine("Number5 is 1");
                number5 = 2;
                // if bloğu: number5 1'e eşit olmadığı için bu blok çalışmaz.
            }
            else if (number5 == 2)
            {
                Console.WriteLine("Number5 is 2");
                // else if bloğu: number5 2'ye eşit olmadığı için bu blok çalışmaz.
            }
            else
            {
                Console.WriteLine("Number5 is not 1 or 2");
                // else bloğu: Önceki if ve else if blokları çalışmadığı için bu blok çalışır ve "Number5 is not 1 or 2" yazdırılır.
            }

            int number6 = 1;
            Console.WriteLine(number6 == 1 ? "Number6 is 1" : "Number6 is not 1");
            // Ternary if: number6 1'e eşit olduğu için "Number6 is 1" yazdırılır.

            int number7 = 2;
            Console.WriteLine(number7 == 1 ? "Number7 is 1" : number7 == 2 ? "Number7 is 2" : "Number7 is not 1 or 2");
            // Ternary if: number7 2'ye eşit olduğu için "Number7 is 2" yazdırılır.

            //TODO - operatörler eklenecek
            //TODO - switch case eklenecek
            

        }
    }
}