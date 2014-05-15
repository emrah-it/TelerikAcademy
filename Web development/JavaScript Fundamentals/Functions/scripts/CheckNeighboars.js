function checkPosition(){
    var inputArrayAsString = document.getElementById("inputArray").value;
    var position = document.getElementById("position").value - 0;
    var arrayAsString = inputArrayAsString.split(" ");
    var array = [];
    for(var index in arrayAsString){
        if(arrayAsString[index] != "")
        array.push(arrayAsString[index] - 0);
    }
    if(checkNeighboarsInArray(array, position)){
        document.getElementById("result").innerHTML = "Element in this position is bigger than his neighbors";
    }
    else{
        document.getElementById("result").innerHTML = "Element in this position isn't bigger from his neighbors";
    }

}

function checkNeighboarsInArray(array, position){
    if(position == 0){
        if(array[position] > array[position + 1]){
            return true;
        }
    }
    else if(position == array.length - 1){
        if(array[position] > array[position - 1]){
            return true;
        }
    }
    else{
        if(array[position] > array[position + 1] &&
            array[position] > array[position - 1]){
            return true;
        }
    }
    return false;
}