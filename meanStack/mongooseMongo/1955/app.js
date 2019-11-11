const express = require('express');
//const path = require('path'); dont need this
const app = express();

app.use(express.json());//this is in place or the urlencoded

require('./server/config/mongoose');//this has to load first compared to one below in order for routing to work
require('./server/config/routes')(app);

app.listen(8888, ()=>console.log('listening on port 8888'));


