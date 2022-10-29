var person = new Person();
person.Name = Console.ReadLine();
person.Surname = Console.ReadLine();
person.Age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(person.GetInfo());