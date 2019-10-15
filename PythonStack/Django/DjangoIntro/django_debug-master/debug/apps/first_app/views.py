from django.shortcuts import render, redirect

# Create your views here.

def index(request):
    if 'count' not in request.session:
        request.session['count'] = 0
    return render(request, 'first_app/index.html')

def show(request, name):
    request.session['count'] += 1
    context = {
        'name': name,
    }
    return render(request, 'first_app/show.html', context)

def start_over(request):
    request.session.clear()
    return redirect('/')