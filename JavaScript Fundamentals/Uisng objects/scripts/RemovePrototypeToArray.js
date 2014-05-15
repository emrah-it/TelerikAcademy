function removeElements(){
    var inputArray = document.getElementById("inputArray").value.split(",");
    var removeELement = document.getElementById("elementToRemove").value;
    inputArray.remove(removeELement);
    document.getElementById("result").innerHTML = inputArray.join(",");

}

Array.prototype.remove = function(element){
    var newArray = new Array();
    for(var current in this){
        if(this[current] == element){
            this.splice(current, 1);
        }
    }
}