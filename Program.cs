﻿// See https://aka.ms/new-console-template for more information

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
using System.Collections;

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
/*
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
/*
string id ="wissen";
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
string id ="wissen";
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
using System.Collections;
SortedList plakalar=new SortedList();
plakalar.Add(01,"ADANA");
plakalar.Add(02,"ADIYAMAN");
plakalar.Add(03,"Afyonkarahisar");
plakalar.Add(04,"Ağrı");
plakalar.Add(05,"Amasya");
plakalar.Add(06,"Ankara");
plakalar.Add(07,"Antalya");
plakalar.Add(08,"Artvin");
plakalar.Add(09,"Aydın");
plakalar.Add(10,"Balıkesir");
plakalar.Add(11,"Bilecik");
plakalar.Add(12,"Bingöl");
plakalar.Add(13,"Bitlis");
plakalar.Add(14,"Bolu");
plakalar.Add(15,"Burdur");
plakalar.Add(16,"Bursa");
plakalar.Add(17,"Çanakkale");
plakalar.Add(18,"Çankırı");
plakalar.Add(19,"Çorum");
plakalar.Add(20,"Denizli");
plakalar.Add(21,"Diyarbakır");
plakalar.Add(22,"Edirne");
plakalar.Add(23,"Elazığ");
plakalar.Add(24,"Erzincan");
plakalar.Add(25,"Erzurum");
plakalar.Add(26,"Eskişehir");
plakalar.Add(27,"Gaziantep");
plakalar.Add(28,"Giresun");
plakalar.Add(29,"Gümüşhane");
plakalar.Add(30,"Hakkari");
plakalar.Add(31,"Hatay");
plakalar.Add(32,"Isparta");
plakalar.Add(33,"Mersin");
plakalar.Add(34,"İstanbul");
plakalar.Add(35,"İzmir");
plakalar.Add(36,"Kars");
plakalar.Add(37,"Kastamonu");
plakalar.Add(38,"Kayseri");
plakalar.Add(39,"Kırklareli");
plakalar.Add(40,"Kırşehir");
plakalar.Add(41,"Kocaeli");
plakalar.Add(42,"Konya");
plakalar.Add(43,"Kütahya");
plakalar.Add(44,"Malatya");
plakalar.Add(45,"Manisa");
plakalar.Add(46,"Kahramanmaraş");
plakalar.Add(47,"Mardin");
plakalar.Add(48,"Muğla");
plakalar.Add(49,"Muş");
plakalar.Add(50,"Nevşehir");
plakalar.Add(51,"Niğde");

for (int i = 0;i<51;i++)
{
    string sehir = plakalar.GetByIndex(i).ToString();
    string plaka = plakalar.GetKey(i).ToString();
    Console.WriteLine(plaka);
    Console.WriteLine(sehir);
    Console.WriteLine("----");
    
}
/*
using System.Collections;
Console.WriteLine("Lütfen girmekistediğiniz not adetini yazınız.");
int notsayisi = int.Parse(Console.ReadLine());
ArrayList nots = new ArrayList(notsayisi);
int not=0;
int a=1;
int toplam =not;

foreach (var item in nots)
{
    Console.WriteLine("Lütfen {0}. notunuzu girin.",a);
    not+=int.Parse(Console.ReadLine());
    a++;
}
Console.WriteLine("TOPLAM {0} ORTALAMA{1}",toplam,toplam/notsayisi);
Random random= new Random();
*/
using System.Globalization;

int[] sayi1 = new int[10]{1,2,3,4,5,6,7,8,9,10,};
int[] sayi2 = new int[10]{1,2,3,4,5,6,7,8,9,10,};
foreach (int i in sayi1)
{
    int a=0;
   foreach (int j in sayi2)
   {
    
   }
   Console.WriteLine(i*);
}


// Metotlar, iş yapan küçük program parçalarıdır.
// Metotlar, içlerine  aldıkları değerler ve size geriye döndürdükleri değerler ile birlikte çalışır


// Gerçek hayatta problemler ile karşılaştığımızda, onları çözüm yoluna gideriz.
// Genelde büyük problemler karşımıza çıktığında, büyük bir problem ile uğraşmak oldukça zordur.

// Bu tarz durumlarda, küçük bir problemi, küçük parçalar haline bölüp çözmeye çalışmak önerilir.

// Yazılım tarafındaki büyük boyuttaki işler gerçek hayattaki probleme benzer. Eğer bu tip işleri
// o boyutuyla çözmeye çalışırsak, genelde çok karmaşık çözümlerle karşılaşırız

// problemi ufak çarçalara ayırmak yazılım dünyasında, metotlara denk gelir.

