from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def hello_world():
    return render_template('index.html', phrase = "Welcome to your Profile", times=5)

@app.route('/<name>')
def personalize(name):
    return render_template("index2.html", namevar=name)

@app.route('/lists')
def render_lists():
    student_info = [
        {'name': 'Michael', 'age': 35},
        {'name': 'John', 'age': 30},
        {'name': 'Mark', 'age': 25},
        {'name': 'KB', 'age': 27}
    ]
    return render_template("lists.html", random_numbers = [3,1,5], students = student_info)

@app.route('/users')
    users = [
        {'first_name': 'Michael', 'last_name': 'choi'},
        {'first_name': 'John', 'last_name': 'Suppy'},
        {'first_name': 'Mark', 'last_name': 'Gilly'},
        {'first_name': 'KB', 'last_name': 'Tony'},
    ]


if __name__=="__main__":
    app.run(debug=True)