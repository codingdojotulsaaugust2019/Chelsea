from django.shortcuts import render, redirect, HttpResponse
from django.contrib import messages
from .models import Users, Books
import bcrypt



def index(request):
    return render(request, 'index.html')

def register(request):
    errors = Users.objects.reg_validator(request.POST)
    print("*********** In Views.py, the errors dictionary returns type of..***********", type(errors))
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect('/', value)
    else:
        first_name = request.POST['first_name']
        last_name = request.POST['last_name']
        email = request.POST['email']
        hash1 = bcrypt.hashpw(request.POST['password'].encode(), bcrypt.gensalt())
        password = hash1
        x = Users.objects.create(first_name=first_name, last_name=last_name, email=email, password=hash1)
        print("********USER Sucessfully Created**********")
        return redirect('/')

def login(request):
    errors = Users.objects.login_validator(request.POST)
    print("*********** In Views.py, at least you got this far..***********", type(errors))
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect('/', value)
    else:
        user = Users.objects.get(email=request.POST['email'])
        request.session['user'] = user.id
        return redirect('/logged')
    

def logged(request):
    if 'user' in request.session:
        context = {
            "user_info": Users.objects.get(id=request.session['user']),
            "all_books": Books.objects.all(),
            "favs": Users.objects.get(id=request.session['user']).fav_books.all(),
            "message": "This book is one of your favorites!"
        }
        return render(request, 'logged.html', context)
    else:
        print("***************** User's session not found in session in logged_in route so access denied *****************")
        return redirect('/')

def logout(request):
    request.session.clear()
    return redirect('/')

def create(request):
    errors = Books.objects.book_validator(request.POST)
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect('/logged', value)
    else:
        title = request.POST['title']
        desc = request.POST['desc']
        uploader = Users.objects.get(id=request.session['user'])
        users_that_favd = Users.objects.get(id=request.session['user'])
        Books.objects.create(title=title, desc=desc, uploader=uploader)
        newbook = Books.objects.last()
        uploader.fav_books.add(newbook)
        print("************* We have created the book *****************")
    return redirect('/logged')

def show(request, id):
    if 'user' in request.session and request.session['user'] == Books.objects.get(id=id).uploader.id:
        id=id
        return redirect(f'/edit/{id}')
    else:
        id=id
        return redirect(f'/info/{id}')

def edit(request, id):
    context = {
            "book": Books.objects.get(id=id),
            "favors": Books.objects.get(id=id).users_that_favd.all(),
            }
    return render(request, 'edit.html', context)

def edit_proccess(request, id):
    this_book = Books.objects.get(id=id)
    this_book.desc = request.POST['desc']
    this_book.title = request.POST['title']
    this_book.save()
    return redirect(f'/info/{id}')

def info(request, id):
    context = {
        "book": Books.objects.get(id=id),
        "favors": Books.objects.get(id=id).users_that_favd.all(),
        }
    return render(request, 'info.html', context)

def delete(request, id):
    if request.POST:
        id=id
        Books.objects.get(id=id).delete()
    return redirect('/logged')

