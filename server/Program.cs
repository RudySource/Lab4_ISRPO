namespace RudyLab4Server;
public class Program{
  static void Main(string[] args){
    Console.WriteLine(@"
      H   H  EEEEE  L      L       OOO  
      H   H  E      L      L      O   O 
      HHHHH  EEEE   L      L      O   O 
      H   H  E      L      L      O   O 
      H   H  EEEEE  LLLLL  LLLLL   OOO  
      ");
    Console.WriteLine($"ФИО: Rudy Rudy rudy");
    Console.WriteLine($"Группа: ИСП-233");
    Console.WriteLine($"Дата и время: {DateTime.Now}");
    while (true){
      Console.WriteLine("\nМеню:\n1 — Показать ФИО\n2 — Показать группу\n3 — Показать дату\n4 — Выход");
      Console.Write("Выберите пункт меню: ");
      switch (Console.ReadLine()){
          case "1":
              Console.WriteLine($"ФИО: Rudy Rudy rudy");
              break;
          case "2":
              Console.WriteLine($"Группа: ИСП-233");
              break;
          case "3":
              Console.WriteLine($"Дата и время: {DateTime.Now}");
              break;
          case "4":
              return;
          default:
              Console.WriteLine("Неверный выбор.");
              break;
      }
    }
  }
}
