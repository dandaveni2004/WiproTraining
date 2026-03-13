let empName = "Ganesh";
let age = 22;
let salary = 30000;
let dept = "IT";
console.log("Employee Details");
console.log(empName, age, salary, dept);


let bonus = salary * 0.10;
let finalSalary = salary + bonus;
console.log("Final Salary:", finalSalary);


console.log(typeof empName);
console.log(typeof age);
console.log(typeof salary);
console.log(typeof dept);


if (age >= 18) {
    console.log("Eligible");
} else {
    console.log("Not Eligible");
}


let userRole = "admin";

if (userRole === "admin") {
    console.log("Full Access");
}
else if (userRole === "hr") {
    console.log("HR Access");
}
else if (userRole === "employee") {
    console.log("Employee Access");
}
else {
    console.log("Access Denied");
}