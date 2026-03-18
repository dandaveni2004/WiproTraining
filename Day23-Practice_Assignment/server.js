const express = require("express");
const cors = require("cors");

const app = express();

app.use(cors());
app.use(express.json());
app.use(express.static("public"));

let users = [
  { id: 1, name: "Ganesh" },
  { id: 2, name: "Karthik" }
];

app.get("/users", (req, res) => {
  res.json(users);
});

app.post("/users", (req, res) => {

  const newUser = {
    id: users.length + 1,
    name: req.body.name
  };

  users.push(newUser);

  res.json(newUser);
});

app.listen(3000, () => {
  console.log("Server running on port 3000");
});