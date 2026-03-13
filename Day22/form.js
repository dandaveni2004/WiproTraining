$(document).ready(function(){
$("#contactForm").submit(function(event){
event.preventDefault();
var name = $("#name").val();
var email = $("#email").val();
var message = $("#message").val();
alert(
"Name: " + name +
"\nEmail: " + email +
"\nMessage: " + message
);
});
});