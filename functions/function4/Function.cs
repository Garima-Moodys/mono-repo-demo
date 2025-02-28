using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorld
{
    public class Function
    {
        // This is the Lambda handler method that AWS Lambda will invoke
        public void FunctionHandler(ILambdaContext context)
        {
            // Log a message to the console (this will be visible in CloudWatch logs)
            LambdaLogger.Log("Hello world");

            // Log a message with an example IP address
            var ip = "127.0.0.1"; // Hardcoded IP address
            LambdaLogger.Log($"The IP address is: {ip}");

            // Optionally, you could add more logic or perform other operations here.
        }
    }
}
