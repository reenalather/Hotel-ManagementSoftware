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

var nextStep = function () {
    backButton.style.display = "block";
    switch (currentStep) {
        case 1:
            step1Form.style.display = "none";
            step2Form.style.display = "";
            currentStep += 1;
            break;

        case 2:
            step2Form.style.display = "none";
            step3Form.style.display = "";
            currentStep += 1;
            break;
        case 3:
            step3Form.style.display = "none";
            step4Form.style.display = "";
            currentStep += 1;
            nextButton.innerHTML = "Submit";
            break;
        default:
            data = {
                "ArrivalDate": $()
                "BookingDate": document.getElementById("booking-date").value,
                "RoomType": document.getElementById("room-type").value,
                "Adult": document.getElementById("adult").value,
                "Infant": document.getElementById("infant").value,               
                "Children": document.getElementById("children").value,
                "TotalPerson": document.getElementById("total-person").value,

                "FirstName": document.getElementById("First-name").value,
                "Countryorregion": document.getElementById("Home-Country").value,
                "PhoneNumber": document.getElementById("Phone-number").value,
                "Address": document.getElementById("Address").value,
                "SurName": document.getElementById("Sur-name").value,
                "Nationality": document.getElementById("Nationality").value,
                "EmailAddress": document.getElementById("Email Address").value,
                "AdditionalMessage": document.getElementById("additional-message").value,

                "CardNumber": document.getElementById("cardnumber").value,
                "SecurityCode": document.getElementById("security-code").value,
                "ExpireMonth": document.getElementById("ExpireMonth").value,
                "ExpireYear": document.getElementById("ExpiresYear").value,

                "BookingNumber": document.getElementById("booking-number").value,
                "YourReservation": document.getElementById("reservation").value,
                "CheckIn": document.getElementById("Check-in").value,
                "CheckOut": document.getElementById("Check-out").value,
                "GST": document.getElementById("gst").value,
                "TotalPrice": document.getElementById("Total-Price").value

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
};

