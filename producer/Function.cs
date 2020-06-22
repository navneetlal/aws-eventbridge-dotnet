using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.EventBridge;
using Amazon.EventBridge.Model;

using Producer.Data;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Producer
{
  public class Function
    {
        public async Task<PutEventsResponse> FunctionHandler(string input, ILambdaContext context)
        {
            PutEventsRequest events = SampleData.transactionEvents;

            AmazonEventBridgeClient client = new AmazonEventBridgeClient();
            var response = await client.PutEventsAsync(events);
            return response;
        }
    }

    
}
