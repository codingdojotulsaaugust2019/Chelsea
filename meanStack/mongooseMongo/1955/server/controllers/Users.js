const mongoose = require('mongoose');
const User = mongoose.model('User');

module.exports = {
    index: (req, res) => {
        User.find()
            .then(allusers => {
                console.log("************ allusers = " + allusers);
                res.json({users: allusers});
            })
            .catch(err => {
                res.json({errors: err});
            })
        //res.send('message from index');
        //res.json({message: "Message from Index"});//putting it in a dictionary takes a non json format and puts it into a jsom format.
    },

    create: (req, res) => {
        const { name } = req.params;
        console.log(name);
        User.create({name: name})
            .then(newUser => {
                console.log("added user" + newUser)
            })
            .catch(err => res.json(err))
            .finally(()=> res.redirect('/'))//the finally is the last catch all that always runs regardless or if then or catch is triggered.
    },

    show: (req, res) => {
        const { name } = req.params;
        console.log(name);
        User.findOne({name: name })
            .then( user => {
                console.log("********* user =" + user);
                res.json(user);
            })
            .catch( err => res.json({error: err}))
    },

    remove: (req, res) => {
        const { name } = req.params;
        User.deleteOne({name: name})
            .then(action => console.log(action))
            .catch(err => res.json({error: err}))
            .finally(()=> res.redirect('/'))
    }
}
