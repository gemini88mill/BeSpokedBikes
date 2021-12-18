using System;

namespace BeSpokedQuarterlyTrackerAPI.Common
{
    public class DateMath
    {
        public static DateRange GetDateRange(int qtr, int year)
        {
            DateTime startDate;
            DateTime endDate;
            switch (qtr)
            {
                case 1: 
                    startDate = new DateTime(year, 1, 1);
                    endDate = startDate.AddMonths(3);
                    return new DateRange
                    {
                        StartDate = startDate,
                        EndDate = endDate
                    };
                case 2:
                    startDate = new DateTime(year, 1, 1).AddMonths(3);
                    endDate = startDate.AddMonths(3);
                    return new DateRange
                    {
                        StartDate = startDate,
                        EndDate = endDate
                    };
                case 3:
                    startDate = new DateTime(year, 1, 1).AddMonths(6);
                    endDate = startDate.AddMonths(3);
                    return new DateRange
                    {
                        StartDate = startDate,
                        EndDate = endDate
                    };
                case 4:
                    startDate = new DateTime(year, 1, 1).AddMonths(9);
                    endDate = startDate.AddMonths(3);
                    return new DateRange
                    {
                        StartDate = startDate,
                        EndDate = endDate
                    };
                default:
                    return null;
            }
        }
    }

    public class DateRange
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}