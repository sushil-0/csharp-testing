using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants;

public class ShoppingCardPluginCheckout {
    public static void cards() {
        Console.WriteLine("ShoppingCardPluginCheckout.cards() executing...");
        Dictionary<string, string> response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                            .SetStaging(true)
                                            .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                            .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                                            .SetURLDetails(DetailsConstant.URL_DETAILS)
                                            .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                            .SetPaymentMode(Modes.CREDIT_CARD)
                                            .BuildPayment(); 
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }

    public static void ideal() {
        Console.WriteLine("ShoppingCardPluginCheckout.ideal() executing...");
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

    public static void alternatePaymentMethod() {
        Console.WriteLine("ShoppingCardPluginCheckout.alternatePaymentMode() executing...");
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