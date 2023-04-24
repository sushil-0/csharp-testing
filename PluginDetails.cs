using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants.Enums;

public class PluginDetails {
    public static void plugInDetails() {
        Console.WriteLine("PluginDetails.pluginDetails() executing...");
        string response = PaymentFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetPluginDetails(Currency.EUR);
        Console.WriteLine(response);
    }
}