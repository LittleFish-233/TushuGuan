using System;
using System.Collections.Generic;
using System.Text;

namespace TushuGuan
{
    public class BookBorrowed
    {
        //图书编号
        public string ISBN { get; set; }
        /// <summary>
        /// 借书时间
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 期限 单位 天
        /// </summary>
        public int Lasttime { get; set; }

    }
}
