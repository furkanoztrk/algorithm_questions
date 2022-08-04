// ****** Algoritma Sorular *******

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.WriteLine("Lütfen Bir Pozitif Sayı Giriniz");
int pozitifsayi= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen n adet pozitif sayı giriniz");
int[] ndizi = new int[pozitifsayi];

for (int i = 0; i < pozitifsayi; i++)  // 
{
    ndizi[i] = Convert.ToInt32(Console.ReadLine());
}

methodlar ilksoru =new methodlar();
Console.WriteLine("Dizideki çift elemanlar: ");

for (int i = 0; i < pozitifsayi; i++)
{    
    if(ilksoru.isEven(ndizi[i]))
    Console.WriteLine(ndizi[i]);
}
//

//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

    /*
        Console.WriteLine("İki Adet Pozitif Tam Sayı Giriniz :");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen : "+ n + "Dizi Elamanlarını Giriniz :");
        int[] diziquest = new int[n];

        for(int i = 0;i < n;i++) // array elemanlarını aldık
        {
            diziquest[i]= Convert.ToInt32( Console.ReadLine());
        }
        methodlar twoquest = new methodlar();
        for (int i = 0; i < n; i++)
        {
            if (twoquest.Bolunebilir(diziquest[i],m))
            {
                Console.WriteLine("m Sayısına Eşit Yada Tam Bölünebilen"+diziquest[i]);
                
            }
        }
        */

////
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        Console.WriteLine("Lütfen Bir Pozitif Sayı Giriniz");
        int n =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen : " + n +" Adet Kelime Giriniz :");
        string[] kelime =new string[n];

        for(int i = 0 ;i < n; i++) // array elemanlarını aldık
        {
            kelime[i]=  Console.ReadLine();
        }
        for (int i = n-1; i >= 0; i--)              // Sondan Başa doğru aldık
        {
                    Console.WriteLine("Sondan Başa Doğru" + kelime[i]);     
        }

////
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
//Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        Console.WriteLine("Lütven Bir Cümle Giriniz");
        string cümle = Console.ReadLine();  

        string[] ayır = cümle.Split(' ');  // 
        foreach (var item in ayır)
        {
            Console.WriteLine(item);
        }
        
        int a = ayır.GetLength(0); // Arrayin Kaç Elamanlı olduğunu bulur
        Console.WriteLine("Bu Dizide :"+ a + " Kelime Mevcuttur");

        Console.WriteLine(cümle.RemoveWhiteSpaces());      //cümlede ki boşlukları sildik
        string cümle2 = cümle.RemoveWhiteSpaces();         //Cümle2 ye boşluksuz halini atadık

        int x = cümle2.Length;
        Console.WriteLine("Bu Cümle :" + x +" Karakter İçerir");
        

 class methodlar //yeni class oluşturdum
{
    public bool isEven ( int a)
    {
        return a %2 == 0;
    }
    public bool Bolunebilir ( int a, int b)
    {
        return a % b == 0;
    }
  
}

public static class extensions 
{
   public static string RemoveWhiteSpaces(this string param)// metindeki boşlukları siler
    {
        string[] dizi = param.Split(" ");  //bu stringi boşluklara göre ayır ve bir diziye at
        return string.Join("",dizi); // diziyi boşluksuz olarak birleştirir, istenen char eklenebilir ilk parametreye
    }
    
    }

