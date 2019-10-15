from django.shortcuts import render, redirect
from django.utils.crypto import get_random_string

def index(request):
    return render(request, 'MyApp/index.html')


def count(request):

    if request.method == "GET": 
        return redirect("/")

    if request.method == "POST":

        request.session['word'] = get_random_string(length=14)

        if not 'counter' in request.session:
            request.session['counter'] = 1
        else:
            request.session['counter'] += 1

    return redirect("/")

def reset(request):
    request.session.clear()
    return redirect('/')

