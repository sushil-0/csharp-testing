using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants.Enums;
using GatewayCSharp.Properties.Token;

public class IFramePaymentPage {
    static public void iFramePaymentPage() {
        Console.WriteLine("IFramePaymentPage.iframePaymentPage() executing...");
        string response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .SetDynamicDescriptor(DetailsConstant.DYNAMIC_DESCRIPTOR)
                .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                .SetURLDetails(DetailsConstant.URL_DETAILS)
                .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                .ForwardToIFrame("sdfjasof");
        Console.WriteLine(response);
    }
}