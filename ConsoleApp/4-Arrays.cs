namespace KursApp
{
    public class Arrays
    {
        public Arrays(){
            //değişken[] değişken adı = new değişken[dizi boyutu];
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Console.WriteLine(numbers[0]);//çıktısı "1" olacaktır.

            //değişken[] değişken adı = {dizinin elemanları,};
            int[] numbers2 = {1,2,3};
            Console.WriteLine(numbers2[0]);//çıktısı "1" olacaktır.

            //diziler(arrays) içerdiği eleman sayısı konusunda çok katıdır.

            //dizi oluşturulurken eleman sayısı belirtilmelidir,
            //eleman sayısının dışına çıkılırsa program çökecektir.
            //numbers[3] = 4; //çalıştırılırsa program çöker.

            //dizinin elemanları değişken ile uyumlu olmalıdır,
            //byte dizisi tanımlanıp int veri eklenemez.

            //diziler tekrar eden işlemlerde veri takibini kolaylaştırır.
            //örneğin 100 adet int veri tipinde değişken oluşturulması gerektiğinde,
            //değişkenleri oluşturmak, organize etmek ciddi vakit alacaktır.
            //diziler sayesinde değişkenler kolayca oluşturulur ve organize edilir.
            //NOTE - gelecek konu olan döngülerle birlikte bu kolaylık daha iyi anlaşılacaktır.

            //2 boyutlu dizi(2 den fazla da olabilir)
            int[,] sudoku = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            //çok boyutlu dizi oluşturmak için
            //değişken[,] değişkenin adı = new değişken[dizi boyutu1,dizi boyutu2];
            //değişken[,,] değişkenin adı = new değişken[dizi boyutu1,dizi boyutu2,dizi boyutu3];
            Console.WriteLine(sudoku[0,0]);//çıktısı "1" olacaktır.

            //diziler her türlü veri tipinde oluşturulabilir.
            object[] objects = new object[3];

            //dizilerin aynı zamanda bir çok fonksiyonu vardır.
            Console.WriteLine(objects.Length);//dizinin eleman sayısını verir.
            System.Array.Clear(objects);//tüm elemanları "0" olarak ayarlar.
            System.Array.Copy(numbers,objects,3);//numbers içindeki elemanları objects içine kopyalar.
            //LINK - https://learn.microsoft.com/tr-tr/dotnet/api/system.array?view=net-8.0
            //daha fazlası için linke bakabilirsiniz.
            //NOTE - aslında diziler System.Array kütüphanesi ile çalışır. Ezberlemeye gerek yok. Kullandıkça pekişir.
            //NOTE - diziler ile neler yapılabileceğini hatırlamak yeterlidir. Nasıl yapılacağı linkte detaylıca anlatılmıştır.


        }
    }
}