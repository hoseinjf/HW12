using HW12.Entity;
using HW12.Entity.Enums;
using HW12.Servise;
using HW12.Servise.Contract;

bool isRun = true;
IDutyServise dutyServise = new DutyServise();


do
{
    Console.WriteLine("1- Add Duty");
    Console.WriteLine("2- show all Duty");
    Console.WriteLine("3- edit Duty");
    Console.WriteLine("4- delete Duty");
    Console.WriteLine("5- cheng status Duty");
    Console.WriteLine("6- search Duty");
    Console.WriteLine("7- Exit");
    Console.WriteLine("---------------------------------------------------------");
    Console.Write("select option : ");
    var op = Console.ReadLine();
    switch (op)
    {
        case "1":
            {
                Console.WriteLine("Title : ");
                var title = Console.ReadLine();
                Console.WriteLine("Description : ");
                var description = Console.ReadLine();
                Console.WriteLine("Priority( 1-low, 2-mid, 3-high) : ");
                var priority = (EnumPriority)int.Parse(Console.ReadLine());
                Console.WriteLine("EndTime (2012/05/04) : ");
                var endTime = Convert.ToDateTime(Console.ReadLine());
                Duty duty = new Duty()
                {
                    Title = title,
                    Description = description,
                    Priority = priority,
                    EndTime = endTime
                };
                dutyServise.Add(duty);
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case "2":
            foreach (var duty in dutyServise.GetAll())
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($" ID : {duty.Id}\n - Title : {duty.Title}\n" +
                    $" - Description : {duty.Description}\n" +
                    $" - Priority : {duty.Priority}\n - Status : {duty.Status}\n" +
                    $" - EndTime : {duty.EndTime}\n");
                Console.WriteLine("------------------------------------------");
            }
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            {
                Console.WriteLine("enter duty ID : ");
                var id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Title : ");
                var title = Console.ReadLine();
                Console.WriteLine("Description : ");
                var description = Console.ReadLine();
                Console.WriteLine("Priority( 1-low, 2-mid, 3-high) : ");
                var priority = (EnumPriority)int.Parse(Console.ReadLine());
                Console.WriteLine("EndTime (2012/05/04) : ");
                var endTime = Convert.ToDateTime(Console.ReadLine());
                Duty duty = new Duty()
                {
                    Title = title,
                    Description = description,
                    Priority = priority,
                    EndTime = endTime
                };
                dutyServise.Update(id, duty);
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case "4":
            {
                Console.Write("enter duty ID : ");
                var id = Convert.ToInt32(Console.ReadLine());
                dutyServise.Delete(id);
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case "5":
            {
                Console.Write("enter duty ID : ");
                var id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Status( 1-progress, 2-success, 3-cancel) : ");
                var status = (EnumStatus)int.Parse(Console.ReadLine());
                Duty duty = new Duty()
                {
                    Status = status
                };
                dutyServise.ChengStatus(id, duty);
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case "6":
            {
                Console.WriteLine("Title : ");
                var title = Console.ReadLine();
                foreach (var duty in dutyServise.Search(title))
                {
                    Console.WriteLine($" ID : {duty.Id}\n - Title : {duty.Title}\n" +
                        $" - Description : {duty.Description}\n" +
                        $" - Priority : {duty.Priority}\n - Status : {duty.Status}\n" +
                        $" - EndTime : {duty.EndTime}\n");
                    Console.WriteLine("------------------------------------------");
                }
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case "7":
            isRun = false;
            break;
            default:
            Console.WriteLine("just No 1 to 7");
            break;
    }
} while (isRun);
