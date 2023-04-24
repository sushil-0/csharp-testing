public class Program {

    static public void Main(String[] args)
    {
        String option = args[0];
        Console.WriteLine("Options: "+option);
        executeMethod(option);
    }

    public static void executeMethod(string option) {
        switch(option) {
        case "WithHostedPaymentPage.withRedirection": 
            WithHostedPaymentPage.withRedirection();
            break;
        case "WithHostedPaymentPage.withoutRedirection":
            WithHostedPaymentPage.withoutRedirection();
            break;
        case "WithoutHostedPaymentPage.cards":
            WithoutHostedPaymentPage.cards();
            break;
        case "WithoutHostedPaymentPage.ideal":
            WithoutHostedPaymentPage.ideal();
            break;
        case "WithoutHostedPaymentPage.alternatePaymentMode":
            WithoutHostedPaymentPage.alternatePaymentMode();
            break;
        case "ShoppingCardPluginCheckout.cards":
            ShoppingCardPluginCheckout.cards();
            break;
        case "ShoppingCardPluginCheckout.ideal":
            ShoppingCardPluginCheckout.ideal();
            break;
        case "ShoppingCardPluginCheckout.alternatePaymentMode":
            ShoppingCardPluginCheckout.alternatePaymentMethod();
            break;
        case "PluginDetails.pluginDetails":
            PluginDetails.plugInDetails();
            break;
        case "IFramePaymentPage.iFramePaymentPage":
            IFramePaymentPage.iFramePaymentPage();
            break;
        case "CardTokenization.saveCard":
            CardTokenization.saveCard();
            break;
        case "CardTokenization.saveAcquireTokenDetails":
            CardTokenization.saveAcquirerTokenDetails();
            break;
        case "CardTokenization.getSaveCards":
            CardTokenization.getSaveCards();
            break;
        case "CardTokenization.verifyCard":
            CardTokenization.verifyCard();
            break;
        case "CardTokenization.getAllAcquirerToken":
            CardTokenization.getAllAcquirerToken();
            break;
        case "CardTokenization.deleteToken":
            CardTokenization.deleteToken();
            break;
        case "CardTokenization.tokenizationPayment_withCvv":
            CardTokenization.tokenizationPayment_withCvv();
            break;
        case "CardTokenization.tokenizationPayment_withoutCvv":
            CardTokenization.tokenizationPayment_withoutCvv();
            break;
        case "PaymentLink.generatePaymentLinkDetails":
            PaymentLink.generatePaymentLinkDetails();
            break;
        case "PaymentLink.getPaymentLinkDetails":
            PaymentLink.getPaymentLinkDetails();
            break;
        case "PaymentLink.updatePaymentLinkDetails":
            PaymentLink.updatePaymentLinkDetails();
            break;
        case "PaymentLink.deactivatePaymentLink":
            PaymentLink.deactivatePaymentLink();
            break;
        case "BackofficeOperation.voidPayment":
            BackofficeOperation.voidPayment();
            break;
        case "BackofficeOperation.capturePayment":
            BackofficeOperation.capturePayment();
            break;
        case "Refund.refundTransaction":
            Refund.refundTransaction();
            break;
        case "Refund.refundDetails":
            Refund.refundDetails();
            break;
        case "Payout.withRedirection":
            Payout.withRedirection();
            break;
        case "Payout.withoutRedirection":
            Payout.withoutRedirection();
            break;
        case "Payout.cardPayout_withoutHostedPage":
            Payout.cardPayout_withoutHostedPage();
            break;
        case "Payout.cardPayout_synchronousFlow":
            Payout.cardPayout_synchronousFlow();
            break;
        case "Payout.synchronousTokenizationPayouts":
            Payout.synchronousTokenizationPayouts();
            break;
        case "Payout.asynchronousTokenizationPayouts":
            Payout.asynchronousTokenizationPayouts();
            break;
        case "Reporting.transactionReport":
            Reporting.transactionReport();
            break;
        case "Reporting.refundReport":
            Reporting.refundReport();
            break;
        case "Reporting.chargebackReport":
            Reporting.chargebackReport();
            break;
        case "Reporting.customerPayoutReport":
            Reporting.chargebackReport();
            break;
        case "Reporting.subscriptionReport":
            Reporting.subscriptionsReport();
            break;
        case "Reporting.plansReport":
            Reporting.plansReport();
            break;
        case "Reporting.subscriptionTransactionReport":
            Reporting.subscriptionTransactionReport();
            break;
        case "Webhook.setupWebhookEndpoint":
            Webhook.setupWebhookEndpoint();
            break;
        case "Webhook.getWebhookDetails":
            Webhook.getWebhookDetails();
            break;
        case "Webhook.deactivateWebhook":
            Webhook.deactivateWebhook();
            break;
        case "Webhook.udpateWebhookStepupDetails":
            Webhook.udpateWebhookStepupDetails();
            break;
        case "Subscription.createPlan":
            Subscription.createPlan();
            break;
        case "Subscription.updateSubscriptionPlan":
            Subscription.updateSubscriptionPlan();
            break;
        case "Subscription.getSubscriptionPlanDetails":
            Subscription.getSubscriptionPlanDetails();
            break;
        case "Subscription.deactivateSubscriptionPlan":
            Subscription.deactivateSubscriptionPlan();
            break;
        case "Subscription.createSubscription":
            Subscription.createSubscription();
            break;
        case "Subscription.updateSubscription":
            Subscription.updateSubscription();
            break;
        case "Subscription.getSubscriptionDetails":
            Subscription.getSubscriptionDetails();
            break;
        case "Subscription.deactivateSubscription":
            Subscription.deactivateSubscription();
            break;
        case "Subscription.scheduleUpdateSubscription":
            Subscription.scheduleUpdateSubscription();
            break;
        default: 
            Console.WriteLine("Invalid choice");
            break;
        }
    }
}
