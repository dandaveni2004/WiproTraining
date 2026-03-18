function getUser(){
fetch("https://randomuser.me/api/")
.then(function(response){
    return response.json();
})
.then(function(data){
    let user = data.results[0];
    document.getElementById("user").innerHTML = 
    "<h3>" + user.name.first + " " + user.name.last + "</h3>" +
    "<p>Email: " + user.email + "</p>" +
    "<img src='" + user.picture.large + "'>";
})
.catch(function(error){
    console.log("Error:", error);
});

}