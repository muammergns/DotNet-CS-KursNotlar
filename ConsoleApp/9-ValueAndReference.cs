namespace KursApp
{
    public class ValueAndReference
    {
        public ValueAndReference(){

            
            int sayi1 = 1;
            int sayi2 = sayi1;
            sayi2 = 2;
            Console.WriteLine($"Sayı1:{sayi1} - Sayı2:{sayi2} değer tip");

            string text1 = "A";
            string text2 = text1;
            text2 = "B";
            Console.WriteLine($"Text1:{text1} - Text2:{text2} değer tip");

            String text3 = "A";
            String text4 = text3;
            text4 = "B"; 
            Console.WriteLine($"Text3:{text3} - Text4:{text4} değer tip");

            string text5 = new string("A");
            string text6 = text5;
            text6 = "B";
            Console.WriteLine($"Text5:{text5} - Text6:{text6} değer tip");
            //NOTE - string bilinenin aksine değer tip veridir.

            int[] sayilar1 = new int[1];
            sayilar1[0] = 1;
            int[] sayilar2 = sayilar1;
            sayilar1[0] = 10;
            ChangeNumber(sayilar2);
            Console.WriteLine($"Sayılar1:{sayilar1[0]} - Sayılar2:{sayilar2[0]} referans tip");

            object obj1 = 5;
            object obj2 = obj1;
            obj2 = 3;
            Console.WriteLine($"Obj1:{obj1} - Obj2:{obj2} değer tip");

            //string nesneleri değer tipli gibi hareket ederler. Bu tür davranan nesnelere immutable denir. 
            string value = "Hello World!";
            value.Replace("World", "Internet");
            Console.WriteLine(value);
            value = value.Replace("World", "Internet");
            Console.WriteLine(value);
            Console.ReadLine();

            //string str = null;
            //int say = null;
            //NOTE - string null atanabilirken int null atanamaz.

        }

        //NOTE - methodlar konusunda ref, out anahtar kelimeleri işlenirken değer ve referans tipin ne anlama geldiği daha iyi anlaşılacak.
        void ChangeNumber(int[] numbers){
            if (numbers.Length>0)
            {
                numbers[0]++;
            }
        }

        

    }
}