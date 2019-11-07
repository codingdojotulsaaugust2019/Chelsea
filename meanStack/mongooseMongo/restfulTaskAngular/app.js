const express = require('express');
const app = express();

app.use(express.json());
app.use(express.static( __dirname + '/build/dist/build' ));

require('./server/config/mongoose');
require('./server/config/routes')(app);

app.listen(8000);