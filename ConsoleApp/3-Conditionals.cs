namespace KursApp
{
    public class Conditionals
    {
        /* Operators
        == Eşit ise
        >  Büyük ise
        <  Küçük ise
        >= Büyük veya Eşit ise
        <= Küçük veya Eşit ise
        <> Eşit değil ise

        Operatörlerin asıl olayı bir fonksiyon olmalarıdır.
        Bize boolean dönüş değeri verirler (true - false)
        if belirteci true değeri alırsa kodu işler, almazsa işlemez.
        ilerideki konularda işlenecek olan methodlara sorgu atmak içinde kullanılabilir.

        && ve
        || veya

        bir kodu çalıştırmak için birden fazla koşul gerekiyorsa ve - veya (&& - ||) belirteçleri kullanılır.
        */
        bool isSometingOk(){
            return true;
        }

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

            bool isActive = true;
            if (isActive)
            {
                //do someting...
            }

            if (isSometingOk())
            {
                //do someting...
            }

            if (isActive && isSometingOk())
            {
                // burada her iki koşulda sağlanmadan kod çalışmaz
            }

            if (isActive || isSometingOk())
            {
                // burada her iki koşuldan herhangi biri sağlansa bile kod çalışacaktır
            }

            bool isCond1 = false;
            bool isCond2 = false;
            bool isCond3 = false;

            if ((isCond1 || isCond2) && isCond3)
            {
                // birden fazla koşul ile işlem yapılırken koşulların net bir şekilde blirtilmesi gerekir.
                // bunun için parantez kullanımı çok önemlidir.
            }

            int number8 = 10;
            bool number8Status = number8 == 10;
            if (number8Status)
            {
                // burada karşılaştırma operatörlerinin aslında nasıl çalıştığı açıkça görülmektedir.
            }

            // alt alta her iki if bloğuda aynı işe yaramaktadır.
            int number9 = 10;
            if (number9 > 5 && number9 < 15)
            {
                
            }
            // if bloğunun bu şekilde kullanımının avantajı 
            // sadece 5'ten büyük olması koşulu içinde kod çalıştırmak gerekiyorsa
            // yukarıdaki if bloğu işimize yaramayacaktır.
            // bunun dışında yine ileride görülecek exeption sorununu da önler.
            // eğerki number9 < 15 karşılaştırma işlemi risk taşıyorsa bir ön koşul olarak
            // number9 > 5 eklemek exeption sorunlarını önleyebilir.
            if (number9 > 5)
            {
                if (number9 < 15)
                {
                    
                }
            }
        }

        // switch, enum ile birlikte daha okunaklı şekilde kullanılabilir.
        // bunun dışında aynı işlemler if kullanarak rahatça yapılabilir.
        // çokda önemli bir konu değil.
        public void DaysOfWeek(Days day){
            switch (day)
            {
                case Days.Monday:{
                    break;
                }  
                case Days.Tuesday:
                    return;
                case Days.Wednesday:
                    break;
                case Days.Thursday:
                    break;
                case Days.Friday:
                    break;
                case Days.Saturday:
                    break;
                case Days.Sunday:
                    break;
                default:
                    break;
            }
        }
    }
}