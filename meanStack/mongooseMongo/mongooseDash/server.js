/////////////////// const ////////////////////////

const express = require("express");
const app = express();
const session = require('express-session');
const flash = require('express-flash');
const mongoose = require('mongoose');

/////////////////// app config ////////////////////////

app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');
app.use(express.urlencoded({extended: true}));
app.use(express.static(__dirname + "/static"));
app.use(session({
  	secret: 'keyboardkitteh',
 	resave: false,
  	saveUninitialized: true,
  	cookie: { maxAge: 60000 }
	}))
app.use(flash());
app.listen(8000, () => console.log("listening on port 8000"));

/////////////////// db/mongo/models config ////////////////////////

mongoose.connect('mongodb://localhost/mongoosedash', {useNewUrlParser: true});

const TarsierSchema =  new mongoose.Schema({
    name: {type: String, required: [ true, 'Please enter a name.']},
    species: {type: String, required: [ true, "Don't forget the specie"]},
    age: {type: Number, required: [ true, 'Remember to add age!']},
    gender: {type: String, required: [ true, 'Gender please...?']},
})

const Tarsier = mongoose.model('Tarsier', TarsierSchema);

//////////////////////////////////////////////////////////////////////////
//  GET Routes

app.get('/', (req, res) => {
    console.log("*********")
    Tarsier.find()
        .then(tarsiers => {
            console.log(tarsiers);
            res.render('index', {tarsiers: tarsiers});
        })
        .catch(err => {
            res.json(err);
        })
})

app.get('/tarsiers/new', (req, res) => {
    res.render('new');
})

app.get('/tarsiers/:id', (req, res) => {
    console.log(req.params.id);
    Tarsier.findById(req.params.id)
    .then(tarsier => {
        console.log(tarsier);
        res.render('tarsier', {tarsier: tarsier});
    })
    .catch(err => res.json(err));
})

app.get('/tarsiers/edit/:id', (req, res) => {
    Tarsier.findById(req.params.id)
    .then(tarsier => {
        console.log(tarsier);
        res.render('edit', {tarsier: tarsier});
    })
    .catch(err => res.json(err));
})

///////////////////////////////////////////////////////
//   POST Routes

//new tarsier processing
app.post('/tarsiers', (req, res) => {
    const tars = req.body;
    Tarsier.create(tars)
        .then(newTars => {
            console.log(newTars);
            res.redirect('/');
        })
        .catch(err => {
            res.json(err)
        });
    })

//edit tarsier processing
app.post('/tarsiers/:id', (req, res) => {
    console.log("*************** Got to edit processing route ********************")
    Tarsier.updateOne({_id: req.params.id}, { $set: {
        name: req.body.name,
        age: req.body.age,
        species: req.body.species,
        gender: req.body.gender
        }})
        .then(result => {
            console.log(result)
            res.redirect(`/tarsiers/${req.params.id}`);
        })
        .catch(err => res.json(err))
    }
)

//delete tarsier processing
app.get('/tarsiers/destroy/:id', (req, res) => {
    Tarsier.remove({_id: req.params.id})
    .then(tarsier => {
        console.log("Deleted!");
        res.redirect('/');
    })
    .catch(err => res.json(err));
})