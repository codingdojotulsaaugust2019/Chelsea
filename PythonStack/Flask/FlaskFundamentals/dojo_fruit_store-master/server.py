from flask import Flask, render_template, request, redirect
app = Flask(__name__)  
import datetime

@app.route('/')         
def index():
    return render_template("index.html")


@app.route('/checkout', methods=['POST'])         
def checkout():
    print(request.form)
    strawberries_from_form = request.form['strawberry']
    raspberries_from_form = request.form['raspberry']
    apples_from_form = request.form['apple']
    total = int(apples_from_form) + int(strawberries_from_form) + int(raspberries_from_form)
    f_name = request.form['first_name']
    l_name = request.form['last_name']
    student_id = request.form['student_id']
    print("charging", str(f_name), "for", str(total), "fruits")
    return render_template("checkout.html", strawberries=strawberries_from_form, raspberries=raspberries_from_form, apples=apples_from_form, first_name=f_name, last_name=l_name, student_id=student_id, total=total)

@app.route('/fruits')         
def fruits():
    return render_template("fruits.html")

if __name__=="__main__":   
    app.run(debug=True)    