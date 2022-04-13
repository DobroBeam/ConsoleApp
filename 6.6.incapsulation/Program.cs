using System;

namespace _6._6.incapsulation
{
    class Program
    {
		static void Main(string[] args)
		{
			//User user = new User();

			//// Setter
			//user.Age = Int32.Parse(Console.ReadLine());

			//// Getter
			//Console.WriteLine("Ваш возраст: {0}", user.Age);



			//// Setter
			//user.Login = Console.ReadLine();

			//// Getter
			//Console.WriteLine("Ваш логин: {0}", user.Login);



			//// Setter
			//user.Email = Console.ReadLine();

			//// Getter
			//Console.WriteLine("Ваш e-mail: {0}", user.Email);

			//Console.ReadKey();
			Triangle triangle = new Triangle();
			Console.Write("Введите сторону А треугольника :");
			triangle.sideA = 2;
			Console.ReadKey();

		}
	}
	class Triangle
    {
		private int a;
		private int b;
		private int c;

		public int sideA
        {
			get
			{
				return a;
			}
			set
			{
				do
				{
					if (value > 0)
					{
						if (b == 0 & c == 0)
						{
							a = value;
						}
						else
						{
							if (value > b + c)
							{ a = value; }
							else
							{ Console.WriteLine("Значение дожно быть больше суммы двух других сторон"); }
						}



					}
					else
					{ Console.WriteLine("Значение дожно быть больше 0"); }
				}
				while (a == 0);
			}
		}
        


    }
	class User
	{
		private int age;
		private string login;
		private string email;

		public int Age
		{
			get
			{
				return age;
			}

			set
			{


				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
				
			}
		}
		public string Login
		{
			get
			{
				return login;
			}

			set
			{
				if (value.Length < 3)
				{
					Console.WriteLine("Логин должен быть не менее 3-х символов длиной");
				}
				else
				{
					login = value;
				}
			}
		}
		public string Email
		{
			get
			{
				return email;
			}

			set
			{
				if (!value.Contains('@'))
				{
					Console.WriteLine("Почта должна содержать символ '@'");
				}
				else
				{
					email = value;
				}
			}
		}
	}
}
