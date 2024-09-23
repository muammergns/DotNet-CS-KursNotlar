namespace KursApp
{
    public class Mathematics
    {
        public Mathematics()
        {
            Console.WriteLine("Matematik methodları:");
            AbsoluteValue(); // Bir sayının mutlak değerini döndürür.
            SquareRoot(); // Bir sayının karekökünü döndürür.
            Power(); // Bir sayının üssünü hesaplar.
            MaxValue(); // İki sayı arasından en büyüğünü döndürür.
            MinValue(); // İki sayı arasından en küçüğünü döndürür.
            PIValue();
            Sine();
            Cosine();
        }

        // Bir sayının mutlak değerini döndürür.
        void AbsoluteValue()
        {
            int number = -10;
            int absolute = Math.Abs(number);
            Console.WriteLine("Absolute value: " + absolute);  // Çıktı: 10
        }
        // Bir sayının karekökünü döndürür.
        void SquareRoot()
        {
            double number = 25;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square root: " + squareRoot);  // Çıktı: 5
        }
        // Bir sayının üssünü hesaplar.
        void Power()
        {
            double baseNumber = 2;
            double exponent = 3;
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine("Power: " + result);  // Çıktı: 8
        }
        // İki sayı arasından en büyüğünü döndürür.
        void MaxValue()
        {//NOTE - sadece 2 sayı ile kontrol yapar. Daha fazla sayı için array.Max() fonksiyonunu kullanın
            int a = 7;
            int b = 12;
            int max = Math.Max(a, b);
            Console.WriteLine("Max value: " + max);  // Çıktı: 12
        }
        // İki sayı arasından en küçüğünü döndürür.
        void MinValue()
        {//NOTE - sadece 2 sayı ile kontrol yapar. Daha fazla sayı için array.Min() fonksiyonunu kullanın
            int a = 7;
            int b = 12;
            int min = Math.Min(a, b);
            Console.WriteLine("Min value: " + min);  // Çıktı: 7
        }

        // pi sayısına direk ulaşmak için
        void PIValue()
        {
            Console.WriteLine($"PI value: {Math.PI}");
        }

        //C#'ta trigonometri fonksiyonları (Math.Sin, Math.Cos gibi) açıları radian cinsinden kabul eder. 
        void Sine()
        {
            double degree = 30;
            double angleInRadians = degree * (Math.PI / 180); // 30 derece
            double sineValue = Math.Sin(angleInRadians);
            Console.WriteLine("Sine: " + sineValue);  // Çıktı: 0.5
        }
        void Cosine()
        {
            double degree = 60;
            double angleInRadians = degree * (Math.PI / 180); // 60 derece
            double cosineValue = Math.Cos(angleInRadians);
            Console.WriteLine("Cosine: " + cosineValue);  // Çıktı: 0.5
        }

    }
    
}