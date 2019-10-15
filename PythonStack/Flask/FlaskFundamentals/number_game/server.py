from flask import Flask, render_template, session, request, redirect
app = Flask(__name__)
app.secret_key="secrets"
import random


@app.route('/',)
def home():
    


    return render_template('index.html')

@app.route('/results', methods=['POST'])
def results():

    if request.method == 'POST':
        session['guess'] = int(request.form['guess'])
        print("Session[Guess] equals", session['guess'])

    if not 'computer' in session:
        session['computer'] = int(random.randint(1,100))

        print(session['computer'], "is the computer's number")

    else:
        print(session['computer'], "is the computer's number")

    if session['guess'] == session['computer']:
        session['result'] = (f"{session['computer']} was the number!")
        session['display'] = "block"
        return redirect('/')

    else:
        if session['guess'] > session['computer']:
            session['result'] = "too high!"
            return redirect('/')

        else:
            session['result'] = "too low!"
            return redirect('/')




@app.route('/clear_cookies', methods=['POST'])
def eatCookie():
    session['guess']
    session['computer']
    session.clear()
    return redirect('/')






if __name__=="__main__":
    app.run(debug=True)