// syntax : 
/*
erişim belirteç + class keyword'ü + sınıfın adı
*/
// Not : Erişim belirteç konusuna kadar, yazılan tüm class tüm struct ve metotlarda public erişim belirteci kullacağız

/*
Erişim belirteçler nelerdir tekrar hatırlayalım

public
private
internal
protected internal
protected
*/

public class Ogrenci{

    //Clsass'ı ürettik, şimdi içerisinde değerleri girelim
    // class içerisinde değişkenler tanımlanır ve bu değişkenler class'ın üyesi olur

    public string name;

    public string lastname;

    public int age;
    
}

// syntax : 
/*
erişim belirteç + class keyword'ü + sınıfın adı
*/
// Not : Erişim belirteç konusuna kadar, yazılan tüm class tüm struct ve metotlarda public erişim belirteci kullacağız

/*
Erişim belirteçler nelerdir tekrar hatırlayalım

public
private
internal
protected internal
protected
*/

public class Product{

    //Clsass'ı ürettik, şimdi içerisinde değerleri girelim
    // class içerisinde değişkenler tanımlanır ve bu değişkenler class'ın üyesi olur

    public string name;

    public int price;

    public string capacity;

    public string brand;

    public string color;
    
}
// syntax : 
/*
erişim belirteç + class keyword'ü + sınıfın adı
*/
// Not : Erişim belirteç konusuna kadar, yazılan tüm class tüm struct ve metotlarda public erişim belirteci kullacağız

/*
Erişim belirteçler nelerdir tekrar hatırlayalım

public
private
internal
protected internal
protected
*/

public class Yamuk
{
    int altTaban;
    int ustTaban;
    int yukseklik;

    public int YamukAlan(int yukseklik,int altTaban,int ustTaban)
    {
       int alan= (yukseklik*(altTaban+ustTaban))/2;
        return alan;
    }
    public int YamukCevre(int a, int b, int c, int d){
        int cevre =a+b+c+d;
        return cevre;
    }



}
public class Koni
{
    int apotemi;
    int yaricap;


    public double KoniAlan(int apotemi,int yaricap)
    {
       double alan= ((Math.PI*yaricap*yaricap)+(Math.PI*apotemi*yaricap*Math.PI));
        return alan;
    }
    public double KoniHacim(int yukseklik,int yaricap){
        double hacim= ((Math.PI*yaricap*yaricap*yukseklik)/3);
        return hacim;
    }


}

