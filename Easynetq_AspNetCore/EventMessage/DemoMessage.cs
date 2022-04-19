using EasyNetQ;

namespace Easynetq_AspNetCore
{
    /// <summary>
    /// 注意  ExchangeName 不要重复,否则easynetq会产生未找到队列的错误
    /// </summary>
    [Queue("Demo", ExchangeName = "DemoMessage")]
    public class DemoMessage
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    }
}