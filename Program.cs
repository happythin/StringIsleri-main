// See https://aka.ms/new-console-template for more information

// Karar mekanizmaları bir yazılımın en önemli bileşenidir.
// Derleyiciye belli değerlere göre, belli kod bloklarını çalıştırmasını söylemek, karar yapılarını açıklar.

// bir koşul 
// koşul true ise, bu kod çalışssın
// değilse bu kod bloğu çalışssın

// Kaç farklı koşul işlemi tipi var : 2
// bunlar;
// If - Else IF-Else
// Switch Case


// If Yöntemi
// syntax
/*

// Koşul değişkeni, her zaman mantıksal operatörlerden gelen bir değer olmalıdır (True,False)
// yani if her zaman true yada false değerine göre karar verir.


if(Koşul)
{
    // koşul true ise, bu kod bloğu çalışacaktır.
    
}

// Bir örnek açıklayalım
*/

//bool isOk = false;
// if parantezi, ya true false değer alır, yada true false değer üretecek bir mantıksal operatör işlemi alır.
//Console.WriteLine("A");
//if(isOk)
//{
//    Console.WriteLine("B");
//}
//Console.WriteLine("C");


// Bool değişken yerine, mantıksal oparatör kullanalım
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isOk = intDegisken > 5;
if(isOk)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/
// İf içerisinde bir değişken değilde, mantıksal değer üretecek olan bir kod bloğu yazabiliriz.
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken>5)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/


// Bir örnek daha
/*Console.WriteLine("Lütfen bir sayı giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isCift = intDegisken%2 == 0;
if(isCift)
{
    Console.WriteLine("Girmiş olduğunuz sayı çift sayıdır.");
}  
if(isCift!=true){
   Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
}
*/

// if - else
/*Console.WriteLine("Bir sayi giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken%2 == 0)
{
    // yukarıdaki koşul işlemi true ise bu blok çalığır
    Console.WriteLine("Girmiş olduğunuz sayı çift sayı");
}
else{
    // yukarıdaki koşul işlemi false bu blok çalışır
    Console.WriteLine("Girmiş olduğunuz sayı tek sayı");
}
Console.WriteLine("Uygulama sonu");


// Örnek : ekrandan bir karakter alalım, bu karakter büyük harf ise, ekrana büyük harf, 
// küçük harf ise, ekrana küçük harf yazdıran bir uygulama yapınız

*/
// Süre 10 dakikadır.
/*

// Ekrandan bir string karakter alıp, büyük yada küçük harf olduğunu ekrana yazdıran uygulama
Console.WriteLine("Lütfen küçük yada büyük bir harf giriniz");
char charKarakter = char.Parse(Console.ReadLine());
int intDegisken = Convert.ToInt32(charKarakter);
if(intDegisken>64 && intDegisken<91){
    // true ise bu blok çalışır
    Console.WriteLine("Girdiğiniz harf büyük harf");
}
else{
    Console.WriteLine("Girdiğiniz harf küçük harf");
}
*/
// Kullanıdan not bilgisini alınız.(Not 50 den düşük ise, kaldı, büyük ise geçti yazdırınız)
/*Console.WriteLine("Lütfen aldığınız notu yazınız");
int not = int.Parse(Console.ReadLine());
if(not<50){
    Console.WriteLine("Kaldın");
}
else{
    System.Console.WriteLine("Geçtin");
}

*/
// Örnek : 
// Kullanıcıdan aldığınız username=wissen ve password=1010'a eşitse, 
//ekrana giriş başarılı, değilse, giriş başarısız yazan uygulamayı yapınız

/*
Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010"){
    Console.WriteLine("Hoşgeldiniz");
}
else{
    Console.WriteLine("Kullanıcı yada şifre hatalı");
}
*/


// İf ve Else koşullarında, eğer bu blokların içerisinde tek bir satır kod yazacaksak, parantez yapmamıza gerek yoktur.
// yukarıdaki örneği bu şekilde yazalım

/*Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010")
    Console.WriteLine("Hoşgeldiniz");
else
    Console.WriteLine("Kullanıcı yada şifre hatalı");
*/

// Ekrandan bir ürün fiyatı değeri alalım, ürün fiyatı değeri 100'den büyük ise %20 kdv payı ekleyip ekranda gösterelim
// ürün fiyatı 100'den küçük ise, %30 indirim yapıp ekrana yazdıralım
/*
Console.WriteLine("Lütfen ürün fiyatını giriniz");
double productPrice = double.Parse(Console.ReadLine());

if(productPrice<100){
    double newPrice = productPrice-(productPrice*0.3);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}
else{

    double newPrice = (productPrice*1.2);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}*/


// İç İçe İf
// syntax
/*
if(koşul)
{
    if(koşul)
    {
        
    }
    else
    {
    }
}
else
{
    if(koşul)
    {
    }
    else
    {
    }
}
*/


// Örnek :
/*
Console.WriteLine("Lütfen not giriniz");
int not = int.Parse(Console.ReadLine());
if(not<50)
{

    if(not<25){
        Console.WriteLine("Sınıfta kaldın");

    }
    else{
        Console.WriteLine("Düşük seviyeli geçtin");
    }
}
else{
    if(not<75){
        Console.WriteLine("Orta seviyeli geçtin");
    }
    else{
        Console.WriteLine("Çok iyi seviye ile geçtin");
    }
}
*/


// IF - Else If- Else Blokları(Çoklu case kontrolü)

// If ve Else kullanımında, derleyici iki tek bir kontrol yapıyordu.
// If bloğunda kapılan kontrol ıf bloğu şartına uyuyorsa, if çalışıyordu,
// uymuyorsa, else çalışıyordu.

// Peki, eğer birden fazla koşum varsa ve ben bu koşulları, her birini if gibi değerlendirmek istiyorsam

/*
if(Koşul)
{
}
else if(koşul)
{
}
else if(koşul)
{
}
else
{

}
*/

// if -else if-else konusunda bir örnek

//Console.WriteLine("Not giriniz");
//int not = int.Parse(Console.ReadLine());

// not 0-24 arasındaysa, 1
// not 25-44 arasındaysa 2
// not 45-60 arasındaysa 3
// not 59-84 arasındaysa 4
// not 85 ve 100 arasındaysa 5

/*
if(not>0 && not<24){
    Console.WriteLine("1 aldın");
}
else if(not>=25 && not<=44){
    Console.WriteLine("2 aldın");
}
else if(not>45 && not<=60){
    Console.WriteLine("3 aldın ");
}
else if (not>60 && not<84){
    Console.WriteLine("4 aldın");
}
else if(not>85 && not<100){
    Console.WriteLine("5 aldın");
}
else{
    Console.WriteLine("Lütfen geçerli bir not giriniz");
}
*/
// Bir basit hesap makinası yapalım
// Ekradan iki adet sayı alıp, birde işlem tipi alıp (+,-,/,*) işlem tipine hesap yapan
// kod bloğunu yazalım
// burada ek bir kontrol daha yapalım
// eğer aldığınız bölen sıfır ise, uyarı mesajı verelim/ bölen sıfır olamaz

/*Console.WriteLine("Hesap makinasına hoşgeldiniz");
Console.WriteLine("1 sayıyı giriniz");
     int birinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz");
int ikinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("İşlem tipini giriniz(+,-,/,*)");
string islemTipi =Console.ReadLine();
*/
/* 1. case
if(islemTipi=="/" && ikinciSayi!=0){
    // programı devam ettir
}
else{
    // bölen sıfır olamaz
}
*/
// 2. case
/*if(islemTipi=="+"){
    Console.WriteLine(birinciSayi+ikinciSayi);
}
else if(islemTipi=="-"){
    Console.WriteLine(birinciSayi-ikinciSayi);
}
else if(islemTipi=="*"){
    Console.WriteLine(birinciSayi*ikinciSayi);   
}
else if(islemTipi=="/"){
    if(ikinciSayi!=0){
        Console.WriteLine(birinciSayi/ikinciSayi);
    }
    else{
        // yukarıda 0 değilse, kontrolü var, değer 0'ı ise burası çalışacak
        Console.WriteLine("Bölen sıfır olamaz");
    }
}
// if veya else if'ler else olmadan çalışabilir.
*/

// Üçgenin alanı ve çevresi ve dairenin alanı ve çevresi hesaplama aracı yapacağız.

// Uygulama çalıştığında, öncelikle programın yapabileceği özellikler ekrana çıksın
// Örnek : Hesaplama için öncelikle şeklin adını sorsun
// değer olarak üçgen yada daire giriniz

// bu değeri girdikten sonra, alan yada çevre hesabı yapmak istediğinizi sorsun
// değer olarak alan yada çevre girin
// daha sonra bu hesaplamalar için gerekli olan parametreleri kullanıcıdan istesin

// daha sonra hesaplama yapıp ekrana sonucu göstersin

