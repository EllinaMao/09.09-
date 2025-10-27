using Microsoft.EntityFrameworkCore;
using ModelsCreating.Models;

namespace DataBaseModels
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region DBFill

            //using (var context = new DbContext())
            //{         
            //    context.Database.EnsureCreated();
            //    // 
            //    if (context.Faculties.Any())
            //    {
            //        Console.WriteLine("База данных уже содержит данные.");
            //        return;
            //    }
            //    Console.WriteLine("Заполняем базу данных...");

            //    //Создаем независимые сущности
            //    var facultyCS = new Faculties { Name = "Компьютерных наук" };
            //    var facultyEco = new Faculties { Name = "Экономики и Менеджмента" };

            //    var curator1 = new Curators { Name = "Марина", Surname = "Петренко" };
            //    var curator2 = new Curators { Name = "Олег", Surname = "Ковальчук" };

            //    var student1 = new Students { Name = "Иван", Surname = "Иванов", Rating = 4 };
            //    var student2 = new Students { Name = "Анна", Surname = "Сидорова", Rating = 5 };
            //    var student3 = new Students { Name = "Петр", Surname = "Петров", Rating = 3 };

            //    var subject1 = new Subject { Name = "Базы данных" };
            //    var subject2 = new Subject { Name = "Программирование C#" };
            //    var subject3 = new Subject { Name = "Микроэкономика" };

            //    var teacher1 = new Teachers { Name = "Виктор", Surname = "Павлов", Salary = 25000, IsProfessor = true };
            //    var teacher2 = new Teachers { Name = "Ирина", Surname = "Волкова", Salary = 18000, IsProfessor = false };
            //    var teacher3 = new Teachers { Name = "Дмитрий", Surname = "Соколов", Salary = 22000, IsProfessor = false };

            //    // Создаем зависимые сущности

            //    // Связываем с факультетами через навигационные свойства
            //    var deptSE = new Departments { Name = "Инженерия ПО", Building = 1, Financing = 100000, FacultyNav = facultyCS };
            //    var deptCyber = new Departments { Name = "Кибербезопасность", Building = 2, Financing = 80000, FacultyNav = facultyCS };
            //    var deptFin = new Departments { Name = "Финансы", Building = 3, Financing = 70000, FacultyNav = facultyEco };

            //    // Связываем с предметами и преподавателями
            //    var lecture1 = new Lectures { Date = new DateTime(2025, 10, 20), Subject = subject1, Teacher = teacher1 };
            //    var lecture2 = new Lectures { Date = new DateTime(2025, 10, 21), Subject = subject2, Teacher = teacher2 };
            //    var lecture3 = new Lectures { Date = new DateTime(2025, 10, 22), Subject = subject3, Teacher = teacher3 };

            //    //Создаем зависимые сущности

            //    // Связываем с кафедрами
            //    var groupP11 = new Groups { Name = "P-11", Year = 1, DepartmentNav = deptSE };
            //    var groupP12 = new Groups { Name = "P-12", Year = 1, DepartmentNav = deptSE };
            //    var groupKB21 = new Groups { Name = "KB-21", Year = 2, DepartmentNav = deptCyber };
            //    var groupF31 = new Groups { Name = "F-31", Year = 3, DepartmentNav = deptFin };

            //    //Создаем таблицы связей

            //    var gs1 = new GroupStudents { GroupNav = groupP11, StudentNav = student1 };
            //    var gs2 = new GroupStudents { GroupNav = groupP11, StudentNav = student2 };
            //    var gs3 = new GroupStudents { GroupNav = groupKB21, StudentNav = student3 };

            //    var gc1 = new GroupsCurators { GroupNav = groupP11, CuratorNav = curator1 };
            //    var gc2 = new GroupsCurators { GroupNav = groupP12, CuratorNav = curator1 };
            //    var gc3 = new GroupsCurators { GroupNav = groupKB21, CuratorNav = curator2 };
            //    var gc4 = new GroupsCurators { GroupNav = groupF31, CuratorNav = curator2 };

            //    var gl1 = new GroupLectures { GroupNav = groupP11, LectureNav = lecture1 };
            //    var gl2 = new GroupLectures { GroupNav = groupP12, LectureNav = lecture1 };
            //    var gl3 = new GroupLectures { GroupNav = groupP11, LectureNav = lecture2 };
            //    var gl4 = new GroupLectures { GroupNav = groupKB21, LectureNav = lecture2 };
            //    var gl5 = new GroupLectures { GroupNav = groupF31, LectureNav = lecture3 };


            //    // Добавляем независимые
            //    context.Faculties.AddRange(facultyCS, facultyEco);
            //    context.Curators.AddRange(curator1, curator2);
            //    context.Students.AddRange(student1, student2, student3);
            //    context.Subjects.AddRange(subject1, subject2, subject3);
            //    context.Teachers.AddRange(teacher1, teacher2, teacher3);

            //    // Добавляем зависимые (Кафедры, Лекции, Группы)
            //    context.Departments.AddRange(deptSE, deptCyber, deptFin);
            //    context.Lectures.AddRange(lecture1, lecture2, lecture3);
            //    context.Groups.AddRange(groupP11, groupP12, groupKB21, groupF31);

            //    // Добавляем таблицы связей
            //    context.GroupStudens.AddRange(gs1, gs2, gs3);
            //    context.GroupsCurators.AddRange(gc1, gc2, gc3, gc4);
            //    context.GroupLectures.AddRange(gl1, gl2, gl3, gl4, gl5);

            //    try
            //    {
            //        context.SaveChanges();
            //        Console.WriteLine("Данные успешно сохранены в БД.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Ошибка при сохранении данных: {ex.Message}");
            //        
            //    }
            //}
            #endregion
            #region DBTasks

            var num1 = 100000;
            var task1 = $"Вывести номера корпусов, если суммарный фонд финансирования расположенных в них кафедр превышает {num1}";
            var courseT2 = 5;
            var departmentNameT2 = "Software Development";
            var lessonsNum = 10;

            var task2 = $"Вывести названия групп {courseT2} - го курса кафедры «{departmentNameT2}», которые имеют более {lessonsNum} пар в первую неделю.";

            var task3 = $"Вывести названия групп, имеющих рейтинг(средний рейтинг всех студентов группы) больше, чем рейтинг группы «D221».";
            var task4 = $"Вывести фамилии и имена преподавателей, ставка которых выше средней ставки профессоров.";
            var task5 = $"Вывести названия групп, у которых больше одного куратора.";
            var task6 = $"Вывести названия групп, имеющих рейтинг(средний рейтинг всех студентов группы) меньше, чем минимальный рейтинг групп 5 - го курса.";
            var task7 = $"Вывести названия факультетов, суммарный фонд финансирования кафедр которых больше суммарного фонда финансирования кафедр факультета «Com­puter Science».  Для этого запроса напишите процедуру, и вызовите  в коде процедуру";
            var task8 = $"Вывести названия дисциплин и полные имена преподавателей, читающих наибольшее количество лекций по ним.";
            var task9 = $"Вывести название дисциплины, по которому читается меньше всего лекций.";
            var task10 = $"Вывести количество студентов и читаемых дисциплин на кафедре «Software Development»";
            var task11 = $"Выполните в коде Вставку новой дисциплины, затем выполните изменение ее название, далее удалите выполняя команды SQL со стороны SQL клиента";
            #endregion
            #region LinqRequests

            #region 1. Корпуса с фондом > 100 000
            using (var context = new DbContext())
            {

                context.Database.EnsureCreated();
                var res = LinqDatabaseRequests.GetBuildingsWithFinancingAbove(context, 100000);

                ConsolePrintClass.PrintResults(res, task1, b => Console.WriteLine($"Корпус {b}"));
            }
            #endregion

            #endregion
        }
    }
}