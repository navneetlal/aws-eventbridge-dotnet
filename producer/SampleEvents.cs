using System;

using Newtonsoft.Json;
using Amazon.EventBridge.Model;

namespace Producer.Data
{
  public class SampleData
  {
    public static PutEventsRequest transactionEvents = new PutEventsRequest
    {
      Entries =
        {
            new PutEventsRequestEntry
            {
                Source = "custom.myATMapp",
                EventBusName = "default",
                DetailType = "transaction",
                Time = DateTime.Now,
                Detail = JsonConvert.SerializeObject(
                    new
                    {
                        action = "withdrawal",
                        location = "MA-BOS-01",
                        amount = 500,
                        result = "approved",
                        transactionId = "123456",
                        cardPresent = true,
                        partnerBank = "Example Bank",
                        remainingFunds = 723.34
                    }
                )
            },
            new PutEventsRequestEntry
            {
                Source = "custom.myATMapp",
                EventBusName = "default",
                DetailType = "transaction",
                Time = DateTime.Now,
                Detail = JsonConvert.SerializeObject(
                    new
                    {
                        action = "withdrawal",
                        location = "NY-NYC-001",
                        amount = 20,
                        result = "approved",
                        transactionId = "123457",
                        cardPresent = true,
                        partnerBank = "Example Bank",
                        remainingFunds = 212.52
                    }
                )
            },
            new PutEventsRequestEntry
            {
                Source = "custom.myATMapp",
                EventBusName = "default",
                DetailType = "transaction",
                Time = DateTime.Now,
                Detail = JsonConvert.SerializeObject(
                    new
                    {
                        action = "withdrawal",
                        location = "NY-NYC-002",
                        amount = 60,
                        result = "denied",
                        transactionId = "123458",
                        cardPresent = true,
                        remainingFunds = 5.77
                    }
                )
            }
        }
    };
  }
}