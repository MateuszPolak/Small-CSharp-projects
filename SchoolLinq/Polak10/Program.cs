using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polak10
{
    class Program
    {
        static void Main(string[] args)
        {
            //0th
            School MySchool = new School();
            int[] numbers = new int[10];
            Random rdn = new Random();
            for (int x = 0; x < numbers.Length; x++)
            {
                
                numbers[x] = rdn.Next(0,100);
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num.ToString());
            }
            
            var LINQcount = (from num in numbers
                           select num).Count();
            Console.WriteLine("Noumber of elements = " + LINQcount);
            
            var QueryEven =
                (from num_even in numbers
                where (num_even % 2) == 0
                select num_even).Count();
            Console.Write("Noumber of even elements = {0}\n", QueryEven);
            
            var QueryOdd =
                (from num_odd in numbers
                 where (num_odd % 2) == 1
                 select num_odd).Count();
            Console.Write("Noumber of odd elements = {0}\n", QueryOdd);

            Console.Write("\n");
            int[,] numbers2d = new int[10,5]; 
            for (int x = 0; x < numbers2d.GetLength(0); x++)
            {
                for (int y = 0; y < numbers2d.GetLength(1); y++)
                {
                    numbers2d[x,y] = rdn.Next(0, 100);
                    //Console.Write("{0}", numbers[x]);
                    Console.Write("{0} ", numbers2d[x, y]);
                }
                Console.Write("\n");
            }

            //1st
            Console.Write("Task 1\n");
            var marksQuery =
                from stdmk in MySchool.students
                 where stdmk.City == "Warsaw" || stdmk.City == "Seattle"
                select stdmk;
            foreach (var stdmk in marksQuery)
            {
                Console.Write("Student from Warsaw// Seattle: = {0}\n", stdmk.Last);
            }
            Console.Write("\n");
            
            var markscntQuery =
                (from stdmkcnt in MySchool.students
                 where stdmkcnt.City == "Warsaw" || stdmkcnt.City == "Seattle"
                 select stdmkcnt).Count();
            Console.Write("No of students from Warsaw and Seattle = {0}\n", markscntQuery);

            //2nd
            Console.Write("\n");
            Console.Write("Task 2\n");
            var marksQuery2 =
                from stdmk in MySchool.students
                where stdmk.City == "Warsaw" || stdmk.City == "Seattle"
                orderby stdmk.Last ascending
                select stdmk;
            foreach (var stdmk in marksQuery2)
            {
                Console.Write("Student from Warsaw // Seattle: = {0}\n", stdmk.Last);
            }

            //3rd
            Console.Write("\n");
            Console.Write("Task 3\n");
            var querybyCity =
                from stdmk in MySchool.students
                group stdmk by stdmk.City;

            foreach (var studGroup in querybyCity)
            {
                Console.WriteLine(studGroup.Key);
                foreach (Student stdmk in studGroup)
                {
                    Console.WriteLine(" {0} {1}", stdmk.First, stdmk.Last);
                }
                Console.Write("\n");
            }

            //4th
            Console.Write("\n");
            Console.Write("Task 4\n");

            var querySTUD =
                from std in MySchool.students
                where std.City == "Warsaw"
                select std;
            var queryTEA =
                from tea in MySchool.teachers
                where tea.City == "Warsaw"
                select tea;

            IEnumerable<string> queryCon =
                (from std in querySTUD select std.Last)
                .Concat(from tea in queryTEA select tea.Last);


            foreach (string Last in queryCon)
            {
                Console.WriteLine(Last);
            }

            //5th
            Console.Write("\n");
            Console.Write("Task 5\n");

            var querySTUD2 =
                from std in MySchool.students
                where std.City == "Warsaw"
                select new { Name = std.First, Surname = std.Last };

            var queryTEA2 =
                from tea in MySchool.teachers
                where tea.City == "Warsaw"
                select new { Name = tea.First, Surname = tea.Last };

            var querySub = querySTUD2.Concat(queryTEA2);
                
            foreach (var item in querySub)
            {
                Console.WriteLine("{0} {1}", item.Name, item.Surname);
            }

            //6th
            Console.Write("\n");
            Console.Write("Task 5\n");
            //6 sub 1
            Console.Write(" subTask 1 rewrite with lambda\n");
            var marksQuery3 =
                MySchool.students
                .Where(q => q.City == "Warsaw" || q.City == "Seattle");
            foreach (var stdmk in marksQuery3)
            {
                Console.Write("Student from Warsaw // Seattle: = {0}\n", stdmk.Last);
            }
            Console.Write("\n");

            var markscntQuery3 =
                MySchool.students
                .Where(p => p.City == "Warsaw" || p.City == "Seattle").Count();
            Console.Write("No of students from Warsaw and Seattle = {0}\n", markscntQuery3);
            //6 sub 4
            Console.Write("\n");
            Console.Write(" subTask 4\n");

            var querySTUD6 =
                MySchool.students
                .Where(q => q.City=="Warsaw");
            var queryTEA6 =
                MySchool.teachers
                .Where(q => q.City == "Warsaw"); ;

            IEnumerable<string> queryCon6 =
                (querySTUD6.Select(q => q.Last))
                .Concat(queryTEA6.Select(q => q.Last));


            foreach (string Last in queryCon6)
            {
                Console.WriteLine(Last);
            }

            //7th
            Console.Write("\n");
            Console.Write("Task 7\n");
            var studentsToXML = new XElement("Root",
                from student in MySchool.students
                let x = String.Format("{0},{1},{2},{3}", student.Scores[0],
                        student.Scores[1], student.Scores[2], student.Scores[3])
                select new XElement("student",
                           new XElement("First", student.First),
                           new XElement("Last", student.Last),
                           new XElement("Scores", x)
                        ) // end "student"
                    ); // end "Root"
            // Execute the query.
            Console.WriteLine(studentsToXML);
            Console.WriteLine("test");
            System.Console.ReadKey();
        }
    }
}
