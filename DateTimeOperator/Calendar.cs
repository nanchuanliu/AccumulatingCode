using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccumulatingCode.DateTimeOperator
{
    using System.Threading;

    class Calendar
    {

        /// <summary>
        /// 获取当前的上一周期
        /// </summary>
        /// <param name="cycle">周期ID</param>
        /// <param name="start">上一周期开始时间</param>
        /// <param name="end">上一周期结束时间</param>
        /// <returns></returns>
        private bool getLatestStartAndEnd(DateTime time,int cycle, out DateTime start, out DateTime end)
        {
            DateTime[] times = new DateTime[2];

            DateTime now =time;
            start = now.Date;
            end = now.Date.AddDays(1).AddSeconds(-1);

            bool flag = false;

            //当前日期的日
            int currentDay = now.Day;

            //前一月
            DateTime lastMonth = now.AddMonths(-1);
            //上一个月的天数
            int numOfLastMonth = Thread.CurrentThread.CurrentUICulture.Calendar.GetDaysInMonth(lastMonth.Year, lastMonth.Month);

            int startOffset = 0, endOffset = 0;

            switch (cycle)
            {
                //取前一天
                case (int)CycleEnum.Day:
                    startOffset = endOffset = 1;
                    flag = true;
                    break;

                //取上一周
                case (int)CycleEnum.Week:
                    if ((int)now.DayOfWeek == 0)
                    {
                        startOffset = 13;
                        endOffset = 7;
                    }
                    else
                    {
                        startOffset = (int)now.DayOfWeek + 6;
                        endOffset = (int)now.DayOfWeek;
                    }
                    flag = true;
                    break;

                //取上一旬
                case (int)CycleEnum.Ten_Day:

                    int _value = (currentDay - 1) / 10;
                    int _offset = currentDay % 10;

                    //上旬取前一个月的下旬
                    if (_value == 0)
                    {
                        startOffset = numOfLastMonth - 21 + _offset;
                        endOffset = _offset;
                    }
                    else
                    {
                        startOffset = 9 + _offset;
                        endOffset = _offset;
                    }

                    //逢10或31号进1
                    if (_offset == 0 || _value == 3)
                    {
                        startOffset += 10;
                        endOffset += 10;
                    }

                    flag = true;
                    break;

                //取上一月
                case (int)CycleEnum.Month:
                    startOffset = currentDay + numOfLastMonth - 1;
                    endOffset = currentDay;
                    flag = true;
                    break;

                //取上一季度
                case (int)CycleEnum.Quarter:
                    int quarterOffset = (now.Month - 1) % 3;
                    DateTime last3StartMonth = now.AddMonths(-3 - quarterOffset);
                    DateTime last3EndMonth = now.AddMonths(-1 - quarterOffset);
                    int numOfLast3EndMonth = Thread.CurrentThread.CurrentUICulture.Calendar.GetDaysInMonth(last3EndMonth.Year, last3EndMonth.Month);
                    startOffset = (int)(now - last3StartMonth).TotalDays + last3StartMonth.Day - 1;
                    endOffset = (int)(now - last3EndMonth).TotalDays - (numOfLast3EndMonth - last3EndMonth.Day);
                    flag = true;
                    break;

                //取上一年
                case (int)CycleEnum.Year:
                    int daysInLastYear = Thread.CurrentThread.CurrentUICulture.Calendar.GetDaysInYear(now.AddYears(-1).Year);
                    int dayOfYear = Thread.CurrentThread.CurrentUICulture.Calendar.GetDayOfYear(now);
                    startOffset = daysInLastYear + dayOfYear - 1;
                    endOffset = dayOfYear;
                    flag = true;
                    break;

            }

            start = start.AddDays(-startOffset);
            end = end.AddDays(-endOffset);

            return flag;
        }
    }

    /// <summary>
    /// 周期
    /// </summary>
    public enum CycleEnum
    {
        /// <summary>
        /// 日
        /// </summary>
        Day = 1,

        /// <summary>
        /// 周
        /// </summary>
        Week = 2,

        /// <summary>
        /// 旬
        /// </summary>
        Ten_Day = 3,

        /// <summary>
        /// 月
        /// </summary>
        Month = 4,

        /// <summary>
        /// 季
        /// </summary>
        Quarter = 5,

        /// <summary>
        /// 年
        /// </summary>
        Year = 6
    }
}
