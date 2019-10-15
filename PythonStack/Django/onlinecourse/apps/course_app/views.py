from django.shortcuts import render

from django.shortcuts import render, redirect, HttpResponse
from django.contrib import messages
from .models import Users, Courses, Badges, Lessons
import bcrypt



def index(request):
    return render(request, 'course_app/index.html')

def register_form(request):
    return render(request, 'course_app/register.html')

def register(request):
    errors = Users.objects.reg_validator(request.POST)
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect('/register_form', value)
    else:
        first_name = request.POST['first_name']
        last_name = request.POST['last_name']
        email = request.POST['email']
        hash1 = bcrypt.hashpw(request.POST['password'].encode(), bcrypt.gensalt())
        password = hash1
        x = Users.objects.create(first_name=first_name, last_name=last_name, email=email, password=hash1)
        print("********USER Sucessfully Created**********")
        return redirect('/login_form')

def login_form(request):
    return render(request, 'course_app/login.html')

def login(request):
    errors = Users.objects.login_validator(request.POST)
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
            "current_courses": Users.objects.get(id=request.session['user']).current_courses.all(),
            "user_badges":Users.objects.get(id=request.session['user']).user_badges.all(),
            "all_courses": Courses.objects.all(),
        }
        return render(request, 'course_app/logged.html', context)
    else:
        print("***************** User's session not found in session in logged_in route so access denied *****************")
        return redirect('/')

def logout(request):
    request.session.clear()
    return redirect('/')

def create_course(request):
    if 'user' in request.session:
        context = {
            "user_info": Users.objects.get(id=request.session['user']),
            "current_courses": Users.objects.get(id=request.session['user']).current_courses.all(),
            "user_badges":Users.objects.get(id=request.session['user']).user_badges.all(),
            "all_courses": Courses.objects.all(),
        }
        return render(request, 'course_app/new_course.html', context)
    else:
        print("***************** User's session not found in session in logged_in route so access denied *****************")
        return redirect('/')

def create_course_process(request):
    title = request.POST['title']
    desc = request.POST['desc']
    duration = request.POST['duration']
    creator = Users.objects.get(id=request.POST['creator'])
    Courses.objects.create(title=title, desc=desc, duration=duration, creator=creator)
    return redirect('/logged')

def create_lesson_process(request):
    title = request.POST['title']
    desc = request.POST['desc']
    content = request.POST['content']
    chapter = request.POST['chapter']
    courseid = request.POST['coursey']
    course = Courses.objects.get(id=courseid)
    Lessons.objects.create(title=title, desc=desc, content=content, chapter=chapter, course=course)
    return redirect('/create_course')

def show(request, id):
    context = {
        "course": Courses.objects.get(id=id),
        "lessons": Courses.objects.get(id=id).lessons.all(),
        "user_info": Users.objects.get(id=request.session['user']),
    }
    return render(request, 'course_app/show_course.html', context)

def delete_course(request, id):
    if 'user' in request.session:
        id=id
        Courses.objects.get(id=id).delete()
        return redirect('/logged')
    else:
        return redirect('/')

def edit_course(request, id):
    context = {
        "course": Courses.objects.get(id=id),
        "user_info": Users.objects.get(id=request.session['user']),
    }
    return render(request, 'course_app/edit_course.html', context)

def update_course(request, id):
    if 'user' in request.session:
        context = {
            "course": Courses.objects.get(id=id),
        }
        title = request.POST['title']
        desc = request.POST['desc']
        duration = request.POST['duration']
        Courses.objects.update(title=title, desc=desc, duration=duration)
        return redirect('/logged')
    else:
        return redirect('/')
