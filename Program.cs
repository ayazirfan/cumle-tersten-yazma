System.Console.WriteLine("Lütfen bir cümle giriniz!");
string cumle = Console.ReadLine();

string tersi = "";

for (int i = 0; i < cumle.Length; i++)
{
    tersi = cumle.Substring(i, 1) + tersi;
}
System.Console.WriteLine("tersi1" + tersi);

// System.Console.WriteLine("tersi2: " + cumle.Reverse().ToString());

System.Console.WriteLine("tersi3:" + new string (cumle.Reverse().ToArray()));