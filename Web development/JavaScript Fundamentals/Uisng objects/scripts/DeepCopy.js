function showDeepCopy() {
    var outputResult = document.getElementById("result");
    var currentArray = [1, 2, 3, 4, 5];
    var createNewElement = document.createElement("p");
    createNewElement.innerHTML = "First array before clone: " + currentArray.join(", ");
    outputResult.appendChild(createNewElement);
    var newArray = clone(currentArray);
    createNewElement = document.createElement("p");
    createNewElement.innerHTML = "New array before change it : " + newArray.join(", ");
    outputResult.appendChild(createNewElement);
    newArray[0] = 10;

    createNewElement = document.createElement("p");
    createNewElement.innerHTML = "New array after change it : " + newArray.join(", ");
    outputResult.appendChild(createNewElement);

    createNewElement = document.createElement("p");
    createNewElement.innerHTML = "Old array after change new array: " + currentArray.join(", ");
    outputResult.appendChild(createNewElement);
}

function clone(obj) {
    if (obj == null || typeof(obj) != 'object')
        return obj;

    var temp = obj.constructor(); // changed

    for (var key in obj)
        temp[key] = clone(obj[key]);
    return temp;
}