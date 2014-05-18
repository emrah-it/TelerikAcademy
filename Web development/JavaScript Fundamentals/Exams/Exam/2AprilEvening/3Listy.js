var input = [
    'def func sum[5, 3, 7, 2, 6, 3]',
    'def func2 [5, 3, 7, 2, 6, 3]',
    'def func3 min[func2]',
    'def func4 max[5, 3, 7, 2, 6, 3]',
    'def func5 avg[5, 3, 7, 2, 6, 3]',
    'def func6 sum[func2, func3, func4 ]',
    'sum[func6, func4]'];


var input2 = [
    'def func sum[1, 2, 3, -6]',
    'def newList [func, 10, 1]',
    'def newFunc sum[func, 100, newList]',
    '[newFunc]'];


var test009 = [
    'def maxy max[100   ,600,6001,-100]',
    'def combo [maxy, maxy,maxy,maxy, 5,6]',
    'def summary sum[combo, maxy, -18000]',
    'def pe6o avg[summary,5,maxy]',
    'sum[1, pe6o]'];
var test012 = [
    'avg[1894998,2]'];
var test011 = [
    'def maxy max[100, 5000, 4,2,1]',
    'def summary1 [0]',
    'def summary11 avg[summary1,maxy]',
    'def summary111 avg[   summary11 ,  maxy]',
    'def summary1111 avg[summary111 , maxy]',
    'sum[75468, summary1111]'];


console.log(Solve(test011));

function Solve(params) {
    var variabels = [];
    params = cleaerWhiteSpace(params);
    function cleaerWhiteSpace(params) {
        for (var i = 0; i < params.length; i++) {
            while (true) {
                params[i] = params[i].trim();
                var indexOfNextWhiteSPace = params[i].indexOf('  ');
                if (indexOfNextWhiteSPace == -1) {
                    break;
                }
                else {
                    params[i] = params[i].replace('  ', ' ');
                }
            }
        }
        return params;
    }

    function getNext(curretLine) {
        var varName = '';
        for (var i = 0; i < curretLine.length; i++) {
            ch = curretLine[i];
            if (ch == ' ' || ch == '[' || ch == ']') {
                return varName;
            }
            else {
                varName += ch;
            }
        }

        return varName;
    }

    function getInScopes(curretLine) {
        var endIndex = curretLine.indexOf(']');

        curretLine = curretLine.substr(1, (endIndex - 1));
        var currVars = curretLine.split(',');
        array = [];
        for (var i = 0; i < currVars.length; i++) {
            var curr = currVars[i].trim();
            if (isNaN(curr)) {
                for (var j = 0; j < variabels[curr].length; j++) {
                    array.push(variabels[curr][j]);
                }
            }
            else {
                array.push(curr);
            }
        }
        return array;
    }

    function calculateIt(cmd, currentResult) {
        function sum(currentResult) {
            var sum = 0;
            var array = [];
            for (var j = 0; j < currentResult.length; j++) {
                sum += (currentResult[j] - 0);
            }
            array.push(sum);
            return array;
        }

        function min(currentResult) {
            var min = Number.MAX_VALUE;
            var arr = [];
            for (var j = 0; j < currentResult.length; j++) {
                if (min > (currentResult[j] - 0)) {
                    min = (currentResult[j] - 0);
                }
            }
            arr.push(min);
            return arr;
        }

        function max(array) {
            var max = Number.MIN_VALUE;
            var result = [];
            for (var j = 0; j < array.length; j++) {
                if (max < (array[j] - 0)) {
                    max = (array[j] - 0);
                }
            }
            result.push(max);
            return result;
        }

        function avg(currentResult) {
            var currentSum = sum(currentResult);
            currentSum = parseInt(currentSum / currentResult.length);
            var result = [];
            result.push(currentSum);
            return result;
        }

        switch (cmd) {
            case 'sum':
                return sum(currentResult);
            case 'min':
                return min(currentResult);
            case 'max':
                return max(currentResult);
            case 'avg':
                return avg(currentResult);
        }
    }

    function processCurrentLien(curretLine) {
        if (curretLine.substr(0, 4) == 'def ') {
            curretLine = curretLine.substr(4).trim();
            var varName = getNext(curretLine).trim();
            curretLine = curretLine.substr(varName.length).trim();
            if (curretLine[0] == '[') {
                var currentResult = getInScopes(curretLine);
                variabels[varName] = currentResult;
            }
            else {
                var cmd = getNext(curretLine).trim();
                curretLine = curretLine.substr(cmd.length).trim();
                var currentResult = getInScopes(curretLine);
                currentResult = calculateIt(cmd, currentResult);
                variabels[varName] = currentResult;
            }
        }
        else{
            if (curretLine[0] == '[') {
                var currentResult = getInScopes(curretLine);
                return  currentResult;
            }
            else{
                var cmd = getNext(curretLine).trim();
                curretLine = curretLine.substr(cmd.length).trim();
                var currentResult = getInScopes(curretLine);
                currentResult = calculateIt(cmd, currentResult);
                return currentResult;
            }
        }
    }

    var result;
    for (var i = 0; i < params.length; i++) {
        result =  processCurrentLien(params[i]);
    }


    return result[0];
}
