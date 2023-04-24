using GatewayCSharp.Properties.Payment;

public class WithHostedPaymentPage {
    // PROBLEM: Implementation needs to be changed
    public static void withRedirection() {
        Console.WriteLine("WithHostedPaymentPage.withRedirection() executing...");
        PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                        .SetStaging(true)
                        .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                        .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                        .SetURLDetails(DetailsConstant.URL_DETAILS)
                        .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                        .redirect();

    }

    public static void withoutRedirection() {
        Console.WriteLine("WithHostedPaymentPage.withoutRedirection() executing...");
        Dictionary<string, string> response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                    .SetStaging(true)
                                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                    .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                                    .SetURLDetails(DetailsConstant.URL_DETAILS)
                                    .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                    .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }
}