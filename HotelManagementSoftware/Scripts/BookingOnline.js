//<--!This is javascript file to write the funtional method for the next button and then used post method here.-->


var currentStep = 1;


var step1Form = document.querySelector("#form-step-1");
var step2Form = document.querySelector("#form-step-2");
var step3Form = document.querySelector("#form-step-3");
var step4Form = document.querySelector("#form-step-4");
var nextButton = document.querySelector("#nextbutton");
var backButton = document.querySelector("#backbutton");



step2Form.style.display = "none";
step3Form.style.display = "none";
step4Form.style.display = "none";
backButton.style.display = "none";

function totalPerson() {
    var total = Number(document.querySelector("#adult").value) + Number(document.querySelector("#infant").value) + Number(document.querySelector("#children").value);
    document.querySelector("#total-person").innerHTML= total;
}

function reservation() {

    var room = String(document.querySelector("#room-type").value);
    document.querySelector("#reservation").innerHTML = room;
}

function checkIn() {

    var date = document.querySelector("#booking-date").value;
    document.querySelector("#check-in").innerHTML = date;
}

function BookingNumber() {

    var number = document.querySelector("#BookingNumber").value;
    document.querySelector("#booking-number").innerHTML = number;
}


function backStep() {
    switch (currentStep) {

        case 1:


            break;
        case 2:
            step2Form.style.display = "none";
            step1Form.style.display = "";
            currentStep -= 1;
            backButton.style.display = "none";
            break;
        case 3:
            step3Form.style.display = "none";
            step2Form.style.display = "";
            currentStep -= 1;

            break;
        case 4:
            step4Form.style.display = "none";
            step3Form.style.display = "";
            currentStep -= 1;
            nextButton.innerHTML = "Next";
            break;
    }
}


var validateForm = function (currentStep) {
    var validateCumpulsaryField = function (fieldId) {
        var isValid = $("#" + fieldId).val()
        isValid ? $("#" + fieldId + "-valid-message").hide() : $("#" + fieldId + "-valid-message").show()
        return isValid;
    };

    switch (currentStep) {
        case 1:
            var elementList = ["room-type", "adult", "infant", "children"];
            for (var element in elementList) {
                if (!validateCumpulsaryField(elementList[element])) {
                    return false;
                }
            }

            return true;
            break;

        case 2:
            var elementList = ["First-name", "Home-Country", "Phone-number", "Address", "Sur-name", "Nationality", "Email-Address", "additional-message"]
            for (var element in elementList) {
                if (!validateCumpulsaryField(elementList[element])) {
                    return false;
                }
            }
            return true;
            break;

        case 3:
            var elementList = ["cardnumber", "security-code", "ExpireMonth", "Expire-Year"]
            for (var element in elementList) {
                if (!validateCumpulsaryField(elementList[element])) {
                    return false;
                }
            }
            return true;
            break;

        case 4:
            var elementList = ["booking-number", "reservation", "Check-in", "Check-out", "gst", "Total-Price"]
            for (var element in elementList) {
                if (!validateCumpulsaryField(elementList[element])) {
                    return false;
                }
            }
            return true;
            break;
        default:
    }
}

    var nextStep = function () {

        switch (currentStep) {
            case 1:
                if (!validateForm(currentStep)) return;
                step1Form.style.display = "none";
                step2Form.style.display = "";
                currentStep += 1;
                break;
            case 2:
                if (!validateForm(currentStep)) return;
                step2Form.style.display = "none";
                step3Form.style.display = "";
                currentStep += 1;
                break;
            case 3:
                if (!validateForm(currentStep)) return;
                step3Form.style.display = "none";
                step4Form.style.display = "";
                currentStep += 1;
                nextButton.innerHTML = "Submit";
                break;
            default:

                var dateRange = $("#booking-date").val().split("-");
                dateRange = dateRange.map(function (item) {
                    return item.trim();
                });
                console.log(dateRange);
                data = {
                    "ArrivalDate": dateRange[0] + " 00:00:00",
                    "DepartureDate": dateRange[1] + " 00:00:00",
                    "RoomType": document.getElementById("room-type").value,
                    "Adult": document.getElementById("adult").value,
                    "Infant": document.getElementById("infant").value,
                    "Children": document.getElementById("children").value,
                    //"TotalPerson": document.getElementById("total-person").value,

                    "FirstName": document.getElementById("First-name").value,
                    "Countryorregion": document.getElementById("Home-Country").value,
                    "PhoneNumber": document.getElementById("Phone-number").value,
                    "Address": document.getElementById("Address").value,
                    "SurName": document.getElementById("Sur-name").value,
                    "Nationality": document.getElementById("Nationality").value,
                    "EmailAddress": document.getElementById("Email-Address").value,
                    "AdditionalMessage": document.getElementById("additional-message").value,

                    "CardNumber": document.getElementById("cardnumber").value,
                    "SecurityCode": document.getElementById("security-code").value,
                    "ExpireMonth": document.getElementById("ExpireMonth").value,
                    "ExpireYear": document.getElementById("Expire-Year").value,

                    //"BookingNumber": document.getElementById("booking-number").value,
                    //"YourReservation": document.getElementById("reservation").value,
                    //"CheckIn": document.getElementById("Check-in").value,
                    //"CheckOut": document.getElementById("Check-out").value,
                    //"GST": document.getElementById("gst").value,
                    //"TotalPrice": document.getElementById("Total-Price").value

                };

                $.ajax({
                    url: urls.postBooking,

                    type: 'POST',
                    contentType: 'application/json',
                    data: JSON.stringify(data),
                    success: console.log("success"),
                    error: function (jqXHR, exception) {
                        console.log(jqXHR);
                        console.log(exception);
                    }
                });
        }
        backButton.style.display = "block";
    };

