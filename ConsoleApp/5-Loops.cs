namespace KursApp
{
    public class Loops
    {
        //NOTE - Tekrar eden işlemler ve dizilerde kullanılır.
        int[] numbers = new int[10];
        public Loops()
        {
            ForLoop();
            ForeachLoop();
            WhileLoop();
            DoWhileLoop();
        }

        void ForLoop()
        {//Daha çok matematiksel tekrar eden işlemlerde kullanılır
            //Gelecekte operatörler konusu işlenirken bu detaylandırılacak.
            Console.WriteLine("For Loop");
            for (int i = 0; i < 10; i++)
            {//ilk çalıştırmada int i = 0; çalışır.
                //i < 10 koşulu karşılıyorsa for içine girer. 
                //bizden boolean koşul ister. True olduğu sürece döngü tekrarlanır.
                Console.WriteLine(i);//koşul karşılandığı sürece kod çalışır.
                numbers[i] = i;//numbers dizisinin her bir elemanına numara atanır.
                //sonunda i++ çalıştırılır.
            }
            Console.WriteLine();
        }

        void ForeachLoop()
        {
            Console.WriteLine("Foreach Loop");
            foreach (var item in numbers)
            {//numara belirtmeden diziler içinde kolayca dolaşmak için sıkça kullanılır. 
                //Kod okunurluğunu kolaylaştırır.
                //Daha çok referans tipler ile kullanılır. Gelecekte bu konu işlenecek.
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        void WhileLoop()
        {
            Console.WriteLine("While Loop");
            //öncelikle for ile yapılabilen tüm işler while ile de yapılabilir.
            //for'un sonsuz döngüye girmesi için fazladan çaba gerekir.
            //ama while döngüsünde yapılacak en ufak hata sonsuz döngüye sokabilir.
            //bu yüzden while döngüsü pek kullanılmaz.

            /* döngü sayısı belli değilse while kullanımı daha uygundur.
                örneğin dizinin elemanlarını rastgele sayılarla doldurmak istiyorsak ve
                kullanılan bir sayıyı tekrar kullanmak istemiyorsak (sudoku algoritması)
                while döngüsü elzemdir.
                ilerleyen konularda buna değinilecek.
            */
            //bizden boolean koşul ister. True olduğu sürece döngü tekrarlanır.
            int i = 10;
            while (i>0)
            {
                Console.WriteLine(i);
                i--;
            }
            //birebir for loop gibi kullandık.
            Console.WriteLine();
        }

        void DoWhileLoop()
        {//dowhile döngüsünde koşul karşılanmasa bile kodlar 1 defa çalışır.
            //bu işlem for döngüsü ile de kolayca yapılabilir.
            //ancak kod okunurluğunu zorlaştırır. açıklama yapmak gerekir.
            //ama aşağıdaki kod çalışma prensibi gereği açıklamaya yer bırakmaz.
            //hem güvenli hem anlaşılır.
            int index = 11;
            do
            {
                numbers[0] = 10;
                if (index<10)
                {
                    numbers[index] = index*2;
                }
                index++;
            } while (index < 10);

            /* ChatGPT örneği
            Bir uygulamada kullanıcıdan geçerli bir şifre girmesini isteyen bir durum düşünelim. 
            Kullanıcı, şifreyi doğru girene kadar tekrar tekrar şifre girmesi istenecektir. 
            Bu durumda, do-while döngüsü uygun bir çözüm olacaktır çünkü kullanıcı en az bir kez şifreyi girmek zorundadır.

            string correctPassword = "12345";
            string userInput;

            do
            {
                Console.Write("Şifreyi girin: ");
                userInput = Console.ReadLine();
                
                if (userInput != correctPassword)
                {
                    Console.WriteLine("Yanlış şifre, tekrar deneyin.");
                }
            } while (userInput != correctPassword);

            Console.WriteLine("Giriş başarılı!");
            
            */
        }
    }
}