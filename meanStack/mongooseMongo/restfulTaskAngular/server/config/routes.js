const Tasks = require('./../controllers/tasks');

module.exports = (app) => {
    app.get('/', Tasks.index);
    app.get('/:id', Tasks.show);
    app.post('/task', Tasks.create);
    app.put('/update/:id', Tasks.update);
    app.delete('/remove/:id', Tasks.remove);
}