// Metotlar, yukarıda da belirttiğimiz gibi ufak kod parçacıklarıdır. Her bir problem çözümünü ufak metotlara ayırarak, 
// problem çözüm süresici boyunca başarılı olunur.

// Metot türleri nelerdir. 
// 1- Parametre alan metotlar(bir parametre alabildiği gibi n adet parametre alabilir)
// 2- Geriye değer döndüren metotlar(çalıştıktan sonra bir değer üretiyor ve onu dönüyor ise değer döndüren metotdur.)
// 3- Parametre almayan metot(Dışarıdan parametre içeride bir şekilde kendi işini kendi yapan metotdur)
// 4- Geriye değer döndürmeyen metotlar(Çalıştıktan sonra geriye bir değer döndürmeyen metotdur.)

// Metot Syntax : 

/*erişim belirteci + static/ yada static olmama + geri dönüş tipi / yada değer dönmeyecekse void + Metot Adı(Metot Parametreleri){



}*/

// yukarıdaki imzayı biraz açalım

// Erişim belirteçler: bir metodun hangi katmandan yada nereden erişebileceğini belirler
// Erişim belirteçler şunlardır

// Public 
// Private
// Protected
// Protected Internal
// Internal

// yukarıdaki erişim belirteçlerden bir süre  sadece public olanı kullanacağız, diğer erişim belirteçlere daha sonra deyineceğiz.

// Static yada Static olmama : Metotlar için en önemli kavramlardan bir tanesidir. Bu belirteçten şimdilik sadece static olanı kullanacağız. Static olamama durumu daha sonra deyineceğiz

// Geri Dönüş tipi : Bir metotdan geriye .net içerisindeki tüm değişken tipleri dönebilir.Ancak metot geriye değer döndürmüyor ise, void olarak işaretlenmelidir.

// Metot Adı : Metot adı, metodun yapacağı iş ile ilgili olmaldır.(tek harf metot olmamalıdır.)

// Metot isimlendirme kuralları

/*
Metot adı tek harf olmamalıdır.
Metot adından önce rakam veya karakter kullanılmamalıdır.
Metot adı metodun yapacağı iş ile ilgili olmalıdır
Metot adı çok uzun olmamalıdır
Metotlar isimlendirilirken Pascal Casing kullanılmalıdır Örnek : WissenMetot yani metot isminin baş harfi büyük sonraki harfler küçük olmaldırı
Eğer metot adı iki kelime ise, her kelimenin baş harfi büyük geri kalan harfler küçük olmalıdır.
*/

// Metot Parametreleri : Bir metot 1 yada birden çok parametre alabilir Parametre sayısının bir sınırı yoktur.Aynı yeri dönüş tipinde olduğu gibi bir metot .net ilçeridsindeki tüm değişken tiplerini parametre olarak alabilir


// Bazı kurallar : 
/*

Metot yazarken, satır sayısı na dikkat edilmelidir. Bu bir yazılım görgü kuralıdır. 30-34 satır kodu geçmemelidir.
Aynı şekilde metot parametrelerinde de bir genel geçer kural vardır. Metot parametre sayısı 4'ü geçerse buraya bir önlem alınması gerektiğini söyler.


// Metot yazalım 

// Parametre alan ve geriye değer döndüren bir metot yazalım 

 

*/
/*
string ters = TersCevir("wissen besiktas");

Console.WriteLine(ters);



static string TersCevir(string deger ){

    // parametre olarak aldığı değeri ters çevirip geri döndüren bir metot yazalım
    string ters ="";
    for (int i = deger.Length - 1; i >= 0 ; i--)
    {
        ters+=deger[i];
    }
    return ters;
}



*/


using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Lütfen yarıçap değeri giriniz.");
int cap =int.Parse(Console.ReadLine());
double alan =yariCapMetod(30);
Console.WriteLine(alan);



static double yariCapMetod(int yaricap )
{
    double alan=yaricap*yaricap*Math.PI;
    return alan;
}


// Metotlar, iş yapan küçük program parçalarıdır.
// Metotlar, içlerine  aldıkları değerler ve size geriye döndürdükleri değerler ile birlikte çalışır


// Gerçek hayatta problemler ile karşılaştığımızda, onları çözüm yoluna gideriz.
// Genelde büyük problemler karşımıza çıktığında, büyük bir problem ile uğraşmak oldukça zordur.

// Bu tarz durumlarda, küçük bir problemi, küçük parçalar haline bölüp çözmeye çalışmak önerilir.

