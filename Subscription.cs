using GatewayCSharp.Properties.Subscription;
using GatewayCSharp.Properties.Constants.Enums;
using GatewayCSharp.Properties.Payment;
using GatewayCSharp.Properties.Constants;

public class Subscription {
    // PROBLEM: Duplicate subscription plan - reponse is string rather than json
    public static void createPlan() {
        Installment installment = new Installment(ValueConstant.SUBSCRIPTION_PERIOD, ValueConstant.SUBSCRIPTION_FREQUENCY, ValueConstant.SUBSCRIPTION_TOTAL_INSTALLMENTS, ValueConstant.SUBSCRIPTION_TYPE, ValueConstant.TRANSACTION_AMOUNT, Currency.USD);
        installment.sequence="1";
        PlanDetails planDetail = new PlanDetails(ValueConstant.SUBSCRIPTION_CODE, ValueConstant.SUBSCRIPTION_NAME, installment);
        Console.WriteLine("Subscription.createPlan() executing...");
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .CreatePlan(planDetail);
        Console.WriteLine(response);
    }

    public static void updateSubscriptionPlan() {
        Console.WriteLine("Subscription.updateSubscriptionPlan() executing...");
        Installment installment = new Installment(ValueConstant.SUBSCRIPTION_PERIOD, ValueConstant.SUBSCRIPTION_FREQUENCY, ValueConstant.SUBSCRIPTION_TOTAL_INSTALLMENTS, ValueConstant.SUBSCRIPTION_TYPE, ValueConstant.TRANSACTION_AMOUNT, Currency.USD);
        installment.sequence="2";
        PlanDetails planDetail = new PlanDetails(ValueConstant.SUBSCRIPTION_CODE, ValueConstant.SUBSCRIPTION_NAME, installment);
        planDetail.AddInstallment(new Installment("MONTH", "4", "2", "REGULAR", "44.99", Currency.USD));
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .UpdateSubscriptionPlan("d76a2faa-2a04-4774-a33f-c7e4e6f856a5", planDetail);
        Console.WriteLine(response);
    }

    public static void getSubscriptionPlanDetails() {
        Console.WriteLine("Subscription.getSubscriptionPlanDetails() executing...");
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .GetSubscriptionPlan("d76a2faa-2a04-4774-a33f-c7e4e6f856a5");
        Console.WriteLine(response);
    }

    // PROBLEM: Getting resopnse "Transaction Successful" rather than "Plan deactivated"
    public static void deactivateSubscriptionPlan() {
        Console.WriteLine("Subscription.deactivateSubscriptionPlan() executing...");
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .DeactivateSubscriptionPlan("d76a2faa-2a04-4774-a33f-c7e4e6f856a5");
        Console.WriteLine(response);
    }

    public static void createSubscription() {
        Console.WriteLine("Subscription.createSubscription() executing...");
        List<NotificationChannel> notificationChannels = new List<NotificationChannel>();
        notificationChannels.Add(new NotificationChannel(Channel.EMAIL, "foo@bar.com"));
        notificationChannels.Add(new NotificationChannel(Channel.SMS, "1234567890"));
        SubscriptionDetails subscriptionDetails = new SubscriptionDetails("", ValueConstant.SUBSCRIPTION_START_DATE, ValueConstant.SUBSCRIPTION_QUANTITY, notificationChannels);
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                    .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                    .CreateSubscription(subscriptionDetails);
        Console.WriteLine(response);
    }

    public static void updateSubscription() {
        Console.WriteLine("Subscription.updateSubscription() executing...");
        List<NotificationChannel> notificationChannels = new List<NotificationChannel>();
        notificationChannels.Add(new NotificationChannel(Channel.EMAIL, "foo@bar.com"));
        notificationChannels.Add(new NotificationChannel(Channel.SMS, "1234567890"));
        SubscriptionDetails subscriptionDetails = new SubscriptionDetails("", ValueConstant.SUBSCRIPTION_START_DATE, ValueConstant.SUBSCRIPTION_QUANTITY, notificationChannels);
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .SetAddressDetails(DetailsConstant.ADDRESS_DETAILS)
                    .SetTransactionDetails(DetailsConstant.TRANSACTION_DETAILS)
                    .UpdateSubscription("d76a2faa-2a04-4774-a33f-c7e4e6f856a5", subscriptionDetails);
        Console.WriteLine(response);
    }

    public static void getSubscriptionDetails() {
        Console.WriteLine("Subscription.getSubscriptionDetails() executing...");
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .GetSubscriptionDetails("");
        Console.WriteLine(response);
    }

    public static void deactivateSubscription() { 
        Console.WriteLine("Subscription.deactivateSubscription() executing...");
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .DeactivateSubscription("");
        Console.WriteLine(response);
    }

    public static void scheduleUpdateSubscription() {
        SubscriptionDetails subscriptionDetails = new SubscriptionDetails("",  ValueConstant.SUBSCRIPTION_START_DATE, ValueConstant.SUBSCRIPTION_APPLY_DATE, ValueConstant.SUBSCRIPTION_QUANTITY);
        Console.WriteLine("Subscription.scheduleUpdateSubscription() executing...");
        string response = SubscriptionFactory.GetInstance(ValueConstant.CERTIFICATE_PATH, DetailsConstant.MERCHANT_DETAILS, ValueConstant.ACCESS_TOKEN)
                    .SetStaging(true)
                    .ScheduleUpdateSubscription("", subscriptionDetails);
        Console.WriteLine(response);
    }
}