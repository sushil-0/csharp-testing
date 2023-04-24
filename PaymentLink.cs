using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants;
using GatewayCSharp.Properties.PaymentLink;

public class PaymentLink {

    public static void generatePaymentLinkDetails() {
        Console.WriteLine("PaymentLink.generatePaymentLinkDetails executing...");
        List<NotificationChannel> notificationChannels = new List<NotificationChannel>();
        notificationChannels.Add(new NotificationChannel(Channel.EMAIL, "foo@bar.com"));
        notificationChannels.Add(new NotificationChannel(Channel.SMS, "1234567890"));
        string response = PaymentLinkFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
            .SetStaging(true)
            .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
            .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
            .SetURLDetails(DetailsConstant.URL_DETAILS)
            .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
            .GeneratePaymentLink(notificationChannels);
        Console.WriteLine(response);
    }

    public static void getPaymentLinkDetails() {
        Console.WriteLine("PaymentLink.getPaymentLinkDetails executing...");
        string response = PaymentLinkFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetPaymentLinkDetails("c84dc272-e39b-4152-ae40-d8a5a76d45ac");
        Console.WriteLine(response);
            
    }

    // PROBLEM: Details are not updating
    public static void updatePaymentLinkDetails() {
        Console.WriteLine("PaymentLink.updatePaymentLinkDetails() executing...");
        List<NotificationChannel> notificationChannels = new List<NotificationChannel>();
        notificationChannels.Add(new NotificationChannel(Channel.EMAIL, "abc@xyz.com"));
        notificationChannels.Add(new NotificationChannel(Channel.SMS, "9876543210"));
        string response = PaymentLinkFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
            .SetStaging(true)
            .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
            .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
            .SetURLDetails(DetailsConstant.URL_DETAILS)
            .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
            .UpdatePaymentLink("c84dc272-e39b-4152-ae40-d8a5a76d45ac", notificationChannels);
        Console.WriteLine(response);
    }


    public static void deactivatePaymentLink() {
        Console.WriteLine("PaymentLink.deactivatePaymentLink() executing...");
        string response = PaymentLinkFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .DeactivatePaymentLink("217854ed-40d5-449c-8959-1935a94218a3");
        Console.WriteLine(response);
    }
}