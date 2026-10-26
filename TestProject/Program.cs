string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn}. Given your current volume, your potential profit would be {newProfit:N2}.");



Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
var formattedLine = currentProduct.PadRight(20);
string currentReturnp = $"{currentReturn:P2}";
formattedLine += currentReturnp;
string currentProfitc = $"{currentProfit:C2}";
formattedLine += currentProfitc.PadLeft(17);
formattedLine += "\n";
formattedLine += newProduct.PadRight(20);
string newReturnp = $"{newReturn:P2}";
formattedLine += newReturnp;
string newProfitc = $"{newProfit:C2}";
formattedLine += newProfitc.PadLeft(17);
Console.WriteLine(comparisonMessage);
Console.WriteLine(formattedLine);

