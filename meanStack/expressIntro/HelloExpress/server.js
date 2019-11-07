const express = require("express");
const app = express();
app.get('/', (request, response) => {
   response.send("Hello Express");
});

//We imported static to the project and are telling express to use static folder for static content.
app.use(express.static(__dirname + "/static"));

//We npm installed ejs(template engine for embedded javascript) and we need to tell express we are using it and where to find out ejs files.
app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');


//Adding a route that displays a list of hard coded users.
app.get("/users", (req, res) => {
   // hard-coded user data
   var users_array = [
       {name: "Michael", email: "michael@codingdojo.com"}, 
       {name: "Jay", email: "jay@codingdojo.com"}, 
       {name: "Brendan", email: "brendan@codingdojo.com"}, 
       {name: "Andrew", email: "andrew@codingdojo.com"}
   ];
   res.render('cars', {users: users_array});
})





app.listen(8000, () => console.log("listening on port 8000"));
