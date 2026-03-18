fetch("https://dummy.restapiexample.com/api/v1/employees")
.then(function(response){
    return response.json(); // convert response to JSON
})
.then(function(data){
    console.log(data); // display data in console
})
.catch(function(error){
    console.log("Error:", error); // handle error
});