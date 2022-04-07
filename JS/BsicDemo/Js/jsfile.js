//Arithmeticops
function add() {
    console.log("Welcome");
    var num1 = document.getElementById("n1").value;
    var num2 = document.getElementById("n2").value;
   // var reslt = num1 + num2; console.log(num1 + " " + num2); console.log(reslt);
    var reslt = parseInt(num1) + parseInt(num2); console.log(num1 + " " + num2); console.log(reslt);
    document.getElementById("res").value =reslt;
    console.log("Addition");
}
function sub() {
    var num1 = document.getElementById("n1").value;
    var num2 = document.getElementById("n2").value;
    var reslt = parseInt(num1) - parseInt(num2);
    document.getElementById("res").value = reslt;
    console.log("Sbstraction");
}
function div() {
    var num1 = document.getElementById("n1").value;
    var num2 = document.getElementById("n2").value;
    var reslt = parseInt(num1)/parseInt(num2);
    document.getElementById("res").value = reslt;
    console.log("Division");
}
function mul() {
    var num1 = document.getElementById("n1").value;
    var num2 = document.getElementById("n2").value;
    var reslt = parseInt(num1) * parseInt(num2);
    document.getElementById("res").value = reslt;
    console.log("Multiplication");
}
//Home Page
function arithmeticops() {
    window.open("../html/Arithmeticops.html");
    
}
function arrayfun() {
    window.open("../html/Arrayfun.html");

}
function regi(){
    window.open("../html/register.html");

}
//ArrayFun
function obj() {

}
function basic() {
    const arr = [12, 56, 55, 66, 25, 23];
    const arr1 = ["Manas", "Klap", "Riri", "Sadhna"];
    //console.log("Displaying Array elemnets:");
    //console.log(arr);
    document.getElementById("pid").innerHTML = "Array Elements:" + arr;
    document.getElementById("pid1").innerHTML = "String Array Elements:" + arr1;
}
function sort() {
    const arr = [12, 56, 55, 66, 25, 23];
    const arr1 = ["Manas", "Klap", "Riri", "Sadhna"];
    //console.log("Displaying Array elemnets:");
    //console.log(arr);
    document.getElementById("pid2").innerHTML = "Sorting Array" + arr.sort();
    arr.push(100);
    document.getElementById("pid11").innerHTML = "Sorting Array" + arr.sort();
    document.getElementById("pid3").innerHTML = "SortingString Array" + arr1.sort();
}
function merge() {
    const arr = [12, 56, 55, 66, 25, 23];
    const arr1 = ["Manas", "Raghu", "Lili", "Champa", "Parshu"];
    //console.log("Displaying Array elemnets:");
    //console.log(arr);
    //document.getElementById("pid4").innerHTML = "Merging of Array" + arr1+ arr.merge();
}
function rev() {
    const arr = [12, 56, 55, 66, 25, 23];
    const arr1 = ["Manas", "Raghu", "Lili", "Champa", "Parshu"];
    //console.log("Displaying Array elemnets:");
    //console.log(arr);
    document.getElementById("pid5").innerHTML = "Reverse of Array" + arr.reverse();
    document.getElementById("pid6").innerHTML = "Reverse of Array" + arr1.reverse();
}
function slice() {
    const arr = [12, 56, 55, 66, 25, 23];
    const arr1 = ["Manas", "Klap", "Riri", "Sadhna"];
    //console.log("Displaying Array elemnets:");
    //console.log(arr);
    document.getElementById("pid7").innerHTML = "ArraySlicing" + arr.slice(3);
    document.getElementById("pid8").innerHTML = "ArraySlicing" + arr.slice(1, 3);
    document.getElementById("pid9").innerHTML = "StringArraySlicing" + arr1.slice(3.4);
}

//register
function register() {
    var pass = document.getElementById("pass").value;
    var cpass = document.getElementById("cpass").value;
    var email = document.getElementById("email").value;
    //if (pass == null || cpass == null || email==null)
    if(!pass || !cpass || !email){
        alert("Please Fill All the details");
    }
    else if (pass == cpass) {
        console.log("Welcome");
        localStorage.setItem("emailId", document.getElementById("email").value);
        localStorage.setItem("pass", document.getElementById("pass").value);
        alert("EmailId:" + localStorage.getItem("emailId") + "\n Password:" + " Stored Successfully");
        window.open("../html/Login.html");
    }
    else {
        alert("Password Doesnt Match");
    }
}
function clearall() {
    doucument.getElementById("frm").value=' ';
}
//Login
function check() {
   var uname = document.getElementById("email").value;
    var pass = document.getElementById("password").value;
    console.log(uname + " " + pass);
   /* if (localStorage.getItem(0) == uname) {
        window.open("portal.html");
    }*/
    if (uname == localStorage.getItem("emailId") && pass == localStorage.getItem("pass") ){
        //how to move to next page??
        window.open("portal.html");
    }
    else {
        alert("Invalid Credential");
    }
}