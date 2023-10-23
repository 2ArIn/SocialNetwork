﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace SN.Utility.Convertor
{
    public static class ToShamsi
    {
        public static string MiladiToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetHour(value) + ":" + pc.GetMinute(value) + ":" + pc.GetSecond(value)+"-"+pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
        }
    }
}
