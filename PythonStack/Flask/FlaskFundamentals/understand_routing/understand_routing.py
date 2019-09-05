from flask import Flask
app = Flask(__name__)

@app.route('/')
def greeting():
    return "Hello World!"

@app.route('/dojo')
def dojo():
    return "Dojo!!!!"

@app.route('/<name>')
def person(name):
    return f"Hi {name}!"

@app.route('/repeat/<times>/<phrase>')
def repeat(times,phrase):
    return (phrase * int(times))

if __name__=="__main__":
    app.run(debug=True)