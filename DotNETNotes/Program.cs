using DotNETNotes.LINQ;
using System;

namespace DotNETNotes
{
    public class Program
    {
        static void Main(string[] args)
        {
            LINQTest(true);

            Console.ReadLine();
        }


        static void LINQTest(bool isShow)
        {
 
            if (isShow)
            {
                Any any = new Any();
                SelectMany selectMany = new SelectMany();
                Where where = new Where();
                GroupJoin groupJoin = new GroupJoin();

                selectMany.Output(!isShow);
                where.Output(!isShow);
                any.Output(!isShow);
                groupJoin.Output(isShow);
            }
            
        }
    }
}
