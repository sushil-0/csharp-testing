using GatewayCSharp.Properties.Refund;

public class Refund {
    public static void refundTransaction() {
        Console.WriteLine("Refund.refundTransaction() executing...");
        RefundTransaction refundTransaction = new RefundTransaction("49f5246c-2c5f-4e23-a1b4-14a9544bdc70", ValueConstant.TRANSACTION_AMOUNT);
        string response = RefundFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                    .Refund(refundTransaction);
        Console.WriteLine(response);
    }

    public static void refundDetails() {
        Console.WriteLine("Refund.refundDetails() executing...");
        RefundStatus refundStatus = new RefundStatus("49f5246c-2c5f-4e23-a1b4-14a9544bdc70");
        string response = RefundFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .RefundStatus(refundStatus);
        Console.WriteLine(response);
    }
}