/*Console.WriteLine("Hesaplama aracına hoşgeldin");
Console.WriteLine("Hesaplama aracımız üçgen ve daire için çalışmaktadır");
Console.WriteLine("Lütfen ücgen yada daire yazınız");

string sekil = Console.ReadLine();
if (sekil.ToLower() == "ucgen")
{
    Console.WriteLine("Alan hesaplama Alan, Çevre hesaplamak için çevre yazınız");
    string hesapText = Console.ReadLine();
    if (hesapText.ToLower() == "alan")
    {

        // taban* yukseklik/2
        Console.WriteLine("Taban değerini giriniz");
        int taban = int.Parse(Console.ReadLine());
        Console.WriteLine("Yükseklik değeri giriniz");
        int yukseklik = int.Parse(Console.ReadLine());
        // hesaplama
        decimal result = taban * yukseklik / 2;
        Console.WriteLine("Taban değeri {0} yükseklik değeri {1} olan üçgenin alanı : {2}", taban, yukseklik, result);
    }
    else if (hesapText.ToLower() == "cevre")
    {
        Console.WriteLine("1. kenar uzunluğu");
        int birinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("2. kenar");
        int ikinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("3. kenar");
        int ucuncuKenar = int.Parse(Console.ReadLine());
        int result = birinciKenar + ikinciKenar + ucuncuKenar;
        Console.WriteLine("Üçgenin çevre uzunluğu : {0}", result);
    }
    else
    {
        Console.WriteLine("İşlem tipi geçersizdir");
    }
}
else if (sekil.ToLower() == "daire")
{

    Console.WriteLine("Alan hesaplamak için Alan, Çevre hesaplamak için Cevre yazınız");
    string hesapText = Console.ReadLine();
    if (hesapText.ToLower() == "alan")
    {

        Console.WriteLine("Alan hesabı için, yarı çap değerini giriniz");
        int yariCap = int.Parse(Console.ReadLine());
        Console.WriteLine("Yarı çapı : {0} olan dairenin alanı : {1}", yariCap, Math.PI * yariCap * yariCap);
    }
    else if (hesapText.ToLower() == "cevre")
    {

        Console.WriteLine("Çevre hesabı için yarı çap değerini giriniz");
        int yariCap = int.Parse(Console.ReadLine());
        Console.WriteLine("Yarı Çapı {0} olan dairenin çevresi {1}", yariCap, Math.PI * yariCap * 2);
    }
    else
    {
        Console.WriteLine("Geçersiz işlem tipi");
    }

}
else
{
    Console.WriteLine("Geçersiz şekil");
}*/


// if yerin geçen ancak if yazmak istemediğimiz noktada, bazen hızlıca bir değeri kontrol edip ve bir sonuö ettiğimiz bir operatör
// Ternary Operatörü

/* using System.Data;

bool isOk = true;
*/
//if(isOk)){
// console.writeline(doğru)
//}
//else{
//    // console.Writeline(yanlış)
//}


//string degisken = isOk?"Doğru":"Yanlış";

//string metin = "Ok";
//string result =metin=="Ok"?"Sonuç Ok":"sonuç ok değil";

/*Console.WriteLine("Sayi 1");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Sayi 1");
int sayi2=int.Parse(Console.ReadLine());
Console.WriteLine("Seçim giriniz");
char secim = char.Parse(Console.ReadLine());
*/

// ternary operatörü mantıksal değere göre çalışır
// eğer mantıksal operatör true değeri verirse, ? işareti ifadesinden sonraki blok çalışır
// eğer mantıksal operatör false değeri verirse, : işaretinden sonraki blok çalışır.

//int result = secim=='+'?sayi1+sayi2:0;
//Console.WriteLine(result);

// Ternary operatörü : Hızlı bir şekilde değeri birşeyler ile karşılaştırıp karar vermek için kullanılır.
// genelde tek satır if yazmak yerine tercih edilir.
// okunabilirliği düşüktür.



// ekrandan girmiş olduğunuz metin 10 karakterden fazla ise, ekrana çok uzun
// 10 karakterden kısa ise, çok kısa yazdırınız

//Console.WriteLine("Bir metin giriniz");
//string metin = Console.ReadLine();
//string result = metin.Length>=10?"karakter 10 dan büyük":"karakter 10'dan küçük";
//Console.WriteLine(result);

// Ekrandan almış olduğunuz karakter, A ile başlalıyorsa, karakter a iel başlıyor, başlamıyorsa
// karakter a ile başlamıyor yazdırınız
/*
Console.WriteLine("Bir değer giriniz");
string deger = Console.ReadLine();
string result =deger.ToLower().StartsWith("a")?"a ile başlıyor":"a ile başlamıyor";
Console.WriteLine(result);



*/
// Switch Case yapısı
// Örnek ile bakalım

/* Console.WriteLine("1. sayıyı giriniz");
int sayi1 = int.Parse(Console.ReadLine());  
Console.WriteLine("2. sayıyı giriniz");
int sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine("İşlem tipini giriniz");
char tip = char.Parse(Console.ReadLine());
switch (tip)
{
    case '+':
    Console.WriteLine(sayi1+sayi2);
    break;
    case '-':
    Console.WriteLine(sayi1-sayi2);
    break;
    case '*':
    Console.WriteLine(sayi1*sayi2);
    break;
    case '/':

    // bölen sıfır olamaz kontrolü
 // İf ile yapmak
    if(sayi2!=0)
    { 
       Console.WriteLine(sayi1/sayi2);
    }
    else{

        Console.WriteLine("Bölen sıfır olamaz");
    }

    
    Switch Case ile yapmak
    switch (sayi2)
    {
        case 0:
        Console.WriteLine("Bölen sıfır olamaz");
        break;
        default:
        Console.WriteLine(sayi1/sayi2);
        break;

    }

    break;
    default:
    Console.WriteLine("girdiğin işlem tipi hatalı");
    // yukarıdaki hiç bir case uymaz ise, default bloğu çalışır
    // default bloğu olmak zorunda değil
    break;
}
*/


// ekrandan bir gün alınız, bu günün hafta sonu yada h içi olduğunu ekrana yazdırınız
// Örnek : Pazartesi,Salı,Cumartesi


// switch case yapısı aşağıdaki şekilde de kullanılabilir.
/* Console.WriteLine("Bir gün adı giriniz");
string gun =Console.ReadLine();
switch (gun)
{
    case "Pazartesi":
    case "Salı":
    case "Çarşamba":
    case "Perşembe":
    case "Cuma":
    Console.WriteLine("H içi");
    break;
    case "Cumartesi":
    case "Pazar":
    Console.WriteLine("H.Sonu");
    break;
    default:
    Console.WriteLine("Geçersiz");
    break;
}
*/
//NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*/

//NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*///NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*/
// 100 ADET RANDOM SAYI ÇEKİP BU SAYILARDAN 
// KAÇ TANESİ ÇİFT SAYI KAÇ TANESİ TEK EKRANA YAZDIRAN UYGULAMA 
/* 
int tek=0;
int cift=0;
int sifir=0;
for (int i=0;i<=1000;i++) 
{
 Random rnd= new Random();
int sayi = rnd.Next(1,99999);
if (sayi == 0)
{
    sifir++;
}

else if(sayi %2== 0)
{
    cift++;
}
else
{
    tek++;
}
}
Console.WriteLine("{0} tane Çift Sayı mevcut",cift);
Console.WriteLine("{0} tane Tek Sayı mevcut",tek);
Console.WriteLine("{0} adet Sıfır seçildi",sifir);
*/

/*
 Random rnd= new Random();
for (int i=0;i<=10;i++) 
{

int intKelime = (char)rnd.Next('A','Z');
char karakter = Convert.ToChar(intKelime);
Console.Write(karakter);
}
*/
//örnek dik üçgen

//girilen sayıların en büyüğü ve en küçüğünü ekrana yazdırma
/*

int buyuk=0;
int kucuk=99999;
for  (int i=0; i<11;i++)
{
    Console.WriteLine("Lütfen bir sayı giriniz");
    
    int sayi1 =int.Parse(Console.ReadLine());
    i++;
    if (buyuk<sayi1)
    {
        buyuk=sayi1;
    }
    else if (sayi1<kucuk)
    {
        kucuk=sayi1; 
    }
}
Console.WriteLine(kucuk);
Console.WriteLine(buyuk);
*/
/*
Console.WriteLine("1'DEN 100'E KADAR RASTGELE ÜRETİLEN SAYIYI TAHMİN ETMEYE ÇALIŞINIZ");
Random rnd=new Random();
int a = rnd.Next();
for (int i = 0; i < 10;i++)
{
    Console.WriteLine("LÜTFEN BİR SAYI GİRİNİZ");
    int girilen=int.Parse(Console.ReadLine());
    if (girilen<a)
    {
        Console.WriteLine("Yukarı");
    }
    else if (girilen==a)
    {
        Console.WriteLine("Tebrikler!!!Doğru tahmin.");
        i=10;
    }
    else
    {
        Console.WriteLine("Aşağı");
    }
}
*/
// GİRİLEN SAYILARIN TOPLAMI ÖRNEĞİ
/* int not=0;
int ortalama = not/10;
for  (int i=0; i<10;i++)
{
    Console.WriteLine("Lütfen {0}. notunuzu girin.",i+1);
    
    int notGirilen =int.Parse(Console.ReadLine());
    not=notGirilen+not;
}
Console.WriteLine("Ortalamanız: {0}",ortalama);
*/
// alınan yazıyı döngü kullanarak ters yazdırmak
/* 
Console.WriteLine("Lütfen bir metin giriniz");
String metin=Console.ReadLine();
string ters="";
for (int i = metin.Length; i >0 ; i--)
{
ters+=metin.Substring(i-1,1);
}
Console.WriteLine(ters);
*/
/*
// ilk ve son hrf büyütme
Console.WriteLine("Lütfen bir metin giriniz");
String metin=Console.ReadLine();
string yeniKelime="";
string ilkHarf="";
for (int i = metin.Length; i >0 ; i--)
{
yeniKelime+=metin.Substring(0,1);
for (int j = 0; j <1 ; j++)
{
yeniKelime.ToUpper();
}
for (int k = metin.Length; k >metin.Length-1 ; k--)
{
yeniKelime.ToUpper();
yeniKelime+=metin;
}
}
Console.WriteLine(yeniKelime);
*/
//Bir metnin içerisindeki rakamları temizleyen kodu yazınız.
/*
// Girilen metindekki rakam,küçük harf,büyükharf ve özel karakter sayılarını ekrana yazdıran program
Console.WriteLine("Lütfen bir metin giriniz");
string metin=Console.ReadLine();
int rakam=0;
int buyukHarf =0;
int kucukHarf=0;
int ozelKarakter=0;
for (int i=0;i<metin.Length;i++)
{
    char charMetin = char.Parse(metin.Substring(i,1));
    if (char.IsNumber(charMetin))
    {
        rakam++;
    }
    else if (char.IsUpper(charMetin))
    {
        buyukHarf++;
    }
     else if (char.IsLower(charMetin))
      {
        kucukHarf++;
      } 
    else
    {
        ozelKarakter++;
    }
    
}
Console.WriteLine("{0} ADET RAKAM. {1} ADET BÜYÜK HARF. {2}ADET KÜÇÜK HARF MEVCUT. {3}ADET ÖZEZL KARAKTER MEVCUT.",rakam, buyukHarf, kucukHarf,ozelKarakter);
*/
//Girilen değere kadar olan asal sayları ekrana yazdırmak

