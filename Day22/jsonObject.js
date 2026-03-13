
let user = {
    name: "Ganesh",
    age: 22,
    city: "Hyderabad"
};


console.log(user.name);
console.log(user.age);
console.log(user.city);

// Convert object to JSON string
let jsonData = JSON.stringify(user);

console.log(jsonData);
console.log(typeof(jsonData));

//// Convert JSON string to object
let obj = JSON.parse(jsonData);

console.log(obj);
console.log(obj.name);
console.log(typeof(obj));