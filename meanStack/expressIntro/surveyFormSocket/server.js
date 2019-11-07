const express = require("express");
const app = express();
const server = app.listen(5000);
const io = require('socket.io')(server);
var counter = 0;

app.use(express.urlencoded({extended: true}));


app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');


app.get('/', (request, response) => {
    response.render('index');

    io.on('connection', function (socket) { //2

            socket.emit('greeting', { msg: 'Greetings, from server Node, brought to you by Sockets! -Server' }); //3
            socket.on('thankyou', function (data) { //7
              console.log(data.msg); //8 (note: this log will be on your server's terminal)
            });
            counter += 0;          
      });

});





app.listen(8000, () => console.log("Listening on port 8000"));