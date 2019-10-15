from flask import Flask, render_template, redirect, request, session 
app = Flask(__name__)
app.secret_key = "secrets"

@app.route('/')
def home():
    return render_template('index.html')

@app.route('/users', methods=['POST'])
def create_user():
    session['sname'] = request.form['name']
    session['semail'] = request.form['email']
    session['slocation'] = request.form['location']
    session['slangauge'] = request.form['language']
    session['scomments'] = request.form['comments']
    return redirect('/show')

@app.route('/show')
def show():
    return render_template('show.html', name=session['sname'], email=session['semail'], location=session['slocation'], language=session['slangauge'], comments=session['scomments'])


if __name__=="__main__":
    app.run(debug=True)