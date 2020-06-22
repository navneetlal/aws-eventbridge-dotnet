using Newtonsoft.Json;

using Amazon.Lambda.Core;
using Amazon.Lambda.CloudWatchEvents;
using Consumer.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Consumer
{
  public class Function
    {
        public void ConsumerCase1Handler(CloudWatchEvent<EventDetail> logsEvent, ILambdaContext context)
        {
            context.Logger.LogLine(JsonConvert.SerializeObject(logsEvent));
        }

        public void ConsumerCase2Handler(CloudWatchEvent<EventDetail> logsEvent, ILambdaContext context)
        {
            context.Logger.LogLine(JsonConvert.SerializeObject(logsEvent));
        }

        public void ConsumerCase3Handler(CloudWatchEvent<EventDetail> logsEvent, ILambdaContext context)
        {
            context.Logger.LogLine(JsonConvert.SerializeObject(logsEvent));
        }
    }
}
