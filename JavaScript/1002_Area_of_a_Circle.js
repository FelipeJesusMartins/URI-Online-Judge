var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let a = parseFloat(lines.shift());

console.log(`A=${((a*a)*3.14159).toFixed(4)}`);