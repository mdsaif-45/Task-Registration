// Enter event listener
var element = document.getElementById("salt");
element.addEventListener("keypress", function (event) {
    if (event.key === "Enter") {
        event.preventDefault();
        validate();
        element.value = "";
    }
})


// Get Current Time
function getTime() {
    var name = document.getElementById("name").value;

    $.ajax({
        type: "POST",
        url: "WebServices/RegistrationService.asmx/GetTime",
        data: '{ name: "' + name + '" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function OnSuccess(response) {
            document.getElementById("timenow").innerHTML = response.d;
            //alert(response.d);
        },
        failure: function (response) {
            alert(response.d);
        }

    });
}


/* old ajax approach */
//Task1.WebService.Registeration();

//var ajax = new XMLHttpRequest();
//ajax.readyState = function () {
//    if (ajax.readyState == 4 && ajax.status == 200) {
//        ajax.open("Get", "WebService/Registeration.asmx?nm=" + name.value + "&dob=" + dob.value, false);
//    }
//}
//ajax.send();


/* validate Registration Form */
function validate() {

    var name = document.getElementById("name");
    var email = document.getElementById("email");
    var password = document.getElementById("password");
    var dob = document.getElementById("dob");
    var gender = document.querySelector('input[name="gender"]:checked');
    var country = document.getElementById("country");

    //var meal = document.querySelector('input[name="meal"]:checked');
    var meal = '';
    if (document.getElementById("salt").checked) {
        meal += document.getElementById("salt").value + " ";
    }
    if (document.getElementById("calarie").checked) {
        meal += document.getElementById("calarie").value;
    }
    //alert(meal); 

    if (dob.value == '' || name.value == '' || email.value == '' || password.value == '' || gender.value == null || country.value == '' || meal == '')
    {
        alert("please enter all details..");
        //return;
    }
    else {

        //document.write("<h1>User Entered Details </h1>");
        //document.writeln("<br />Name : " + name.value);
        //document.writeln("<br />Email : " + email.value);
        //document.writeln("<br />Dob : " + dob.value);
        //document.writeln("<br />Country : " + country.value);
        //document.writeln("<br />Gender : " + gender.value);
        //document.writeln("<br />Meal preference : " + meal);

        var formdata = {}
        formdata.Name = name.value;
        formdata.Email = email.value;
        formdata.Dob = dob.value;
        formdata.Country = country.value;
        formdata.Gender = gender.value;
        formdata.Meal = meal;

        $.ajax({
            type: "POST",
            url: "WebServices/RegistrationService.asmx/RegistrationForm",
            //data: "{'name':'" + name.value + "', 'email':'" + email.value + "', 'dob':'" + dob.value + "', 'country':'" + country.value + "', 'gender':'" + gender.value + "', 'meal':'" + meal + "' }",
            data: JSON.stringify({ Formdata: formdata }),
            contentType: "application/json",
            datatype: "json",
            success: function (res) {
                document.getElementById("result").style.display = "block";
                document.getElementById("divForminfo").innerHTML = res.d;
            },
            failure: function (res) {
                alert(res.d);
            }
        });

    }

}