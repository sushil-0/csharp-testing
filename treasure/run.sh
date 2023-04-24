#!/usr/bin/bash

clear

OPTION=$1

TEMP_FILE=$(mktemp)
PROJECT_PATH="/home/vishesh/Desktop/code/c_sharp/merchant_paymentgateway/"


dotnet run --project "$PROJECT_PATH" "$OPTION" > "$TEMP_FILE"

EXECUTE=$(sed -n '1p' "$TEMP_FILE")
REQUEST=$(sed -n '2p' "$TEMP_FILE")
URL=$(sed -n '3p' "$TEMP_FILE")
PAYLOAD=$(sed -n '4p' "$TEMP_FILE")
HEADER=$(sed -n '5p' "$TEMP_FILE")
RESPONSE=$(sed -n '6p' "$TEMP_FILE")

printf "$EXECUTE\n" | tee -a history.txt
printf "$REQUEST\n" | json_pp 
printf "$REQUEST\n" >> history.txt
printf "$URL\n" | tee -a history.txt
printf "$PAYLOAD\n" | tee -a history.txt
printf "$HEADER\n" | tee -a history.txt
printf "$RESPONSE" | json_pp 
printf "$RESPONSE" >> history.txt

printf "\n\n" >> history.txt
