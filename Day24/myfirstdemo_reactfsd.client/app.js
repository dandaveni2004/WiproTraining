function add(a, b) {
    return a + b;
}
var sum = add(5, 10);
// A generic Add fucntion that can work with different types of numbers (e.g., integers, floats, strings that can be converted to numbers)
function genericAdd(a, b) {
    return Number(a) + Number(b);
}
var genericSum = genericAdd(5, 10);
console.log("The generic sum is: " + genericSum);
var genericSum2 = genericAdd("10", "5");
console.log("The generic sum is: " + genericSum2);
function identity(arg) {
    return arg;
}
var output1 = identity("Hello, Generics!");
console.log(output1);
var output2 = identity(42);
console.log(output2);
