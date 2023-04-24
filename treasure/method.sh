#/bin/bash

clear

arr=("WithHostedPaymentPage.withRedirection" 
        "WithHostedPaymentPage.withoutRedirection"
        "WithoutHostedPaymentPage.cards"
        "WithoutHostedPaymentPage.ideal"
        "WithoutHostedPaymentPage.alternatePaymentMode"
        "ShoppingCardPluginCheckout.cards"
        "ShoppingCardPluginCheckout.ideal"
        "ShoppingCardPluginCheckout.alternatePaymentMode"
        "PluginDetails.pluginDetails"
        "IFramePaymentPage.iFramePaymentPage"
        "PaymentLink.generatePaymentLinkDetails"
        "PaymentLink.getPaymentLinkDetails"
        "PaymentLink.updatePaymentLinkDetails"
        "PaymentLink.deactivatePaymentLink"
        "CardTokenization.saveCard"
        "CardTokenization.saveAcquireTokenDetails"
        "CardTokenization.getSaveCards"
        "CardTokenization.verifyCard"
        "CardTokenization.getAllAcquirerToken"
        "CardTokenization.deleteToken"
        "CardTokenization.tokenizationPayment_withCvv"
        "CardTokenization.tokenizationPayment_withoutCvv"
        "BackofficeOperation.voidPayment"
        "BackofficeOperation.capturePayment"
        "Refund.refundTransaction"
        "Refund.refundDetails"
        "Payout.withRedirection"
        "Payout.withoutRedirection"
        "Payout.cardPayout_withoutHostedPage"
        "Payout.cardPayout_synchronousFlow"
        "Payout.synchronousTokenizationPayouts"
        "Payout.asynchronousTokenizationPayouts"
        "Reporting.transactionReport"
        "Reporting.refundReport"
        "Reporting.chargebackReport"
        "Reporting.customerPayoutReport"
        "Reporting.subscriptionReport"
        "Reporting.plansReport"
        "Reporting.subscriptionTransactionReport"
        "Webhook.setupWebhookEndpoint"
        "Webhook.getWebhookDetails"
        "Webhook.deactivateWebhook"
        "Webhook.udpateWebhookStepupDetails"
        "Subscription.createPlan"
        "Subscription.updateSubscriptionPlan"
        "Subscription.getSubscriptionPlanDetails"
        "Subscription.deactivateSubscriptionPlan"
        "Subscription.createSubscription"
        "Subscription.updateSubscription"
        "Subscription.getSubscriptionDetails"
        "Subscription.deactivateSubscription"
        "Subscription.scheduleUpdateSubscription")


function generate {
	for str in "${arr[@]}"; do
		touch "$str"
	done
}

function remove {
	for str in "${arr[@]}"; do
		rm "$str"
	done
}

if [[ -f "${arr[0]}" ]]; then
	remove
else
	generate
fi



