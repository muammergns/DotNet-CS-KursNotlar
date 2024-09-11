namespace KursApp
{
    //bir grup sabit değeri tam sayı değerleriyle eşleştirerek okunabilirliği ve
    //belirli değerler veya durumlar arasında seçim yapmayı kolaylaştırır.
    //Hatalı input almayı engeller.
    //varsayılan olarak sıfırdan başlar ve sıralı artar, istenirse farklı sayılar atanabilir.
    public enum Days{
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday = 10
    }
    public class Variables
    {
        public Variables(Days day){
            //veri tipleri veya değişkenler bellekte verilerin nasıl saklanacağını belirler.

            if (day == Days.Monday)
            {
                Print("Day",day);
            }

            Print("bool: true veya false değerini tutar.");
            bool isActive = true;
            Print("isActive",isActive);

            Print("byte: 0 ile 255 arasında tamsayı değeri tutar.");
            byte UnsignedInteger8Bit = 255;
            Print("UnsignedInteger8Bit",UnsignedInteger8Bit);

            Print("sbyte: -128 ile 127 arasında tamsayı değeri tutar.");
            sbyte SignedInteger8Bit = -128;
            Print("SignedInteger8Bit",SignedInteger8Bit);

            Print("char: Tek bir Unicode karakteri tutar.");
            char UnicodeChar8Bit = 'A';
            Print("UnicodeChar8Bit",UnicodeChar8Bit);

            Print("ushort: 0 ile 65,535 arasında pozitif tamsayı değeri tutar.");
            ushort UnsignedInteger16Bit = 65535;
            Print("UnsignedInteger16Bit",UnsignedInteger16Bit);

            Print("short: -32,768 ile 32,767 arasında tamsayı değeri tutar.");
            short SignedInteger16Bit = -32768;
            Print("SignedInteger16Bit",SignedInteger16Bit);

            Print("uint: 0 ile 4,294,967,295 arasında pozitif tamsayı değeri tutar.");
            uint UnsignedInteger32Bit = 4294967295;
            Print("UnsignedInteger32Bit",UnsignedInteger32Bit);

            Print("int: -2,147,483,648 ile 2,147,483,647 arasında tamsayı değeri tutar.");
            int SignedInteger32Bit = -2147483648;
            Print("SignedInteger32Bit",SignedInteger32Bit);

            Print("ulong: 0 ile 18,446,744,073,709,551,615 arasında pozitif tamsayı değeri tutar.");
            ulong UnsignedInteger64Bit = 18446744073709551615L;
            Print("UnsignedInteger64Bit",UnsignedInteger64Bit);

            Print("long: -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında tamsayı değeri tutar.");
            long SignedInteger64Bit = -9223372036854775808L;
            Print("SignedInteger64Bit",SignedInteger64Bit);

            Print("float: Tek hassasiyetli kayan nokta sayısı tutar.");
            float Decimal32Bit = -3.4028235E+38F;
            Print("Decimal32Bit",Decimal32Bit);

            Print("double: Çift hassasiyetli kayan nokta sayısı tutar.");
            double Decimal64Bit = -1.7976931348623157E+308;
            Print("Decimal64Bit",Decimal64Bit);

            Print("decimal: Yüksek hassasiyetli ondalık sayıları tutar, özellikle finansal hesaplamalar için kullanılır.");
            decimal Decimal128Bit = 79228162514264337593543950335M;
            Print("Decimal128Bit",Decimal128Bit);

        }

        public void Print(string description, object value){
            Console.WriteLine($"{description}: {value}");
        }
        public void Print(string description){
            Console.WriteLine();
            Console.WriteLine(description);
            Console.WriteLine("------------------------------");
        }
    }


    public class ObjectAndVar
    {
        public ObjectAndVar(){
            /*
                object: Türü belirtilen bir değişken türüdür. Tür dönüşümleri (casting) gerekebilir.
                var: Türü, atanan değere göre derleyici tarafından belirlenir.

                object: Herhangi bir türdeki veriyi saklayabilir, ancak tür dönüşümü yapılmadan doğrudan türüyle kullanılamaz.
                var: Tür güvenliğini korur ve tür dönüşümü gerektirmez, çünkü atandığı değerin türünü otomatik olarak belirler.

                object: Boxing ve unboxing işlemleri performans maliyetine neden olabilir.
                var: Tür dönüşümü gerektirmediğinden performans açısından avantajlıdır.

                object, geniş bir tür yelpazesi için kullanılabilecek bir genel veri türüdür.
                var ise tür çıkarımı yaparak kodunuzu daha temiz ve okunabilir hale getirir. 
                    Ancak, var'ı kullanırken değişken türünü anlamak için atanan değeri incelemek gerekebilir.

                Kişisel olarak object değer tipler ile, var referans tipler ile kullanımı avantajlı.
            */

            var number = 10;//doğru çalışacaktır.
            //number = 10.5f;//tür dönüşümü gerçekleştirilemez.
            var variable = new Variables(Days.Monday);//doğru çalışacaktır

            object number2= 10;//doğru çalışacaktır. Ayrıca kullanılmadı uyarısı vermez.
            number2 = 11.5f;//tür sonradan dönüştürüldü.
            //number = new Variables(Days.Monday);//referans tip atanabilir. ancak kullanılamaz. number.Print() çalışmayacaktır.

            variable.Print("Object ve Var farkı");
            variable.Print("object number",number);
            variable.Print("object number2",number2);
            //var için sınıf ve fonksiyonlar doğru şekilde kullanılabiliyor.
        }
    }
}