/* 
Console.WriteLine("Lütfen bir sayı giriniz.");
int deger = int.Parse(Console.ReadLine());
int asalDegil=0;
for (int i = 2;i<=deger;i++)
{
    int asal=0;
    for (int j = 2;j<i;j++)
    {
        if (i%j==0)
        {
               asal++;
        }
    }
    if (asal==0)
    Console.WriteLine(i);
}
*/
/*
for(int i=1;i<=10;i++)
{

    for(int j=1;j<=i;j++)
    {
        if(i==1&&j==1)
        {
            Console.Write("X");
            Console.WriteLine("");
            i++;
        }
        if(i==10&&j==1)
        {
            Console.Write("X");
        }
        if(i==10&&j==10)
        {
            Console.Write("X");
            Console.WriteLine("");
        } 
        else
        {
            Console.Write("*");
        }
        
    }
    Console.WriteLine("");
}
*/
/*
for(int i=1;i<=4;i++)
{
    for(int j=1;j<=i;j++)
    {
        for (int k=0;k<=i;k++)
        {
        if(i==0&&j==0)
        {
            Console.WriteLine(" ");
        }
        if(i==0&&j==1)
        {
            Console.WriteLine(" ");
        }
        if(i==0&&j==2)
        {
            Console.WriteLine(" ");
        }
        else 
        {
            Console.Write("x");
        }
        
        }
        Console.WriteLine("");
    }
    
}
*/
/*
using System.Drawing;
Console.BackgroundColor=ConsoleColor.DarkRed;
Console.WriteLine("Değer giriniz.");
int deger=int.Parse(Console.ReadLine());
 for (int i = 0; i < deger; i++)  
{
    for (int j = i; j < deger; j++) 
        {
            Console.Write(" ");
        }
    for (int k = 0; k <= i; k++)
        {
    Console.Write("*");
    Console.Write(" ");
                
        }
    Console.WriteLine();
}
*/

/* string id ="wissen";
string pass ="2409";
string girilenId="";
string girilenPass="";
do
{
 Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
 girilenId=Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
 girilenPass=Console.ReadLine();
 if (girilenId==id && girilenPass==pass)
    {
        Console.WriteLine("Başarıyla giriş yaptınız.");
        break;
    }
    else 
    {
        Console.WriteLine("Giriş başarısız. Lütfen tekrar deneyiniz.");
    }
} while (true);



*/
Console.WriteLine("Kaç adet fibonacci sayısı görmek istersiniz?");
int deger = int.Parse(Console.ReadLine());
 
int fibo1 = 1;
int fibo2 = 1;
 
Console.Write(fibo1 + " " + fibo2 + " ");
 
for (int i = 3; i <= deger; i++)
{
    int fibo3 = fibo1 + fibo2;
    Console.Write(fibo3 + " ");
 
    fibo1 = fibo2;
    fibo2 = fibo3;
}
// See https://aka.ms/new-console-template for more information

// Karar mekanizmaları bir yazılımın en önemli bileşenidir.
// Derleyiciye belli değerlere göre, belli kod bloklarını çalıştırmasını söylemek, karar yapılarını açıklar.

// bir koşul 
// koşul true ise, bu kod çalışssın
// değilse bu kod bloğu çalışssın

// Kaç farklı koşul işlemi tipi var : 2
// bunlar;
// If - Else IF-Else
// Switch Case


// If Yöntemi
// syntax
/*

// Koşul değişkeni, her zaman mantıksal operatörlerden gelen bir değer olmalıdır (True,False)
// yani if her zaman true yada false değerine göre karar verir.


if(Koşul)
{
    // koşul true ise, bu kod bloğu çalışacaktır.
    
}

// Bir örnek açıklayalım
*/

//bool isOk = false;
// if parantezi, ya true false değer alır, yada true false değer üretecek bir mantıksal operatör işlemi alır.
//Console.WriteLine("A");
//if(isOk)
//{
//    Console.WriteLine("B");
//}
//Console.WriteLine("C");


// Bool değişken yerine, mantıksal oparatör kullanalım
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isOk = intDegisken > 5;
if(isOk)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/
// İf içerisinde bir değişken değilde, mantıksal değer üretecek olan bir kod bloğu yazabiliriz.
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken>5)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/


// Bir örnek daha
/*Console.WriteLine("Lütfen bir sayı giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isCift = intDegisken%2 == 0;
if(isCift)
{
    Console.WriteLine("Girmiş olduğunuz sayı çift sayıdır.");
}  
if(isCift!=true){
   Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
}
*/

// if - else
/*Console.WriteLine("Bir sayi giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken%2 == 0)
{
    // yukarıdaki koşul işlemi true ise bu blok çalığır
    Console.WriteLine("Girmiş olduğunuz sayı çift sayı");
}
else{
    // yukarıdaki koşul işlemi false bu blok çalışır
    Console.WriteLine("Girmiş olduğunuz sayı tek sayı");
}
Console.WriteLine("Uygulama sonu");


// Örnek : ekrandan bir karakter alalım, bu karakter büyük harf ise, ekrana büyük harf, 
// küçük harf ise, ekrana küçük harf yazdıran bir uygulama yapınız

*/
// Süre 10 dakikadır.
/*

// Ekrandan bir string karakter alıp, büyük yada küçük harf olduğunu ekrana yazdıran uygulama
Console.WriteLine("Lütfen küçük yada büyük bir harf giriniz");
char charKarakter = char.Parse(Console.ReadLine());
int intDegisken = Convert.ToInt32(charKarakter);
if(intDegisken>64 && intDegisken<91){
    // true ise bu blok çalışır
    Console.WriteLine("Girdiğiniz harf büyük harf");
}
else{
    Console.WriteLine("Girdiğiniz harf küçük harf");
}
*/
// Kullanıdan not bilgisini alınız.(Not 50 den düşük ise, kaldı, büyük ise geçti yazdırınız)
/*Console.WriteLine("Lütfen aldığınız notu yazınız");
int not = int.Parse(Console.ReadLine());
if(not<50){
    Console.WriteLine("Kaldın");
}
else{
    System.Console.WriteLine("Geçtin");
}

*/
// Örnek : 
// Kullanıcıdan aldığınız username=wissen ve password=1010'a eşitse, 
//ekrana giriş başarılı, değilse, giriş başarısız yazan uygulamayı yapınız

/*
Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010"){
    Console.WriteLine("Hoşgeldiniz");
}
else{
    Console.WriteLine("Kullanıcı yada şifre hatalı");
}
*/


// İf ve Else koşullarında, eğer bu blokların içerisinde tek bir satır kod yazacaksak, parantez yapmamıza gerek yoktur.
// yukarıdaki örneği bu şekilde yazalım

/*Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010")
    Console.WriteLine("Hoşgeldiniz");
else
    Console.WriteLine("Kullanıcı yada şifre hatalı");
*/

// Ekrandan bir ürün fiyatı değeri alalım, ürün fiyatı değeri 100'den büyük ise %20 kdv payı ekleyip ekranda gösterelim
// ürün fiyatı 100'den küçük ise, %30 indirim yapıp ekrana yazdıralım
/*
Console.WriteLine("Lütfen ürün fiyatını giriniz");
double productPrice = double.Parse(Console.ReadLine());

if(productPrice<100){
    double newPrice = productPrice-(productPrice*0.3);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}
else{

    double newPrice = (productPrice*1.2);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}*/


// İç İçe İf
// syntax
/*
if(koşul)
{
    if(koşul)
    {
        
    }
    else
    {
    }
}
else
{
    if(koşul)
    {
    }
    else
    {
    }
}
*/


// Örnek :
/*
Console.WriteLine("Lütfen not giriniz");
int not = int.Parse(Console.ReadLine());
if(not<50)
{

    if(not<25){
        Console.WriteLine("Sınıfta kaldın");

    }
    else{
        Console.WriteLine("Düşük seviyeli geçtin");
    }
}
else{
    if(not<75){
        Console.WriteLine("Orta seviyeli geçtin");
    }
    else{
        Console.WriteLine("Çok iyi seviye ile geçtin");
    }
}
*/


// IF - Else If- Else Blokları(Çoklu case kontrolü)

// If ve Else kullanımında, derleyici iki tek bir kontrol yapıyordu.
// If bloğunda kapılan kontrol ıf bloğu şartına uyuyorsa, if çalışıyordu,
// uymuyorsa, else çalışıyordu.

// Peki, eğer birden fazla koşum varsa ve ben bu koşulları, her birini if gibi değerlendirmek istiyorsam

/*
if(Koşul)
{
}
else if(koşul)
{
}
else if(koşul)
{
}
else
{

}
*/

// if -else if-else konusunda bir örnek

//Console.WriteLine("Not giriniz");
//int not = int.Parse(Console.ReadLine());

// not 0-24 arasındaysa, 1
// not 25-44 arasındaysa 2
// not 45-60 arasındaysa 3
// not 59-84 arasındaysa 4
// not 85 ve 100 arasındaysa 5

/*
if(not>0 && not<24){
    Console.WriteLine("1 aldın");
}
else if(not>=25 && not<=44){
    Console.WriteLine("2 aldın");
}
else if(not>45 && not<=60){
    Console.WriteLine("3 aldın ");
}
else if (not>60 && not<84){
    Console.WriteLine("4 aldın");
}
else if(not>85 && not<100){
    Console.WriteLine("5 aldın");
}
else{
    Console.WriteLine("Lütfen geçerli bir not giriniz");
}
*/
// Bir basit hesap makinası yapalım
// Ekradan iki adet sayı alıp, birde işlem tipi alıp (+,-,/,*) işlem tipine hesap yapan
// kod bloğunu yazalım
// burada ek bir kontrol daha yapalım
// eğer aldığınız bölen sıfır ise, uyarı mesajı verelim/ bölen sıfır olamaz

