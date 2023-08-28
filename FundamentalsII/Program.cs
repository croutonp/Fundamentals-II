// See https://aka.ms/new-console-template for more information


Random rand = new Random();


int[] Nums = new int[]{0,1,2,3,4,5,6,7,8,9};

string[] Names = new string[]{"Tim", "Martin", "Nikki", "Sara"};

for (int i = 0; i<=10; i++)
{
    
    bool newBoolean = i%2 == 0;
    Console.WriteLine(newBoolean);
     
}

List<string> Flavors = new List<string>();
Flavors.Add("Vanilla");
Flavors.Add("Chocolate");
Flavors.Add("Pistachio");
Flavors.Add("Peanut Butter");
Flavors.Add("Superman");
Flavors.RemoveAt(2);
int length = Flavors.Count;



Dictionary<string, string> Dict = new();

Dict.Add(Names[0],Flavors[rand.Next(0,4)]);
Dict.Add(Names[1],Flavors[rand.Next(0,4)]);
Dict.Add(Names[2],Flavors[rand.Next(0,4)]);
Dict.Add(Names[3],Flavors[rand.Next(0,4)]);

foreach (KeyValuePair <string,string> items in Dict)
{
    Console.WriteLine($"Name: {items.Key} - Favorite flavor is :  {items.Value}");
}


Console.WriteLine(length);
Console.WriteLine(Flavors[2]);





