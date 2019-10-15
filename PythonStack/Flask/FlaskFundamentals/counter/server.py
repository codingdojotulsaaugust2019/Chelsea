from flask import Flask, render_template, redirect, session, request
app = Flask(__name__)
app.secret_key = 'secrets'


@app.route('/')
def home():
    if 'visits' in session:
        session['visits'] = session.get('visits') + 1
    else:
        session['visits'] = 1
    total = session['visits']
    return render_template('index.html', total=total, visits=session['visits'])


@app.route('/eat-cookies')
def destroy():
    if 'visits' in session:
        session.pop('visits')
    else:
        print("No sessions to delete.")
    return redirect("localhost:5000/")


if __name__=="__main__":
    app.run(debug=True)