// Yazılım tarafındaki büyük boyuttaki işler gerçek hayattaki probleme benzer. Eğer bu tip işleri
// o boyutuyla çözmeye çalışırsak, genelde çok karmaşık çözümlerle karşılaşırız

// problemi ufak çarçalara ayırmak yazılım dünyasında, metotlara denk gelir.

// Metotlar, yukarıda da belirttiğimiz gibi ufak kod parçacıklarıdır. Her bir problem çözümünü ufak metotlara ayırarak, 
// problem çözüm süresici boyunca başarılı olunur.

// Metot türleri nelerdir. 
// 1- Parametre alan metotlar(bir parametre alabildiği gibi n adet parametre alabilir)
// 2- Geriye değer döndüren metotlar(çalıştıktan sonra bir değer üretiyor ve onu dönüyor ise değer döndüren metotdur.)
// 3- Parametre almayan metot(Dışarıdan parametre içeride bir şekilde kendi işini kendi yapan metotdur)
// 4- Geriye değer döndürmeyen metotlar(Çalıştıktan sonra geriye bir değer döndürmeyen metotdur.)

// Metot Syntax : 

/*erişim belirteci + static/ yada static olmama + geri dönüş tipi / yada değer dönmeyecekse void + Metot Adı(Metot Parametreleri){



}*/

// yukarıdaki imzayı biraz açalım

// Erişim belirteçler: bir metodun hangi katmandan yada nereden erişebileceğini belirler
// Erişim belirteçler şunlardır

// Public 
// Private
// Protected
// Protected Internal
// Internal

// yukarıdaki erişim belirteçlerden bir süre  sadece public olanı kullanacağız, diğer erişim belirteçlere daha sonra deyineceğiz.

// Static yada Static olmama : Metotlar için en önemli kavramlardan bir tanesidir. Bu belirteçten şimdilik sadece static olanı kullanacağız. Static olamama durumu daha sonra deyineceğiz

// Geri Dönüş tipi : Bir metotdan geriye .net içerisindeki tüm değişken tipleri dönebilir.Ancak metot geriye değer döndürmüyor ise, void olarak işaretlenmelidir.

// Metot Adı : Metot adı, metodun yapacağı iş ile ilgili olmaldır.(tek harf metot olmamalıdır.)

// Metot isimlendirme kuralları

/*
Metot adı tek harf olmamalıdır.
Metot adından önce rakam veya karakter kullanılmamalıdır.
Metot adı metodun yapacağı iş ile ilgili olmalıdır
Metot adı çok uzun olmamalıdır
Metotlar isimlendirilirken Pascal Casing kullanılmalıdır Örnek : WissenMetot yani metot isminin baş harfi büyük sonraki harfler küçük olmaldırı
Eğer metot adı iki kelime ise, her kelimenin baş harfi büyük geri kalan harfler küçük olmalıdır.
*/

// Metot Parametreleri : Bir metot 1 yada birden çok parametre alabilir Parametre sayısının bir sınırı yoktur.Aynı yeri dönüş tipinde olduğu gibi bir metot .net ilçeridsindeki tüm değişken tiplerini parametre olarak alabilir


