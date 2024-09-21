// See https://aka.ms/new-console-template for more information


// Döngü :  Verilen şart sağlanmadığı sürece, belirli kod bloklarını 
//şart sağlanana kadar çalıştıran yapılardır
// Döngü Çesitleri :
// For döngüsü
// Forech Döngüsü
// do while

// koşul 
// a satir
// b satir
// c satir

// For Döngüsü : 

// Syntax

// for(int i = 0;i<100;i++)
//{

//}

// Örnek : 
/*for(int i = 0; i <= 100;i++)
{
    Console.WriteLine(i);
    
}
*/

// Örnek 
// 1 den 100 e kadar 5 er 5 er ekrana yazdıralım


/*for (int i=0;i<1000;i+=5){

Console.WriteLine(i);
}
*/

// Örnek : 
// For döngüsünü tersten çevirebilir miyiz ?
// 1000'den 0'a tersten döndürelim

/*for (int i = 1000; i > 0 ; i--)
{
    Console.WriteLine(i);
}
*/

// i değeri her zaman 0 dan başlamak zorunda değildir.

// 10 dan yüze kadar sayıları ekrana yazdıralım

/*for(int i=10;i<100;i++){

}
*/


// Hiç bir koşul ve artış verilmeden döngü tanımlanabilir
/*int a = 10;
for(;;){

    // bu döngüye sonsuz döngü denir.
    a++;
    Console.WriteLine(a);
}
*/

// Farklı bir yazım şekli


/*int a;
int b =0;
for(a=20;a<100;){
    //a++;
    Console.WriteLine(a);

    b++;
    // sonsuz adet 20 olur
    Console.WriteLine(b);
}
*/
// dönen bir döngüyü durdurma!!
// iki yöntem var
// 1- kaçış keywordleri ile(break-contiune,return)
// 2- mevcut koşuşu bozarak döngüden dışarı çıkılabilir
/*for(int i=10;i<100;i++){
    // bu göndü 10'dan 100'a kadar dönecek

    // döngü 50ye ulaştığında sonlandıralım
    Console.WriteLine(i);
    if(i==50){
        i=101;
    }

    // döngünün dönmesi, yukarıdaki koşulun sağlanmasına bağlıdır. 
    //bu konuş bozulduğunda, yani true değer üretmediğinde döngü dönmeuye devam etmez:

}*/


// For içerisinde for olur mu ?

// çarpım tablosu örneği üstünden gösterelim

/*for(int i=1;i<=10;i++){
// bir kere çalıştı
    for(int j=1;j<=10;j++){
        // 10 kere çalıştı
        // buraya yazılan bir yazı ekrana kaç defa yazar.
        //9 
        //10 11
        //100 2
        // sürekli olarak tekrarlar mı 
        // Cevap : 100 kere yazar 

        Console.WriteLine("{0}x{1}={2}",i,j,i*j);
        
    }// döngü değişkeni bellekten düşer
    Console.WriteLine("--------------------");
}
*/


// Örnek : 
// 1000 adet random sayı çekip, bu sayılardan kaç tanesi tek kaç tanesi çift sayı ekrana yazan uygulama

/*int tekSayi=0;
int ciftSayi =0;
Random rnd = new Random();

for(int i =0;i < 10000;i++)
{
    int randomSAyi = rnd.Next(0, 1000);
    if(randomSAyi%2==0){
        ciftSayi++;
    }
    else{
        tekSayi++;
    }
}
Console.WriteLine("{0} adet tek sayı",tekSayi);
Console.WriteLine("{0} adet çift sayı",ciftSayi);
*/
// for döngüsü kullanılarak, ekrana 10 karakterli random bir kelime yazdırınız
// Örnek : asjasdkdkd

/*Random rnd = new Random();
string randomString="";
for(int i=0;i<=1000;i++){

   char random = (char)rnd.Next('A','Z');
   //randomString=randomString+random.ToString();

   // oluşturulan değeri bir değişken üzerine alalım.!!
   randomString+=random.ToString();
   Console.Write(random);

}
*/

// Örnek : Ekrandan x adet sayı alalım, girilen bu sayıların en küçüğünü ve en büyüğünü ekrana yazdıralım
// Örnek

