namespace Coldairarrow.Util
{
    /// <summary>
    /// Ajax请求结果
    /// </summary>
    public class AjaxResult
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool success { get; set; } = true;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int errorCode { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string msg { get; set; }
    }
}
