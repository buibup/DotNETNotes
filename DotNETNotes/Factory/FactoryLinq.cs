using DotNETNotes.LINQ;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
