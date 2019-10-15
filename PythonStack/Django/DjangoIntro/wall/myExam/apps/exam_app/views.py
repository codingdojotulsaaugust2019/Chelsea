from django.shortcuts import render, redirect, HttpResponse
from django.contrib import messages
from .models import User

import bcrypt


def index(request):
    return render(request, 'index.html')
    
def login(request):
    user = User.objects.filter(email=request.POST['email'])
    if user:
        logged_user = user[0]
        if bcrypt.checkpw(request.POST['password'].encode(), logged_user.password.encode()):
            print("******************* Got into password bcrypt verification inside login route *********************")
            request.session['user'] = logged_user.id
            return redirect('/welcome')
    return redirect('/')

def register(request):
    print("******** Got right inside views file register route ****")
    errors = User.objects.reg_validator(request.POST)
    print("******** Got past defining our errors dict in views at register ****")
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect('/', value)
    else:
        print("******** past our validation and on to begin creating our user ****")
        first_name = request.POST['first_name']
        last_name = request.POST['last_name']
        email = request.POST['email']
        hash1 = bcrypt.hashpw(request.POST['password'].encode(), bcrypt.gensalt())
        password = hash1
        newUser = User.objects.create(first_name=first_name, last_name=last_name, email=email, password=hash1)
        request.session['user'] = newUser.id
        return redirect('/welcome')

def logged_in(request):
    if 'user' in request.session:
        print("*************** User was validated by the logged_in if statement checking if in session**************")
        context = {
            'user_info': User.objects.get(id=request.session['user']),
        }
        return render(request, 'welcome.html', context)
    else:
        print("***************** User's session not found in session in logged_in route so access denied *****************")
        return redirect('/')

def logout(request):
    request.session.clear()
    return redirect('/')

def create_message(request):
    if method == 'POST':
        print("*************** Got to create_message in views*************")
        if 'user' in request.session:
            message = request.POST['message']
            return redirect('/welcome')
        else:
            return redirect('/login')
    else:
        return redirect('/welcome')
    pass

def create_comment(request):
    return redirect('/welcome')
    pass

def delete_comment(request):
    return redirect('/welcome')
    pass