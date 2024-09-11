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

    #Bit Düzeyinde Operatörler:
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

    #Tür Dönüşüm Operatörleri:
    (type): Belirtilen türe zorunlu dönüşüm yapar.
    as: Tür dönüştürmeye çalışır, başarısız olursa null döner.
    is: Bir nesnenin belirtilen türe ait olup olmadığını kontrol eder.

    Diğer Operatörler:
    []: Dizi elemanlarına erişmek için kullanılır.
    .: Nesne veya sınıf üyelerine erişmek için kullanılır.
    #->: İşaretçi kullanırken üyelere erişmek için kullanılır.
    #??: Eğer sol taraf null ise sağ tarafı döner.
    #checked: Sayısal işlemlerde taşma durumlarını kontrol eder.
    #unchecked: Sayısal işlemlerde taşma kontrolünü devre dışı bırakır.
    #default: Bir değişkene varsayılan bir değer atar.
    #nameof: Belirtilen değişkenin, yöntemin veya türün adını döner.
    #sizeof: Bir türün bellek boyutunu döner.
    #typeof: Bir türün meta verilerini döner.
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
    #break: Döngü veya switch yapısını anında sonlandırır.
    #continue: Bir döngünün o anki iterasyonunu sonlandırır ve döngünün bir sonraki iterasyonuna geçer.
    goto: Program akışını, belirtilen etikete atlamak için kullanılır (nadiren önerilir).
    return: Bir metodun çalışmasını sonlandırır ve isteğe bağlı olarak bir değer döndürür.
    yield: Bir iteratör metodunda, geçici olarak bir değer döndürmek ve metodu sonraki çağrıda kaldığı yerden devam ettirmek için kullanılır.

    Erişim Belirleyiciler:
    public: Her yerden erişilebilen üyeleri belirtir.
    private: Sadece tanımlandığı sınıf içinde erişilebilen üyeleri belirtir.
    protected: Yalnızca tanımlandığı sınıf ve ondan türeyen sınıflardan erişilebilen üyeleri belirtir.
    internal: Sadece aynı derleme (assembly) içinde erişilebilen üyeleri belirtir.
    
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
        public OperatorsAndExpressions(){
            Func1();
        }
        void Func1(){//Artırma ve Azaltma Operatörleri
            int number=5;
            Console.WriteLine(number++);//5
            Console.WriteLine(number);//6
            Console.WriteLine(++number);//7
            Console.WriteLine(number);//7
        }
    }

    
}