
using System.Diagnostics.Metrics;

Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");

Console.WriteLine("-------------------------------------------------------");

    string metin = "Selamlar";
        int sayı = 18;
            Console.WriteLine($"{metin}\n{sayı}");


Console.WriteLine("-------------------------------------------------------");

  Random random = new Random();
    int randomNumber = random.Next(100);
        Console.WriteLine($"0 Ile 100 arasında rasgele bir sayı: {randomNumber}");


Console.WriteLine("-------------------------------------------------------");

    Random rasgele = new Random();
            int rastgeleSayı = random.Next(100);
                int kalan = rastgeleSayı % 3;
                    Console.WriteLine($"0 ile 100 arasındaki rasgele sayımız: {rastgeleSayı},\nbu sayının 3 e bölümünden kalan= {kalan}");

Console.WriteLine("-------------------------------------------------------");

         Console.Write("Lütfen yaşınızı giriniz: ");
              int yas = Convert.ToInt32(Console.ReadLine());

            if (yas < 18 )
            {
                Console.WriteLine("-");
                }
                    else
                    {
                            Console.WriteLine("+");
                            }


Console.WriteLine("-------------------------------------------------------");


               for (int i = 1; i <= 10; i++)
                        {
                             Console.WriteLine($"{i} - Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
                            }

Console.WriteLine("-------------------------------------------------------");


Console.Write("1- Lütfen Gülse Birsel yazınız:  ");
    string ılk = Console.ReadLine();

        Console.Write("2- Lütfen Demet Evgar yazınız: ");
                string ıkı = Console.ReadLine();

                    Console.WriteLine($"Sırası ile yazdıklarınız 1- {ılk} , 2- {ıkı}");

//temporary(geçici) boş bir değişken olmadan direkt bu değişimi yapamayız çünkü boşluk açılmadan yer değişimi mümkün değildir.
        string temp = ılk;
            ılk = ıkı;
                ıkı= temp;

                    Console.WriteLine($"Değiştirilen yazılar 1- {ılk}, 2- {ıkı}");

Console.WriteLine("-------------------------------------------------------");

BenDegerDondurmem();

        static void BenDegerDondurmem()
            {
                Console.WriteLine("Ben değer döndürmem,benim bir karşılığım yok , beni değişkene atamaya çalışma");
                    }

Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine(twoNumbersSum(3,5));
                    static int twoNumbersSum(int a, int b)
                        {
                            return a + b;
                                }

Console.WriteLine("-------------------------------------------------------");


            string userValue = RequestBooleanInput("Lütfen 'true' yada 'false' yazınız:");
                    Console.WriteLine($"Girdiğiniz değer String Olarak: {userValue}");

                    static string RequestBooleanInput(string prompt)
{
                        bool isValidInput = false;
                        bool userValue = false;

    
    while (!isValidInput)
             {
              Console.WriteLine(prompt);
                  string input = Console.ReadLine();

        
                 isValidInput = bool.TryParse(input, out userValue);
            
                                   if (!isValidInput)
                         {
                        Console.WriteLine("Geçersiz yazı lütfen tekrar deneyiniz!");
             }
    }

    return userValue.ToString();

}


Console.WriteLine("-------------------------------------------------------");


Console.Write("İlk Yaşı Giriniz: ");
int firstNumber = int.Parse(Console.ReadLine());

                Console.Write("İkinci Yaşı Giriniz: ");
                    int secondNumber = int.Parse(Console.ReadLine());

                        Console.Write("Üçüncü Yaşı Giriniz: ");
                            int thirdNumber = int.Parse(Console.ReadLine());

        int largestNumber = FindLargestNumber(firstNumber, secondNumber, thirdNumber);

Console.WriteLine($"Girdiğiniz En büyük Yaş: {largestNumber}");
    

    static int FindLargestNumber(int num1, int num2, int num3)
{
                 int largest = num1; 

                 if (num2 > largest)
                    {
                        largest = num2;
                              } 
                          if (num3 > largest)
                              {
                             largest = num3;
                                  }
                return largest;     
                }


Console.WriteLine("-------------------------------------------------------");

//12. soruda sınırsız sayıda input olacağı için girdileri liste yerleştirip içindeki en büyüğü geri döndürüyoruz


            int ınfınıtelargestNumber = ınfınıteFindLargestNumber();

                    Console.WriteLine($"Girdiğiniz birçok sayıdan en büyüğü : {ınfınıtelargestNumber}");
    

    
    static int ınfınıteFindLargestNumber()
{
                List<int> numbers = new List<int>();
                    string input;
                        int number;

    Console.WriteLine("Arzu ettiğiniz kadar sayı giriniz. Son sayıdan sonra 'done' yazınız:");

    while (true)
    {
                   Console.Write("sayı girin veya bitirmek için 'done' yazın : ");
                         input = Console.ReadLine();
    
        if (input.ToLower() == "done")
        {
                  break;
                  }

                        if (int.TryParse(input, out number))
                              {
                 numbers.Add(number);
                 }
                  else
                {
            Console.WriteLine("geçersiz sayı lütfen tam sayı giriniz.");
        }
    }

    if (numbers.Count == 0)
    {
        Console.WriteLine("Sayı girmediniz.");
        return 0; 
    }

    //bir dizi gezmemiz gerektiğinden foreach ile en büyük sayıyı rahatlıkla döndürebildik.

    int largest = numbers[0];
    foreach (int num in numbers)
    {
        if (num > largest)
        {
            largest = num;
        }
    }

    return largest;
}




Console.WriteLine("-------------------------------------------------------");



    Console.Write("1- İki değiştirilecek ismin ilkini yazınız :  ");
    string bırıncıString = Console.ReadLine();


    Console.Write("2-  iki değiştirilecek ismin ikincisini yazınız : ");
    string ıkıncıStrıng = Console.ReadLine();

//metotun içinde birşeyler değişip dışarı çıktığı için out u kullandım
SwapString (bırıncıString, ıkıncıStrıng, out string swappedFirstString, out string swappedSecondString);

Console.WriteLine($"Değiştirildikten sonraki hali:\nFirst string: {swappedFirstString}\nSecond string: {swappedSecondString}");

Console.WriteLine($"Sırası ile yazdıklarınız 1- {bırıncıString} , 2- {ıkıncıStrıng}");


static void SwapString(string str1, string str2, out string swappedStr1, out string swappedStr2)
{
   
    swappedStr1 = str2;
    swappedStr2 = str1;
}




Console.WriteLine("-------------------------------------------------------");



Console.WriteLine("Bir sayı giriniz:");
int number = int.Parse(Console.ReadLine());

// metotdu cagırıp boolen a eşitledim bu sadece true veya false çıkacak ekrana
bool isEven = IsEven(number);


Console.WriteLine($"Sayı {number} çift {isEven}");
    

    //çift ise true tek ise false dönecektir bool isEven
    static bool IsEven(int num)
{
   
    return num % 2 == 0;
}



Console.WriteLine("-------------------------------------------------------");


Console.Write("Lütfen hızınızı giriniz (km/h)  : ");
int hız =Convert.ToInt32(Console.ReadLine());

Console.Write(" Lütfen gittiğiniz zamanı dk olarak giriniz (dk)  : ");
int zaman = Convert.ToInt32(Console.ReadLine());

int gıdılenyol= roadCalculator(zaman,hız);


Console.Write($"Gittiğiniz yol = {gıdılenyol} km  ");

static int roadCalculator(int zaman,int hız)
{

    return zaman * hız;
}


Console.WriteLine("-------------------------------------------------------");


Console.WriteLine("Verilen bilgiler pi = 3.14 ve çevre = 5.0");
double pi = 3.14;
double cevre = 5.0;

double sonuc=radiusCalculator(pi, cevre);
Console.WriteLine(sonuc);

static double radiusCalculator(double pi,double cevre)

{ 
    return cevre / (2 * pi);
}


Console.WriteLine("-------------------------------------------------------");



string yazı = "Zaman bir GeRi SayIm";
string upperCaseText = yazı.ToUpper();
string lowerCaseText = yazı.ToLower();

Console.WriteLine(upperCaseText);

Console.WriteLine(lowerCaseText);


Console.WriteLine("--------------------------------------------------");

string text = "    Selamlar    ";
string trimmedText = text.Trim();

Console.WriteLine(trimmedText);




Console.WriteLine("--------------------------------------------------");