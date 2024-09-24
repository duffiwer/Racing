using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Racing.Races;
using Racing.Transports.AirTransports;
using Racing.Transports.GroundTransports;

namespace Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Шаг 1. Пользователь выбирает тип гонки
                    int raceType;
                    while (true)
                    {
                        Console.WriteLine("Выберите тип гонки:");
                        Console.WriteLine("1 - Наземные ТС");
                        Console.WriteLine("2 - Воздушные ТС");
                        Console.WriteLine("3 - Все виды ТС");
                        if (int.TryParse(Console.ReadLine(), out raceType) && raceType >= 1 && raceType <= 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: введите число от 1 до 3.");
                        }
                    }
                    
                    // Шаг 2. Пользователь выбирает дистанцию
                    double distance;
                    while (true)
                    {
                        Console.WriteLine("Введите дистанцию гонки:");
                        if (double.TryParse(Console.ReadLine(), out distance) && distance > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: дистанция должна быть положительным числом.");
                        }
                    }
                    // Создаем гонку
                    Race race ;
                    switch (raceType)
                    {
                        case 1:
                            race = new GroundRace();
                            race.Distance = distance;
                            break;
                        case 2:
                            
                            race = new AirRace();
                            race.Distance = distance;
                            break;
                        case 3:
                            race = new CommonRace();
                            race.Distance = distance;
                            break;
                            
                        default:
                            throw new InvalidOperationException("Неверный выбор гонки");
                    }

                    // Шаг 3. Регистрируем ТС
                    List<int> participants = new List<int>();
                    int participants_type;
                    Console.WriteLine("Выберите транспортное средство для регистрации:");
                    Console.WriteLine("1 - Ступа; 2 - Метла; 3 - Сапоги-скороходы; 4 - Карета-тыква;");
                    Console.WriteLine("5 - Ковер-самолет; 6 - Избушка на курьих ножках; 7 - Кентавр; 8 - Летучий корабль;");
                    Console.WriteLine("Чтобы завершить выбор, введите 0.");

                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (input == "0")
                        {
                            break;  // завершение регистрации
                        }
                        // Проверка на корректность ввода
                        while (true)
                        {
                            try
                            {
                                participants_type = int.Parse(input);
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Введите корректное значение.");
                                input = Console.ReadLine();
                            }
                        }
                        if (participants.Contains(participants_type))
                        {
                            Console.WriteLine("Это транспортное средство уже зарегистрировано. Попробуйте снова.");
                        }
                        else
                        {
                            try
                            {
                                switch (participants_type)
                                {
                                    case 1:
                                            Yaga yaga = new Yaga();
                                            race.RegisterTransport(yaga); 
                                        break;
                                    case 2:
                                            Broom br = new Broom();
                                            race.RegisterTransport(br);
                                        break;
                                    case 3:
                                            Boots boots = new Boots();
                                            race.RegisterTransport(boots);
                                        break;
                                    case 4:
                                            Carriage carriage = new Carriage();
                                            race.RegisterTransport(carriage);
                                        break;
                                    case 5:
                                            Carpet carpet = new Carpet();
                                            race.RegisterTransport(carpet);
                                            
                                        break;
                                    case 6:
                                            Hut hut = new Hut();
                                            race.RegisterTransport(hut);
                                        break;
                                    case 7:
                                        Centaur centaur = new Centaur();
                                        race.RegisterTransport(centaur);
                                        break;
                                    case 8:
                                        Ship ship = new Ship();
                                        race.RegisterTransport(ship);
                                        break;
                                    default:
                                        Console.WriteLine("Неверный номер транспортного средства.");
                                        continue;
                                }
                                participants.Add(participants_type);
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }

                    // Шаг 4. Запуск гонки
                    race.StartRace();

                    // Завершение работы программы после гонки
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}. Попробуйте еще раз.");
                }
            }
            Console.ReadKey();
        }
    }
}


 