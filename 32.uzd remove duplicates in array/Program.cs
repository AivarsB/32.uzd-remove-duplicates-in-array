using System;
using System.Collections.Generic;
using System.Linq;

namespace _32.uzd_remove_duplicates_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "ABC", "CDE", "FGA", "CDE", "GAE", "ABC", "ABO" };

            // 1.veids = manējais nodotais
            var namesShort = new HashSet<string>(names);

            foreach (var item in namesShort)
            {
                Console.WriteLine(item);
            }

            #region 2.veids
            // 2.veids
            // Console.WriteLine("---------------------");
            //var uniqueValuesCount = names.Length;
            //;
            //for (int i = 0; i < names.Length; i++)
            //{
            //    for (int j = 0; j < names.Length; j++)
            //    {
            //        if (names[i] == names[j] && i != j && names[j] != "")
            //        {
            //            names[j] = "";              // tur kur atrod dublikātu, ieliek tukšu vietu
            //            --uniqueValuesCount;
            //        }
            //    }
            //}
            //var uniqueValues = new string[uniqueValuesCount];
            //var k = 0;
            //foreach (var name in names)
            //{
            //    if (name != "")
            //    {
            //        uniqueValues[k] = name;
            //        ++k;
            //    }
            //}
            //foreach (var uname in uniqueValues)
            //{
            //    Console.WriteLine(uname);
            //}
            #endregion

            #region 3.veids
            // 3.veids
            //Console.WriteLine("---------------------");

            //var uniqueValues = new List<string>();

            //foreach (var name in names)
            //{
            //    if (!uniqueValues.Contains(name))
            //    {
            //        uniqueValues.Add(name);
            //    }
            //}

            //foreach (var uname in uniqueValues)
            //{
            //    Console.WriteLine(uname);
            //}

            #endregion

            // 4.veids
            Console.WriteLine("---------------------");

            var uniqueValues = names.Distinct();   // jāpievieno LINQ

            foreach (var uname in uniqueValues)
            {
                Console.WriteLine(uname);
            }

        }
    }
}
// Uzrakstīt programmu, kas no masīva izmet visus dublikātus - vērtības, 
// kas atkārtojas vairāk kā vienu reizi.
// Piemērs [“ABC”,”CDE”,”FGA”,”CDE”,”GAE”,”ABC”,”ABO”] -> 
// [“ABC”,”FGA”,”CDE”,”GAE”,”ABO”]