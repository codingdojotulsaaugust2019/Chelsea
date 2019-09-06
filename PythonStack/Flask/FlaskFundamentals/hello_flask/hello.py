from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def hello_world():
    return render_template('index.html', phrase = "Welcome to your Profile", times=5)

@app.route('/<name>')
def personalize(name):
    return render_template("index2.html", namevar=name)

if __name__=="__main__":
    app.run(debug=True)