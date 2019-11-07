const mongoose = require('mongoose');
const Task = mongoose.model('Task');

module.exports = {
    index: (req, res) => {
        Task.find()
            .then(allTasks => {
                console.log("********** allTasks = " + allTasks);
                res.json({allTasks: allTasks})
            })
            .catch(err => console.log({error: err}));
    },

    create: (req, res) => {
        Task.create(req.body)
        .then(newTask => res.json({status: true, task: newTask}))
        .catch(err => res.json({status: false, error: err}))
    },

    show: (req, res) => {
        const { id } = req.params;
        Task.findOne({_id: id})
            .then(task => res.json({task: task}))
            .catch(err => res.json({error: err}))
    },

    update: (req, res) => {
        console.log("********** req.params.id = " + req.params.id);
        Task.findOne({_id: req.params.id})
            .catch(err => res.json({status: false, error: err}))
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