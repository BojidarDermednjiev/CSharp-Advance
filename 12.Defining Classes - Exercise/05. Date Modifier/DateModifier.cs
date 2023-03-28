namespace DateModifier
{
    using System;
    using System.Globalization;

    public class DateModifier
    {
        public static int GetDateDifference(string firstDate, string secondDate)
        {
            DateTime firstDateTime = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDateTime = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            TimeSpan dateDifference = firstDateTime - secondDateTime;
            return Math.Abs(dateDifference.Days);
        }
    }
}
