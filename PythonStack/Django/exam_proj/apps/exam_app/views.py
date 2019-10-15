from django.shortcuts import render, redirect, HttpResponse
from django.contrib import messages
from .models import Users, Wishes
import bcrypt



def index(request):
    return render(request, 'index.html')

def register(request):
    errors = Users.objects.reg_validator(request.POST)
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
            "all_wishes": Wishes.objects.all(),
            "granted": Wishes.objects.exclude(granted="no"),
            "my_wishes": Users.objects.get(id=request.session['user']).wished.exclude(granted="yes"),
            "favs": Users.objects.get(id=request.session['user']).fav_wishes.all(),
            "message": "This wish is one of your favorites!"
        }
        return render(request, 'logged.html', context)
    else:
        print("***************** User's session not found in session in logged_in route so access denied *****************")
        return redirect('/')

def logout(request):
    request.session.clear()
    return redirect('/')

def create(request):
    if 'user' in request.session:
        context = {
            "user_info": Users.objects.get(id=request.session['user']),
        }
        return render(request, 'create.html', context)
    else:
        return redirect('/')

def create_proccess(request):
    errors = Wishes.objects.wish_validator(request.POST)
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect('/create', value)
    else:
        title = request.POST['title']
        desc = request.POST['description']
        wisher = Users.objects.get(id=request.session['user'])
        users_that_favd = Users.objects.get(id=request.session['user'])
        Wishes.objects.create(title=title, desc=desc, wisher=wisher, granted="no")
        newwish = Wishes.objects.last()
        wisher.fav_wishes.add(newwish)
        print("************* We have created the wish *****************")
    return redirect('/logged')

def delete(request, id):
    if 'user' in request.session:
        id=id
        Wishes.objects.get(id=id).delete()
        return redirect('/logged')
    else:
        return redirect('/')

def edit(request, id):
    if 'user' in request.session:
        context = {
                "wish": Wishes.objects.get(id=id),
                "favors": Wishes.objects.get(id=id).users_that_favd.all(),
                "user_info": Users.objects.get(id=request.session['user']),
                }
        return render(request, 'edit.html', context)
    else:
        return redirect('/')

def edit_proccess(request, id):
    if 'user' in request.session:
        id=id
        errors = Wishes.objects.wish_validator(request.POST)
        if len(errors) > 0: 
            for key,value in errors.items():
                messages.error(request, value)
            return redirect(f'/edit/{id}', value)
        this_wish = Wishes.objects.get(id=id)
        this_wish.desc = request.POST['description']
        this_wish.title = request.POST['title']
        this_wish.save()
        return redirect('/logged')
    else:
        return redirect('/')

def grant(request, id):
    if 'user' in request.session:
        id=id
        this_wish = Wishes.objects.get(id=id)
        this_wish.granted = "yes"
        this_wish.save()
        return redirect('/logged')
    else:
        return redirect('/')

def like(request, id):
    if 'user' in request.session:
        wishid=id
        userid=request.session['user']
        Wishes.objects.get(id=wishid).users_that_favd.add(Users.objects.get(id=userid))
        return redirect('/logged')
    else:
        return redirect('/')

def stats(request, id):
    if 'user' in request.session:
        context = {
            "user_info": Users.objects.get(id=request.session['user']),
            "all_wishes": Wishes.objects.all(),
            "my_wishes": Users.objects.get(id=request.session['user']).wished.exclude(granted="yes"),
            "granted": Wishes.objects.exclude(granted="no"),
            "my_granted": Users.objects.get(id=request.session['user']).wished.exclude(granted="no"),
            "favs": Users.objects.get(id=request.session['user']).fav_wishes.all(),
            "message": "This wish is one of your favorites!",
            "granted_count": len(Users.objects.get(id=request.session['user']).wished.exclude(granted="no")),
            "pending_count": len(Users.objects.get(id=request.session['user']).wished.exclude(granted="yes"))
        }
        return render(request, 'stats.html', context)
    else:
        print("***************** User's session not found in session in logged_in route so access denied *****************")
        return redirect('/')

