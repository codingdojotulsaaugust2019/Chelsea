from flask import Flask, render_template, request, redirect, session
app = Flask(__name__) 
app.secret_key = "quassword"
import random

@app.route('/')
def index():
    return render_template("index.html")

@app.route('/results', methods=['GET'])
def results():
    return render_template("results.html")

@app.route('/counter', methods=['POST'])
def count():
    if not 'game_count' in session:
        session['game_count'] = 0
        session['player_score'] = 0
        session['comp_score'] = 0

    choice = request.form['choice']

    challenger = ["rock", "paper", "scissors"]
    rps = {"rock":"scissors", "scissors":"paper", "paper":"rock"}

    computer = challenger[random.randint(0,len(challenger)-1)]

    if choice == computer:
        session['result'] = "Its a TIE!👔"


    elif rps[choice] == computer:
        session['player_score']+=1
        session['result'] = "WINNER WINNER CHICKEN DINNER🍗"

    else:
        session['result'] = "YOU LOSE. Commence: Robot Takeover.🤖"
        session['comp_score']+=1

    session['game_count']+=1

    return redirect ('/results')

if __name__=="__main__":
    app.run(debug=True)