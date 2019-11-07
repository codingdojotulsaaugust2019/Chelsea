const express = require("express");
const app = express();
const server = app.listen(8000);

const io = require('socket.io')(server);

var counter = 0;

app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');

app.get('/', (request, response) => {
    response.render("index");

io.on('connection', function (socket) {
  
    socket.emit('count', counter);

    socket.on('add', function () {
      counter++;

    socket.on('reset', function () {
        counter = 0;
    });
  });
});
});