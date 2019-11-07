const express = require("express");
	const app = express();

	app.use(express.static(__dirname + "/static"));

	app.set('view engine', 'ejs');
	app.set('views', __dirname + '/views');


	app.get("/cuddles1", (req, res) => {
    	// hard-coded user data
    	var cat_info =
      		{name: "Hitty Kitty", age: "1", food: "genetically superior tuna", toys: ["cups of water", "live mice", "world domination"]
		};
    	res.render('cat', {cat: cat_info});
	})

	app.get("/cuddles2", (req, res) => {
    	// hard-coded user data
    	var cat_info =
      		{name: "Tiger", age: "2", food:"cat grass", toys: ["slow gazelles", "turtles", "tumbleweeds"]
		};
    	res.render('cat', {cat: cat_info});
	})

	app.get("/cuddles3", (req, res) => {
    	// hard-coded user data
    	var cat_info =
      		{name: "Janet", age: "3", food:"Fozen tv dinners", toys: ["Tequila", "cigarettes", "red lipstick"]
		};
    	res.render('cat', {cat: cat_info});
	})

	app.listen(8000, () => console.log("listening on port 8000"));
