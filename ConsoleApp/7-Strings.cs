namespace KursApp
{
    public class Strings
    {
        public Strings()
        {
            Console.WriteLine("String methodları:");
            GetLength(); // Bir string'in uzunluğunu döndürür.
            FormatString(); // Bir dizeyi belirli bir biçimde biçimlendirir.
            FindIndexOfSubstring(); // Bir dize içinde belirli bir alt dizeyi arar ve ilk bulunduğu konumun indeksini döndürür.
            FindLastIndexOfSubstring(); // Bir dize içinde belirli bir alt dizeyi arar ve son bulunduğu konumun indeksini döndürür.
            InsertSubstring(); // Bir dizeye belirli bir konumda alt dize ekler.
            CheckEndsWith(); // Bir dize belirli bir alt dizeyle bitip bitmediğini kontrol eder.
            CheckStartsWith(); // Bir dize belirli bir alt dizeyle başlayıp başlamadığını kontrol eder.
        }

        // Bir string'in uzunluğunu döndürür.
        void GetLength()
        {
            string text = "Hello, world!";
            int length = text.Length;
            Console.WriteLine("Length: " + length);  // Çıktı: 13
        }
        // Bir dizeyi belirli bir biçimde biçimlendirir.
        void FormatString()
        {
            int number = 42;
            string formattedString = string.Format("The number is {0}", number);
            Console.WriteLine(formattedString);  // Çıktı: The number is 42
        }
        // Bir dize içinde belirli bir alt dizeyi arar ve ilk bulunduğu konumun indeksini döndürür.
        void FindIndexOfSubstring()
        {
            string text = "Hello, world!";
            int index = text.IndexOf("world");
            Console.WriteLine("Index of 'world': " + index);  // Çıktı: 7
        }
        // Bir dize içinde belirli bir alt dizeyi arar ve son bulunduğu konumun indeksini döndürür.
        void FindLastIndexOfSubstring()
        {
            string text = "Hello, world! World!";
            int lastIndex = text.LastIndexOf("World");
            Console.WriteLine("Last index of 'World': " + lastIndex);  // Çıktı: 14
        }
        // Bir dizeye belirli bir konumda alt dize ekler.
        void InsertSubstring()
        {
            string text = "Hello, !";
            string newText = text.Insert(7, "world");
            Console.WriteLine(newText);  // Çıktı: Hello, world!
        }
        // Bir dize belirli bir alt dizeyle bitip bitmediğini kontrol eder.
        void CheckEndsWith()
        {
            string text = "Hello, world!";
            bool endsWithWorld = text.EndsWith("world!");
            Console.WriteLine("Ends with 'world!': " + endsWithWorld);  // Çıktı: True
        }
        // Bir dize belirli bir alt dizeyle başlayıp başlamadığını kontrol eder.
        void CheckStartsWith()
        {
            string text = "Hello, world!";
            bool startsWithHello = text.StartsWith("Hello");
            Console.WriteLine("Starts with 'Hello': " + startsWithHello);  // Çıktı: True
        }
    }
    
}