using System;

namespace DotNet.Utilities
{
    public class TimeParser
    {
        /// <summary>
        /// ����ת���ɷ���
        /// </summary>
        /// <returns></returns>
        public static int SecondToMinute(int Second)
        {
            decimal mm = (decimal)((decimal)Second / (decimal)60);
            return Convert.ToInt32(Math.Ceiling(mm));           
        }

        #region ����ĳ��ĳ�����һ��
        /// <summary>
        /// ����ĳ��ĳ�����һ��
        /// </summary>
        /// <param name="year">���</param>
        /// <param name="month">�·�</param>
        /// <returns>��</returns>
        public static int GetMonthLastDate(int year, int month)
        {
            DateTime lastDay = new DateTime(year, month, new System.Globalization.GregorianCalendar().GetDaysInMonth(year, month));
            int Day = lastDay.Day;
            return Day;
        }
        #endregion

        #region ����ʱ���
        public static string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            string dateDiff = null;
            try
            {
                //TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
                //TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
                //TimeSpan ts = ts1.Subtract(ts2).Duration();
                TimeSpan ts = DateTime2 - DateTime1;
                if (ts.Days >=1)
                {
                    dateDiff = DateTime1.Month.ToString() + "��" + DateTime1.Day.ToString() + "��";
                }
                else
                {
                    if (ts.Hours > 1)
                    {
                        dateDiff = ts.Hours.ToString() + "Сʱǰ";
                    }
                    else
                    {
                        dateDiff = ts.Minutes.ToString() + "����ǰ";
                    }
                }
            }
            catch
            { }
            return dateDiff;
        }
        #endregion
    }
}
