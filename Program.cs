/* See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
*/

Console.WriteLine("Ekrana bir yazı yazınız");
string metin = Console.ReadLine();

// Ekrandan küçük harf aldığımız değeri,ekrana büyük harf olarak yazdıralım.(toUpper)
//metin = metin.ToUpper();
//Console.WriteLine(metin);

// ekrandan aldığımız büyük harfleri, küçük harfe çevirelim (toLower)
//metin =metin.ToLower();
//Console.WriteLine(metin);

// ekrandan aldğınız değer içerisindeki karakteri değiştirmek için kullanılır.(Replace)
// metin=metin.Replace("x"," ");
// Console.WriteLine(metin);

// çoklu kullanım için, peşpeşe replace fonksiyonunu çalıştırmanız gerekmektedir.(Length)

// ekrandan aldığımız değerin kaç karakter olduğunu öğrenelim

// Console.WriteLine("Girdiğiniz yazılının karakter uzunluğu : "+metin.Length);

string adana = metin.Trim('s');
Console.WriteLine(adana);