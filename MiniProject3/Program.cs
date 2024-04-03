using MiniProject3;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Office> offices = new List<Office> {
    new Office("Sweden", "SEK", 10.63m),
    new Office("Denmark", "DKK", 6.88m),
    new Office("USA", "$", 1.0m)
};

List<Asset> assets = new List<Asset> {
    new Computer(offices[0], new DateOnly(2020, 11, 24), 243, "ASUS ROG", "B550-F"),
    new Computer(offices[1], new DateOnly(2022, 01, 30), 679, "HP", "14S-FQ1010NO"),
    new Phone(offices[2], new DateOnly(2020, 09, 12), 1500, "Samsung", "S20 Plus"),
    new Phone(offices[0], new DateOnly(2020, 03, 06), 800, "Sony Xperia", "10 III"),
    new Phone(offices[1], new DateOnly(2018, 11, 25), 951, "Iphone", "10"),
    new Computer(offices[2], new DateOnly(2021, 08, 30), 2234, "HP", "Elitebook"),
    new Computer(offices[0], new DateOnly(2020, 07, 30), 2234, "HP", "Elitebook")
};

