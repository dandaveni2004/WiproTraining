const products = [
  { name: "Laptop", price: 50000, category: "Electronics" },
  { name: "Shoes", price: 2000, category: "Fashion" },
  { name: "Phone", price: 30000, category: "Electronics" },
  { name: "T-Shirt", price: 1000, category: "Fashion" }
];
const productNames = products.map(product => product.name);
console.log(productNames);
const electronics = products.filter(product => 
  product.category === "Electronics"
);
console.log(electronics);
const totalPrice = products.reduce((total, product) => 
  total + product.price, 0
);
console.log(totalPrice);