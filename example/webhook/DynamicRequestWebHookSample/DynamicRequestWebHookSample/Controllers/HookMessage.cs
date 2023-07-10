namespace Webhook;

public class HookMessage
{
    public String TriggerType { get; set; }
    public String TriggerTime { get; set; }
    public String ObjectUrl { get; set; }
    public String ObjectId { get; set; }
    public String Summary { get; set; }
    public String ServiceType { get; set; }
    public Int32 RequestId { get; set; }
    public Guid RequestGuid { get; set; }

    public String ServiceName { get; set; }
    public String Requester { get; set; }
    public String RequesterIdentityName { get; set; }
}