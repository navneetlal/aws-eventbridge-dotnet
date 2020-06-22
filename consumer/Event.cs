namespace Consumer.Model
{
  public class EventDetail
  {
    public string action { get; set; }
    public string location { get; set; }
    public double amount { get; set; }
    public string result { get; set; }
    public string transactionId { get; set; }
    public bool cardPresent { get; set; }
    public string partnerBank { get; set; }
    public double remainingFunds { get; set; }

  }
}