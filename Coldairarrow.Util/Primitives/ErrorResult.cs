namespace Coldairarrow.Util
{
    public class ErrorResult : AjaxResult
    {
        public ErrorResult(string Msg = "操作失败!", int ErrorCode = 0)
        {
            msg = msg;
            success = false;
            errorCode = errorCode;
        }
    }
}