const Users = require('./../controllers/Users');

module.exports = (app) => {
  app.get('/', Users.index);
  app.get('/new/:name', Users.create);
  app.get('/:name', Users.show);
  app.get('/remove/:name', Users.remove);
}
