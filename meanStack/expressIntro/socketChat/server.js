const app = require('express')();
const server = require('https').Server(app);
const io = require('socket.io')(server);
const port = 3000;


server.listen(port, ()=> {
    console.log(`server is running on port ${port}`);
});

app.get('/', (req, res) => {
    res.sendFile(__dirname + '/public/index.html');
});

io.on('connection', (socket) => {
    console.log('user connected');
    socket.emit('message', { Sally: 'Hello, How are ya?'});
    socket.on ('another event', (data) => {
        console.log(data);
    })
})


//{'key': $('#SELECT MY INPUT ID').val()}  This uses jquery to create a dictionary by using jquery selector to grab form input id and grab the value inputted.