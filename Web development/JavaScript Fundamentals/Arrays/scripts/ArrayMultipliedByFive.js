document.getElementById("arraySizeInput").value = "20";
ShowNewArrayIndex();


function ShowNewArrayIndex() {
    var inputNumber = document.getElementById("arraySizeInput").value - 0;
    var output = document.getElementById("result");
    var newArray = new Array();
    var i;
    for ( i = 0; i < inputNumber; i++)
        newArray[i] = i * 5;


    for ( i = 0; i < inputNumber; i++){
        console.log(newArray[i]);
        output.innerHTML = newArray.join(", ") + "</br> Look at console also";
    }
}