const express = require("express");
const app = express();
const session = require('express-session');
const flash = require('express-flash');
const mongoose = require('mongoose');

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

//************************ Schema **************************/

mongoose.connect('mongodb://localhost/msgboard', {useNewUrlParser: true});

const CommentSchema =  new mongoose.Schema({
    content: {type: String, required: [ true, 'Please enter a comment or go home.']},
    poster: {type: String, required: [ true, 'Add the user who posted to the object']},
    post: {type: String, required: [ true, 'Need to add Post id to comment.']}
    }, {timestamps: true}
)
const PostSchema =  new mongoose.Schema({
    content: {type: String, required: [ true, 'Please enter a content.']},
    poster: {type: String, required: [ true, 'Add the user who posted']},
    comments: [CommentSchema]
    }, {timestamps: true}
)


const Post = mongoose.model('Post', PostSchema);

const Comment = mongoose.model('Comment', CommentSchema);

//******************************************************************************/

app.get('/', (req, res) => {
    Post.find()
        .then(posts => {
            res.render('index', {allposts: posts});
        })
        .catch(err => res.json(err));
})

app.post('/post', (req, res) => {
    const post = req.body;
    console.log("************ post = " + post);
    Post.create(post)
        .then(newPost => {
            console.log("************ newPost = " + newPost);
            res.redirect('/');
        })
        .catch(err => res.json(err));
})

app.post('/comment', (req, res) => {
    const comment = req.body;
    console.log("************ comment = " + comment);

    Comment.create(req.body, function(err, data){
        if(err){
            console.log("stuck in the error of comment.create and error is = " + err);
        }
        else {
             Post.findOneAndUpdate({_id: data.post}, {$push: {comments: data}}, function(err, data){
                  if(err){
                    console.log("stuck in the error of Post.findOneAndUpdate and error is = " + err);
                    res.json(err);
                  }
                  else {
                       console.log("******* we are in the area where we should have successfully pushed the comment to the post *****");
                       res.redirect('/');
                  }
             })
         }
   })
})