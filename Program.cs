// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

double totalSum = 0;
double totalTax = 0;

void main(){
   // Hier commt Cover Letter:
   anschreiben();

   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("Name\t\tMenge\t\tPreis\t\tTotal\t\tinkl.tUst 19%");
   Console.WriteLine("");

   menge("apple", 10, 3.2);
   menge("avocado", 3, 10);
   menge("tofu", 10, 5);
   menge("coconuß", 2, 1.2);

   Console.WriteLine("");
   Console.WriteLine("\t\t\t\t\t\tGesamt: " + totalSum + "$");
   Console.WriteLine("\t\t\t\t\t\tGesamt tUst: " + totalTax + "$");
   Console.WriteLine("");
}

static void anschreiben(){
   string name = "Musterman";
   string date = "31.Oktober 2024";
   Console.WriteLine(@"Hallo " + name + @",
heute ist " + date + @"
Hier ist Ihre Bestellung mit der Ausrechnung.

Mit freundlihen Grüßen");
}

void menge(string name, int amount, double price){

   double totalSumProItem = amount * price;
   totalSum += totalSumProItem;
   double taxPtoItem = Math.Round((totalSumProItem * 0.19), 2);
   totalTax = Math.Round((totalTax + taxPtoItem), 2);
   
   Console.WriteLine(name + "\t\t" + amount + "\t\t" + price + "$" + "\t\t" + totalSumProItem + "$" + "\t\t" + taxPtoItem + "$");
}

main();