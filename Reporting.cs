using GatewayCSharp.Properties.Report;
using GatewayCSharp.Properties.Constants;

public class Reporting {
    public static void transactionReport() {
        Console.WriteLine("Reporting.transactionReport() executing...");
        ReportDetails reportDetails = new ReportDetails(ValueConstant.FROM_DATE, ValueConstant.TO_DATE, ReportTypes.TRANSACTION_REPORT, Field.TXN_REFERENCE, ValueConstant.FROM_COUNT, ValueConstant.LIMIT, SortOrder.ASC);
        string response = ReportFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetReportDetails(reportDetails);
        Console.WriteLine(response);
    }

    public static void refundReport() {
        Console.WriteLine("Reporting.refundReport() executing...");
        ReportDetails reportDetails = new ReportDetails(ValueConstant.FROM_DATE, ValueConstant.TO_DATE, ReportTypes.REFUND_REPORT, Field.TXN_REFERENCE, ValueConstant.FROM_COUNT, ValueConstant.LIMIT, SortOrder.ASC);
        string response = ReportFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetReportDetails(reportDetails);
        Console.WriteLine(response);
    }

    public static void chargebackReport() {
        Console.WriteLine("Reporting.chargebackReport() executing...");
        ReportDetails reportDetails = new ReportDetails(ValueConstant.FROM_DATE, ValueConstant.TO_DATE, ReportTypes.CHARGEBACK_REPORT, Field.TXN_REFERENCE, ValueConstant.FROM_COUNT, ValueConstant.LIMIT, SortOrder.ASC);
        string response = ReportFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetReportDetails(reportDetails);
        Console.WriteLine(response);
    }

    public static void customerPayoutReport() {
        Console.WriteLine("Reporting.customerPayoutReport() executing...");
        ReportDetails reportDetails = new ReportDetails(ValueConstant.FROM_DATE, ValueConstant.TO_DATE, ReportTypes.PAYOUTS_REPORT, Field.TXN_REFERENCE, ValueConstant.FROM_COUNT, ValueConstant.LIMIT, SortOrder.ASC);
        string response = ReportFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetReportDetails(reportDetails);
        Console.WriteLine(response);
    }

    public static void subscriptionsReport() {
        Console.WriteLine("Reporting.subscriptionReport() executing...");
        ReportDetails reportDetails = new ReportDetails(ValueConstant.FROM_DATE, ValueConstant.TO_DATE, ReportTypes.SUBSCRIPTION_REPORT, Field.TXN_REFERENCE, ValueConstant.FROM_COUNT, ValueConstant.LIMIT, SortOrder.ASC);
        string response = ReportFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetReportDetails(reportDetails);
        Console.WriteLine(response);
    }

    public static void plansReport() {
        Console.WriteLine("Reporting.plansReport() executing...");
        ReportDetails reportDetails = new ReportDetails(ValueConstant.FROM_DATE, ValueConstant.TO_DATE, ReportTypes.PLANS_REPORT, Field.TXN_REFERENCE, ValueConstant.FROM_COUNT, ValueConstant.LIMIT, SortOrder.ASC);
        string response = ReportFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetReportDetails(reportDetails);
        Console.WriteLine(response);
    }

    public static void subscriptionTransactionReport() {
        Console.WriteLine("Reporting.subscriptionTransactionReport() executing...");
        ReportDetails reportDetails = new ReportDetails(ValueConstant.FROM_DATE, ValueConstant.TO_DATE, ReportTypes.SUBSCRIPTION_TRANSACTION_REPORT, Field.TXN_REFERENCE, ValueConstant.FROM_COUNT, ValueConstant.LIMIT, SortOrder.ASC);
        string response = ReportFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                .SetStaging(true)
                .GetReportDetails(reportDetails);
        Console.WriteLine(response);
    }
}