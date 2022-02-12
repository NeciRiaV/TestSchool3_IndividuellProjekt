using System;
using TestSchool3.Models;
using System.Linq;

namespace TestSchool3
{
    class Program
    {
        static void Main(string[] args)
        {
            using TestSchool3DbContext Context = new TestSchool3DbContext();

            Console.WriteLine("Welcome to ThreeSchool");
            Console.WriteLine();

            bool myBool = true;
            while (myBool)
            {
                Console.WriteLine("[1] - Show students");
                Console.WriteLine("[2] - Amount of Teachers/departments");
                Console.WriteLine("[3] - List active courses");
                Console.WriteLine("[4] - End");

                int menyVal = Convert.ToInt32(Console.ReadLine());
                switch (menyVal)
                {
                    case 1:
                        ShowStudents();
                        break;
                    case 2:
                        TeachPerDepartment();
                        break;
                    case 3:
                        ListActiveCourses();
                        break;
                    case 4:
                        myBool = false;
                        Console.WriteLine("Thank you for today. \nSee you next time!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Error! Please choose a valid option!");
                        break;
                }
            }
        }
        static void ShowStudents()
        {
            using TestSchool3DbContext Context = new TestSchool3DbContext();

            Console.Write("Show by: [First name = F] or [Last name = L]: ");
            string answerOrder = Console.ReadLine().ToUpper();
            if (answerOrder == "F")//First Name
            {
                Console.Write("Show by: [Rising = R] or [Falling = F]: ");
                Console.WriteLine();
                string answerOrder2 = Console.ReadLine().ToUpper();
                if (answerOrder2 == "R") //Rising
                {
                    var order = from TblStudent in Context.TblStudent
                                where TblStudent.FirstName == TblStudent.FirstName
                                orderby TblStudent.FirstName ascending
                                select TblStudent;
                    foreach (var item in order)
                    {
                        Console.WriteLine($"Personal Number: {item.Idnumber} ||  Name: {item.FirstName} {item.LastName} " +
                            $"|| StudentID: {item.StudentId} ||  Year: {item.SchoolYear} ||  Gender: {item.Gender}");
                        Console.WriteLine(new string('-', (5)));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to menu!");
                    Console.ReadLine();
                }
                else if (answerOrder2 == "F") //Falling
                {
                    var order = from TblStudent in Context.TblStudent
                                where TblStudent.FirstName == TblStudent.FirstName
                                orderby TblStudent.FirstName descending
                                select TblStudent;
                    foreach (var item in order)
                    {
                        Console.WriteLine($"Personal Number: {item.Idnumber} ||  Name: {item.FirstName} {item.LastName} " +
                            $"|| StudentID: {item.StudentId} ||  Year: {item.SchoolYear} ||  Gender: {item.Gender}");
                        Console.WriteLine(new string('-', (5)));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to menu!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error! Please choose a valid option!");
                    ShowStudents();
                }
            }
            else if (answerOrder == "L") //Last Name
            {
                Console.Write("Show by: [Rising = R] or [Falling = F]:  ");
                string answerOrder2 = Console.ReadLine().ToUpper();
                if (answerOrder2 == "R") //Rising
                {
                    var order = from TblStudent in Context.TblStudent
                                where TblStudent.LastName == TblStudent.LastName
                                orderby TblStudent.LastName ascending
                                select TblStudent;
                    foreach (var item in order)
                    {
                        Console.WriteLine($"ID: {item.Idnumber} ||  Name: {item.LastName} {item.FirstName}" +
                             $" ||  StudentID: {item.StudentId} ||  Year: {item.SchoolYear} ||  Gender: {item.Gender}");
                        Console.WriteLine(new string('-', (5)));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to menu!");
                    Console.ReadLine();
                }
                else if (answerOrder2 == "F") //Falling
                {
                    var order = from TblStudent in Context.TblStudent
                                where TblStudent.LastName == TblStudent.LastName
                                orderby TblStudent.LastName descending
                                select TblStudent;
                    foreach (var item in order)
                    {
                        Console.WriteLine($"ID: {item.Idnumber} ||  Name: {item.LastName} {item.FirstName}" +
                             $" ||  StudentID: {item.StudentId} ||  Year: {item.SchoolYear} ||  Gender: {item.Gender}");
                        Console.WriteLine(new string('-', (5)));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to menu!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error! Please choose a valid option!");
                    ShowStudents();
                }
            }
            else
            {
                Console.WriteLine("Error! Please choose a valid option!");
                ShowStudents();
            }
        }
        static void TeachPerDepartment()
        {
            using TestSchool3DbContext Context = new TestSchool3DbContext();

            Console.Write("Choose department [1]Language [2]Science [3]World Knowledge [4]Sports : ");
            string answer = Console.ReadLine();
            int answer1 = int.Parse(answer);
            var TeacherDepartments = from TeacherDep in Context.TeacherDep
                                     orderby TeacherDep.TdepId
                                     where TeacherDep.TdepId == answer1
                                     select TeacherDep;

            foreach (var item in TeacherDepartments)
            {
                Console.WriteLine($"StaffID: {item.StaffId}");
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to return to menu!");
            Console.ReadLine();
        }
        static void ListActiveCourses()
        {
            using TestSchool3DbContext Context = new TestSchool3DbContext();

            var Active = from TblClasses in Context.TblClasses
                        where TblClasses.CourseActivity == "Active"
                        orderby TblClasses ascending
                        select TblClasses;
            foreach (var item in Active)
            {
                Console.WriteLine($"Class: {item.ClassName}");
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to return to menu!");
            Console.ReadLine();
        }
    }
}

    

