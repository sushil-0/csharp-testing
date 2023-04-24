using GatewayCSharp.Properties.Constants;
using GatewayCSharp.Properties.Webhook;

public class Webhook {
    public static void setupWebhookEndpoint() {
        Console.WriteLine("Webhook.setupWebhookEndpoint() executing...");
        List<string> events = new List<string>();    
        events.Add(Events.PAYMENT);
        events.Add(Events.PAYOUTS);
        events.Add(Events.REFUND);
        events.Add(Events.CAPTURE);
        events.Add(Events.VOID);
        string response = WebhookFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .SetEvents(events)
                    .SetUpWebhookEndpoints(ValueConstant.WEBHOOK_ENDPOINT);
        Console.WriteLine(response);
    }

    public static void getWebhookDetails() {
        Console.WriteLine("Webhook.getWebhookDetails() executing...");
        string response = WebhookFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .GetWebhookDetails("F3cvLI8SPgse9KG7VVubxjeQH3bS1EDvHz0nRMzGDqo=");
        Console.WriteLine(response);
    }

    public static void deactivateWebhook() {
        Console.WriteLine("Webhook.deactivateWebhook() executing...");
        string response = WebhookFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .DeactivateWebhook("F3cvLI8SPgse9KG7VVubxjeQH3bS1EDvHz0nRMzGDqo=");
        Console.WriteLine(response);
    }

    public static void udpateWebhookStepupDetails() {
        Console.WriteLine("Webhook.udpateWebhookStepupDetails() executing...");
        List<string> events = new List<string>();    
        events.Add(Events.PAYMENT_EXPIRED);
        events.Add(Events.REVERSAL_FAILED);
        events.Add(Events.CAPTURE_FAILED);
        events.Add(Events.CHARGEBACK);
        string response = WebhookFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .UpdateWebhookDetails("F3cvLI8SPgse9KG7VVubxjeQH3bS1EDvHz0nRMzGDqo=", ValueConstant.WEBHOOK_ENDPOINT, events);
        Console.WriteLine(response);
    }

}