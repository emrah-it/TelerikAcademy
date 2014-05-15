var small = "";
var big = "";
var current;
var output = document.getElementById("result");
var newElement = document.createElement("p");
for(current in document){
    small = current;
    big = current;
    break;
}

for(current in document){
    if(current + "" < small){
        small = current + "";
    }
    if(current + "" > big){
        small = current + "";
    }
}

var newElement = document.createElement("p");
newElement.innerHTML = "Document smallest propery is :" + small;
output.appendChild(newElement);

newElement = document.createElement("p");
newElement.innerHTML = "Document biggest propery is :" + big;
output.appendChild(newElement);
//------------------------------------------------
for(current in window){
    small = current;
    big = current;
    break;
}
for(current in window){
    if(current + "" < small){
        small = current + "";
    }
    if(current + "" > big){
        small = current + "";
    }
}

var newElement = document.createElement("p");
newElement.innerHTML = "Window smallest propery is :" + small;
output.appendChild(newElement);

newElement = document.createElement("p");
newElement.innerHTML = "Window biggest propery is :" + big;
output.appendChild(newElement);
//------------------------------------------------
for(current in navigator){
    small = current;
    big = current;
    break;
}
for(current in navigator ){
    if(current + "" < small){
        small = current + "";
    }
    if(current + "" > big){
        small = current + "";
    }
}

var newElement = document.createElement("p");
newElement.innerHTML = "Navigator  smallest propery is :" + small;
output.appendChild(newElement);

newElement = document.createElement("p");
newElement.innerHTML = "Navigator  biggest propery is :" + big;
output.appendChild(newElement);