/*Console.WriteLine("Hesap makinasına hoşgeldiniz");
Console.WriteLine("1 sayıyı giriniz");
     int birinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz");
int ikinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("İşlem tipini giriniz(+,-,/,*)");
string islemTipi =Console.ReadLine();
*/
/* 1. case
if(islemTipi=="/" && ikinciSayi!=0){
    // programı devam ettir
}
else{
    // bölen sıfır olamaz
}
*/
// 2. case
/*if(islemTipi=="+"){
    Console.WriteLine(birinciSayi+ikinciSayi);
}
else if(islemTipi=="-"){
    Console.WriteLine(birinciSayi-ikinciSayi);
}
else if(islemTipi=="*"){
    Console.WriteLine(birinciSayi*ikinciSayi);   
}
else if(islemTipi=="/"){
    if(ikinciSayi!=0){
        Console.WriteLine(birinciSayi/ikinciSayi);
    }
    else{
        // yukarıda 0 değilse, kontrolü var, değer 0'ı ise burası çalışacak
        Console.WriteLine("Bölen sıfır olamaz");
    }
}
// if veya else if'ler else olmadan çalışabilir.
*/

// Üçgenin alanı ve çevresi ve dairenin alanı ve çevresi hesaplama aracı yapacağız.

// Uygulama çalıştığında, öncelikle programın yapabileceği özellikler ekrana çıksın
// Örnek : Hesaplama için öncelikle şeklin adını sorsun
// değer olarak üçgen yada daire giriniz

// bu değeri girdikten sonra, alan yada çevre hesabı yapmak istediğinizi sorsun
// değer olarak alan yada çevre girin
// daha sonra bu hesaplamalar için gerekli olan parametreleri kullanıcıdan istesin

// daha sonra hesaplama yapıp ekrana sonucu göstersin

/*Console.WriteLine("Hesaplama aracına hoşgeldin");
Console.WriteLine("Hesaplama aracımız üçgen ve daire için çalışmaktadır");
Console.WriteLine("Lütfen ücgen yada daire yazınız");

string sekil = Console.ReadLine();
if (sekil.ToLower() == "ucgen")
{
    Console.WriteLine("Alan hesaplama Alan, Çevre hesaplamak için çevre yazınız");
    string hesapText = Console.ReadLine();
    if (hesapText.ToLower() == "alan")
    {

        // taban* yukseklik/2
        Console.WriteLine("Taban değerini giriniz");
        int taban = int.Parse(Console.ReadLine());
        Console.WriteLine("Yükseklik değeri giriniz");
        int yukseklik = int.Parse(Console.ReadLine());
        // hesaplama
        decimal result = taban * yukseklik / 2;
        Console.WriteLine("Taban değeri {0} yükseklik değeri {1} olan üçgenin alanı : {2}", taban, yukseklik, result);
    }
    else if (hesapText.ToLower() == "cevre")
    {
        Console.WriteLine("1. kenar uzunluğu");
        int birinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("2. kenar");
        int ikinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("3. kenar");
        int ucuncuKenar = int.Parse(Console.ReadLine());
        int result = birinciKenar + ikinciKenar + ucuncuKenar;
        Console.WriteLine("Üçgenin çevre uzunluğu : {0}", result);
    }
    else
    {
        Console.WriteLine("İşlem tipi geçersizdir");
    }
}
else if (sekil.ToLower() == "daire")
{

    Console.WriteLine("Alan hesaplamak için Alan, Çevre hesaplamak için Cevre yazınız");
    string hesapText = Console.ReadLine();
    if (hesapText.ToLower() == "alan")
    {

        Console.WriteLine("Alan hesabı için, yarı çap değerini giriniz");
        int yariCap = int.Parse(Console.ReadLine());
        Console.WriteLine("Yarı çapı : {0} olan dairenin alanı : {1}", yariCap, Math.PI * yariCap * yariCap);
    }
    else if (hesapText.ToLower() == "cevre")
    {

        Console.WriteLine("Çevre hesabı için yarı çap değerini giriniz");
        int yariCap = int.Parse(Console.ReadLine());
        Console.WriteLine("Yarı Çapı {0} olan dairenin çevresi {1}", yariCap, Math.PI * yariCap * 2);
    }
    else
    {
        Console.WriteLine("Geçersiz işlem tipi");
    }

}
else
{
    Console.WriteLine("Geçersiz şekil");
}*/


// if yerin geçen ancak if yazmak istemediğimiz noktada, bazen hızlıca bir değeri kontrol edip ve bir sonuö ettiğimiz bir operatör
// Ternary Operatörü

/* using System.Data;

bool isOk = true;
*/
//if(isOk)){
// console.writeline(doğru)
//}
//else{
//    // console.Writeline(yanlış)
//}


//string degisken = isOk?"Doğru":"Yanlış";

//string metin = "Ok";
//string result =metin=="Ok"?"Sonuç Ok":"sonuç ok değil";

/*Console.WriteLine("Sayi 1");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Sayi 1");
int sayi2=int.Parse(Console.ReadLine());
Console.WriteLine("Seçim giriniz");
char secim = char.Parse(Console.ReadLine());
*/

// ternary operatörü mantıksal değere göre çalışır
// eğer mantıksal operatör true değeri verirse, ? işareti ifadesinden sonraki blok çalışır
// eğer mantıksal operatör false değeri verirse, : işaretinden sonraki blok çalışır.

//int result = secim=='+'?sayi1+sayi2:0;
//Console.WriteLine(result);

// Ternary operatörü : Hızlı bir şekilde değeri birşeyler ile karşılaştırıp karar vermek için kullanılır.
// genelde tek satır if yazmak yerine tercih edilir.
// okunabilirliği düşüktür.



// ekrandan girmiş olduğunuz metin 10 karakterden fazla ise, ekrana çok uzun
// 10 karakterden kısa ise, çok kısa yazdırınız

//Console.WriteLine("Bir metin giriniz");
//string metin = Console.ReadLine();
//string result = metin.Length>=10?"karakter 10 dan büyük":"karakter 10'dan küçük";
//Console.WriteLine(result);

// Ekrandan almış olduğunuz karakter, A ile başlalıyorsa, karakter a iel başlıyor, başlamıyorsa
// karakter a ile başlamıyor yazdırınız
/*
Console.WriteLine("Bir değer giriniz");
string deger = Console.ReadLine();
string result =deger.ToLower().StartsWith("a")?"a ile başlıyor":"a ile başlamıyor";
Console.WriteLine(result);



*/
// Switch Case yapısı
// Örnek ile bakalım

/* Console.WriteLine("1. sayıyı giriniz");
int sayi1 = int.Parse(Console.ReadLine());  
Console.WriteLine("2. sayıyı giriniz");
int sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine("İşlem tipini giriniz");
char tip = char.Parse(Console.ReadLine());
switch (tip)
{
    case '+':
    Console.WriteLine(sayi1+sayi2);
    break;
    case '-':
    Console.WriteLine(sayi1-sayi2);
    break;
    case '*':
    Console.WriteLine(sayi1*sayi2);
    break;
    case '/':

    // bölen sıfır olamaz kontrolü
 // İf ile yapmak
    if(sayi2!=0)
    { 
       Console.WriteLine(sayi1/sayi2);
    }
    else{

        Console.WriteLine("Bölen sıfır olamaz");
    }

    
    Switch Case ile yapmak
    switch (sayi2)
    {
        case 0:
        Console.WriteLine("Bölen sıfır olamaz");
        break;
        default:
        Console.WriteLine(sayi1/sayi2);
        break;

    }

    break;
    default:
    Console.WriteLine("girdiğin işlem tipi hatalı");
    // yukarıdaki hiç bir case uymaz ise, default bloğu çalışır
    // default bloğu olmak zorunda değil
    break;
}
*/


// ekrandan bir gün alınız, bu günün hafta sonu yada h içi olduğunu ekrana yazdırınız
// Örnek : Pazartesi,Salı,Cumartesi


// switch case yapısı aşağıdaki şekilde de kullanılabilir.
/* Console.WriteLine("Bir gün adı giriniz");
string gun =Console.ReadLine();
switch (gun)
{
    case "Pazartesi":
    case "Salı":
    case "Çarşamba":
    case "Perşembe":
    case "Cuma":
    Console.WriteLine("H içi");
    break;
    case "Cumartesi":
    case "Pazar":
    Console.WriteLine("H.Sonu");
    break;
    default:
    Console.WriteLine("Geçersiz");
    break;
}
*/
//NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*/

//NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*///NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*/
// 100 ADET RANDOM SAYI ÇEKİP BU SAYILARDAN 
// KAÇ TANESİ ÇİFT SAYI KAÇ TANESİ TEK EKRANA YAZDIRAN UYGULAMA 
/* 
int tek=0;
int cift=0;
int sifir=0;
for (int i=0;i<=1000;i++) 
{
 Random rnd= new Random();
int sayi = rnd.Next(1,99999);
if (sayi == 0)
{
    sifir++;
}

else if(sayi %2== 0)
{
    cift++;
}
else
{
    tek++;
}
}
Console.WriteLine("{0} tane Çift Sayı mevcut",cift);
Console.WriteLine("{0} tane Tek Sayı mevcut",tek);
Console.WriteLine("{0} adet Sıfır seçildi",sifir);
*/

/*
 Random rnd= new Random();
for (int i=0;i<=10;i++) 
{

int intKelime = (char)rnd.Next('A','Z');
char karakter = Convert.ToChar(intKelime);
Console.Write(karakter);
}
*/
//örnek dik üçgen

