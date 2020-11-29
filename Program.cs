using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax clss = new Syntax(); 
            //result = result.Select(x => x.ToLower());


            //EscalarLastSingleFirst clss = new EscalarLastSingleFirst(); 

            //AnyAllAndAVG clss = new AnyAllAndAVG();

            #region using Object class

            List<ObjectClass> obj = new List<ObjectClass>();


            // creating 10 objts
            foreach (int values in Enumerable.Range(0, 11)) // 0-10
                obj.Add(new ObjectClass() { Number = values, Text = "Elemnt " + values });

            //Covertsion to dicionary
            var Myobj = obj.ToDictionary(key => key.Number, value => value.Text); 
           // Console.WriteLine(string.Join("\n", Myobj.Values ));
            foreach(var i in Myobj)
            System.Console.WriteLine("Dicionary: "+ i.Key + " - "+ i.Value);
            #endregion

            // string.Join => join the list 
            //Console.WriteLine(string.Join(", ", obj.Where(x => x.Number < 5).Select(x => x.Text)));

        }
    }



}

