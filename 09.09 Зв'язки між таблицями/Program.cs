using Microsoft.EntityFrameworkCore;
using ModelsCreating.Models;

namespace DataBaseModels
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region DBFillCOMMENTED

            //using (var context = new DbContext())
            //{
            //    //context.Database.EnsureDeleted();
            //    context.Database.EnsureCreated();

            //    if (context.Faculties.Any())
            //    {
            //        Console.WriteLine("База данных уже содержит данные.");
            //        return; // Выходим
            //    }

            //    Console.WriteLine("Заполняем базу данных расширенным набором данных...");

            //    // независимые сущности

            //    // Факультеты
            //    var facultyCS = new Faculties { Name = "Computer Science" }; 
            //    var facultyEco = new Faculties { Name = "Экономики и Менеджмента" };
            //    var facultyMed = new Faculties { Name = "Медицинский Факультет" }; 

            //    // Кураторы
            //    var curator1 = new Curators { Name = "Марина", Surname = "Петренко" };
            //    var curator2 = new Curators { Name = "Олег", Surname = "Ковальчук" };

            //    // Студенты
            //    var student1 = new Students { Name = "Иван", Surname = "Иванов", Rating = 4 };
            //    var student2 = new Students { Name = "Анна", Surname = "Сидорова", Rating = 5 };
            //    var student3 = new Students { Name = "Петр", Surname = "Петров", Rating = 3 };  
            //    var student4 = new Students { Name = "Ольга", Surname = "Ольгина", Rating = 5 }; 
            //    var student5 = new Students { Name = "Алекс", Surname = "Котов", Rating = 4 }; 
            //    var student6 = new Students { Name = "Мария", Surname = "Волк", Rating = 4 };  

            //    // Предметы
            //    var subject1 = new Subject { Name = "Базы данных" };
            //    var subject2 = new Subject { Name = "Программирование C#" };
            //    var subject3 = new Subject { Name = "Микроэкономика" };

            //    // Преподаватели
            //    var teacher1 = new Teachers { Name = "Виктор", Surname = "Павлов", Salary = 25000, IsProfessor = true };
            //    var teacher2 = new Teachers { Name = "Ирина", Surname = "Волкова", Salary = 18000, IsProfessor = false };
            //    var teacher3 = new Teachers { Name = "Дмитрий", Surname = "Соколов", Salary = 22000, IsProfessor = false };                
            //    var teacher4 = new Teachers { Name = "Елена", Surname = "Иванова", Salary = 35000, IsProfessor = true }; 
            //    var teacher5 = new Teachers { Name = "Сэм", Surname = "Кинг", Salary = 32000, IsProfessor = false };

            //    //зависимые сущности 

            //    // Кафедры
            //    var deptSE = new Departments { Name = "Software Development", Building = 1, Financing = 100000, FacultyNav = facultyCS }; 
            //    var deptCyber = new Departments { Name = "Кибербезопасность", Building = 2, Financing = 80000, FacultyNav = facultyCS };
            //    var deptFin = new Departments { Name = "Финансы", Building = 3, Financing = 70000, FacultyNav = facultyEco };               
            //    var deptAI = new Departments { Name = "Искусственный Интеллект", Building = 2, Financing = 30000, FacultyNav = facultyCS }; 
            //    var deptBioMed = new Departments { Name = "Биомедицина", Building = 4, Financing = 250000, FacultyNav = facultyMed }; 

            //    // Лекции
            //    var lecture1 = new Lectures { Date = new DateTime(2025, 10, 20), Subject = subject1, Teacher = teacher1 }; 
            //    var lecture2 = new Lectures { Date = new DateTime(2025, 10, 21), Subject = subject2, Teacher = teacher2 }; 
            //    var lecture3 = new Lectures { Date = new DateTime(2025, 10, 22), Subject = subject3, Teacher = teacher3 }; 

            //    var lecture_db2 = new Lectures { Date = new DateTime(2025, 10, 23), Subject = subject1, Teacher = teacher1 };

            //    var lecturesForT2 = new List<Lectures>();
            //    for (int i = 0; i < 11; i++)
            //    {
            //        lecturesForT2.Add(new Lectures { Date = new DateTime(2025, 9, 2 + (i % 5)), Subject = subject2, Teacher = teacher2 });
            //    }

            //    // Группы
            //    var groupP11 = new Groups { Name = "P-11", Year = 1, DepartmentNav = deptSE };
            //    var groupP12 = new Groups { Name = "P-12", Year = 1, DepartmentNav = deptSE };
            //    var groupD221 = new Groups { Name = "D221", Year = 2, DepartmentNav = deptCyber }; 
            //    var groupF31 = new Groups { Name = "F-31", Year = 3, DepartmentNav = deptFin };

            //    var groupSD51 = new Groups { Name = "SD-51", Year = 5, DepartmentNav = deptSE }; 

            //    // табл связей

            //    // GroupStudents 
            //    var gs1 = new GroupStudents { GroupNav = groupP11, StudentNav = student1 };
            //    var gs2 = new GroupStudents { GroupNav = groupP11, StudentNav = student2 }; 
            //    var gs3 = new GroupStudents { GroupNav = groupD221, StudentNav = student3 }; 
            //    var gs4 = new GroupStudents { GroupNav = groupF31, StudentNav = student4 };   
            //    var gs5 = new GroupStudents { GroupNav = groupSD51, StudentNav = student5 };
            //    var gs6 = new GroupStudents { GroupNav = groupSD51, StudentNav = student6 };

            //    // GroupsCurators 
            //    var gc1 = new GroupsCurators { GroupNav = groupP11, CuratorNav = curator1 };
            //    var gc2 = new GroupsCurators { GroupNav = groupP12, CuratorNav = curator1 };
            //    var gc3 = new GroupsCurators { GroupNav = groupD221, CuratorNav = curator2 };
            //    var gc4 = new GroupsCurators { GroupNav = groupF31, CuratorNav = curator2 };              
            //    var gc5 = new GroupsCurators { GroupNav = groupP11, CuratorNav = curator2 }; 

            //    // GroupLectures 
            //    var gl1 = new GroupLectures { GroupNav = groupP11, LectureNav = lecture1 }; 
            //    var gl2 = new GroupLectures { GroupNav = groupP12, LectureNav = lecture1 }; 
            //    var gl3 = new GroupLectures { GroupNav = groupP11, LectureNav = lecture2 }; 
            //    var gl4 = new GroupLectures { GroupNav = groupD221, LectureNav = lecture2 }; 
            //    var gl5 = new GroupLectures { GroupNav = groupF31, LectureNav = lecture3 };  // F-31 -> Eco
            //    var gl6 = new GroupLectures { GroupNav = groupP11, LectureNav = lecture_db2 }; 

            //    var gl_for_T2 = new List<GroupLectures>();
            //    foreach (var lec in lecturesForT2)
            //    {
            //        gl_for_T2.Add(new GroupLectures { GroupNav = groupSD51, LectureNav = lec });
            //    }

            //    // сохранеие

            //    // независимые
            //    context.Faculties.AddRange(facultyCS, facultyEco, facultyMed);
            //    context.Curators.AddRange(curator1, curator2);
            //    context.Students.AddRange(student1, student2, student3, student4, student5, student6);
            //    context.Subjects.AddRange(subject1, subject2, subject3);
            //    context.Teachers.AddRange(teacher1, teacher2, teacher3, teacher4, teacher5);

            //    // зависимые 
            //    context.Departments.AddRange(deptSE, deptCyber, deptFin, deptAI, deptBioMed);
            //    context.Lectures.AddRange(lecture1, lecture2, lecture3, lecture_db2);
            //    context.Lectures.AddRange(lecturesForT2);
            //    context.Groups.AddRange(groupP11, groupP12, groupD221, groupF31, groupSD51);


            //    context.GroupStudens.AddRange(gs1, gs2, gs3, gs4, gs5, gs6); 
            //    context.GroupsCurators.AddRange(gc1, gc2, gc3, gc4, gc5);
            //    context.GroupLectures.AddRange(gl1, gl2, gl3, gl4, gl5, gl6);
            //    context.GroupLectures.AddRange(gl_for_T2);

            //    // Сохраняем
            //    try
            //    {
            //        context.SaveChanges();
            //        Console.WriteLine("Данные успешно сохранены в БД.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Ошибка при сохранении данных: {ex.Message}");
            //        if (ex.InnerException != null)
            //        {
            //            Console.WriteLine($"Внутренняя ошибка: {ex.InnerException.Message}");
            //        }
            //    }
            //}
            #endregion

            #region Переменные для заданий
            // --- Задание 1 ---
            var num1 = 100000;
            var task1 = $"Вывести номера корпусов, если суммарный фонд финансирования расположенных в них кафедр превышает {num1}";

            // --- Задание 2 ---
            var courseT2 = 5;
            var departmentNameT2 = "Software Development";
            var lessonsNumT2 = 10;
            var weekStartT2 = new DateTime(2025, 9, 1);
            var weekEndT2 = new DateTime(2025, 9, 7);//не понимаю что такое первая неделя. Первая неделя чего?
            var task2 = $"Вывести названия групп {courseT2}-го курса кафедры «{departmentNameT2}», которые имеют более {lessonsNumT2} пар в первую неделю.";

            // --- Задание 3 ---
            var groupNameT3 = "D221";
            var task3 = $"Вывести названия групп, имеющих рейтинг (средний) больше, чем рейтинг группы «{groupNameT3}».";

            // --- Задание 4 ---
            var task4 = $"Вывести фамилии и имена преподавателей, ставка которых выше средней ставки профессоров.";

            // --- Задание 5 ---
            var curatorCountT5 = 1;
            var task5 = $"Вывести названия групп, у которых больше {curatorCountT5} куратора.";

            // --- Задание 6 ---
            var yearT6 = 5;
            var task6 = $"Вывести названия групп, имеющих рейтинг (средний) меньше, чем минимальный рейтинг групп {yearT6}-го курса.";

            // --- Задание 7 ---
            var facultyNameT7 = "Computer Science";
            var task7 = $"Вывести названия факультетов, суммарный фонд... > суммарного фонда... факультета «{facultyNameT7}». (Вызов процедуры)";

            // --- Задание 8 ---
            var task8 = $"Вывести названия дисциплин и полные имена преподавателей, читающих наибольшее количество лекций по ним.";

            // --- Задание 9 ---
            var task9 = $"Вывести название дисциплины, по которому читается меньше всего лекций.";

            // --- Задание 10 ---
            var deptNameT10 = "Software Development";
            var task10 = $"Вывести количество студентов и читаемых дисциплин на кафедре «{deptNameT10}»";

            // --- Задание 11 ---
            var subjectT11 = "Новая SQL Дисциплина";
            var newSubjectT11 = "Обновленная SQL Дисциплина";
            var task11 = $"Выполнить (через Raw SQL) Вставку, Изменение и Удаление дисциплины.";

            #endregion
            #region LinqRequests

            using (var context = new DbContext())
            {
                #region 1. Корпуса с фондом > 100 000

                context.Database.EnsureCreated();
                var res = LinqDatabaseRequests.GetBuildingsWithFinancingAbove(context, num1);

                ConsolePrintClass.PrintResults(res, task1, b => Console.WriteLine($"Корпус {b}"));

                #endregion
                #region 2. Группы 5-го курса кафедры «Software Development», которые имеют более 10 пар в первую неделю.

                var res2 = LinqDatabaseRequests.GetGroupsByAmountOfLectures(context, courseT2, lessonsNumT2, departmentNameT2, weekStartT2, weekEndT2);
                ConsolePrintClass.PrintResults(res2, task2, b => Console.WriteLine($"Название группы: {b}"));
                #endregion
                #region 3. Группы с рейтингом больше чем рейтинг группы «D221»


                #endregion

                #region 4. Фамилии и имена преподавателей, ставка которых выше средней ставки профессоров


                #endregion

                #region 5. Названия групп, у которых больше одного куратора.


                #endregion

                #region 6. Названия групп, имеющих рейтинг меньше, чем минимальный рейтинг групп 5-го курса.


                #endregion

                #region 7. Процедура - Названия факультетов, суммарный фонд финансирования кафедр которых больше суммарного фонда финансирования кафедр факультета «Com­puter Science».


                #endregion
                #region 8. Названия дисциплин и полные имена преподавателей, читающих наибольшее количество лекций по ним.


                #endregion
                #region 9. Название дисциплины, по которому читается меньше всего лекций


                #endregion

                #region 10. Количество студентов и читаемых дисциплин на кафедре «Software Development»



                #endregion
                #region 11. Выполнение в коде Вставку новой дисциплины, затем изменение ее название, далее удаление SQL  со стороны SQL клиента


                #endregion
























            }
            #endregion
        }
    }
}