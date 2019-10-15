from django.shortcuts import render, HttpResponse, redirect
from .models import Books, Authors

def index(request):
    #This displays the books in a table and an add book form
    context ={
        'book_list': Books.objects.all(),
    }
    return render(request, 'books_authors_app/index.html', context)

def add_book(request):
    #This proccesses the add book form above and redirects back to index route.
    if request.method == "GET":
        print("Get request is being made to this route")
    if request.method == "POST":
        bktitle = request.POST['title']
        bkdescription = request.POST['description']
        Books.objects.create(title=bktitle, desc=bkdescription)
    return redirect('/')

def books_id(request, urlid):
    context ={
        'my_book': Books.objects.get(id=urlid),
        'all_authors': Authors.objects.all(),
        'book_authors': Books.objects.get(id=urlid).author.all()
            }
    request.session['bk_id'] = Books.objects.get(id=urlid).id
    print(type(urlid))
    #this displays info on the specific book selected in the book table 
    return render(request, 'books_authors_app/about_books.html', context)
    

def book_add_auth(request):
    if request.method == "POST":
        auth_id = request.POST['selected_auth_id']
        book_id = request.session['bk_id']
        Books.objects.get(id=book_id).author.add(Authors.objects.get(id=auth_id))
        return redirect(f'/books/{book_id}')
        
    #this processes the option to add an author to a book's authors list and redirects back to book_id route
    #redirects to /about_books
    


def authors(request):
    context = {
        'author_list': Authors.objects.all(),
    }
    return render(request, 'books_authors_app/authors.html', context)


def add_author(request):
    if request.method == "GET":
        print("Get request is being made to this route.")
    if request.method == "POST":
        fname = request.POST['f_name']
        lname = request.POST['l_name']
        note = request.POST['notes']
        Authors.objects.create(first_name=fname, last_name=lname, notes=note)
    return redirect('/authors')

def authors_id(request, urlid):
    if request.method == "GET":
        context = {
        "url_author": Authors.objects.get(id=urlid),
        "auth_wb": Authors.objects.get(id=urlid).written_books.all(),
        "books_not_written": Books.objects.all(),
        "url_id": urlid,
        }
        request.session['auth'] = Authors.objects.get(id=urlid).id
        return render(request, 'books_authors_app/about_authors.html', context )
    if request.method == "POST":
       return print("A get request is being made from the authors_id route")

def auth_add_book(request):
    if request.method == "GET":
        print("a GET request is being made to the auth_add_book route.")
    if request.method == "POST":
        book_id = request.POST['selected_book']
        auth_id = request.session['auth']
        print("The request.session['auth'] variable equals", request.POST['selected_book'])
        Authors.objects.get(id=auth_id).written_books.add(Books.objects.get(id=book_id))
        return redirect(f'/authors/{auth_id}')