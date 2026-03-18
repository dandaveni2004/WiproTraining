function App() {
const [users,setUsers] = React.useState([]);
const [name,setName] = React.useState("");
React.useEffect(()=>{
fetch("/users")
.then(res=>res.json())
.then(data=>setUsers(data));
},[]);
function addUser(e){
e.preventDefault();
fetch("/users",{
method:"POST",
headers:{
"Content-Type":"application/json"
},
body:JSON.stringify({name})
})
.then(res=>res.json())
.then(newUser=>{
setUsers([...users,newUser]);
setName("");
});
}
return(
<div>
<form onSubmit={addUser}>
<input
type="text"
value={name}
onChange={(e)=>setName(e.target.value)}
placeholder="Enter name"
/>
<button type="submit">Add User</button>
</form>
<ul>
{users.map(user=>(
<li key={user.id}>{user.name}</li>
))}
</ul>
</div>
);
}
ReactDOM.createRoot(document.getElementById("root")).render(<App />);