using MiniProject3;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Office> offices = new List<Office> {
    new Office("Sweden", "SEK", 0.094m),
    new Office("Denmark", "DKK", 0.15m),
    new Office("USA", "USD", 1.0m)
};

List<Asset> assets = new List<Asset> {
    new Computer("ASUS ROG", "B550-F", new DateOnly(2020, 11, 24), 9500, offices[0]),
    new Computer("HP", "14S-FQ1010NO", new DateOnly(2023, 01, 30), 6790, offices[1]),
    new Phone("Samsung", "S20 Plus", new DateOnly(2022, 09, 12), 700, offices[2]),
    new Phone("Sony Xperia", "10 III", new DateOnly(2021, 03, 06), 8000, offices[0]),
    new Phone("Iphone", "10", new DateOnly(2018, 11, 25), 7500, offices[1]),
    new Computer("HP", "Elitebook", new DateOnly(2023, 08, 30), 1530, offices[2]),
    new Computer("HP", "Elitebook", new DateOnly(2021, 07, 30), 16450, offices[0])
};


DateOnly today = DateOnly.FromDateTime(DateTime.Now);

string? input = Menu.GetCommand();

while (EvaluateInput(input))
{
    input = Menu.GetCommand();
}

bool EvaluateInput(string input)
{
    switch (input)
    {
        case "1":  //Print
            Menu.PrintAll(assets.OrderBy(a => a.GetType().Name).ThenBy(d => d.Office.Country).ToList(), 
                assets.Where(d => (d.Date.Year <= today.Year - 3) || (d.Date.Month >= today.Month - 3 && d.Date.Year == today.Year - 3)).ToList());
            return true;
        case "2":  //Add

            return true;
        case "3":  //Quit
            return false;
        default:   //Try again
            Menu.PrintError(input);
            return true;
    }
}
