﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenFu.ValueGenerators.Temporal
{
    public class CalendarDate : BaseValueGenerator
    {
        public CalendarDate(GenFuInstance genfu) : base(genfu)
        {
        }

        public DateTime Date(DateTime earliestDate, DateTime latestDate)
        {
            return DateTimeFill(earliestDate, latestDate);
        }

        public DateTime Date(DateRules rules)
        {
            // apply rule restrictions
            if (rules == DateRules.Within1Year)
            {
                GenFu.MinDateTime = DateTime.Now.AddYears(-1);
                GenFu.MaxDateTime = DateTime.Now.AddYears(1);
            }

            if (rules == DateRules.Within10Years)
            {
                GenFu.MinDateTime = DateTime.Now.AddYears(-10);
                GenFu.MaxDateTime = DateTime.Now.AddYears(10);
            }

            if (rules == DateRules.Within25years)
            {
                GenFu.MinDateTime = DateTime.Now.AddYears(-25);
                GenFu.MaxDateTime = DateTime.Now.AddYears(25);
            }

            if (rules == DateRules.Within50Years)
            {
                GenFu.MinDateTime = DateTime.Now.AddYears(-50);
                GenFu.MaxDateTime = DateTime.Now.AddYears(50);
            }

            if (rules == DateRules.Within100Years)
            {
                GenFu.MinDateTime = DateTime.Now.AddYears(-100);
                GenFu.MaxDateTime = DateTime.Now.AddYears(100);
            }

            if (rules == DateRules.FutureDates)
                GenFu.MinDateTime = DateTime.Now;

            if (rules == DateRules.PastDate)
                GenFu.MaxDateTime = DateTime.Now;

            return DateTimeFill(GenFu.MinDateTime, GenFu.MaxDateTime);
        }

        private static DateTime DateTimeFill(DateTime min, DateTime max)
        {
            int totalDays = (max - min).Days;
            int randomDays = _random.Next(totalDays);
            int seconds = _random.Next(24 * 60 * 60);

            return min.AddDays(randomDays).AddSeconds(seconds);
        }
    }
}
