function checkExp() {
    var input = document.getElementById("inputExpression").value;

    var result = checkExpression(input);

    document.getElementById("result").innerHTML = result ? "Correct" : "It's not correct";
}

function checkExpression(value) {
    var stack = new Array();

    for (var index = 0; index < value.length; index++) {
        if ('(' == value[index]) {
            stack.push('(');
        }
        else if (')' == value[index]) {
            if (stack.length > 0) {
                stack.pop();
            }
            else {
                return false;
            }
        }
    }

    if (stack.length == 0) {
        return true;
    }
    else {
        return false;
    }
}