//girilen sayıların en büyüğü ve en küçüğünü ekrana yazdırma
/*

int buyuk=0;
int kucuk=99999;
for  (int i=0; i<11;i++)
{
    Console.WriteLine("Lütfen bir sayı giriniz");
    
    int sayi1 =int.Parse(Console.ReadLine());
    i++;
    if (buyuk<sayi1)
    {
        buyuk=sayi1;
    }
    else if (sayi1<kucuk)
    {
        kucuk=sayi1; 
    }
}
Console.WriteLine(kucuk);
Console.WriteLine(buyuk);
*/
/*
Console.WriteLine("1'DEN 100'E KADAR RASTGELE ÜRETİLEN SAYIYI TAHMİN ETMEYE ÇALIŞINIZ");
Random rnd=new Random();
int a = rnd.Next();
for (int i = 0; i < 10;i++)
{
    Console.WriteLine("LÜTFEN BİR SAYI GİRİNİZ");
    int girilen=int.Parse(Console.ReadLine());
    if (girilen<a)
    {
        Console.WriteLine("Yukarı");
    }
    else if (girilen==a)
    {
        Console.WriteLine("Tebrikler!!!Doğru tahmin.");
        i=10;
    }
    else
    {
        Console.WriteLine("Aşağı");
    }
}
*/
// GİRİLEN SAYILARIN TOPLAMI ÖRNEĞİ
/* int not=0;
int ortalama = not/10;
for  (int i=0; i<10;i++)
{
    Console.WriteLine("Lütfen {0}. notunuzu girin.",i+1);
    
    int notGirilen =int.Parse(Console.ReadLine());
    not=notGirilen+not;
}
Console.WriteLine("Ortalamanız: {0}",ortalama);
*/
// alınan yazıyı döngü kullanarak ters yazdırmak
/* 
Console.WriteLine("Lütfen bir metin giriniz");
String metin=Console.ReadLine();
string ters="";
for (int i = metin.Length; i >0 ; i--)
{
ters+=metin.Substring(i-1,1);
}
Console.WriteLine(ters);
*/
/*
int i=0;
while (i<=10)
{
    int j=0;
    while(j<i){

        Console.Write("*");
        j++;
    }
    Console.WriteLine("");
    i++;
}
*/
/* 
//ORTALAMA HESAPLAMA

Console.WriteLine("Ortalama hesaplama aracına hoşgeldiniz.");
int not=0;
int notsayisi=1;
while(notsayisi<=10)
{
    Console.WriteLine("{0}. notunuzu giriniz.",notsayisi);
    int girilenNot=int.Parse(Console.ReadLine());
    not+=girilenNot;
    notsayisi++;
}
Console.WriteLine("Ortalamanız: " +not/10);

*/
//
/*
int tekSayi=0;
int ciftSayi=0;
int sayi=0;
while(sayi<=1000){
if (sayi%2==0)
{
ciftSayi++;
}
else{
    tekSayi++;
}
sayi++;
}
Console.WriteLine("{0} adet tek sayı {1} adet çift sayı mevcuttur.",tekSayi,ciftSayi);
*/
//SAYI TAHMİN OYUNU

/*
Random rnd = new Random();
int randomSayi =rnd.Next(1,100);
int randomSayi2 =rnd.Next(1,100);
int tahmin=1;
Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz 1 ile 100 arasında tutulan değeri tahmin etmeye çalışınız");
while (tahmin<=10)
{
    Console.WriteLine("Tahmininizi giriniz:");
    int girilenSayi=int.Parse(Console.ReadLine());
    if(tahmin==10)
    {
        if (girilenSayi!=randomSayi) 
        {
            Console.WriteLine("Maalesef bilemediniz doğru tahmin {0} olacaktı."+randomSayi);
            Console.WriteLine("Tekrar oynamak istiyorsanız 1 yazınız.");
            int devam=int.Parse(Console.ReadLine());
            if (devam==1)
            {
                tahmin=6;
                
            }
           
            else
            {
                break;
            }

            
        }
    }
    if(girilenSayi>randomSayi)
    {
    Console.WriteLine("Aşağı");
    }
    if(girilenSayi<randomSayi)
    {
        Console.WriteLine("Yukarı");
    }

    if(girilenSayi==randomSayi)
    {
        Console.WriteLine("Tebrikler kazandınız");
        break;
    }
    

    tahmin++;
}
*/
/*
Console.WriteLine("Merhaba, lütfen kaç adet not gireceğinizi yazınız.");
int notAdet=int.Parse(Console.ReadLine());
int[] nots=new int[notAdet];
for(int i=0;i<notAdet;i++)
{
    Console.WriteLine(" {0}. notunuzu giriniz",i+1);
    nots[i]=int.Parse(Console.ReadLine());
    
    
}
for(int j=0;j<notAdet;j++)
{
    Console.WriteLine(nots[j]);
}
*/
/*
int[] nots=new int[10];
Random rnd =new Random();
for(int i=0;i<nots.Length;i++)
{
    nots[i]=rnd.Next(1,100);
    Console.WriteLine(nots[i]);
}
for(int j=0;j<nots.Length;j++)
{
 Console.WriteLine(nots[j]);
}
*/
/*
string[] stringDizi=new string[10];

Random rnd =new Random();

for (int i=0;i<10;i++)
{
    string randomString="";
    for(int j=0;j<=10;j++)
    {
        char random = (char)rnd.Next('A','Z');
        randomString+=random.ToString();
    }
    stringDizi[i]+=randomString;
    Console.WriteLine(stringDizi[i]);
    
}
*/
//SAYISAL LOTO OYUNU
// kullanıcıdan 1-49 arası sayı alınır
// 6 adet 1 ile 1-49 arası değer üretip diziye doldurulur
// iki dizi birbiri ile karşılaştırılır
// kaç adet doğru tahmin girildiği ekrana yazdırılır

Console.WriteLine("Merhaba, lütfen 1 ile 49 arası sayı  tahmini giriniz.");
int[] loto=new int[6];
int[] tahmin=new int[6];
for(int j=0;j<5;j++)
{   
    Random rnd =new Random();
    for(int i=0;i<6;i++)
    {
        loto[i]=rnd.Next(1,49);
    }
}
for(int i=0;i<6;i++)
{
    Console.WriteLine(loto[i]);
    Console.WriteLine(" {0}. tahmini giriniz",i+1);
    tahmin[i]=int.Parse(Console.ReadLine());
}
for (int i=0;i<6;i++)
{
    if(tahmin[i]==loto[i])
    {
        Console.WriteLine("Tebrikler!!!Kazandınız.");
        break;
    }
    else
    {
        Console.WriteLine("!!KAYBETTİNİZ ŞANS OYUNU PİŞMANLIKTIR!!");
        break;
    }
 
}

/*
Console.WriteLine("Merhaba, lütfen kaç adet not gireceğinizi yazınız.");
int notAdet=int.Parse(Console.ReadLine());
int[] nots=new int[notAdet];
for(int i=0;i<notAdet;i++)
{
    Console.WriteLine(" {0}. notunuzu giriniz",i+1);
    nots[i]=int.Parse(Console.ReadLine());
    
    
}
for(int j=0;j<notAdet;j++)
{
    Console.WriteLine(nots[j]);
}
*/
/*
int[] nots=new int[10];
Random rnd =new Random();
for(int i=0;i<nots.Length;i++)
{
    nots[i]=rnd.Next(1,100);
    Console.WriteLine(nots[i]);
}
for(int j=0;j<nots.Length;j++)
{
 Console.WriteLine(nots[j]);
}
*/
/*
string[] stringDizi=new string[10];

Random rnd =new Random();

for (int i=0;i<10;i++)
{
    string randomString="";
    for(int j=0;j<=10;j++)
    {
        char random = (char)rnd.Next('A','Z');
        randomString+=random.ToString();
    }
    stringDizi[i]+=randomString;
    Console.WriteLine(stringDizi[i]);
    
}
*/
//SAYISAL LOTO OYUNU
// kullanıcıdan 1-49 arası sayı alınır
// 6 adet 1 ile 1-49 arası değer üretip diziye doldurulur
// iki dizi birbiri ile karşılaştırılır
// kaç adet doğru tahmin girildiği ekrana yazdırılır

/* 
Console.WriteLine("Merhaba, sayısal loto simülasyonuna hoşgeldiniz.");
int[] loto=new int[6];
int[] tahmin=new int[6];
tahmin[1]=19;tahmin[2]=47;tahmin[3]=23;tahmin[4]=22;tahmin[5]=11;tahmin[0]=20;
int haftaSayisi=0;

for(int j=0;j<5;j++)
{   
    Random rnd =new Random();
    for(int i=0;i<6;i++)
    {
        loto[i]=rnd.Next(1,49);
    }
}
for(int j=0;j<100000;j++)
{

    for (int i=0;i<6;i++)
{
    if(tahmin[i]==loto[i])
    {
        Console.WriteLine("Tebrikler!!!Kazandınız.");
        break;
        haftaSayisi++;
    }
    else
    {
        Console.WriteLine("!!KAYBETTİNİZ ŞANS OYUNU PİŞMANLIKTIR!!");
        haftaSayisi++;
    }
    
}
}
Console.WriteLine("{0} TL harcadınız.",haftaSayisi*15);
*/
/*
int tahminEdilenNo=0;
int haftaSayisi=0;
int[] random = new int[6];
int[] tahmin = new int[6];
tahmin[0]=20;tahmin[1]=19;tahmin[2]=47;tahmin[3]=23;tahmin[4]=22;tahmin[5]=11;
Random rnd = new Random();
for(int i = 0; i < 6;i++)
{

    random[i]=rnd.Next(1,49);
}
for(int k = 0;k<1000000;k++)
{
    for(int i = 0;i<random.Length;i++)
    {

    for(int j=0;j<random.Length;j++)
    {

        if(random[i]==tahmin[j])
        {

            tahminEdilenNo++;

        }
        if(tahminEdilenNo==5)
        {
            Console.WriteLine("{0} TL harcadınız.",haftaSayisi*15);
            Console.WriteLine("Şanslı sayılar {0}{1}{2}{3}{4}{5}",random[0],random[1],random[2],random[3],random[4],random[5]);
            break;
        }
        haftaSayisi++;
    }

    }
}
*/
//ALINAN DİZİYİ TERS ÇEVİRİP EKRANA YAZDIRMAK
/*
Console.WriteLine("Merhaba, lütfen 10 adet sayı yazınız.");

int[] sayi=new int[10];
int[] terSayi=new int[sayi.Length];
int sayac=0;
for(int i=0;i<10;i++)
{
    Console.WriteLine(" {0}. sayıyı giriniz",i+1);
    sayi[i]=int.Parse(Console.ReadLine());
}
 for(int j=9;j>=0;j--)
    {
        terSayi[sayac]=sayi[j];
        sayac++;
    }
    for(int i=0;i<10;i++)
    {
    Console.WriteLine(terSayi[i]);
    }
*/
//
/*
Array.Reverse
*/
// See https://aka.ms/new-console-template for more information

