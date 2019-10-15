from django.shortcuts import render, redirect, HttpResponse
from django.contrib import messages

from .models import Shows


def index(request):
    return redirect('/shows')

def shows_new(request):
    return render(request, 'create.html')


def shows_create(request):
    errors = Shows.objects.not_empty_validator(request.POST)
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect('/shows/new', value)
    else:
        title = request.POST['title']
        network = request.POST['network']
        release_date = request.POST['release_date']
        description = request.POST['description']
        x = Shows.objects.create(title=title, network=network, release_date=release_date, description=description)
        return redirect(f'/shows/{x.id}')
    

def shows_id(request, id):
    context = {
        'show': Shows.objects.get(id=id)
    }

    return render(request, ('display_show.html'), context)

def shows(request):
    context = {
        'shows': Shows.objects.all(),
    }
    return render(request, 'shows.html', context)


def shows_id_edits(request, id):
    show_id = id
    context = {
        "show": Shows.objects.get(id=id),
    }
    return render(request, ('edit.html'), context)
    

def shows_id_updates(request, id):
    errors = Shows.objects.not_empty_validator(request.POST)
    if len(errors) > 0: 
        for key,value in errors.items():
            messages.error(request, value)
        return redirect(f'/shows/{id}/edit', value)
    else:
        show_id = id
        show = Shows.objects.get(id=show_id)
        show.title = request.POST['title']
        show.description = request.POST['description']
        #show.release_date = request.POST['release_date']
        show.network = request.POST['network']
        show.save()
        return redirect(f'/shows/{id}')


def shows_id_destroy(request, id):
    show_id = id
    Shows.objects.get(id=id).delete()
    return redirect('/shows')
    

