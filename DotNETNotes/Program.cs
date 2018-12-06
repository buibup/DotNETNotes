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

                using (var distinct = FactoryLinq.GetDistinct()) distinct.Output(!isShow);

                using (var count = FactoryLinq.GetCount()) count.Output(!isShow);

                using (var cast = FactoryLinq.GetCast()) cast.Output(!isShow);

                using (var range = FactoryLinq.GetRange()) range.Output(!isShow);

                using (var thenBy = FactoryLinq.GetThenBy()) thenBy.Output(!isShow);

                using (var repeat = FactoryLinq.GetRepeat()) repeat.Output(!isShow);

                using (var empty = FactoryLinq.GetEmpty()) empty.Output(!isShow);

                using (var select = FactoryLinq.GetSelect()) select.Output(!isShow);

                using (var orderBy = FactoryLinq.GetOrderBy()) orderBy.Output(!isShow);

                using (var orderByDescending = FactoryLinq.GetOrderByDescending()) orderByDescending.Output(!isShow);

                using (var contains = FactoryLinq.GetContains()) contains.Output(!isShow);

                using (var first = FactoryLinq.GetFirst()) first.Output(!isShow);

                using (var single = FactoryLinq.GetSingle()) single.Output(!isShow);

                using (var last = FactoryLinq.GetLast()) last.Output(!isShow);

                using (var lastOrDefault = FactoryLinq.GetLastOrDefault()) lastOrDefault.Output(!isShow);

                using (var singleOrDefault = FactoryLinq.GetSingleOrDefault()) singleOrDefault.Output(!isShow);

                using (var firstOrDefault = FactoryLinq.GetFirstOrDefault()) firstOrDefault.Output(!isShow);

                using (var skip = FactoryLinq.GetSkip()) skip.Output(isShow);
            }

        }
    }
}
