using MiniProject3;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Office> offices = new List<Office> {
    new Office("Sweden", "SEK", 10.68m),
    new Office("Denmark", "DKK", 6.88m),
    new Office("USA", "USD", 1.0m)
};

List<Asset> assets = new List<Asset> {
    new Computer("ASUS ROG", "B550-F", new DateOnly(2020, 11, 24), 950, offices[0]),
    new Computer("HP", "14S-FQ1010NO", new DateOnly(2023, 01, 30), 679, offices[1]),
    new Phone("Samsung", "S20 Plus", new DateOnly(2022, 09, 12), 700, offices[2]),
    new Phone("Sony Xperia", "10 III", new DateOnly(2021, 03, 06), 800, offices[0]),
    new Phone("Iphone", "10", new DateOnly(2018, 11, 25), 750, offices[1]),
    new Computer("HP", "Elitebook", new DateOnly(2023, 08, 30), 1530, offices[2]),
    new Computer("HP", "Elitebook", new DateOnly(2021, 07, 01), 1640, offices[0])
};


DateOnly today = DateOnly.FromDateTime(DateTime.Now);
int todayInMonths = today.Year * 12 + today.Month;  //Easier to calculate difference in months instead of years and months

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
                assets.Where(d => (todayInMonths - (d.Date.Year * 12 + d.Date.Month) == 33 && today.Day > d.Date.Day)
				|| todayInMonths - (d.Date.Year * 12 + d.Date.Month) >= 34).ToList());  //2*12 + 9 == 33 months
            return true;
        case "2":  //Add
            string assetName = Menu.GetName();
            if (assetName == "Computer" || assetName == "Phone")
            {
                string brand = Menu.GetBrand();
                string model = Menu.GetModel();
                string price = Menu.GetPrice();
                bool priceIsInt = int.TryParse(price, out int p1);  //Try parsing price as an int
                while (!priceIsInt)                                //If not then ask user to enter again
                {
                    Menu.PrintError(price + " is not an integer");
                    price = Menu.GetPrice();
                    priceIsInt = int.TryParse(price, out int p2);
                }
                string country = Menu.GetCountry();
                int index = offices.FindIndex(o => o.Country == country);  //Index of office "country", -1 if it doesn't exist
                while (index == -1)                                        //If country doesn't exist, ask user to enter again
                {
                    Menu.PrintError(country);
                    country = Menu.GetCountry();
                    index = offices.FindIndex(o => o.Country == country);
                }
                if (assetName == "Computer")  //Now we know all inputs are "correct", just need to test for type again
                {
                    assets.Add(new Computer(brand, model, DateOnly.FromDateTime(DateTime.Now), Convert.ToInt32(price), offices[index]));
                }
                else   //Type is Phone here
                {
                    assets.Add(new Phone(brand, model, DateOnly.FromDateTime(DateTime.Now), Convert.ToInt32(price), offices[index]));
                }
                Menu.PrintAdded();
            } 
            else
            {
                Menu.PrintError(assetName);
                return true;
            }
            return true;
        case "3":  //Quit
            Menu.Quit();
            return false;
        default:   //Try again
            Menu.PrintError(input);
            return true;
    }
}
