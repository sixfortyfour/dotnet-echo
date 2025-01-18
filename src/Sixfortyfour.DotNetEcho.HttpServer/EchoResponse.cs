namespace Sixfortyfour.DotNetEcho.HttpServer
{
    public class EchoResponse
    {
        public string Body { get; set; }
        public IHeaderDictionary Headers { get; set; }
        public string Method { get; set; }
        public PathString Path { get; set; }
        public QueryString QueryString { get; set; }
        public IQueryCollection Query { get; set; }
    }
}
