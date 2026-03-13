let randomNumber = Math.floor(Math.random() * 10) + 1;

function checkGuess(){

let userGuess = Number(document.getElementById("guess").value);

if(userGuess === randomNumber){
document.getElementById("message").innerText = "Correct Guess!";
}
else if(userGuess > randomNumber){
document.getElementById("message").innerText = "Too High!";
}
else{
document.getElementById("message").innerText = "Too Low!";
}

}