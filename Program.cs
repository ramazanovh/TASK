//TASK-1
//İnput olaraq ilin aylarının hər hansı biri daxil edilir, siz console-a hansı fəsil olduğunu yazdırmalısınız. Yanlış ay adı daxil edilərsə ekrana yazdırmalısınız ki, yanlış ad daxil etdiniz. Məs: input - "Mart", output: "Yaz"


string month = Console.ReadLine();
string season = "yaz";

if (month == "mart" || month == "aprel" || month == "may" && season == "yaz")
{
    Console.WriteLine("Yaz");
}
else
{
    Console.WriteLine("yanlis ad daxil etmisiniz!");
}


//TASK-2
// İnput olaraq integer bir dəyər gəlir siz bu ədədin neçə mərtəbəli olduğunu console-a yazdırmalısınız. Məs: input - 2543; ouptp

Console.WriteLine("Integer dəyəri daxil edin: ");
int number = Convert.ToInt32(Console.ReadLine());

int mertebeler = 1;

while (number >= 10)
{
    number = number / 10;
    mertebeler++;
}

Console.WriteLine($"Daxil etdiyiniz ədəd {mertebeler} mərtəbəlidir.");


//TASK-3
//Daxil edilən ədədin faktorialını tapın. (3!=3*2*1). Məs: input - 3, output: 6


Console.Write("Reqem Daxil Edin: ");
int reqem = Convert.ToInt32(Console.ReadLine());
int netice = 1;
for (int i = reqem; i >= 1; i--)
{
    netice = netice * i;
}
Console.WriteLine("result: " + netice);
