using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants.Enums;
using GatewayCSharp.Properties.Token;

public class DetailsConstant {
    public static MerchantDetails MERCHANT_DETAILS = new MerchantDetails(ValueConstant.MERCHANT_ID, ValueConstant.CUSTOMER_ID);
    public static TransactionDetails TRANSACTION_DETAILS = new TransactionDetails(ValueConstant.TRANSACTION_AMOUNT, Currency.EUR);
    public static CardDetails CARD_DETAILS = new CardDetails(ValueConstant.CARD_NUMBER, ValueConstant.EXPIRY_MONTH, ValueConstant.EXPIRY_YEAR, ValueConstant.CVV, ValueConstant.CARD_HOLDER_NAME);
    public static URLDetails URL_DETAILS = new URLDetails(ValueConstant.SUCCESS_URL, ValueConstant.FAIL_URL,ValueConstant.CANCEL_URL);
    public static AddressDetails ADDRESS_DETAILS = new AddressDetails(ValueConstant.CUSTOMER_FIRST_NAME, ValueConstant.CUSTOMER_LAST_NAME, ValueConstant.CUSTOMER_MOBILE_NUMBER, ValueConstant.CUSTOMER_EMAIL);
    public static DynamicDescriptor DYNAMIC_DESCRIPTOR = new DynamicDescriptor(ValueConstant.MERCHANT_NAME, ValueConstant.MERCAHNT_EMAIL, ValueConstant.MERCHANT_MOBILE_NUMBER);
	public static FingerprintDetails FINGERPRINT_DETAILS = new FingerprintDetails(ValueConstant.TIMEZONE, ValueConstant.BROWSER_COLOR_DEPTH, ValueConstant.BROWSER_LANGUAGE, ValueConstant.BROWSER_SCREEN_HEIGHT, ValueConstant.BROWSER_SCREEN_WIDTH, ValueConstant.OS, ValueConstant.BROWSER_ACCEPT_HEADER, ValueConstant.USER_AGENT, ValueConstant.BROWSER_JAVASCRIPT_ENABLED, ValueConstant.BROWSER_JAVA_ENABLED, ValueConstant.ACCEPT_CONTENT);
    public static AcquirerTokenDetails ACQUIRER_TOKEN_DETAILS = new AcquirerTokenDetails("PayPal", "TKNBAAAF1ED-EB7F-41D5-8E35-2F9BBA7716E4", "sti65152-245-5468dwzjvuy-", "12", "2030", "Fred", "123456", "9999");
}