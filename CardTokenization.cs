using GatewayCSharp.Properties.Token;
using GatewayCSharp.Properties.Constants;
using GatewayCSharp.Properties.Payment;

public class CardTokenization 
{
    public static void saveCard() {
        Console.WriteLine("CardTokenization.saveCard() executing...");
        string response = TokenFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                .SaveCard(DetailsConstant.CARD_DETAILS);
        Console.WriteLine(response);
    }


    public static void saveAcquirerTokenDetails() {
        Console.WriteLine("CardTokenization.saveAcquireTokenDetails() executing...");
        string response = TokenFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                            .SetStaging(true)
                            .SaveAcquirerToken(DetailsConstant.ACQUIRER_TOKEN_DETAILS);
        Console.WriteLine(response);
    }    

    public static void getSaveCards() {
        Console.WriteLine("CardTokenization.getSaveCards() executing...");
        string response = TokenFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .GetSavedCard(CardTypes.ALL);
        Console.WriteLine(response);
    }


    public static void verifyCard() {
        Console.WriteLine("CardTokenization.verifyCard() executing...");
        string response = TokenFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .VerifyCard(ValueConstant.CARD_NUMBER);
        Console.WriteLine(response);
    }

    public static void getAllAcquirerToken() {
        Console.WriteLine("CardTokenization.getAllAcquirerToken() executing...");
        string response = TokenFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .GetAcquirerToken(false);
        Console.WriteLine(response);
    }

    public static void deleteToken() {
        Console.WriteLine("CardTokenization.deleteToken() executing...");
        string response = TokenFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .DeleteToken("46663004-332254108807558841-0282");
        Console.WriteLine(response);
    }

    public static void tokenizationPayment_withCvv() {
        Console.WriteLine("CardTokenization.tokenizationPayment_withCvv() executing...");
        CardDetails cardDetails = new CardDetails("46663004-842385177603275512-0282", ValueConstant.CVV);
        Dictionary<string, string> response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                        .SetStaging(true)
                                        .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                        .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                                        .SetURLDetails(DetailsConstant.URL_DETAILS)
                                        .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                        .SetCardDetails(cardDetails)
                                        .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }

    public static void tokenizationPayment_withoutCvv() {
        Console.WriteLine("CardTokenization.tokenizationPayment_withoutCvv() executing...");
        CardDetails cardDetails = new CardDetails("46663004-317233633054424784-0282");
        Dictionary<string, string> response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                        .SetStaging(true)
                                        .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                        .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                                        .SetURLDetails(DetailsConstant.URL_DETAILS)
                                        .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                        .SetCardDetails(cardDetails)
                                        .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }
}
