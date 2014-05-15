var persons = [];
var output = document.getElementById("result");

function createPerson(firstName, lastName, age) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age
    }
}

function addPerson() {
    var newElement = document.createElement("p");
    var firstName = document.getElementById("firstName").value;
    var lastName = document.getElementById("lastName").value;
    var age = document.getElementById("age").value - 0;
    var newPerson = createPerson(firstName, lastName, age);
    persons.push(newPerson);
    document.getElementById("firstName").value = "";
    document.getElementById("lastName").value = "";
    document.getElementById("age").value = "";
    newElement.innerHTML = newPerson.firstName + " " + newPerson.lastName + " " + newPerson.age;
    output.appendChild(newElement);
}

function showResult() {
    var newElement = document.createElement("p");
    if (persons.length == 0) {
        newElement.innerHTML = "No existing persons";
    }
    else {
        var minAge = Number.MAX_VALUE;
        var youngestPerson;
        for (var current in persons) {
            if (persons[current].age < minAge) {
                youngestPerson = persons[current];
                minAge = persons[current].age;
            }
        }
        newElement.innerHTML = "Youngest person is : " + youngestPerson.firstName + " " + youngestPerson.lastName;
    }
    output.appendChild(newElement);
}
