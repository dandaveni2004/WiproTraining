function sortArray(){
let input = document.getElementById("numbers").value;
let arr = input.split(",");
arr.sort(function(a,b){
return a - b;
});
document.getElementById("output").innerText = "Sorted Array: " + arr;
}