﻿using MoneyTrackerDb.Models;
using System;

namespace MoneyTrackerDb.DAL
{
    internal class CommonBase
    {
        public static RecordType recordType_NullValue = RecordType.Unknown;
        public static DateTime DateTime_NullValue = DateTime.MinValue;
        public static Guid Guid_NullValue = Guid.Empty;
        public static int Int_NullValue = int.MinValue;
        public static float Float_NullValue = float.MinValue;
        public static decimal Decimal_NullValue = decimal.MinValue;
        public static double Double_NullValue = double.MinValue;
        public static string String_NullValue = null;
    }
}