// Bazı kurallar : 
/*

Metot yazarken, satır sayısı na dikkat edilmelidir. Bu bir yazılım görgü kuralıdır. 30-34 satır kodu geçmemelidir.
Aynı şekilde metot parametrelerinde de bir genel geçer kural vardır. Metot parametre sayısı 4'ü geçerse buraya bir önlem alınması gerektiğini söyler.


// Metot yazalım 

// Parametre alan ve geriye değer döndüren bir metot yazalım 

 

*/
/*
string ters = TersCevir("wissen besiktas");

Console.WriteLine(ters);



static string TersCevir(string deger ){

    // parametre olarak aldığı değeri ters çevirip geri döndüren bir metot yazalım
    string ters ="";
    for (int i = deger.Length - 1; i >= 0 ; i--)
    {
        ters+=deger[i];
    }
    return ters;
}



*/
/*
int []sayilar= new int[10];
int teksayi=0;
int ciftSayi=0;
int tekToplam=0;
int CiftToplam=0;
Console.WriteLine("Hoşgeldiniz...");
for (int i=0; i<10;i++)
{
    Console.Write("LÜTFEN {0}. SAYIYI GİRİNİZ: ",i+1);
    int girilen=int.Parse(Console.ReadLine());
    sayilar[i]=girilen;
    if (girilen%2==0)
    {
        ciftSayi++;
        CiftToplam+=girilen;
    }
    else 
    {
        teksayi++;
        tekToplam+=girilen;
    }
    

}
Console.WriteLine("{0} adet tek sayı, {1} adet çift sayı girdiniz." ,teksayi,ciftSayi);
Console.WriteLine("Tek sayıların toplamı {0}. Çift sayıların toplamı {1}",tekToplam,CiftToplam);
if (CiftToplam<tekToplam)
{
    Console.WriteLine("Tek sayıların toplamı daha büyüktür");
}
else if (CiftToplam>tekToplam)
{
        Console.WriteLine("Çift sayıların toplamı daha büyüktür");
}
else{
    Console.WriteLine("Girdiğiniz tek ve çift sayıların toplamları eşittir.");
}
for (int i=0; i<sayilar.Length;i++)
{
    System.Console.WriteLine(sayilar[i]);
}
*/
/*
static bool tekmiciftmi (int sayi)
{
    if (sayi %2==0)
    {
    return true;
    }
    else
    {
    return false;
    }
}
bool kontrol=tekmiciftmi(9);
if (kontrol==true)
{
    System.Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    System.Console.WriteLine("Girdiğiniz sayı tektir.");

}
*/
/*
static void buyukolan(int sayi1, int sayi2)
{
    if (sayi1 < sayi2)
    {
        System.Console.WriteLine("Büyük sayı : "+ sayi2);
    }
    else if (sayi1 > sayi2)
    {
        System.Console.WriteLine("Büyük sayı : "+1 sayi1);

    }
    else
    {
        System.Console.WriteLine("Girdiğiniz sayılar eşittir");
    }
}
Console.WriteLine("1.sayıyı girin.");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("2.sayıyı girin.");
int b = int.Parse(Console.ReadLine());
buyukolan(a, b);
*/

string metin="";
int deger=1;
static bool TryBarse(string? metin, out int deger)
{
    int harf=0;
    for (int i=0; i<metin.Length;i++)
    {
        metin.Substring(i,metin.Length-1);
        if (metin.)
    }
   
}


// Metotlar, iş yapan küçük program parçalarıdır.
// Metotlar, içlerine  aldıkları değerler ve size geriye döndürdükleri değerler ile birlikte çalışır


// Gerçek hayatta problemler ile karşılaştığımızda, onları çözüm yoluna gideriz.
// Genelde büyük problemler karşımıza çıktığında, büyük bir problem ile uğraşmak oldukça zordur.

// Bu tarz durumlarda, küçük bir problemi, küçük parçalar haline bölüp çözmeye çalışmak önerilir.

// Yazılım tarafındaki büyük boyuttaki işler gerçek hayattaki probleme benzer. Eğer bu tip işleri
// o boyutuyla çözmeye çalışırsak, genelde çok karmaşık çözümlerle karşılaşırız

// problemi ufak çarçalara ayırmak yazılım dünyasında, metotlara denk gelir.

// Metotlar, yukarıda da belirttiğimiz gibi ufak kod parçacıklarıdır. Her bir problem çözümünü ufak metotlara ayırarak, 
// problem çözüm süresici boyunca başarılı olunur.

// Metot türleri nelerdir. 
// 1- Parametre alan metotlar(bir parametre alabildiği gibi n adet parametre alabilir)
// 2- Geriye değer döndüren metotlar(çalıştıktan sonra bir değer üretiyor ve onu dönüyor ise değer döndüren metotdur.)
// 3- Parametre almayan metot(Dışarıdan parametre içeride bir şekilde kendi işini kendi yapan metotdur)
// 4- Geriye değer döndürmeyen metotlar(Çalıştıktan sonra geriye bir değer döndürmeyen metotdur.)

// Metot Syntax : 

/*erişim belirteci + static/ yada static olmama + geri dönüş tipi / yada değer dönmeyecekse void + Metot Adı(Metot Parametreleri){



}*/

// yukarıdaki imzayı biraz açalım

// Erişim belirteçler: bir metodun hangi katmandan yada nereden erişebileceğini belirler
// Erişim belirteçler şunlardır

// Public 
// Private
// Protected
// Protected Internal
// Internal

// yukarıdaki erişim belirteçlerden bir süre  sadece public olanı kullanacağız, diğer erişim belirteçlere daha sonra deyineceğiz.

// Static yada Static olmama : Metotlar için en önemli kavramlardan bir tanesidir. Bu belirteçten şimdilik sadece static olanı kullanacağız. Static olamama durumu daha sonra deyineceğiz

// Geri Dönüş tipi : Bir metotdan geriye .net içerisindeki tüm değişken tipleri dönebilir.Ancak metot geriye değer döndürmüyor ise, void olarak işaretlenmelidir.

// Metot Adı : Metot adı, metodun yapacağı iş ile ilgili olmaldır.(tek harf metot olmamalıdır.)

