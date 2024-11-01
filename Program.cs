// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Global vars:
double totalSumForAllOrder = 0;
double totalTaxesForAllOrder = 0;
double deliveryPreis = 0;
string message = "";

void main(){
   // Hier commt Cover Letter:
   anschreiben();

   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("Name\t\tMenge\tPreis Stück + tUst\tUst pro Stück \t\tTotal + tUst\t\tTotal tUst");
   Console.WriteLine("");

   //Items (name, amount, price):
   menge("apple", 10, 3.2);
   //menge("avocado", 3, 10);
   //menge("tofu", 10, 5);
   menge("coconuß", 2, 1.2);

   Console.WriteLine("");
   Console.WriteLine("Gesamt tUst: " + Math.Round(totalTaxesForAllOrder, 2) + "$");
   Console.WriteLine("Gesamt: " + Math.Round(totalSumForAllOrder, 2) + "$");
   Console.WriteLine("");
   shipping();
   Console.WriteLine(@"Versandkosten: " + deliveryPreis + "$ inkl tUst. " + message);
   Console.WriteLine("");

   double totalPrisePlusDelivery = totalSumForAllOrder + deliveryPreis;

   if(deliveryPreis > 0) {Console.WriteLine("Gesamt mit den Versandkosten: " + totalPrisePlusDelivery + "$");}
}

static void anschreiben(){
   string name = "Musterman";
   string date = "31.Oktober 2024";
   Console.WriteLine(@"Hallo " + name + @",
heute ist " + date + @"
Hier ist Ihre Bestellung mit der Ausrechnung.

Mit freundlihen Grüßen");
}

// Main function:
void menge(string name, int amount, double price){

   //Taxes for 1 item (-> goes to the final tabel of goods!):
   double taxProItem = Math.Round(price * 0.19, 2);

   //Prise for 1 item with itsown taxes (-> goes to the final tabel of goods!):
   double priseForItemWithTaxes = price + taxProItem;

   //Amount of taxes for one items category (only for accounting):
   double allTaxesProItemsOneCategory = Math.Round(taxProItem * amount, 2);

   //Full price for all items of one category with taxes (--> goes to the final tabel of goods!):
   double priseForItemsWithTaxes = priseForItemWithTaxes * amount;

   //Totals (--> go under the tabel of goods!):
   totalSumForAllOrder += priseForItemsWithTaxes;
   totalTaxesForAllOrder += allTaxesProItemsOneCategory;
   
   Console.WriteLine(name + "\t\t" + amount + "\t\t" + priseForItemWithTaxes + "$" + "\t\t" + taxProItem + "$" + "\t\t\t" + priseForItemsWithTaxes + "$"+ "\t\t\t" + allTaxesProItemsOneCategory);
}

// Definition of shipping terms:

void shipping(){
   if(totalSumForAllOrder >= 100){
      message = "Der Versand ist kostenslos, da Ihre Bestellung beträgt 100$ oder mehr 🙂";
   }
   else {
      deliveryPreis = 10 + Math.Round(10 * 0.19, 2);
      message = "Es nicht kostenslos, da Ihre Bestellung beträgt weniger als 100$.";
      }
}

main();