// Karar mekanizmaları bir yazılımın en önemli bileşenidir.
// Derleyiciye belli değerlere göre, belli kod bloklarını çalıştırmasını söylemek, karar yapılarını açıklar.

// bir koşul 
// koşul true ise, bu kod çalışssın
// değilse bu kod bloğu çalışssın

// Kaç farklı koşul işlemi tipi var : 2
// bunlar;
// If - Else IF-Else
// Switch Case


// If Yöntemi
// syntax
/*

// Koşul değişkeni, her zaman mantıksal operatörlerden gelen bir değer olmalıdır (True,False)
// yani if her zaman true yada false değerine göre karar verir.


if(Koşul)
{
    // koşul true ise, bu kod bloğu çalışacaktır.
    
}

// Bir örnek açıklayalım
*/

//bool isOk = false;
// if parantezi, ya true false değer alır, yada true false değer üretecek bir mantıksal operatör işlemi alır.
//Console.WriteLine("A");
//if(isOk)
//{
//    Console.WriteLine("B");
//}
//Console.WriteLine("C");


// Bool değişken yerine, mantıksal oparatör kullanalım
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isOk = intDegisken > 5;
if(isOk)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/
// İf içerisinde bir değişken değilde, mantıksal değer üretecek olan bir kod bloğu yazabiliriz.
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken>5)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/


// Bir örnek daha
/*Console.WriteLine("Lütfen bir sayı giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isCift = intDegisken%2 == 0;
if(isCift)
{
    Console.WriteLine("Girmiş olduğunuz sayı çift sayıdır.");
}  
if(isCift!=true){
   Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
}
*/

// if - else
/*Console.WriteLine("Bir sayi giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken%2 == 0)
{
    // yukarıdaki koşul işlemi true ise bu blok çalığır
    Console.WriteLine("Girmiş olduğunuz sayı çift sayı");
}
else{
    // yukarıdaki koşul işlemi false bu blok çalışır
    Console.WriteLine("Girmiş olduğunuz sayı tek sayı");
}
Console.WriteLine("Uygulama sonu");


// Örnek : ekrandan bir karakter alalım, bu karakter büyük harf ise, ekrana büyük harf, 
// küçük harf ise, ekrana küçük harf yazdıran bir uygulama yapınız

*/
// Süre 10 dakikadır.
/*

// Ekrandan bir string karakter alıp, büyük yada küçük harf olduğunu ekrana yazdıran uygulama
Console.WriteLine("Lütfen küçük yada büyük bir harf giriniz");
char charKarakter = char.Parse(Console.ReadLine());
int intDegisken = Convert.ToInt32(charKarakter);
if(intDegisken>64 && intDegisken<91){
    // true ise bu blok çalışır
    Console.WriteLine("Girdiğiniz harf büyük harf");
}
else{
    Console.WriteLine("Girdiğiniz harf küçük harf");
}
*/
// Kullanıdan not bilgisini alınız.(Not 50 den düşük ise, kaldı, büyük ise geçti yazdırınız)
/*Console.WriteLine("Lütfen aldığınız notu yazınız");
int not = int.Parse(Console.ReadLine());
if(not<50){
    Console.WriteLine("Kaldın");
}
else{
    System.Console.WriteLine("Geçtin");
}

*/
// Örnek : 
// Kullanıcıdan aldığınız username=wissen ve password=1010'a eşitse, 
//ekrana giriş başarılı, değilse, giriş başarısız yazan uygulamayı yapınız

/*
Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010"){
    Console.WriteLine("Hoşgeldiniz");
}
else{
    Console.WriteLine("Kullanıcı yada şifre hatalı");
}
*/


// İf ve Else koşullarında, eğer bu blokların içerisinde tek bir satır kod yazacaksak, parantez yapmamıza gerek yoktur.
// yukarıdaki örneği bu şekilde yazalım

/*Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010")
    Console.WriteLine("Hoşgeldiniz");
else
    Console.WriteLine("Kullanıcı yada şifre hatalı");
*/

// Ekrandan bir ürün fiyatı değeri alalım, ürün fiyatı değeri 100'den büyük ise %20 kdv payı ekleyip ekranda gösterelim
// ürün fiyatı 100'den küçük ise, %30 indirim yapıp ekrana yazdıralım
/*
Console.WriteLine("Lütfen ürün fiyatını giriniz");
double productPrice = double.Parse(Console.ReadLine());

if(productPrice<100){
    double newPrice = productPrice-(productPrice*0.3);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}
else{

    double newPrice = (productPrice*1.2);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}*/


// İç İçe İf
// syntax
/*
if(koşul)
{
    if(koşul)
    {
        
    }
    else
    {
    }
}
else
{
    if(koşul)
    {
    }
    else
    {
    }
}
*/


// Örnek :
/*
Console.WriteLine("Lütfen not giriniz");
int not = int.Parse(Console.ReadLine());
if(not<50)
{

    if(not<25){
        Console.WriteLine("Sınıfta kaldın");

    }
    else{
        Console.WriteLine("Düşük seviyeli geçtin");
    }
}
else{
    if(not<75){
        Console.WriteLine("Orta seviyeli geçtin");
    }
    else{
        Console.WriteLine("Çok iyi seviye ile geçtin");
    }
}
*/


// IF - Else If- Else Blokları(Çoklu case kontrolü)

// If ve Else kullanımında, derleyici iki tek bir kontrol yapıyordu.
// If bloğunda kapılan kontrol ıf bloğu şartına uyuyorsa, if çalışıyordu,
// uymuyorsa, else çalışıyordu.

// Peki, eğer birden fazla koşum varsa ve ben bu koşulları, her birini if gibi değerlendirmek istiyorsam

/*
if(Koşul)
{
}
else if(koşul)
{
}
else if(koşul)
{
}
else
{

}
*/

// if -else if-else konusunda bir örnek

//Console.WriteLine("Not giriniz");
//int not = int.Parse(Console.ReadLine());

// not 0-24 arasındaysa, 1
// not 25-44 arasındaysa 2
// not 45-60 arasındaysa 3
// not 59-84 arasındaysa 4
// not 85 ve 100 arasındaysa 5

/*
if(not>0 && not<24){
    Console.WriteLine("1 aldın");
}
else if(not>=25 && not<=44){
    Console.WriteLine("2 aldın");
}
else if(not>45 && not<=60){
    Console.WriteLine("3 aldın ");
}
else if (not>60 && not<84){
    Console.WriteLine("4 aldın");
}
else if(not>85 && not<100){
    Console.WriteLine("5 aldın");
}
else{
    Console.WriteLine("Lütfen geçerli bir not giriniz");
}
*/
// Bir basit hesap makinası yapalım
// Ekradan iki adet sayı alıp, birde işlem tipi alıp (+,-,/,*) işlem tipine hesap yapan
// kod bloğunu yazalım
// burada ek bir kontrol daha yapalım
// eğer aldığınız bölen sıfır ise, uyarı mesajı verelim/ bölen sıfır olamaz

/*Console.WriteLine("Hesap makinasına hoşgeldiniz");
Console.WriteLine("1 sayıyı giriniz");
     int birinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz");
int ikinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("İşlem tipini giriniz(+,-,/,*)");
string islemTipi =Console.ReadLine();
*/
/* 1. case
if(islemTipi=="/" && ikinciSayi!=0){
    // programı devam ettir
}
else{
    // bölen sıfır olamaz
}
*/
// 2. case
/*if(islemTipi=="+"){
    Console.WriteLine(birinciSayi+ikinciSayi);
}
else if(islemTipi=="-"){
    Console.WriteLine(birinciSayi-ikinciSayi);
}
else if(islemTipi=="*"){
    Console.WriteLine(birinciSayi*ikinciSayi);   
}
else if(islemTipi=="/"){
    if(ikinciSayi!=0){
        Console.WriteLine(birinciSayi/ikinciSayi);
    }
    else{
        // yukarıda 0 değilse, kontrolü var, değer 0'ı ise burası çalışacak
        Console.WriteLine("Bölen sıfır olamaz");
    }
}
// if veya else if'ler else olmadan çalışabilir.
*/

// Üçgenin alanı ve çevresi ve dairenin alanı ve çevresi hesaplama aracı yapacağız.

// Uygulama çalıştığında, öncelikle programın yapabileceği özellikler ekrana çıksın
// Örnek : Hesaplama için öncelikle şeklin adını sorsun
// değer olarak üçgen yada daire giriniz

// bu değeri girdikten sonra, alan yada çevre hesabı yapmak istediğinizi sorsun
// değer olarak alan yada çevre girin
// daha sonra bu hesaplamalar için gerekli olan parametreleri kullanıcıdan istesin

// daha sonra hesaplama yapıp ekrana sonucu göstersin