// Metot isimlendirme kuralları

/*
Metot adı tek harf olmamalıdır.
Metot adından önce rakam veya karakter kullanılmamalıdır.
Metot adı metodun yapacağı iş ile ilgili olmalıdır
Metot adı çok uzun olmamalıdır
Metotlar isimlendirilirken Pascal Casing kullanılmalıdır Örnek : WissenMetot yani metot isminin baş harfi büyük sonraki harfler küçük olmaldırı
Eğer metot adı iki kelime ise, her kelimenin baş harfi büyük geri kalan harfler küçük olmalıdır.
*/

// Metot Parametreleri : Bir metot 1 yada birden çok parametre alabilir Parametre sayısının bir sınırı yoktur.Aynı yeri dönüş tipinde olduğu gibi bir metot .net ilçeridsindeki tüm değişken tiplerini parametre olarak alabilir


// Bazı kurallar : 
/*

Metot yazarken, satır sayısı na dikkat edilmelidir. Bu bir yazılım görgü kuralıdır. 30-34 satır kodu geçmemelidir.
Aynı şekilde metot parametrelerinde de bir genel geçer kural vardır. Metot parametre sayısı 4'ü geçerse buraya bir önlem alınması gerektiğini söyler.


// Metot yazalım 

// Parametre alan ve geriye değer döndüren bir metot yazalım 

 

*/
/*
string ters = TersCevir("wissen besiktas");

Console.WriteLine(ters);



static string TersCevir(string deger ){

    // parametre olarak aldığı değeri ters çevirip geri döndüren bir metot yazalım
    string ters ="";
    for (int i = deger.Length - 1; i >= 0 ; i--)
    {
        ters+=deger[i];
    }
    return ters;
}



*/
/*
int []sayilar= new int[10];
int teksayi=0;
int ciftSayi=0;
int tekToplam=0;
int CiftToplam=0;
Console.WriteLine("Hoşgeldiniz...");
for (int i=0; i<10;i++)
{
    Console.Write("LÜTFEN {0}. SAYIYI GİRİNİZ: ",i+1);
    int girilen=int.Parse(Console.ReadLine());
    sayilar[i]=girilen;
    if (girilen%2==0)
    {
        ciftSayi++;
        CiftToplam+=girilen;
    }
    else 
    {
        teksayi++;
        tekToplam+=girilen;
    }
    

}
Console.WriteLine("{0} adet tek sayı, {1} adet çift sayı girdiniz." ,teksayi,ciftSayi);
Console.WriteLine("Tek sayıların toplamı {0}. Çift sayıların toplamı {1}",tekToplam,CiftToplam);
if (CiftToplam<tekToplam)
{
    Console.WriteLine("Tek sayıların toplamı daha büyüktür");
}
else if (CiftToplam>tekToplam)
{
        Console.WriteLine("Çift sayıların toplamı daha büyüktür");
}
else{
    Console.WriteLine("Girdiğiniz tek ve çift sayıların toplamları eşittir.");
}
for (int i=0; i<sayilar.Length;i++)
{
    System.Console.WriteLine(sayilar[i]);
}
*/
/*
static bool tekmiciftmi (int sayi)
{
    if (sayi %2==0)
    {
    return true;
    }
    else
    {
    return false;
    }
}
bool kontrol=tekmiciftmi(9);
if (kontrol==true)
{
    System.Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    System.Console.WriteLine("Girdiğiniz sayı tektir.");

}
*/
/*
static void buyukolan(int sayi1, int sayi2)
{
    if (sayi1 < sayi2)
    {
        System.Console.WriteLine("Büyük sayı : "+ sayi2);
    }
    else if (sayi1 > sayi2)
    {
        System.Console.WriteLine("Büyük sayı : "+1 sayi1);

    }
    else
    {
        System.Console.WriteLine("Girdiğiniz sayılar eşittir");
    }
}
Console.WriteLine("1.sayıyı girin.");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("2.sayıyı girin.");
int b = int.Parse(Console.ReadLine());
buyukolan(a, b);
*/
/*
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string metin = "";
        int deger = 1;
        static bool TryBarse(string? metin, out int deger)
        {
            int harf = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                metin.Substring(i, metin.Length - 1);
                if (metin.)
    }

        }
        int parametre = 10;
        static bool OverLoad(bool parametre)
        {
            return true;
        }
        static int OverLoad(out int parametre)
        {

            return 10;
        }
    }
}
*/

// OOP :Nesne  OOP dünyadaki her şeye bir object olarak bakan bir bakış açısıdır.

