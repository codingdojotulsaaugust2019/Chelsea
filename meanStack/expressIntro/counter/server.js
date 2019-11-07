const express = require("express");
	const app = express();

    
    app.set('view engine', 'ejs');
	app.set('views', __dirname + '/views');
    
    const session = require('express-session');
    app.use(session({
        secret: 'keyboardkitteh',
        resave: false,
        saveUninitialized: true,
        cookie: { maxAge: 60000 }
    }))
    
    app.get('/', (request, response) => {
        if(request.session.num){
            request.session.num += 1;
        }
        else{
            request.session.num = 1;
        }
       response.render('index',{sessionVariable: request.session.num});
    });


	app.listen(8000, () => console.log("listening on port 8000"));