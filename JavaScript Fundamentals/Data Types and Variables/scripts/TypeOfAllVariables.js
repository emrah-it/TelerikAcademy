function showResult(){
    var output = document.getElementById("result");
    var element;

    element = document.createElement("p");
    element.innerHTML = typeof ""+ " String";
    output.appendChild(element);


    element = document.createElement("p");
    element.innerHTML = typeof 1 + " Number";
    output.appendChild(element);

    var arr = new Array();
    element = document.createElement("p");
    element.innerHTML = typeof arr+ " Array";
    output.appendChild(element);

    element = document.createElement("p");
    element.innerHTML = typeof null + " Null";
    output.appendChild(element);


    element = document.createElement("p");
    element.innerHTML = typeof undefined + " Undefined";
    output.appendChild(element);
}
