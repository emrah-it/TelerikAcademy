var persons = [
    {firstName: "Gosho", lastName: "Petrov", age: 32},
    {firstName: "Bay", lastName: "Ivan", age: 1},
    {firstName: "va", lastName: "Ivan", age: 8},
    {firstName: "er", lastName: "Ivan", age: 9},
    {firstName: "se", lastName: "Ivan", age: 81},
    {firstName: "asg", lastName: "Ivan", age: 81},
    {firstName: "as", lastName: "Ivan", age: 101},
    {firstName: "sa", lastName: "Ivan", age: 82},
    {firstName: "se", lastName: "Ivan", age: 83},
    {firstName: "vd", lastName: "Ivan", age: 84}
];

var output = document.getElementById("result");

function gorupByCriteria() {
    var criteria = document.getElementById("groupCriteria");
    var checked = criteria[criteria.selectedIndex].value;

    var grouped = group(persons, checked);

    var str = "";
    for (var index in grouped) {
        str += "Grouped by: " + index;
        for (var innerIndex in grouped[index]) {
            str += "<br />" + grouped[index][innerIndex].firstName + " " + grouped[index][innerIndex].lastName + " "
            grouped[index][innerIndex].age;
        }
        str += "<br />";
    }
    output.innerHTML = str;
}
function group(obj, property) {
    var result = new Array();


    for (var index = 0; index < obj.length; index++) {
        if (result[obj[index][property]] == undefined) {
            result[obj[index][property]] = new Array();
            result[obj[index][property]][0] = obj[index];
        }
        else {
            result[obj[index][property]][result[obj[index][property]].length] = obj[index];
        }
    }
    return result;
}

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