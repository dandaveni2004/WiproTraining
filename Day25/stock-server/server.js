const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const cors = require("cors");

const app = express();
app.use(cors());

const server = http.createServer(app);

const io = new Server(server,{
cors:{origin:"*"}
});

function getStock(symbol){
return{
symbol:symbol,
price:(Math.random()*1000).toFixed(2)
};
}

io.on("connection",(socket)=>{

socket.on("getStock",(symbol)=>{

setInterval(()=>{

const data = getStock(symbol);
socket.emit("stockUpdate",data);

},3000);

});

});

server.listen(5000,()=>{
console.log("Server running on port 5000");
});