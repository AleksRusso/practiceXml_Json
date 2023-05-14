using practiceXml;
using System.Xml;

XmlDocument doc = new XmlDocument();
try
{
    
    doc.LoadXml("<user>" + "<user1>" + "<Id>1</Id>" + "<Name>user1</Name>" + "<Email>a@gmail.com</Email>" + "</user1>" +
        "<user2>" + "<Id>2</Id>" + "<Name>user2</Name>" + "<Email>b@gmail.com</Email>" + "</user2>"+
        "<user3>" + "<Id>3</Id>" + "<Name>user3</Name>" + "<Email>c@gmail.com</Email>" + "</user3>"+ "</user>");
    doc.Save("file.xml");

    Console.WriteLine("Файл сохранен\n");

}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка c cохр: {ex.Message}");
}



XmlDocument xmlDocument = new XmlDocument();
xmlDocument.Load("file1.xml");

List<User> users = new List<User>();
XmlElement xmlMainElement = xmlDocument.DocumentElement;
foreach(XmlElement xmlElement in xmlMainElement)
{
    User user = new User();
    foreach(XmlNode xmlNode in xmlElement.ChildNodes)
    {
        if(xmlNode.Name == "Id")
        {
            user.Id =int.Parse(xmlNode.InnerText);
            Console.WriteLine($"Id: {xmlNode.InnerText}");
        }
        if(xmlNode.Name == "Name")
        {
            user.Name = xmlNode.InnerText;
            Console.WriteLine($"Name: {xmlNode.InnerText}");
        }
        if(xmlNode.Name == "Email")
        {
            user.Email = xmlNode.InnerText;
            Console.WriteLine($"Email: {xmlNode.InnerText}");
        }
    }

    users.Add(user);
}


//foreach (var i in users)
//{
//    Console.WriteLine($"{i.Id} {i.Name} {i.Email}\n");
//}
