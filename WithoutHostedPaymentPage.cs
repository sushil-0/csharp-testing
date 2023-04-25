using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants;

public class WithoutHostedPaymentPage
{
    // PROBLEM: 3DS and fingerprint implementation needs to be implemented
    public static void cards()
    {
        Console.WriteLine("WithoutHostedPaymentPage.cards() executing...");

        TransactionDetails transactionDetails = DetailsConstant.TRANSACTION_DETAILS;
        transactionDetails.async = false;
        Dictionary<string, string> response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                    .SetStaging(true)
                                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                    .SetTransactionDetails(transactionDetails)
                                    .SetURLDetails(DetailsConstant.URL_DETAILS)
                                    .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                    .SetCardDetails(DetailsConstant.CARD_DETAILS)
                                    .SetPaymentMode(Modes.CREDIT_CARD)
                                    .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }

    public static void ideal()
    {
        Console.WriteLine("WithoutHostedPaymentPage.ideal() executing...");
        Dictionary<string, string> response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                    .SetStaging(true)
                                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                    .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                                    .SetURLDetails(DetailsConstant.URL_DETAILS)
                                    .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                    .SetPaymentMode(Modes.IDEAL)
                                    .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }

    public static void alternatePaymentMode()
    {
        Console.WriteLine("WithoutHostedPaymentPage.alternatePaymentMode() executing...");
        Dictionary<string, string> response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                    .SetStaging(true)
                                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                    .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                                    .SetURLDetails(DetailsConstant.URL_DETAILS)
                                    .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                    .SetPaymentMode(Modes.GOOGLEPAY)
                                    .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }
}