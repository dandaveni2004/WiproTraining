var xhr = new XMLHttpRequest();
xhr.open("GET", "https://jsonplaceholder.typicode.com/users/1");
xhr.onload = function () {
    let user = JSON.parse(xhr.responseText);
    console.log("User Name:", user.name);
    console.log("Email:", user.email);
};
xhr.send();

var xhr = new XMLHttpRequest();
xhr.open("GET", "https://dummyjson.com/recipes");
xhr.onload = function () {
let data = JSON.parse(xhr.responseText);
data.recipes.forEach(function(recipe){
console.log("Recipe:", recipe.name);
});
}
xhr.send();




fetch("https://dummyjson.com/recipes")
.then(response => response.json())
.then(data => {
    data.recipes.forEach(recipe => {
        console.log("Recipe:", recipe.name);
        console.log("Cuisine:", recipe.cuisine);
        console.log("----------------");
    });
});