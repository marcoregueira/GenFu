﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace GenFu
{
    public partial class BaseValueGenerator
    {

        protected static Random _random = new Random(Environment.TickCount);

        public GenFuInstance GenFu { get; }

        public BaseValueGenerator() { }

        public BaseValueGenerator(GenFuInstance genFu)
        {
            GenFu = genFu;
        }

        public static string Word()
        {
            // aww, shucks.  we did our best!
            int index = _random.Next(0, ResourceLoader.Data(PropertyType.Words).Count());
            return ResourceLoader.Data(PropertyType.Words)[index];
        }

        public static T GetRandomValue<T>(T[] values)
        {
            int index = _random.Next(0, values.Length);
            return values[index];
        }

        public static T GetRandomValue<T>(List<T> values)
        {
            int index = _random.Next(0, values.Count);
            return values[index];
        }

        public static T GetRandomValue<T>(IEnumerable<T> values)
        {
            int index = _random.Next(0, values.Count());
            return values.ElementAt(index);
        }
    }
}
