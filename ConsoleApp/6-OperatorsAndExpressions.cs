namespace KursApp
{
/*
    Aritmetik Operatörler:
    +: İki değeri toplar.
    -: İki değeri çıkarır.
    *: İki değeri çarpar.
    /: İki değeri böler.
    %: İki değerin bölümünden kalanı döner.

    Atama Operatörleri:
    =: Bir değeri bir değişkene atar.
    +=: Bir değişkenin mevcut değerine bir değer ekler ve sonucu atar.
    -=: Bir değişkenin mevcut değerinden bir değer çıkarır ve sonucu atar.
    *=: Bir değişkenin mevcut değeri ile bir değeri çarpar ve sonucu atar.
    /=: Bir değişkenin mevcut değerini bir değere böler ve sonucu atar.
    %=: Bir değişkenin mevcut değerini bir değere bölüp kalanı atar.

    Karşılaştırma Operatörleri:
    ==: İki değerin eşit olup olmadığını kontrol eder.
    !=: İki değerin eşit olmadığını kontrol eder.
    >: Sol operandın sağ operanddan büyük olup olmadığını kontrol eder.
    <: Sol operandın sağ operanddan küçük olup olmadığını kontrol eder.
    >=: Sol operandın sağ operanddan büyük veya eşit olup olmadığını kontrol eder.
    <=: Sol operandın sağ operanddan küçük veya eşit olup olmadığını kontrol eder.

    Mantıksal Operatörler:
    &&: Tüm koşulların true olması durumunda true döner (ve).
    ||: Koşullardan birinin true olması durumunda true döner (veya).
    !: Koşulun tersini döner, true ise false yapar, false ise true yapar.

    Bit Düzeyinde Operatörler:
    &: İki operandın bit düzeyinde "ve" işlemini gerçekleştirir.
    |: İki operandın bit düzeyinde "veya" işlemini gerçekleştirir.
    ^: İki operandın bit düzeyinde "özel veya" (XOR) işlemini gerçekleştirir.
    ~: Bir operandın tüm bitlerini tersine çevirir.
    <<: Bir operandın bitlerini sola kaydırır.
    >>: Bir operandın bitlerini sağa kaydırır.

    Artırma ve Azaltma Operatörleri:
    ++: Bir değeri 1 artırır.
    --: Bir değeri 1 azaltır.

    Koşul Operatörü:
    ?:: Bir koşulun doğru olup olmadığını kontrol eder ve duruma göre iki değerden birini döner (ternary operatör).

    Tür Dönüşüm Operatörleri:
    (type): Belirtilen türe zorunlu dönüşüm yapar.
    as: Tür dönüştürmeye çalışır, başarısız olursa null döner.
    is: Bir nesnenin belirtilen türe ait olup olmadığını kontrol eder.

    Diğer Operatörler:
    []: Dizi elemanlarına erişmek için kullanılır.
    .: Nesne veya sınıf üyelerine erişmek için kullanılır.
    ->: İşaretçi kullanırken üyelere erişmek için kullanılır.
    ??: Eğer sol taraf null ise sağ tarafı döner.
    checked: Sayısal işlemlerde taşma durumlarını kontrol eder.
    unchecked: Sayısal işlemlerde taşma kontrolünü devre dışı bırakır.
    default: Bir değişkene varsayılan bir değer atar.
    nameof: Belirtilen değişkenin, yöntemin veya türün adını döner.
    sizeof: Bir türün bellek boyutunu döner.
    typeof: Bir türün meta verilerini döner.
    await: Bir async yöntemde asenkron bir işlemin sonucunu beklemek için kullanılır.
    yield: Bir iteratör yöntemi içinde değer döndürmek için kullanılır.
    =>: Anonim (isimsiz) bir fonksiyon tanımlamak için kullanılır.

    Kontrol Deyimleri:
    if: Belirtilen bir koşulun doğru olup olmadığını kontrol eder; doğruysa ilgili kod bloğunu çalıştırır.
    else: if koşulu yanlış olduğunda çalıştırılacak alternatif bir kod bloğunu belirtir.
    switch: Bir değişkenin değerine göre farklı kod bloklarının çalıştırılmasını sağlar.
    case: switch içinde her bir olası değeri temsil eder ve buna göre kod blokları ayrılır.
    default: switch yapısında hiçbir case ile eşleşmeyen durumlarda çalıştırılacak olan varsayılan kod bloğunu tanımlar.
    do: En az bir kere çalışacak bir döngü oluşturur ve her tekrardan sonra koşul kontrol edilir (while ile birlikte kullanılır).
    for: Sayısı belli olan döngüleri tekrarlamak için kullanılır; genellikle sayaçla birlikte çalışır.
    foreach: Koleksiyonlar veya dizilerdeki her bir elemanı döngüyle işlemek için kullanılır.
    while: Koşul doğru olduğu sürece döngüyü tekrarlar, döngü sayısının önceden bilinmediği durumlarda tercih edilir.
    break: Döngü veya switch yapısını anında sonlandırır.
    continue: Bir döngünün o anki iterasyonunu sonlandırır ve döngünün bir sonraki iterasyonuna geçer.
    goto: Program akışını, belirtilen etikete atlamak için kullanılır (nadiren önerilir).
    return: Bir metodun çalışmasını sonlandırır ve isteğe bağlı olarak bir değer döndürür.
    yield: Bir iteratör metodunda, geçici olarak bir değer döndürmek ve metodu sonraki çağrıda kaldığı yerden devam ettirmek için kullanılır.

    Erişim Belirleyiciler:
    public: Her yerden erişilebilen üyeleri belirtir.
    private: Sadece tanımlandığı sınıf içinde erişilebilen üyeleri belirtir.
    protected: Yalnızca tanımlandığı sınıf ve ondan türeyen sınıflardan erişilebilen üyeleri belirtir.
    internal: Sadece aynı derleme (assembly) içinde erişilebilen üyeleri belirtir.
    
    //TODO - kurs sonunda eksik kalanlar için tekrar edilecek
    Diğer Anahtar Kelimeler:
    abstract: Soyut bir sınıf veya yöntem, doğrudan örneklenemez ve alt sınıflar tarafından miras alınabilir.
    as: Tür dönüşümü yapmak için kullanılır, dönüşüm başarısız olursa null döner.
    base: Taban sınıfın üyelerine erişmek veya onları çağırmak için kullanılır.
    catch: try bloğunda meydana gelen istisnaları yakalamak için kullanılır.
    checked: Sayısal işlemler sırasında taşma (overflow) durumlarını kontrol eder.
    class: Bir nesne yönelimli programlama yapısında sınıf tanımlamak için kullanılır.
    const: Derleme zamanında sabit olan ve değiştirilemeyen bir değeri belirtir.
    delegate: Bir yöntemi temsil eden türleri tanımlamak için kullanılır.
    enum: Sabit değerlerin bir listesini tanımlamak için kullanılır.
    event: Delege türünde olayları tanımlamak için kullanılır.
    explicit: Tür dönüşümlerini yalnızca açıkça belirtildiğinde yapmayı zorunlu kılar.
    extern: Bir yöntemin veya değişkenin başka bir dosyada veya dış kaynakta tanımlandığını belirtir.
    finally: try-catch bloğundan sonra her durumda çalıştırılan kod bloğunu tanımlar.
    fixed: Belirli bir değişkenin bellek adresini sabitlemek için kullanılır, genelde unsafe kodda.
    implicit: Tür dönüşümlerinin otomatik olarak yapılmasını sağlar.
    in: Parametreleri yalnızca içeriye doğru geçiren bir yöntem parametre modifikasyonudur.
    interface: Bir sınıfın uygulaması gereken yöntem ve özellikleri tanımlayan bir yapıdır.
    is: Bir nesnenin belirli bir türe sahip olup olmadığını kontrol eder.
    lock: Çoklu iş parçacığı erişiminde bir kaynağın güvenli hale getirilmesi için kullanılır.
    namespace: Kodun mantıksal gruplar halinde düzenlenmesi için kullanılır.
    new: Bellekte yeni bir nesne oluşturmak için kullanılır veya bir üyenin temel sınıftaki üye ile aynı isme sahip olduğunu belirtir.
    null: Boş bir referansı temsil eder, yani bir nesneyi işaret etmez.
    operator: Sınıflar için özel operatör tanımlamak amacıyla kullanılır.
    out: Bir yöntemin, parametrelerin dışında veri döndürmesini sağlar.
    override: Taban sınıftan gelen bir yöntemi geçersiz kılmak için kullanılır.
    params: Değişken sayıda parametre alan bir yöntemi belirtir.
    readonly: Bir alanın yalnızca okunabilir olduğunu belirtir ve bu alanın değeri yalnızca tanımlandığı yerde veya bir yapıcıda değiştirilebilir.
    ref: Bir yönteme parametre olarak bir referansın geçirilmesini sağlar.
    sealed: Bir sınıfın veya yöntemin daha fazla türetilmesini engeller.
    sizeof: Bir türün bellek boyutunu döndürür.
    stackalloc: Yığın üzerinde bellek ayırmak için kullanılır.
    static: Bir sınıfın örnekleri olmadan erişilebilecek üyeleri belirtir.
    struct: Değer türünde bir veri yapısını tanımlamak için kullanılır.
    this: Geçerli örneği temsil eder, genellikle örnek alanlarına veya yöntemlerine erişmek için kullanılır.
    throw: Bir istisna fırlatmak için kullanılır.
    try: Potansiyel olarak istisna fırlatabilecek bir kod bloğunu tanımlar.
    typeof: Bir türün meta verilerini elde etmek için kullanılır.
    unchecked: Taşma kontrolü yapılmadan sayısal işlemlerin gerçekleştirilmesini sağlar.
    unsafe: Güvenli olmayan kod bloğu tanımlar, genellikle işaretçiler ile çalışmak için kullanılır.
    using: Bir ad alanı veya kaynağın kapsamını belirtmek için kullanılır.
    virtual: Bir taban sınıfta geçersiz kılınabilecek bir yöntemi belirtir.
    void: Geri dönüş değeri olmayan bir yöntemi tanımlar.
    volatile: Bir alanın birden çok iş parçacığı tarafından değiştirilip okunabileceğini belirtir, bu yüzden optimize edilmeden her seferinde bellekten okunur.

*/

    public class OperatorsAndExpressions
    {
        //NOTE - Detaylı bilgi için
        //LINK - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
        public OperatorsAndExpressions(){
            Func1();
            Console.WriteLine("Bit Düzeyinde İşlemler:");
            BitwiseAnd();         // Bit düzeyinde VE işlemi (&)
            BitwiseOr();          // Bit düzeyinde VEYA işlemi (|)
            BitwiseXor();         // Bit düzeyinde XOR işlemi (^)
            BitwiseNot();         // Bit düzeyinde NOT işlemi (~)
            BitwiseLeftShift();   // Bitlerin sola kaydırılması (<<)
            BitwiseRightShift();  // Bitlerin sağa kaydırılması (>>)
            Console.WriteLine();

            Console.WriteLine("Diğer Operatörler ve İfadeler:");
            NullCoalescing();       // Eğer değer null ise belirtilen değeri döner (null-coalescing operator ??)
            CheckedOverflow();   // Sayısal işlemlerde taşma durumlarını kontrol eder (checked)
            UncheckedOverflow();    // Sayısal işlemlerde taşma kontrolünü devre dışı bırakır (unchecked)
            DefaultValue();         // Bir değişkene varsayılan bir değer atar (default)
            NameOfOperator();       // Belirtilen değişkenin, yöntemin veya türün adını döner (nameof)
            SizeOfOperator();       // Bir türün bellek boyutunu döner (sizeof)
            TypeOfOperator();       // Bir türün meta verilerini döner (typeof)
            TypeCastingExample();   // Bu yöntemle belirtilen türe zorunlu dönüşüm yapılır. Eğer dönüşüm başarısız olursa, çalışma zamanı hatası (exception) fırlatılır.
            CheckTypeUsingIs("Merhaba"); // is operatörü, bir nesnenin belirtilen türde olup olmadığını kontrol eder ve başarılıysa aynı anda tür dönüşümünü gerçekleştirir.
            CheckTypeUsingIs(12);
            
            CheckTypeUsingAs("Merhaba");// as operatörü, bir nesneyi belirtilen türe dönüştürmeye çalışır ve dönüşüm başarısızsa null döner.
            CheckTypeUsingAs(12);
            Console.WriteLine();
            
            Console.WriteLine("Kontrol Deyimleri:");
            BreakOperator();        // Döngü veya switch yapısını anında sonlandırır
            ContinueOperator();     // Bir döngünün o anki adımı sonlandırır ve döngünün bir sonraki adımına(iterasyonuna) geçer
            Console.WriteLine();
        }
        void Func1(){//Artırma ve Azaltma Operatörleri önce veya sonra kullanmanın etkileri
            int number=5;
            Console.WriteLine(number++);//5
            Console.WriteLine(number);//6
            Console.WriteLine(++number);//7
            Console.WriteLine(number);//7
        }

        // Bit düzeyinde VE işlemi (&)
        void BitwiseAnd()
        {
            int a = 5; // 0b0101 (binary)
            int b = 3; // 0b0011 (binary)
            // a ve b'nin her bitinin VE işlemi yapılır. 
            // Sadece her iki bit de 1 ise sonuç 1 olur.
            int result = a & b;
            Console.WriteLine("Bit düzeyinde VE işlemi (&)");
            Console.WriteLine("Bitwise AND: " + result);  // Çıktı: 0b0001
        }

        // Bit düzeyinde VEYA işlemi (|)
        void BitwiseOr()
        {
            int a = 5; // 0b0101 (binary)
            int b = 3; // 0b0011 (binary)
            // a ve b'nin her bitinin VEYA işlemi yapılır.
            // Herhangi bir bit 1 ise sonuç 1 olur.
            int result = a | b;
            Console.WriteLine("Bit düzeyinde VEYA işlemi (|)");
            Console.WriteLine("Bitwise OR: " + result);  // Çıktı: 0b0111
        }

        // Bit düzeyinde XOR işlemi (^)
        void BitwiseXor()
        {
            int a = 5; // 0b0101 (binary)
            int b = 3; // 0b0011 (binary)
            // a ve b'nin her bitinin XOR işlemi yapılır.
            // Eğer bitler farklıysa sonuç 1, aynıysa 0 olur.
            int result = a ^ b;
            Console.WriteLine("Bit düzeyinde XOR işlemi (^)");
            Console.WriteLine("Bitwise XOR: " + result);  // Çıktı: 0b0110
        }

        // Bit düzeyinde NOT işlemi (~)
        void BitwiseNot()
        {
            int a = 5; // 0b0101 (binary)
            // a'nın bitleri ters çevrilir.
            // 1 olan bitler 0, 0 olan bitler 1 olur. Sonuç negatif bir sayı olur.
            int result = ~a;
            Console.WriteLine("Bit düzeyinde NOT işlemi (~)");
            Console.WriteLine("Bitwise NOT: " + result);  // Çıktı: 0b1010
        }

        // Bitlerin sola kaydırılması (<<)
        void BitwiseLeftShift()
        {
            int a = 5; // 0b0101 (binary)
            // a'nın bitleri 1 bit sola kaydırılır.
            // Bu işlem, sayıyı 2 ile çarpmak anlamına gelir.
            int result = a << 1;
            Console.WriteLine("Bitlerin sola kaydırılması (<<)");
            Console.WriteLine("Bitwise Left Shift: " + result);  // Çıktı: 0b1010
        }

        // Bitlerin sağa kaydırılması (>>)
        void BitwiseRightShift()
        {
            int a = 5; // 0b0101 (binary)
            // a'nın bitleri 1 bit sağa kaydırılır.
            // Bu işlem, sayıyı 2'ye bölmek anlamına gelir.
            int result = a >> 1;
            Console.WriteLine("Bitlerin sağa kaydırılması (>>)");
            Console.WriteLine("Bitwise Right Shift: " + result);  // Çıktı: 0b0010
        }

        // Eğer sol taraf null ise sağ tarafı döner (null-coalescing operator ??)
        void NullCoalescing()
        {
            string? str = null; // Nullable string
            string result = str ?? "Default Value"; // str null ise "Default Value" döner.
            Console.WriteLine("Değerin NULL olması durumunda atama yapma:");
            Console.WriteLine("Result: " + result);  // Çıktı: Default Value
        }

        // Sayısal işlemlerde taşma durumlarını kontrol eder (checked)
        // Eğer checked veya unchecked kullanılmazsa varsayılan olarak debug sırasında checked, release sırasında unchecked şeklinde davranır.
        void CheckedOverflow()
        {
            int maxValue = int.MaxValue;
            // Taşma hatası olabilecek bir işlem
            try
            {
                Console.Write("Checked Overflow:"); // Çıktı: Overflow Exception caught: Arithmetic operation resulted in an overflow.
                int result = checked(maxValue + 1); // Taşma hatası meydana gelir
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Sayısal işlemlerde taşma kontrolünü devre dışı bırakır (unchecked)
        void UncheckedOverflow()
        {
            int maxValue = int.MaxValue;
            int result = unchecked(maxValue + 1); // Taşma kontrolü devre dışı
            Console.Write("Kontrol Edilmemiş Taşıma:");
            Console.WriteLine("Result: " + result);  // Çıktı: -2147483648 (taşma sonucunda)
        }

        // Bir değişkene varsayılan bir değer atar (default)
        void DefaultValue()
        {
            int defaultValue = default; // int için varsayılan değer 0'dır
            Console.Write("Varsayılan Değer Atama:");
            Console.WriteLine("Default Value: " + defaultValue);  // Çıktı: 0
        }

        // Belirtilen değişkenin, yöntemin veya türün adını döner (nameof)
        void NameOfOperator()
        {
            string variableName = nameof(NameOfOperator); // Yöntemin adı döner
            Console.Write("Operatörün Adı:");
            Console.WriteLine("Method Name: " + variableName);  // Çıktı: NameOfOperator
        }

        // Bir türün byte adeti bellek boyutunu döner (sizeof)
        void SizeOfOperator()
        {
            int size = sizeof(int); // int türünün bellek boyutu (4 byte)
            Console.Write("Operatör Boyutu:");
            Console.WriteLine("Size of int: " + size + " bytes");  // Çıktı: 4 bytes
        }

        // Bir türün meta verilerini döner (typeof)
        void TypeOfOperator()
        {
            Type type = typeof(int); // int türünün meta verileri
            Console.Write("Türün Mera Verisi:");
            Console.WriteLine("Type of int: " + type);  // Çıktı: System.Int32
        }
        // Bu yöntemle belirtilen türe zorunlu dönüşüm yapılır. Eğer dönüşüm başarısız olursa, çalışma zamanı hatası (exception) fırlatılır. 
        void TypeCastingExample()
        {
            object obj = 42; // obj tipinde bir integer değer
            int num = (int)obj; // Zorunlu tür dönüşümü (int tipine dönüştürülüyor)
            Console.WriteLine(num); // 42
        }
        // is operatörü, bir nesnenin belirtilen türde olup olmadığını kontrol eder ve başarılıysa aynı anda tür dönüşümünü gerçekleştirir.
        void CheckTypeUsingIs(object obj)
        {
            if (obj is string str) 
            {
                Console.WriteLine($"Bu bir string: {str}");
            }
            else
            {
                Console.WriteLine($"Bu bir string değil: {obj}");
            }
        }


        // as operatörü, bir nesneyi belirtilen türe dönüştürmeye çalışır ve dönüşüm başarısızsa null döner.
        void CheckTypeUsingAs(object obj)
        {
            string? str = obj as string;

            if (str != null)
            {
                Console.WriteLine("Dönüştürme başarılı: " + str);
            }
            else
            {
                Console.WriteLine($"Dönüştürme başarısız. {obj}");
            }
        }
         // Döngü veya switch yapısını anında sonlandırır (break)
         void BreakOperator()
        {
            Console.WriteLine("Break Operator:");
            
            // Basit bir döngü örneği
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    // i 5 olduğunda döngüyü kırar
                    Console.WriteLine("Break at i = " + i);
                    break;
                }
                Console.WriteLine("i = " + i);
            }
        }

        // Bir döngünün o anki adımını sonlandırır ve döngünün bir sonraki adımına geçer (continue)
        void ContinueOperator()
        {
            Console.WriteLine("Continue Operator:");
            
            // Basit bir döngü örneği
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    // i çift olduğunda bu adımı atlar ve döngünün bir sonraki iterasyonuna geçer
                    continue;
                }
                Console.WriteLine("i = " + i);
            }
        }
    }
}