// OOP'nin en tepedeki tipi object tipidir.

// Tüm her şey objectten türer

// OOP şu başlıklardan oluşur : 
// 1- Kalıtım : Inheritance  : Üst soydan özellik aktarımı
// 2-Kapsüllemek : Encapsulation : Özelliklerin, kapsüllenerek dış dünyaya açılması
// 3-Çok biçimlilik Polymorphism : Özelliklerin nasıl kullanılacağı(zorunlu ? 
//opsiyonel ? zorunlu ise davranışı değiştirebilir miyiz ?)


// OOP'nin ilk konusu nesne oluşturma ile başlayalım


// Ogrenci.cs isimli dosyada bir ogrenci isimli class (sınıf) yazdık.
// Program.cs dosyasında Ogrenci sınıfından nesneler oluşturacağız

// Sınıf ve Nesne Kavramı : 

// Sınıf : Nesne içerisinde olması gerken özelliklerin tanımlı olduğu şablondur

// Sınıf : Mimarin çizimidir. Yani özellikerin durmuş olduğu şablondur

// Nesne : Sınıf içerisinde duran şablondan üretilmiş öğelerdir

// Ogrenci sinifindan bir kaç nesne üretelim

// nesne örneği almak : 


// aşağıdaki kod örneği iki parçadan oluşuyor

// bu kısım stack bölgesinde, bir pointer oluşturur
//Ogrenci o1


// bu kısım ise, stack bölgesindeki pointer'in işaret ettiği heap bölgesindeki alanda bir
// bellek register eder.(Aynı zamanda, bu nesnesin taşımış olduğu değişkenlerin
// başlangıç değerlerini belleye yazar)
//new Ogrenci();


/*
Ogrenci ogrenci1 = new Ogrenci();

// değer verelim 
ogrenci1.name="Oğuzhan";
ogrenci1.lastname="Ayaz";
ogrenci1.age=12;

// o1 adında nesnemiz hazır : Ekrana yazdıralım

Console.WriteLine("Ad : {0}",ogrenci1.name);
Console.WriteLine("Soyad : {0}",ogrenci1.lastname);
Console.WriteLine("Yaş : {0}",ogrenci1.age);

*/

// 4 adet öğrenci nesnesi üretip, bir dizi içerisine yerleştirelim

using System.Collections;
using Microsoft.VisualBasic;

Ogrenci ogrenci1=new Ogrenci();
ogrenci1.name="Pınar";
ogrenci1.lastname="Demirtaş";
ogrenci1.age=23;

Ogrenci ogrenci2=new Ogrenci();
ogrenci2.name="Murat";
ogrenci2.lastname="Dedekoca";
ogrenci2.age=10;

Ogrenci ogrenci3=new Ogrenci();
ogrenci3.name="Hilmi";
ogrenci3.lastname="Kanat";
ogrenci3.age=40;

Ogrenci ogrenci4=new Ogrenci();
ogrenci4.name="Büşra";
ogrenci4.lastname="Sarı";
ogrenci4.age=10;

// Bu 4 öğrenci nesnesini bir dizi içerisinde yerleştirelim

Ogrenci[] ogrenciler = new Ogrenci[4];


// Ogrenci dizisi içerisinde Ogrenci nesnelerini yerleştirelim 
ogrenciler[0]=ogrenci1;
ogrenciler[1]=ogrenci2;
ogrenciler[2]=ogrenci3;
ogrenciler[3]=ogrenci4;
// Ogrenciler  adındaki, Ogrenci tipindeki dizi, içerisine sadece öğrenci nesneleri alır

// Örnek : öğrenci tipindeki bir diziye bir int değer atamaya çalışalım 
// Cevap : Ogrenci tipinden bir dizi içerisine başka tipte bir dğer veremezsiniz

// Ögrenci dizisini ekrana yazdıralım 
// 1 : Foreach ile yazdıralım
foreach(Ogrenci ogr in ogrenciler){

    Console.WriteLine("Ad : {0} Soyad : {1} - Yaş : {2}",ogr.name,ogr.lastname,ogr.age);
}


// 2 : For ile yazdıralım



// 2 : For ile yazdıralım

for(int i =0;i<ogrenciler.Length;i++){

    // Çözüm 1 : 
    //Console.WriteLine("Ad : {0} Soyad : {1} Yaş :{2}",ogrenciler[i].name,ogrenciler[i].lastname,ogrenciler[i].age);

    // Çözüm 2
    // Çözüm 2 performans olarak bir önceki yönteme göre daha mantıklı kalacaktır.
    Ogrenci geciciOgrenci = ogrenciler[i];
    Console.WriteLine("Ad : {0} Soyad : {1} Yaş :{2}",geciciOgrenci.name,geciciOgrenci.lastname,geciciOgrenci.age);

    
}




