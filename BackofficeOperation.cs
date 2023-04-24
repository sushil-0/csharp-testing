using GatewayCSharp.Properties.Authorize;

public class BackofficeOperation {
    public static void voidPayment() {
        Console.WriteLine("BackofficeOperation.voidPayment() executing...");
        VoidDetails voidDetails = new VoidDetails("ea620adf-3129-429d-8c68-f51e146f26af");
        string response = AuthorizationFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .VoidPayment(voidDetails);
        Console.WriteLine(response);
    } 

    public static void capturePayment() {
        Console.WriteLine("BackofficeOperation.capturePayment() executing...");
        CaptureDetails captureDetails = new CaptureDetails("afffba1a-4b8e-468b-8ded-4587c739cd1a", GatewayCSharp.Properties.Constants.Enums.Currency.EUR);
        string response = AuthorizationFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .CapturePayment(captureDetails);
        Console.WriteLine(response);
    }
}
