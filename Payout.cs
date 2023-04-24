using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants.Enums;
using GatewayCSharp.Properties.Payout;
using GatewayCSharp.Properties.Constants;

public class Payout
{
    // PROBLEM: Implementation needs to be changed
    public static void withRedirection()
    {
        Console.WriteLine("Payout.withRedirection executing...");
        TransactionDetails transactionDetails = new TransactionDetails(ValueConstant.TRANSACTION_AMOUNT, Currency.EUR);
        transactionDetails.payout = true;
        PayoutFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                    .SetTransactionDetails(transactionDetails)
                    .SetURLDetails(DetailsConstant.URL_DETAILS)
                    .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                    .redirect();
    }

    public static void withoutRedirection()
    {
        Console.WriteLine("Payout.withoutRedirection executing...");
        TransactionDetails transactionDetails = new TransactionDetails(ValueConstant.TRANSACTION_AMOUNT, Currency.EUR);
        transactionDetails.payout = true;
        Dictionary<string, string> response = PayoutFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                        .SetStaging(true)
                                        .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                        .SetTransactionDetails(transactionDetails)
                                        .SetURLDetails(DetailsConstant.URL_DETAILS)
                                        .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                                        .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }

    public static void cardPayout_withoutHostedPage() {
        Console.WriteLine("Payout.cardPayout_withHostedPage() executing...");
        TransactionDetails transactionDetails = new TransactionDetails(ValueConstant.TRANSACTION_AMOUNT, Currency.INR);
        transactionDetails.payout = true;
        Dictionary<string, string> response = PayoutFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                    .SetStaging(true)
                                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                    .SetTransactionDetails(transactionDetails)
                                    .SetURLDetails(DetailsConstant.URL_DETAILS)
                                    .SetCardDetails(DetailsConstant.CARD_DETAILS)
                                    .SetPaymentMode(Modes.CREDIT_CARD)
                                    .BuildPayment();
        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }

    // PROBLEM: Response is html which is causing System.ApplicationException
    public static void cardPayout_synchronousFlow() {
        Console.WriteLine("Payout.cardPayout_synchronousFlow() executing...");
        TransactionDetails transactionDetails = new TransactionDetails(ValueConstant.TRANSACTION_AMOUNT, Currency.EUR);
        transactionDetails.payout = true;
        transactionDetails.async = false;
        var response = PayoutFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                                    .SetStaging(true)
                                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                                    .SetTransactionDetails(transactionDetails)
                                    .SetURLDetails(DetailsConstant.URL_DETAILS)
                                    .SetCardDetails(DetailsConstant.CARD_DETAILS)
                                    .SetPaymentMode(Modes.CREDIT_CARD)
                                    .BuildPayment();

        Console.WriteLine(response["action"]);
        Console.WriteLine(response["payLoad"]);
    }

    public static void synchronousTokenizationPayouts() {
        Console.WriteLine("Payout.synchronousTokenizationPayouts executing...");    
        TransactionDetails transactionDetails = new TransactionDetails(ValueConstant.TRANSACTION_AMOUNT, Currency.EUR);
        transactionDetails.payout = true;
        transactionDetails.async = false;
        CardDetails cardDetails = new CardDetails("46663004-147085487630303433-0282");
        PayoutFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
            .SetStaging(true)
            .SetTransactionDetails(transactionDetails)
            .SetURLDetails(DetailsConstant.URL_DETAILS)
            .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
            .SetCardDetails(cardDetails)
            .BuildPayment();
    }

    // PROBLEM: Response is html which is causing System.ApplicationException
    public static void asynchronousTokenizationPayouts() {
        Console.WriteLine("Payout.asynchronousTokenizationPayouts executing...");    
        TransactionDetails transactionDetails = new TransactionDetails(ValueConstant.TRANSACTION_AMOUNT, Currency.EUR);
        transactionDetails.payout = true;
        CardDetails cardDetails = new CardDetails("46663004-147085487630303433-0282");
        PayoutFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
            .SetStaging(true)
            .SetTransactionDetails(transactionDetails)
            .SetURLDetails(DetailsConstant.URL_DETAILS)
            .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
            .SetCardDetails(cardDetails)
            .BuildPayment();
    }

    // PROBLEM: Wrapper docs doesn't have APM related documents
}
