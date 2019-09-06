from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def home():
    return "Well, Hello There."

@app.route('/play')
def play():
    return render_template('playground.html') * 2

@app.route('/play/<times>')
def playnum(times):
    return render_template('playground.html', times=times) * int(times)

@app.route('/play/<times>/<color>')
def playnumcol(times,color):
    return render_template('playground.html', times=times, color=color) * int(times)

if __name__=="__main__":
    app.run(debug=True)