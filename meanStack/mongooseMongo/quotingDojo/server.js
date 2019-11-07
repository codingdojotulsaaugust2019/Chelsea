const express = require("express");
const app = express();
const flash = require('express-flash');
const mongoose = require('mongoose');

const session = require('express-session');

//*************** app requirements **************/

app.use(session({
  secret: 'keyboardkitteh',
  resave: false,
  saveUninitialized: true,
  cookie: { maxAge: 60000 }
}))

app.use(flash());
    
app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');

app.use(express.urlencoded({extended: true}));

app.use(express.static(__dirname + "/static"));


//*************** configuring Mongoose and Schema **************/

mongoose.connect('mongodb://localhost/quotingdojo', {useNewUrlParser: true});

const QuoteSchema = new mongoose.Schema({
    name: {type: String, required: [true, 'Name is required, sorry pal, no anonymous submissions.' ]},
    quote: {type: String, required: [true, "Really? You come here to my site and try to submit nothing as your quote? C'mon..."]}
    })

const Quote = mongoose.model('Quote', QuoteSchema);

//****************************************************************/

app.get('/', (req, res) => {
    Quote.find()
    .then(data => res.render("index", {quotes: data}))
    .catch(err => res.json(err));
    });

app.post('/quotes', (req, res) => {
    const quote = new Quote();
    console.log(req.body);
    quote.name = req.body.name;
    quote.quote = req.body.quote;
    quote.save()
      .then(newQuoteData => {
      console.log('quote created: ', newQuoteData);
      res.redirect('/');
      })
      .catch(err => {
        console.log(err);
        console.log("***** We have an error! *****", err);
        for (var key in err.errors) {
          req.flash('quote', err.errors[key].message);
        }
        res.redirect('/');
      })
  })

app.get('/quotes', (req, res) => {
  Quote.find()
    .then(data => res.render("quotes", {quotes: data}))
    .catch(err => res.json(err));
})



app.listen(8000, () => console.log("listening on port 8000"));
