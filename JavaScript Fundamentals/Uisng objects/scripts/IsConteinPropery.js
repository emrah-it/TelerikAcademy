function checkIt() {
    var outputResult = document.getElementById("result");
    var propertyToCheck = document.getElementById("inputProperty").value;


    if (isContainProperty(document, propertyToCheck)) {
        outputResult.innerHTML = "Yes this property is exist";
    }
    else {
        outputResult.innerHTML = "No, this property isn't exist";
    }
}
function isContainProperty(obj, property) {
    if (obj[property] != undefined) {
        return true;
    }
    else {
        return false;
    }
}