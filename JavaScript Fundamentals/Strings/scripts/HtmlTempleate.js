'use strict';

function generateList(people, template) {
    var result = '<ul>';

    people.forEach(function (human) {
        result += '<li>';

        result += template.replace(/-\{(.*?)\}-/g, function (match, p1) {
            return human[p1]
        });

        result += '</li>'
    });

    result += '</ul>';

    return result
}

var people =
        [
            { name: 'Peter', age: 14 }
            ,
            { name: 'Ivan', age: 18 }
            ,
            { name: 'Vlado', age: 17 }
            ,
            { name: 'Joro', age: 25 }
        ]

    , template = document.getElementById('list-item');
var element = document.createElement("div");
element.innerHTML = "<strong>-{name}-</strong> <span>-{age}-</span>";
element.innerHTML = generateList(people,  element.innerHTML);
document.getElementById("result").appendChild(element);