/*int enBuyuk = 0;
int enKucuk = 999;
Console.WriteLine("Merhaba en küçük ve en büyük sayı bulma oyunu için sayı girişi yapmanızı istiyorum");
for(int i = 0; i < 10;i++){


    Console.WriteLine("{0}. sayıyı giriniz",i+1);
    int girilenSayi =int.Parse(Console.ReadLine());
    if(girilenSayi<enKucuk){
        enKucuk=girilenSayi;
    }
    if(girilenSayi>enBuyuk){
        enBuyuk=girilenSayi;
    }
}

*/
/*
enbuyuk = 0;
enkucuk = 0;

ekrandan değer aldın.
4 girildi

4 değeri 999 değerinden küçük mü 
7 değeri 4 değerinden küçük mü ?


1 değeri 4 değerinden küçük mü ?

1 değeri 0 değerinden küçük mü ?



Console.WriteLine("Girilen en büyük sayı : {0}",enBuyuk);
Console.WriteLine("Girilen en küçük sayı : {0}",enKucuk);

*/
/*
iç içe for döngüsü kullanarak aşağıdaki dik üçgeni çizdiriniz
x
xx
xxx
xxxx
xxxxx
xxxxxx
xxxxxxx
xxxxxxxx

*/
/*
for(int i=0;i<10;i++){

    for(int j=0;j<i;j++){

        Console.Write("x");
    }
    Console.WriteLine("");
}

/*
*
**
***
****
*****
******
*******
********
*********
**********
***********
*/


// Random 1 ile 100 arasında bir sayı tutalım
// For döngüsü kulnarak, ekrandan sayı girişi alalım
// kullanıcının girdiği değer, random tutulan değerden küçük ise, yukarı, büyük ise aşağı
// yazdırarak kullanıcıyı yönlendirelim
// kullanıcıya 10 hak verelim, 10 hakta doğru sayıyı tahmin edemezse, ekrana kaybettiniz
// yazalım, eğer doğru bulursa, tebrikler kazandınız diyelim


// döngüyü sonlandırma yöntemi
/*for(int i = 0; i < 10;i++){

    Console.WriteLine(i);
    if(i==5){
        i=10;
    }
}
*/
/*Console.WriteLine("1-100 arasında bir değer tuttum, bu değeri tahmin et");
Random rnd = new Random();  
int randomSayi =rnd.Next(1,100);
bool kazandimi = false;
for (int i = 0;i<10;i++){

    Console.WriteLine("{0}. tahminini gir",i+1);
    int girilenSayi=int.Parse(Console.ReadLine());
    if(girilenSayi>randomSayi){
        Console.WriteLine("Aşağı");
    }
    if(girilenSayi<randomSayi){
        Console.WriteLine("Yukarı");
    }

    if(girilenSayi==randomSayi){
        kazandimi=true;
        Console.WriteLine("Tebrikler Kazandınız");
        // döngüyü sonlandırıyorum
        i=10; // döngü koşulunu bozuyorum artık döngü dönmeyecek
    }
}
if(kazandimi!=true){
    // kazanılmadıysa, kaybettir yazdır
  Console.WriteLine("Kaybettiniz");
}
*/

// Örnek : 
// Öğrenciden 10 adet not alıp, bu notların ortalamasını bulan program yazınız.
/*int toplamSayisi = 10;
int toplamNot = 0;
for (int i = 0;i<toplamSayisi;i++){
    Console.WriteLine("{0}. notu giriniz",i+1);
    int not = int.Parse(Console.ReadLine());
    toplamNot+=not;

}
Console.WriteLine("Not Ortalamanız : {0}",toplamNot/toplamSayisi);
*/

// Bölüm sonu canavarı örnek 
// Ekrandan almış olduğunuz bir yazıyı, döngü kullanarak ekrana ters yazdırınız

// Kahve
// evhak


/*Console.WriteLine("Bir metin giriniz");
string metin = Console.ReadLine();

// kahve
// 5
// 4
// 3


// bu örneği inceleyin, yarın bu konu hakkında konuşacağız.
// yarın başka örneklerden devam!!

/*string ters ="";
for (int i = metin.Length;i>0;i--){

   ters+=metin.Substring(i-1,1);
}
Console.WriteLine(ters);
*/




// Ekrana girilen küçük harf string metinin, baş harf ve son harf lerini büyük harf yapan
// "uygulama yazınız


Console.WriteLine("Bir değer giriniz");
string deger = Console.ReadLine();
string ilkKarakter ="";
string sonKarakter="";
for (int i = 0;i<deger.Length;i++){

    string tekKarakter= deger.Substring(i,1);
    if(i==0){
        // ilk karakteri yakalarız
        ilkKarakter=tekKarakter.ToUpper();
    }
    if(i==deger.Length-1){
        sonKarakter=tekKarakter.ToUpper();
    }
}
// baş harfi silelim
string newString = deger.Remove(0,1);
string newStringNew=newString.Remove(newString.Length-1,1);

Console.WriteLine(ilkKarakter+newStringNew+sonKarakter);

// bir metnin içerisindeki rakamları temizleyen kod örneği yazınız
// bu5g9ün i2tan6b2ul çok y4ğmu55r8l2u