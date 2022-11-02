using week2_homework;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee1 = new Employee(1, "Yavuz Selim", "Aydın", 20);
        Employee employee2 = new Employee(2, "Ahmet", "Bahadır", 21);

        var manager = new EmpManager();
        var list = manager.GetList();

        //Employee ekleme
        manager.Add(employee1);
        manager.Add(employee2);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("------------------");

        //Employee Silme
        manager.Remove(1);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}