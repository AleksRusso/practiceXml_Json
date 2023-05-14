using practiceJson;
using System.Text.Json;

//User user1 = new(1, "Aleks", "a@gmail.com");

List<User> users = new List<User>
{
    new(1, "user1", "a@gmail.com"),
    new(2, "user2", "b@gmail.com"),
    new(3, "user3", "c@gmail.com"),
    new(4, "user4", "d@gmail.com")
};
var options = new JsonSerializerOptions
{
    WriteIndented = true
};
string json = JsonSerializer.Serialize(users, options);
Console.WriteLine($"\nИз класса в json: \n {json}");


List<User> unjson = JsonSerializer.Deserialize<List<User>>(json);
Console.WriteLine("\nИз json в класс: ");
foreach (User user in unjson)
{
    Console.WriteLine($"\n {user.Id} \n {user.Name} \n {user.Email}");
}


try
{
    string file = "user.json";
    File.WriteAllText(file, json);
    Console.WriteLine("\nФайл сохранен");


    Console.WriteLine("\nЧтение из файла: ");
    string filejson = File.ReadAllText(file);
    List<User> jsonstring = JsonSerializer.Deserialize<List<User>>(filejson);
    foreach (User user in jsonstring)
    {
        Console.WriteLine($"\n{user.Id} \n {user.Name} \n {user.Email}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка с сохр: {ex.Message}");
}










