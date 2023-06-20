using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatTimeIsIn
{
    public class TimeZoneService
    {
        public DateTime GetCurrentDateByTimeZone(string timZoneId) 
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timZoneId);
            return  TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);
        }
    }
}
