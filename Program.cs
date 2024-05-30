System.Console.WriteLine("Lütfen bir cümle giriniz.");
string cumle = Console.ReadLine();

string ters="";

for (int i = 0; i < cumle.Length; i++)
{
    ters = cumle[i] + ters;
}
Console.WriteLine("{0}", ters);

System.Console.WriteLine("gitdiğiniz cümlenin tersi:" + new string (cumle.Reverse().ToArray()));Console.Write("Bir sayi giriniz: ");
            

            // int sayi = Convert.ToInt32(Console.ReadLine()); * girilen sayıyı ter çevirme
            // int rakam;
            // Console.Write("Sayinin tersten yazılısı = ");
            // while (sayi > 0)
            // {
            //     rakam = sayi % 10;
            //     Console.Write(rakam);
            //     sayi /= 10;
            // }
            
