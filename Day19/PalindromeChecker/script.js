function checkPalindrome(){
let text = document.getElementById("word").value;
let reversed = text.split("").reverse().join("");
if(text === reversed){
document.getElementById("result").innerText = "It is Palindrome";
}
else{
document.getElementById("result").innerText = "Not Palindrome";
}
}