// Yukarıdaki ogrenci isimli nesneleri, SortedList koleksiyonu içerisine yerleştirip, sonrasında 
// foreach ile ekrana yazdırınız

SortedList ogrenciListesi = new SortedList();
ogrenciListesi.Add(1,ogrenci1);
ogrenciListesi.Add(2,ogrenci2);
ogrenciListesi.Add(3,ogrenci3);
ogrenciListesi.Add(4,ogrenci4);
// Ogrenci nesneleri sortedlist içerisine eklendiler.

// Ekrana yazdırmak

foreach(DictionaryEntry item in ogrenciListesi){

    // Ogrenci nesneleri, item.value diye erişilir
   Ogrenci selectedOgrenci =  ((Ogrenci)item.Value);
   Console.WriteLine("Sıra No : {3} Ad : {0} Soyad :{1} Yaş : {2}",selectedOgrenci.name,selectedOgrenci.lastname,selectedOgrenci.age,item.Key);
}
// Okey : yarın sınıf ve nesnelerden devam!!!


// OOP :Nesne  OOP dünyadaki her şeye bir object olarak bakan bir bakış açısıdır.

// OOP'nin en tepedeki tipi object tipidir.

// Tüm her şey objectten türer

// OOP şu başlıklardan oluşur : 
// 1- Kalıtım : Inheritance  : Üst soydan özellik aktarımı
// 2-Kapsüllemek : Encapsulation : Özelliklerin, kapsüllenerek dış dünyaya açılması
// 3-Çok biçimlilik Polymorphism : Özelliklerin nasıl kullanılacağı(zorunlu ? 
//opsiyonel ? zorunlu ise davranışı değiştirebilir miyiz ?)


// OOP'nin ilk konusu nesne oluşturma ile başlayalım


// Ogrenci.cs isimli dosyada bir ogrenci isimli class (sınıf) yazdık.
// Program.cs dosyasında Ogrenci sınıfından nesneler oluşturacağız

// Sınıf ve Nesne Kavramı : 

// Sınıf : Nesne içerisinde olması gerken özelliklerin tanımlı olduğu şablondur

// Sınıf : Mimarin çizimidir. Yani özellikerin durmuş olduğu şablondur

// Nesne : Sınıf içerisinde duran şablondan üretilmiş öğelerdir

// Ogrenci sinifindan bir kaç nesne üretelim

// nesne örneği almak : 


// aşağıdaki kod örneği iki parçadan oluşuyor

// bu kısım stack bölgesinde, bir pointer oluşturur
//Ogrenci o1


// bu kısım ise, stack bölgesindeki pointer'in işaret ettiği heap bölgesindeki alanda bir
// bellek register eder.(Aynı zamanda, bu nesnesin taşımış olduğu değişkenlerin
// başlangıç değerlerini belleye yazar)
//new Ogrenci();


/*
Ogrenci ogrenci1 = new Ogrenci();

// değer verelim 
ogrenci1.name="Oğuzhan";
ogrenci1.lastname="Ayaz";
ogrenci1.age=12;

// o1 adında nesnemiz hazır : Ekrana yazdıralım

Console.WriteLine("Ad : {0}",ogrenci1.name);
Console.WriteLine("Soyad : {0}",ogrenci1.lastname);
Console.WriteLine("Yaş : {0}",ogrenci1.age);

*/

// 4 adet öğrenci nesnesi üretip, bir dizi içerisine yerleştirelim

using System.Collections;
using Microsoft.VisualBasic;

Product product1 = new Product();
product1.name = "Iphone 16 Pro Max";
product1.brand = "Apple";
product1.capacity = "256 GB";
product1.price = 120000;
product1.color = "Dessert";

Product product2 = new Product();
product2.name = "Glaxy S24 Ultra";
product2.brand = "Samsung";
product2.capacity = "512 GB";
product2.price = 90000;
product2.color = "Gray";


Product product3 = new Product();
product3.name = "13 Ultra";
product3.brand = "Xiaomi";
product3.capacity = "512 GB";
product3.price = 70000;
product3.color = "White";



Product product5 = new Product();
product5.name = "Redmi Note 8 Pro";
product5.brand = "Xiaomi";
product5.capacity = "64 GB";
product5.price = 20000;
product5.color = "Blue";


// Bu 4 öğrenci nesnesini bir dizi içerisinde yerleştirelim

Product[] Products = new Product[5];


