namespace Sixfortyfour.DotNetEcho.HttpServer
{
    public static class ExtensionMethods
    {
        public static async Task<EchoResponse> ToEchoResponseAsync(this HttpRequest request)
        {
            var echoResponse = new EchoResponse();
            using (StreamReader streamReader = new StreamReader(request.Body))
            {
                echoResponse.Body = await streamReader.ReadToEndAsync();
            };
            echoResponse.Method = request.Method;
            echoResponse.Headers = request.Headers;
            echoResponse.Path = request.Path;
            echoResponse.QueryString = request.QueryString;
            echoResponse.Query = request.Query;

            return echoResponse;
        }
    }
}