/*Console.WriteLine("Hesaplama aracına hoşgeldin");
Console.WriteLine("Hesaplama aracımız üçgen ve daire için çalışmaktadır");
Console.WriteLine("Lütfen ücgen yada daire yazınız");

string sekil = Console.ReadLine();
if (sekil.ToLower() == "ucgen")
{
    Console.WriteLine("Alan hesaplama Alan, Çevre hesaplamak için çevre yazınız");
    string hesapText = Console.ReadLine();
    if (hesapText.ToLower() == "alan")
    {

        // taban* yukseklik/2
        Console.WriteLine("Taban değerini giriniz");
        int taban = int.Parse(Console.ReadLine());
        Console.WriteLine("Yükseklik değeri giriniz");
        int yukseklik = int.Parse(Console.ReadLine());
        // hesaplama
        decimal result = taban * yukseklik / 2;
        Console.WriteLine("Taban değeri {0} yükseklik değeri {1} olan üçgenin alanı : {2}", taban, yukseklik, result);
    }
    else if (hesapText.ToLower() == "cevre")
    {
        Console.WriteLine("1. kenar uzunluğu");
        int birinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("2. kenar");
        int ikinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("3. kenar");
        int ucuncuKenar = int.Parse(Console.ReadLine());
        int result = birinciKenar + ikinciKenar + ucuncuKenar;
        Console.WriteLine("Üçgenin çevre uzunluğu : {0}", result);
    }
    else
    {
        Console.WriteLine("İşlem tipi geçersizdir");
    }
}
else if (sekil.ToLower() == "daire")
{

    Console.WriteLine("Alan hesaplamak için Alan, Çevre hesaplamak için Cevre yazınız");
    string hesapText = Console.ReadLine();
    if (hesapText.ToLower() == "alan")
    {

        Console.WriteLine("Alan hesabı için, yarı çap değerini giriniz");
        int yariCap = int.Parse(Console.ReadLine());
        Console.WriteLine("Yarı çapı : {0} olan dairenin alanı : {1}", yariCap, Math.PI * yariCap * yariCap);
    }
    else if (hesapText.ToLower() == "cevre")
    {

        Console.WriteLine("Çevre hesabı için yarı çap değerini giriniz");
        int yariCap = int.Parse(Console.ReadLine());
        Console.WriteLine("Yarı Çapı {0} olan dairenin çevresi {1}", yariCap, Math.PI * yariCap * 2);
    }
    else
    {
        Console.WriteLine("Geçersiz işlem tipi");
    }

}
else
{
    Console.WriteLine("Geçersiz şekil");
}*/


// if yerin geçen ancak if yazmak istemediğimiz noktada, bazen hızlıca bir değeri kontrol edip ve bir sonuö ettiğimiz bir operatör
// Ternary Operatörü

/* using System.Data;

bool isOk = true;
*/
//if(isOk)){
// console.writeline(doğru)
//}
//else{
//    // console.Writeline(yanlış)
//}


//string degisken = isOk?"Doğru":"Yanlış";

//string metin = "Ok";
//string result =metin=="Ok"?"Sonuç Ok":"sonuç ok değil";

/*Console.WriteLine("Sayi 1");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Sayi 1");
int sayi2=int.Parse(Console.ReadLine());
Console.WriteLine("Seçim giriniz");
char secim = char.Parse(Console.ReadLine());
*/

// ternary operatörü mantıksal değere göre çalışır
// eğer mantıksal operatör true değeri verirse, ? işareti ifadesinden sonraki blok çalışır
// eğer mantıksal operatör false değeri verirse, : işaretinden sonraki blok çalışır.

//int result = secim=='+'?sayi1+sayi2:0;
//Console.WriteLine(result);

// Ternary operatörü : Hızlı bir şekilde değeri birşeyler ile karşılaştırıp karar vermek için kullanılır.
// genelde tek satır if yazmak yerine tercih edilir.
// okunabilirliği düşüktür.



// ekrandan girmiş olduğunuz metin 10 karakterden fazla ise, ekrana çok uzun
// 10 karakterden kısa ise, çok kısa yazdırınız

//Console.WriteLine("Bir metin giriniz");
//string metin = Console.ReadLine();
//string result = metin.Length>=10?"karakter 10 dan büyük":"karakter 10'dan küçük";
//Console.WriteLine(result);

// Ekrandan almış olduğunuz karakter, A ile başlalıyorsa, karakter a iel başlıyor, başlamıyorsa
// karakter a ile başlamıyor yazdırınız
/*
Console.WriteLine("Bir değer giriniz");
string deger = Console.ReadLine();
string result =deger.ToLower().StartsWith("a")?"a ile başlıyor":"a ile başlamıyor";
Console.WriteLine(result);



*/
// Switch Case yapısı
// Örnek ile bakalım

/* Console.WriteLine("1. sayıyı giriniz");
int sayi1 = int.Parse(Console.ReadLine());  
Console.WriteLine("2. sayıyı giriniz");
int sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine("İşlem tipini giriniz");
char tip = char.Parse(Console.ReadLine());
switch (tip)
{
    case '+':
    Console.WriteLine(sayi1+sayi2);
    break;
    case '-':
    Console.WriteLine(sayi1-sayi2);
    break;
    case '*':
    Console.WriteLine(sayi1*sayi2);
    break;
    case '/':

    // bölen sıfır olamaz kontrolü
 // İf ile yapmak
    if(sayi2!=0)
    { 
       Console.WriteLine(sayi1/sayi2);
    }
    else{

        Console.WriteLine("Bölen sıfır olamaz");
    }

    
    Switch Case ile yapmak
    switch (sayi2)
    {
        case 0:
        Console.WriteLine("Bölen sıfır olamaz");
        break;
        default:
        Console.WriteLine(sayi1/sayi2);
        break;

    }

    break;
    default:
    Console.WriteLine("girdiğin işlem tipi hatalı");
    // yukarıdaki hiç bir case uymaz ise, default bloğu çalışır
    // default bloğu olmak zorunda değil
    break;
}
*/


// ekrandan bir gün alınız, bu günün hafta sonu yada h içi olduğunu ekrana yazdırınız
// Örnek : Pazartesi,Salı,Cumartesi


// switch case yapısı aşağıdaki şekilde de kullanılabilir.
/* Console.WriteLine("Bir gün adı giriniz");
string gun =Console.ReadLine();
switch (gun)
{
    case "Pazartesi":
    case "Salı":
    case "Çarşamba":
    case "Perşembe":
    case "Cuma":
    Console.WriteLine("H içi");
    break;
    case "Cumartesi":
    case "Pazar":
    Console.WriteLine("H.Sonu");
    break;
    default:
    Console.WriteLine("Geçersiz");
    break;
}
*/
//NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*/

//NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*///NOT HESAPLAMA
/*
Console.WriteLine("Lütfen vize notunuzu giriniz.");
double vize= (double.Parse(Console.ReadLine()))*0.3;
Console.WriteLine("Lütfen final notunuzu giriniz");
int final= int.Parse(Console.ReadLine());
double final1 = final*0.70;

if (final<=49)
{
    Console.WriteLine("Final notunuz 50'nin altında olduğu için Bütünlemeye kaldınız.");
}
else if (vize+final1>= 50)
{
    Console.WriteLine("{0} ile dersten geçtiniz.",vize+final1);
}
else   
{
    Console.WriteLine("{0} ile dersten kaldınız. Bütünlemede başarılar",vize+final1);
}
*/
// ÜRÜN FİYATINA GÖRE KARGO BEDELİ EKLEME
/*
Console.WriteLine("Satın almak istediğiniz ürünün fiyatını giriniz.");
int fiyat = int.Parse(Console.ReadLine());
if (fiyat>100) 
{
    Console.WriteLine("Ödenecek toplam tutar: {0}TL.",fiyat);

}
else
{
    Console.WriteLine("Ödenecek toplam tutar {0}TL.",fiyat+50);
}
*/
//sayının pozitif negatif veya sıfır olduğunu belirtmek
/* 
Console.WriteLine("Lütfen herhangi bir sayı giriniz");
string sayi=Console.ReadLine();
if (sayi == "0")
{
    Console.WriteLine("Girdiğiniz Sayı 0.");
}
else if (sayi.StartsWith("-") )
{
    Console.WriteLine("Girdiğiniz sayı negatif");
}
else   
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
*/
// DÖRT İŞLEM
/*

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
char islem =char.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi1=int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 1. Sayıyı giriniz");
int sayi2=int.Parse(Console.ReadLine());
if (islem =='/')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("Bölüm 0 olamaz");
    }

    else
    {
          Console.WriteLine(sayi1/sayi2);
    }
  
}
else if (islem =='*')
{
    Console.WriteLine(sayi1*sayi2);
}
else if (islem =='+')
{
    Console.WriteLine(sayi1+sayi2);
}
else if (islem =='-')
{
    Console.WriteLine(sayi1-sayi2);
}
else
{
    Console.WriteLine("Geçersiz işlem.");
}
*/
// 100 ADET RANDOM SAYI ÇEKİP BU SAYILARDAN 
// KAÇ TANESİ ÇİFT SAYI KAÇ TANESİ TEK EKRANA YAZDIRAN UYGULAMA 
/* 
int tek=0;
int cift=0;
int sifir=0;
for (int i=0;i<=1000;i++) 
{
 Random rnd= new Random();
int sayi = rnd.Next(1,99999);
if (sayi == 0)
{
    sifir++;
}

else if(sayi %2== 0)
{
    cift++;
}
else
{
    tek++;
}
}
Console.WriteLine("{0} tane Çift Sayı mevcut",cift);
Console.WriteLine("{0} tane Tek Sayı mevcut",tek);
Console.WriteLine("{0} adet Sıfır seçildi",sifir);
*/

/*
 Random rnd= new Random();
for (int i=0;i<=10;i++) 
{

int intKelime = (char)rnd.Next('A','Z');
char karakter = Convert.ToChar(intKelime);
Console.Write(karakter);
}
*/
//örnek dik üçgen

