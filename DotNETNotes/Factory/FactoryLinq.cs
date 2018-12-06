using DotNETNotes.LINQ;
using System;
using System.Collections.Generic;
using System.Text;
using Single = DotNETNotes.LINQ.Single;

namespace DotNETNotes.Factory
{
    public static class FactoryLinq
    {
        public static SelectMany GetSelectMany() => new SelectMany();

        public static Where GetWhere() => new Where();

        public static Any GetAny() => new Any();

        public static GroupJoin GetGroupJoin() => new GroupJoin();

        public static Except GetExcept() => new Except();

        public static Zip GetZip() => new Zip();

        public static Aggregate GetAggregate() => new Aggregate();

        public static ToLookup GetToLookup() => new ToLookup();

        public static Intersect GetIntersect() => new Intersect();

        public static Concat GetConcat() => new Concat();

        public static All GetAll() => new All();

        public static Sum GetSum() => new Sum();

        public static SequenceEqual GetSequenceEqual() => new SequenceEqual();

        public static Min GetMin() => new Min();

        public static Distinct GetDistinct() => new Distinct();

        public static Count GetCount() => new Count();

        public static Cast GetCast() => new Cast();

        public static Range GetRange() => new Range();

        public static ThenBy GetThenBy() => new ThenBy();

        public static Repeat GetRepeat() => new Repeat();

        public static Empty GetEmpty() => new Empty();

        public static Select GetSelect() => new Select();

        public static OrderBy GetOrderBy() => new OrderBy();

        public static OrderByDescending GetOrderByDescending() => new OrderByDescending();

        public static Contains GetContains() => new Contains();

        public static First GetFirst() => new First();

        public static Single GetSingle() => new Single();

        public static Last GetLast() => new Last();

        public static LastOrDefault GetLastOrDefault() => new LastOrDefault();

        public static SingleOrDefault GetSingleOrDefault() => new SingleOrDefault();

        public static FirstOrDefault GetFirstOrDefault() => new FirstOrDefault();

        public static Skip GetSkip() => new Skip();
    }
}
