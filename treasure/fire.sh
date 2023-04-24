#!/usr/bin/bash

clear

OPTION=$1

TEMP_FILE=$(mktemp)
PROJECT_PATH="/home/sushil/wrappers/merchant_paymentgateway"


dotnet run --project "$PROJECT_PATH" "$OPTION" > "$TEMP_FILE"

EXECUTE=$(sed -n '1p' "$TEMP_FILE")
REQUEST=$(sed -n '2p' "$TEMP_FILE")
URL=$(sed -n '3p' "$TEMP_FILE")
PAYLOAD=$(sed -n '4p' "$TEMP_FILE")
HEADER=$(sed -n '5p' "$TEMP_FILE")
TRASH_ENCRYPTION=$(sed -n '6p' "$TEMP_FILE")
REDIRECT_LINK=$(sed -n '7p' "$TEMP_FILE")
RESPONSE_PAYLOAD=$(sed -n '8p' "$TEMP_FILE")

printf "\033[1;32m$EXECUTE\033[0m\n" | tee -a history.txt
printf "$REQUEST\n" | jq
printf "$REQUEST\n" >> history.txt
printf "\033[1;35m$URL\033[0m\n" | tee -a history.txt
printf "$PAYLOAD\n" | jq
printf "$PAYLOAD\n" >> history.txt
printf "\033[1;33m$HEADER\033[0m\n" | tee -a history.txt
printf "\033[1;35m$REDIRECT_LINK\033[0m\n" | tee -a history.txt
printf "$RESPONSE_PAYLOAD" | jq
printf "$REPONSE_PAYLOAD" >> history.txt

printf "\n\n" >> history.txt

TEMP_FILE=$(mktemp)
PAGE=$(mktemp)
$(cp template.html page.html)

sed -i "s|REDIRECT_LINK|${REDIRECT_LINK}|g" page.html
sed -i "s/PAYLOAD/${RESPONSE_PAYLOAD}/g" page.html

google-chrome page.html
