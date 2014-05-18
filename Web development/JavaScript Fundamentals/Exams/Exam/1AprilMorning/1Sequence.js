var firstTest = ['7','1','2','-3','4','4','0','1'];
console.log(Solve(firstTest));

function Solve(params) {
    var N = parseInt(params[0]);
    var answer = 0;

    var length = params.length;
    var counter = 0;
    for(var i = 2 ; i < length; i++){
        if((params[i] - 0) >= (params[i - 1] - 0)){
            counter++;
        }
        else
        {
            answer++;
            counter = 0;
        }
    }

    answer++;
    return answer;
}