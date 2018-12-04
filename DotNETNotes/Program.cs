using DotNETNotes.LINQ;
using DotNETNotes.Factory;
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
                using (var selectMany = FactoryLinq.GetSelectMany()) selectMany.Output(!isShow);

                using (var any = FactoryLinq.GetAny()) any.Output(!isShow);

                using (var groupJoin = FactoryLinq.GetGroupJoin()) groupJoin.Output(!isShow);

                using (var where = FactoryLinq.GetWhere()) where.Output(!isShow);

                using (var except = FactoryLinq.GetExcept()) except.Output(!isShow);

                using (var zip = FactoryLinq.GetZip()) zip.Output(!isShow);

                using (var aggregate = FactoryLinq.GetAggregate()) aggregate.Output(!isShow);

                using (var toLookup = FactoryLinq.GetToLookup()) toLookup.Output(!isShow);

                using (var intersect = FactoryLinq.GetIntersect()) intersect.Output(!isShow);

                using (var concat = FactoryLinq.GetConcat()) concat.Output(!isShow);

                using (var all = FactoryLinq.GetAll()) all.Output(!isShow);

                using (var sum = FactoryLinq.GetSum()) sum.Output(!isShow);

                using (var sequenceEqual = FactoryLinq.GetSequenceEqual()) sequenceEqual.Output(!isShow);

                using (var min = FactoryLinq.GetMin()) min.Output(!isShow);

                using (var distinct = FactoryLinq.GetDistinct()) distinct.Output(isShow);
            }

        }
    }
}
