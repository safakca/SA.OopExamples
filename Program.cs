#region Class/Object (create a class example)
//public class Feriha { }
#endregion

#region ClassMembers (create a class and class members)
// public class RamizDayi
// {
//     // class members
//     public string name; //field
//     public int age; //field

//     // method
//     public void sleep(){ } 
// }
#endregion

#region Constructors (create a class,constructor,field)
// public class Bizimkiler 
// {
//     public string benimAdim;
//     public Bizimkiler()
//     {
//         benimAdim = "Benim Adım Cemil Constructor";
//         Console.WriteLine(benimAdim);
//     }
// }

#endregion

#region AccessModifiers (private, public, protected, internal)
// public class AccessModifiers
// {
//     private string ozelAlan;
//     public string genelAlan;
//     protected string baglantiliAlan;
//     internal string kisitliAlan;

//     public AccessModifiers()
//     {
//         ozelAlan = "sadece bulunduğu class içinde erişilebilir.";
//         genelAlan = "projenin tamamından erişilebilir.";
//         baglantiliAlan = "kendi sınıfı ve kalıtım verdiği bağlantılı sınıflardan erişilebilir.";
//         kisitliAlan = "bulunduğu katman içersinde erişilebilir.";
//         System.Console.WriteLine("**************************************************************************************");

//         Console.WriteLine($"Private : {ozelAlan}");
//         System.Console.WriteLine("**************************************************************************************");

//         Console.WriteLine($"Public : {genelAlan}");
//         System.Console.WriteLine("**************************************************************************************");

//         Console.WriteLine($"Protected : {baglantiliAlan}");
//         System.Console.WriteLine("**************************************************************************************");

//         Console.WriteLine($"Internal : {kisitliAlan}");
//     }

//}

#endregion

#region Properties-Encapsulation (Get and Set)
// public class LeylaMecnun
// {
//     private string? _ismailAbi;
//     public string IsmailAbi
//     {
//         get
//         {
//             return "Hoop İsmail Abi " + _ismailAbi;
//         }
//         set
//         {
//             _ismailAbi = value;
//         }
//     }

//     public LeylaMecnun(string ismailAbi)
//     {
//         IsmailAbi = ismailAbi;
//         Console.WriteLine(IsmailAbi);
//     }
// }
#endregion

#region Inheritance (Derived and Base Class)
// public class Babam
// {
//     public void BabaReplik()
//     {
//         Console.WriteLine("Acaydım kollarımı gitme diyeydim.");
//     }
// }
// public class Oglum: Babam{ }
#endregion

#region Polymorphism 
// public class Diziler
// {
//     public virtual void DiziMuzikler()
//     {
//         System.Console.WriteLine("Dizi müziği seçiminiz");
//     }
// }
// public class Dizi1 : Diziler
// {
//     public override void DiziMuzikler()
//     {
//         base.DiziMuzikler();
//         System.Console.WriteLine("Dizi bir müzigi");
//     }
// }
// public class Dizi2 : Diziler
// {
//     public override void DiziMuzikler()
//     {
//         base.DiziMuzikler();
//         System.Console.WriteLine("Dizi iki müziği");
//     }
// }

#endregion

#region Abstract Classes and Interface
// public interface IDiziTuru
// {
//     void DovusSahnesi(string diziAdi);
// }
// public abstract class DiziTurleri
// {
//     public string? _diziAdi;

// }
// public class AksiyonDizisi : DiziTurleri, IDiziTuru
// {
//     public void DovusSahnesi(string diziAdi)
//     {
//         base._diziAdi = diziAdi;
//         System.Console.WriteLine($"{ _diziAdi} Dövüs sahnesi çekildi");
//     }
// }
// public class AskDizisi : DiziTurleri, IDiziTuru
// {
//     public void DovusSahnesi(string diziAdi)
//     {
//         base._diziAdi = diziAdi;
//         System.Console.WriteLine($"{_diziAdi} Dövüs sahnesi cekilmedi");
//     }
// }

#endregion

#region Enums
// enum Ekip
// {
//     yönetmen,
//     oyuncu,
//     kameraman
// }
#endregion



public class Program
{
    static void Main(string[] args)
    {
        #region Class/Object  (create an obj from feriha class with use c# 10)
        // Feriha feriha = new();
        #endregion

        #region ClassMembers (create an instance from ramizDayi class and call the class members)
        // RamizDayi ram = new();
        // ram.name = "Ramiz";
        // ram.age = 55;
        // ram.sleep();

        #endregion

        #region Constructors (create an object and call the constructor)
        // Bizimkiler bizimkiler = new();
        // Console.WriteLine(bizimkiler.benimAdim);
        #endregion

        #region AccessModifiers (private, public, protected, internal)
        // AccessModifiers acs = new();
        #endregion

        #region Properties-Encapsulation (Get and Set)
        // LeylaMecnun leylaMecnun = new("heyy");
        #endregion

        #region Inheritance (Derived and Base Class)
        // Oglum oglum = new();
        // oglum.BabaReplik();
        #endregion

        #region Polymorphism
        // Dizi1 dizi1 = new();
        // dizi1.DiziMuzikler();

        #endregion

        #region Abstract Classes and Interface
        // AksiyonDizisi aksiyonDizisi = new();
        // aksiyonDizisi.DovusSahnesi("xxx");
        #endregion

        #region Enums
        // System.Console.WriteLine(Ekip.kameraman);

        #endregion

    }
}
