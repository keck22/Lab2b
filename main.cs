using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a salesperson's name:");
    string name = Console.ReadLine();
    Console.WriteLine ("Enter a sales amount:");
    int amount = Convert.ToInt32(Console.ReadLine());
    double salesCommission = 200 + (0.09 * amount);

    Console.WriteLine("Sales commission for " + name + " is $" + salesCommission);

    if (amount > 0 && amount < 2999) {
      Console.WriteLine("Performance is Poor");
    }
    else if (amount >= 3000 && amount < 4999) {
      Console.WriteLine("Performance is Average");
    }
    else if (amount >= 5000 && amount < 9999){
      Console.WriteLine("Performance is Good");
    }
    else if (amount >= 10000 && amount < 14999) {
      Console.WriteLine("Performance is Excellent");
    }
    else if (amount > 15000) {
      Console.WriteLine("Performance is Outstanding");
    }
  }
}