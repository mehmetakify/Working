function validationFuntion() {
    var answer = document.getElementById("answer").value;
    if (answer.toUpperCase() === "TOSYA") {
        document.getElementById("message").innerHTML = "Correct Answer.";
    } else {
        document.getElementById("message").innerHTML = "Wrong Answer.";
    }
}
function trying() {
    var a = document.getElementById("calculate").value;
    var b = a.substring(0, a.indexOf(" "));
    var c = a.substring(a.indexOf(" ") + 1, a.length);
    document.getElementById("operation").innerHTML = b * c;
}
var city = {
    name: "Kastamonu ",
    place: "North of the Ankara",
    population: 365000,
    peopleInThePlace: function () {
        return this.name + " is in the " + this.place + " and " + this.population + " people lives in there."; 
    }
}
var myCity = {
    name: "Kastamonu ",
    place: "North of the Ankara",
    population: 365000,
}
x = city.peopleInThePlace.call(myCity);
document.getElementById("info").innerHTML = x;