﻿// See https://aka.ms/new-console-template for more information
// Tip Dönüşümü : C# da olan 15 adet önceden tanımlı olan tiplerin birbirlerine olan dönüşümlerini anlatan konudur.
// C#'da 4 türlü tip dönüşümü vardır.
/*
 1- Convert
 2- Cast
 3- ToString
 4- Parse
*/


// Convert :

// Syntax
//int olarak dönecek değer =Convert.ToInt32(int tipine çevrilmesi için verilecek olan değer)
/*Console.WriteLine("Lütfen bir sayıyı, ");
string kullanicidanGelen = Console.ReadLine();
int convertStringToInt = Convert.ToInt32(kullanicidanGelen);
// matematiksel işlem yapalım
int toplam = convertStringToInt +convertStringToInt;
Console.WriteLine(toplam);
*/

#region Örnek 
// ekradan alınan bir sayının tek sayımı çift sayımı olduğunu gösteren uygulama
// tek ise true
// çift ise false

//Console.WriteLine("merhaba bir sayı giriniz");
//string kulllanicidanAlinanString  = Console.ReadLine();
//int intTipineDonusturme = Convert.ToInt32(kulllanicidanAlinanString);

// bir sayının 2 ye göre modu 0 ise çift sayı, 1 ise çift sayıdır.
//bool result =intTipineDonusturme%2!=0;
//Console.WriteLine(result);

#endregion

#region Örnek
#endregion

#region Örnek
// kullanıcıdan taban ve yükseklik değerini açıp, üçgenin alanını hesaplayınız
//Console.WriteLine("Taban değerini giriniz");
//int taban = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Yüksellik değerini giriniz");
//int yukseklik = Convert.ToInt32(Console.ReadLine());
// sonuçtan ondalık dönme riskine karşı, ondalık değişkenle karşılıyoruz.
//decimal hesap = (taban*yukseklik)/2;
//Console.WriteLine("Alan : {0} ",hesap);
#endregion

#region Örnek
// Kullanıcıdan aldığınız, yarı çap değeri ile, dairenin alanını ve çevreni hesaplayınız()
Console.WriteLine("Lütfen yarıçap giriniz");
int yariCap = Convert.ToInt32(Console.ReadLine());

// Pi*r*r
//decimal pi = 3.1415M;
// Ancak c# da PI değerini veren bir fonksiyon var.
double result = Math.PI*yariCap*yariCap;
Console.WriteLine("Dairenin Alanı : {0 }",result);


#endregion


// Matematiksel işlemler için :


// Bir sayısının üssünü hesaplamak için Math sınıfından faydalanıyoruz.
Math.Pow(10,3);
// Sonuç : 1000 

// Ödev : 
// Math sınıfına ait fonksiyonları inceleyin, 
// Tüm fonksiyonlar için ufak örnek yapınız