// Ogrenci dizisi içerisinde Ogrenci nesnelerini yerleştirelim 
Products[0] = product1;
Products[1] = product2;
Products[2] = product3;
//Farklı tanımlama yöntemi
Products[3] = new Product()
{
 name= "P60 Pro",
brand = "Huawei",
capacity = "128 GB",
price = 80000,
color = "Silver",
};
Products[4] = new Product()
{
    name = "Redmi Note 8 Pro",
brand = "Xiaomi",
capacity = "64 GB",
price = 20000,
color = "Blue",

};

// Ogrenciler  adındaki, Ogrenci tipindeki dizi, içerisine sadece öğrenci nesneleri alır

// Örnek : öğrenci tipindeki bir diziye bir int değer atamaya çalışalım 
// Cevap : Ogrenci tipinden bir dizi içerisine başka tipte bir dğer veremezsiniz

// Ögrenci dizisini ekrana yazdıralım 
// 1 : Foreach ile yazdıralım
foreach (Product pro in Products)
{

    Console.WriteLine("Marka : {0} Model : {1} - Fiyat : {2} Kapasite : {3} Renk : {4}", pro.brand, pro.name, pro.price, pro.capacity, pro.color);
}


// 2 : For ile yazdıralım



// 2 : For ile yazdıralım
/*
for(int i =0;i<Products.Length;i++){

    // Çözüm 1 : 
    //Console.WriteLine("Ad : {0} Soyad : {1} Yaş :{2}",ogrenciler[i].name,ogrenciler[i].lastname,ogrenciler[i].age);

    // Çözüm 2
    // Çözüm 2 performans olarak bir önceki yönteme göre daha mantıklı kalacaktır.
    Product gecicipro = Products[i];
    Console.WriteLine("Ad : {0} Soyad : {1} Yaş :{2}",gecicipro.brand,gecicipro.name,gecicipro.price);

    
}
*/



// Yukarıdaki ogrenci isimli nesneleri, SortedList koleksiyonu içerisine yerleştirip, sonrasında 
// foreach ile ekrana yazdırınız

/*
SortedList cihazListesi = new SortedList();
cihazListesi.Add(1,product1);
cihazListesi.Add(2,product1);
cihazListesi.Add(3,product1);
cihazListesi.Add(4,product1);
*/
// Ogrenci nesneleri sortedlist içerisine eklendiler.

// Ekrana yazdırmak
/*
foreach(DictionaryEntry item in cihazListesi){

    // Ogrenci nesneleri, item.value diye erişilir
   Product selectedProduct =  ((Product)item.Value);
   Console.WriteLine("Sıra No : {3} Ad : {0} Soyad :{1} Yaş : {2}",selectedProduct.name,selectedProduct.brand,selectedProduct.price,item.Key);
}
*/
Yamuk yamuk=new Yamuk();
double yamukalan=yamuk.YamukAlan(9,15,8);
double yamukcevre=yamuk.YamukCevre(9,15,8,3);
Koni koni=new Koni();
double konihacim=koni.KoniHacim(10,2);
double konialan=koni.KoniAlan(11,5);
Console.WriteLine("yamuk alanı "+yamukalan);
Console.WriteLine("yamuk cevresi "+yamukcevre);
Console.WriteLine("koni alanı "+konialan);
Console.WriteLine("koni hacmi "+konihacim);

Personel p = new Personel();
Console.WriteLine(p.Ad);
Console.WriteLine(p.Soyad);
Console.WriteLine(p.Yas);
Personel p1 = new Personel("Yaşar","Kemal",80);
Console.WriteLine(p1.Ad);
Console.WriteLine(p1.Soyad);
Console.WriteLine(p1.Yas);


Personel  p  = new Personel();
p.Ad="Rıza";


// pointer ile nesnenin bağlantısını keselim!!!
p=null;
// artık nesne ile p arasındaki bağlantı kesildi ve p isimli pointer artık yok!!!

// Garbage Collector : Hiç bir pointer tarafınsan işaret edilmeyen nesneleri toplar demiştik
// şu anda ilk bellek ihtiyacında sıraya göre pointer tarafından işaret edilmeyen nesneler toplanacka
// ve yeni bellek alanları açılacaktır!!
// Garbage collector : manuel olarak devreye sokulsa da manuel çalıştırmak önerilmez
//  Garbage Collector 
GC.Collect();

// destructor : Garbage Collector'un belleği silme aşamasında, çalışan bir yapıdır!! 
// nesne bellekten düşerken, en son olarak yapılacak işler
// veri tabanı bağlantıları
// dosya bağlantıları vb gibi şeyleri kapatmak için kullanılır!!



