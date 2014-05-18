var input3 = ['9',
    '-9',
    '-8',
    '-8',
    '-7',
    '-6',
    '-5',
    '-1',
    '-7',
    '-6'];
console.log(Solve(input3));

function Solve(params){
    var max_sum = -2000000 ;

    for(var i = 1; i < params.length; i++){
        var currentSum = 0;
        for(var j = i; j < params.length; j++){
            currentSum += (params[j] - 0);
            if(currentSum > max_sum){
                max_sum = currentSum;
            }
        }
    }

    return max_sum;
}