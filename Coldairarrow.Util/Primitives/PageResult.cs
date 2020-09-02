using System.Collections.Generic;

namespace Coldairarrow.Util
{
    /// <summary>
    /// 分页返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageResult<T> : AjaxResult<List<T>>
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        public int total { get; set; }
        public int pageSize { get; set; }
        public int current { get; set; }
    }
}
