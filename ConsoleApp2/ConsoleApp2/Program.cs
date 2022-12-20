List<double> list = new List<double>
{
    0.1,0.2,0.5,1,5,10,20,50,100,200
};

void CheckMoney(List<double> list , double money,double price)
{
    list.Reverse();
    List<double> zdac = new List<double>();
    money = money - price;
    foreach (var item in list)
    {
        if (money>=item)
        {
            money=money - item;
            zdac.Add(item);
        }
    }

    foreach (var item in zdac)
    {
        Console.WriteLine(item);
    }

}

Console.WriteLine("Enter money:");
double money = double.Parse(Console.ReadLine());
CheckMoney(list, money,25);