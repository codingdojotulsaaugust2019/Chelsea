const mongoose = require('mongoose');
const Task = mongoose.model('Task');

module.exports = {
    index: (req, res) => {
        Task.find()
            .then(allTasks => {
                res.json({allTasks: allTasks})
            })
            .catch(err => console.log({error: err}));
    },

    create: (req, res) => {
        console.log("************************************************ go to the Express server Tasks.js Create method*****")
        console.log(req.body);
        Task.create(req.body)
        .then(newTask => res.json({status: true, task: newTask}))
        .catch(err => {
            const errors = [];
            for(var key in err.errors){
                errors.push(err.errors[key].message);
            }
            res.json({status: false, error: errors})
        }
    )},

    show: (req, res) => {
        const { id } = req.params;
        console.log("****** the id used to findOne is..." + id);
        Task.findOne({_id: id})
            .then(task => res.json({theTask: task}))
            .catch(err => res.json({error: err}))
    },

    update: (req, res) => {
        console.log("********************************** req.params = **********************************");
        //The param is undefined----why?
        console.log(req.params.id);
        Task.findOne({_id: req.params.id})
            .catch(err => {
                const errors = [];
                for(var key in err.errors){
                    errors.push(err.errors[key].message);
                }
                res.json({status: false, error: errors})
                })
            .then(task => {
                task.title = req.body.title;
                task.description = req.body.description;
                console.log("*********task is = " + task)
                task.save();
            })
                .then(saveResult => {
                    res.json({status: true, result: saveResult})
                })
                .catch(err => {
                    res.json({status: false, error: err})
                })
    },

    remove:(req, res) => {
        Task.deleteOne({_id: req.params.id})
            .then(() => res.json({status: true}))
            .catch(() => res.json({status: false}))
    },
}