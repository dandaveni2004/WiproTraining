$.ajax({
url: "https://dummyjson.com/recipes",
method: "GET",
success: function(data){
data.recipes.forEach(function(recipe){
console.log("Recipe:", recipe.name);
});
}
});