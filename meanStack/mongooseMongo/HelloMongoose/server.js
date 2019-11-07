const express = require("express");
const app = express();

//*************** app requirements **************/
    
app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');

app.use(express.urlencoded({extended: true}));

app.use(express.static(__dirname + "/static"));

const mongoose = require('mongoose');

//*************** configuring Mongoose and Schemas **************/

mongoose.connect('mongodb://localhost/welcome', {useNewUrlParser: true});

const UserSchema = new mongoose.Schema({
    name: String,
    age: Number
    })

const User = mongoose.model('User', UserSchema);

//****************************************************************/

app.get('/', (req, res) => {
    User.find()
    .then(data => res.render("index", {users: data}))
    .catch(data => res.json(err));
    });

app.post('/users', (req, res) => {
    const user = new User();
    console.log(req.body);
    user.name = req.body.name;
    user.age = req.body.age;
    user.save()
      .then(newUserData => console.log('user created: ', newUserData))
      .catch(err => console.log(err));
     
    res.redirect('/');
  })
  



app.listen(8000, () => console.log("listening on port 8000"));
