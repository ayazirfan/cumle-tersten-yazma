System.Console.WriteLine("Lütfen bir cümle giriniz.");
string cumle = Console.ReadLine();

string ters="";

for (int i = 0; i < cumle.Length; i++)
{
    ters = cumle[i] + ters;
}
Console.WriteLine("{0}", ters);

System.Console.WriteLine("gitdiğiniz cümlenin tersi:" + new string (cumle.Reverse().ToArray()));