//girilen sayıların en büyüğü ve en küçüğünü ekrana yazdırma
/*

int buyuk=0;
int kucuk=99999;
for  (int i=0; i<11;i++)
{
    Console.WriteLine("Lütfen bir sayı giriniz");
    
    int sayi1 =int.Parse(Console.ReadLine());
    i++;
    if (buyuk<sayi1)
    {
        buyuk=sayi1;
    }
    else if (sayi1<kucuk)
    {
        kucuk=sayi1; 
    }
}
Console.WriteLine(kucuk);
Console.WriteLine(buyuk);
*/
/*
Console.WriteLine("1'DEN 100'E KADAR RASTGELE ÜRETİLEN SAYIYI TAHMİN ETMEYE ÇALIŞINIZ");
Random rnd=new Random();
int a = rnd.Next();
for (int i = 0; i < 10;i++)
{
    Console.WriteLine("LÜTFEN BİR SAYI GİRİNİZ");
    int girilen=int.Parse(Console.ReadLine());
    if (girilen<a)
    {
        Console.WriteLine("Yukarı");
    }
    else if (girilen==a)
    {
        Console.WriteLine("Tebrikler!!!Doğru tahmin.");
        i=10;
    }
    else
    {
        Console.WriteLine("Aşağı");
    }
}
*/
// GİRİLEN SAYILARIN TOPLAMI ÖRNEĞİ
/* int not=0;
int ortalama = not/10;
for  (int i=0; i<10;i++)
{
    Console.WriteLine("Lütfen {0}. notunuzu girin.",i+1);
    
    int notGirilen =int.Parse(Console.ReadLine());
    not=notGirilen+not;
}
Console.WriteLine("Ortalamanız: {0}",ortalama);
*/
// alınan yazıyı döngü kullanarak ters yazdırmak
/* 
Console.WriteLine("Lütfen bir metin giriniz");
String metin=Console.ReadLine();
string ters="";
for (int i = metin.Length; i >0 ; i--)
{
ters+=metin.Substring(i-1,1);
}
Console.WriteLine(ters);
*/
/*
// ilk ve son hrf büyütme
Console.WriteLine("Lütfen bir metin giriniz");
String metin=Console.ReadLine();
string yeniKelime="";
string ilkHarf="";
for (int i = metin.Length; i >0 ; i--)
{
yeniKelime+=metin.Substring(0,1);
for (int j = 0; j <1 ; j++)
{
yeniKelime.ToUpper();
}
for (int k = metin.Length; k >metin.Length-1 ; k--)
{
yeniKelime.ToUpper();
yeniKelime+=metin;
}
}
Console.WriteLine(yeniKelime);
*/
//Bir metnin içerisindeki rakamları temizleyen kodu yazınız.
/*
// Girilen metindekki rakam,küçük harf,büyükharf ve özel karakter sayılarını ekrana yazdıran program
Console.WriteLine("Lütfen bir metin giriniz");
string metin=Console.ReadLine();
int rakam=0;
int buyukHarf =0;
int kucukHarf=0;
int ozelKarakter=0;
for (int i=0;i<metin.Length;i++)
{
    char charMetin = char.Parse(metin.Substring(i,1));
    if (char.IsNumber(charMetin))
    {
        rakam++;
    }
    else if (char.IsUpper(charMetin))
    {
        buyukHarf++;
    }
     else if (char.IsLower(charMetin))
      {
        kucukHarf++;
      } 
    else
    {
        ozelKarakter++;
    }
    
}
Console.WriteLine("{0} ADET RAKAM. {1} ADET BÜYÜK HARF. {2}ADET KÜÇÜK HARF MEVCUT. {3}ADET ÖZEZL KARAKTER MEVCUT.",rakam, buyukHarf, kucukHarf,ozelKarakter);
*/
//Girilen değere kadar olan asal sayları ekrana yazdırmak

/* 
Console.WriteLine("Lütfen bir sayı giriniz.");
int deger = int.Parse(Console.ReadLine());
int asalDegil=0;
for (int i = 2;i<=deger;i++)
{
    int asal=0;
    for (int j = 2;j<i;j++)
    {
        if (i%j==0)
        {
               asal++;
        }
    }
    if (asal==0)
    Console.WriteLine(i);
}
*/
/*
for(int i=1;i<=10;i++)
{

    for(int j=1;j<=i;j++)
    {
        if(i==1&&j==1)
        {
            Console.Write("X");
            Console.WriteLine("");
            i++;
        }
        if(i==10&&j==1)
        {
            Console.Write("X");
        }
        if(i==10&&j==10)
        {
            Console.Write("X");
            Console.WriteLine("");
        } 
        else
        {
            Console.Write("*");
        }
        
    }
    Console.WriteLine("");
}
*/
/*
for(int i=1;i<=4;i++)
{
    for(int j=1;j<=i;j++)
    {
        for (int k=0;k<=i;k++)
        {
        if(i==0&&j==0)
        {
            Console.WriteLine(" ");
        }
        if(i==0&&j==1)
        {
            Console.WriteLine(" ");
        }
        if(i==0&&j==2)
        {
            Console.WriteLine(" ");
        }
        else 
        {
            Console.Write("x");
        }
        
        }
        Console.WriteLine("");
    }
    
}
*/
/*
using System.Drawing;
Console.BackgroundColor=ConsoleColor.DarkRed;
Console.WriteLine("Değer giriniz.");
int deger=int.Parse(Console.ReadLine());
 for (int i = 0; i < deger; i++)  
{
    for (int j = i; j < deger; j++) 
        {
            Console.Write(" ");
        }
    for (int k = 0; k <= i; k++)
        {
    Console.Write("*");
    Console.Write(" ");
                
        }
    Console.WriteLine();
}
*/

/* string id ="wissen";
string pass ="2409";
string girilenId="";
string girilenPass="";
do
{
 Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
 girilenId=Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
 girilenPass=Console.ReadLine();
 if (girilenId==id && girilenPass==pass)
    {
        Console.WriteLine("Başarıyla giriş yaptınız.");
        break;
    }
    else 
    {
        Console.WriteLine("Giriş başarısız. Lütfen tekrar deneyiniz.");
    }
} while (true);



*/
/*
Console.WriteLine("Kaç adet fibonacci sayısı görmek istersiniz?");
int deger = int.Parse(Console.ReadLine());
 
int fibo1 = 1;
int fibo2 = 1;
 
Console.Write(fibo1 + " " + fibo2 + " ");
 
for (int i = 3; i <= deger; i++)
{
    int fibo3 = fibo1 + fibo2;
    Console.Write(fibo3 + " ");
 
    fibo1 = fibo2;
    fibo2 = fibo3;
}
*/
// 5 adet not alınıp kullanıcıdan alınan veriye göre sıralaması yapılacak veya çıkış yapılacak.
/*
int[] nots=new int[5];
for(int i=0;i<5;i++)
{
    Console.WriteLine(" {0}. notunuzu giriniz",i+1);
    nots[i]=int.Parse(Console.ReadLine());
    
}
Console.WriteLine("Notları sıralamak için 1, uygulamayı kapatmak için 3 yazınız.");
int giris=int.Parse(Console.ReadLine());
if (giris==1){
    for(int j=0;j<5;j++)
    {
    Array.Sort(nots);

    }
}
if (giris==2)
{

}
else if (giris==3)
{
    Console.WriteLine("Uygulama kapatılıyor.");
}
*/
String [] tersDizi=new String[10];
string ters="";
for (int i=0; i<10;i++)
{
    Console.WriteLine("Lütfen bir metin giriniz");
    String metin=Console.ReadLine();
  
for (int j = metin.Length; j >0 ; j--)
{
    ters+=metin.Substring(j-1,1);
    tersDizi[i]=ters;
}

}
for (int i=0; i<10;i++)
{
    Console.WriteLine(tersDizi[i]);
}
// 5 adet not alınıp kullanıcıdan alınan veriye göre sıralaması yapılacak veya çıkış yapılacak.
/*
int[] nots=new int[5];
for(int i=0;i<5;i++)
{
    Console.WriteLine(" {0}. notunuzu giriniz",i+1);
    nots[i]=int.Parse(Console.ReadLine());
    
}
Console.WriteLine("Notları sıralamak için 1, uygulamayı kapatmak için 3 yazınız.");
int giris=int.Parse(Console.ReadLine());
if (giris==1){
    for(int j=0;j<5;j++)
    {
    Array.Sort(nots);

    }
}
if (giris==2)
{

}
else if (giris==3)
{
    Console.WriteLine("Uygulama kapatılıyor.");
}
*/
/*
String [] tersDizi=new String[10];
string ters="";
for (int i=0; i<10;i++)
{
    Console.WriteLine("Lütfen bir metin giriniz");
    String metin=Console.ReadLine();
  
for (int j = metin.Length; j >0 ; j--)
{
    ters+=metin.Substring(j-1,1);
    tersDizi[i]=ters;
}

}
for (int i=0; i<10;i++)
{
    Console.WriteLine(tersDizi[i]);
}
*/
/*
using System.Collections;

ArrayList notlar= new ArrayList();
int toplam=0;


for(int i=0;i<10;i++)
{
    Console.WriteLine("lÜTFEN {0}. NOTUNUZU GİRİNİZ",i+1);
    notlar.Add(int.Parse(Console.ReadLine()));

}
for(int i=0;i<10;i++)
{
toplam+=(int)notlar[i];
}
Console.WriteLine("Notlarınızın toplamı :"+toplam);
Console.WriteLine("Notlarınızın ortalaması: "+toplam/10);
*/
/*
//TAHMİN OYUNU
using System.Collections;
using System.ComponentModel;

int tahmin=0;
Random rnd = new Random();
int a = rnd.Next(1,100);
ArrayList tahminler= new ArrayList();
for(int i=0;i<10;i++)
{
Console.WriteLine("Tahmininizi giriniz");
tahmin =int.Parse(Console.ReadLine());
tahminler.Add(tahmin);
if(i==9)
{
if(tahmin==0)
{
Console.WriteLine("Tebrikler!");
    break;
}
else{
    Console.WriteLine("Kaybettiniz doğru tahmin {0} olacaktı",a);
    Console.WriteLine("Tahminleriniz: ");
    for(int j=0;j<10;j++)
    {
        
        Console.WriteLine(tahminler[j]);
    }

    break;
}
}
if(tahmin<a)
{
Console.WriteLine("Yukarı");
}
else if(tahmin>a){
    Console.WriteLine("AŞAĞI");
}
else{
    Console.WriteLine("Tebrikler!");
    break;
}
}
*/