from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def eight():
    return render_template("checkerboard.html",rows=8,columns=8)

@app.route('/4')
def four():
    return render_template("checkerboard.html", rows=4, columns=8)

@app.route('/<rows>/<columns>')
def flowers(rows,columns):
    return render_template("checkerboard.html", rows=int(rows), columns=int(columns))


if __name__== "__main__":
    app.run(debug=True)