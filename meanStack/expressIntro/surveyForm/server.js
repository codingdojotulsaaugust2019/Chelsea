const express = require("express");
const app = express();


app.use(express.urlencoded({extended: true}));


app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');

app.get('/', (request, response) => {
    response.render('index');
});

app.post("/results", (request, response) => {
    console.log(request.body);
    const data = {
        name: request.body.name,
        language: request.body.language,
        location: request.body.location,
        comment: request.body.comment,
    };
    response.render('results', {formdata: data});
})

app.listen(8000, () => console.log("Listening on port 8000"));