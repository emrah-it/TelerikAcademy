function testInput() {
    var format = "{0}, {1}, {0} text {2}";
    var str = stringFormat(format, 1, "Pesho", "Gosho");

    document.getElementById("result").innerHTML = str;
}

function stringFormat() {
    var text = arguments[0];
    var counter = 0;
    var currentResult = true;
    var re = new RegExp("regex", "g");
    while (true) {
        var current = "{" + counter++ + "}";
        currentResult = false;
        var text = text.replace(current, arguments[counter]);
        if(text.indexOf(current) != -1){
            counter--;
        }

        if(counter == arguments.length){
            break;
        }
    }
    return text;
}