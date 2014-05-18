var input = [
    '(def func 10)',
    '(def newFunc (+  func 2))',
    '(def sumFunc (+ func func newFunc 0 0 0))',
    '(* sumFunc 2)'];
var input2 = [
    '(def func (+ 5 2))',
    '(def func2 (/  func 5 2 1 0))',
    '(def func3 (/ func 2))',
    '(+ func3 func)'];

var input3 = [
'(def myFunc 5)',
'(def myNewFunc (+  myFunc  myFunc 2))',
'(def MyFunc (* 2  myNewFunc))',
'(/  MyFunc  myFunc)'];


var input4 = [
' (def     go6o    (/ -7 1 1 1 1) )',
'(def asd (/ 0 5))',
'(def func2 asd  )',
'(           +        4          2      func2)',
];
console.log(Solve(input));
function Solve(params) {
    var result = [];
    var variables = [];

    function getNextName(line) {
        line = line.trim();
        var varName = '';

        for(var i = 0; i < line.length; i++){
            if(line[i] != ' ' &&
                line[i] != ')'&&
                line[i] != '('){
                varName += line[i];
            } else{
                return varName;
            }
        }
        return varName;
    }

    function isOperator(operator) {
        if(operator == '-' ||
            operator == '+' ||
            operator == '*' ||
            operator == '/' ){
            return true;
        }
        else{
            return false;
        }
    }

    function getAsInteger(currentVar) {
        if(isNaN(currentVar - 0)){
            return variables[currentVar];
        }
        else{
            return currentVar - 0;
        }
    }

    function calculateIt(operator, sum, current) {
        switch (operator){
            case '-': return sum - current;
            case '+': return sum + current;
            case '*': return sum * current;
            case '/': return sum / current;
        }
    }

    function calcLine(innerScope) {
        innerScope = innerScope.substr(1, innerScope.length - 2).trim();
        var varName = null;
        var currentResult = 0;
        if(innerScope.substr(0,4) == 'def '){
            innerScope = innerScope.substr(4).trim();
            varName = getNextName(innerScope);
            innerScope = innerScope.substr(varName.length).trim();
            currentResult = getAsInteger(innerScope);
        }
        else if(isOperator(innerScope[0])){
            var operator = innerScope[0];
            innerScope = innerScope.substr(1).trim();
            var sum = 0;
            var current = Number.NaN;
            for(var i = 0; i < innerScope.length; i++){
                if(innerScope[i] == ' ') continue;
                var currentVar = getNextName(innerScope.substr(i));
                i += currentVar.length;

                if(isNaN(current)){
                    current = getAsInteger(currentVar);
                    sum = current;
                }
                else{
                    current = getAsInteger(currentVar);
                    sum = calculateIt(operator, sum, current);
                }
            }
            return sum;
        }




        if(varName != null){
            variables[varName] = parseInt(currentResult);
            return variables[varName];
        }
        return sum;
    }

    for (var i = 0; i < params.length; i++) {
        var currLine = params[i].trim();
        var invariable = false, inScopes = false;
        var varName = '';
        var hasDef = false;
        var defName;
        for(var j = 1; j < currLine.length; j++){
            if(currLine.indexOf('(', j) != -1){
                var startIndex = currLine.indexOf('(', j);
                var end = currLine.indexOf(')');
                var innerScope = currLine.substr(startIndex, (end - startIndex) + 1 );
                var currentLineResult = calcLine(innerScope);
                if(currentLineResult  + ''== 'Infinity'){
                    result.push(currentLineResult);
                    break;
                }
                currLine = currLine.replace(innerScope, currentLineResult);
            }
            else{
                result.push(calcLine(currLine));
                break;
            }
        }

    }
    for(var i = 0; i < result.length; i++){
        if(result[i] + '' == 'Infinity' ){
            return 'Division by zero! At Line:' +  (i + 1);
        }
    }
    return parseInt(result[result.length -1]);
}
