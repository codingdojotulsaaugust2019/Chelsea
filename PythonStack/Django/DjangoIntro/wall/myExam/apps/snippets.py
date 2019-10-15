

#******************** basic validation *******************************
    #1 in VIEWS.PY
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
    
    #2 in MODELS.PY
    #The manager MUST go ABOVE the other models.
    #The other models need to include a feild "objects = ManagerName()" as part of their feilds.
    class ShowsManager(models.Manager):
    def not_empty_validator(self, postData):
        errors = {}
        #add KEY and VALUES to errors dictionary
        if len(postData["title"]) < 1:
            errors["title"] = "Don't forget the damn title."
            print(errors["title"])

        if len(postData['network']) < 1:
            errors["network"] = "Ummm network please? Don't forget!"

        if len(postData['description']) < 1:
            errors["description"] = "Don't be lazy. Enter a description."

        if postData['release_date']== '':
            errors["network"] = "date must be at least one character long."
        
        return errors


        #EMAIL validation

        import re	# the regex module

            class BlogManager(models.Manager):
                def basic_validator():    
                    errors = {}
                    EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
                    if not EMAIL_REGEX.match(request.form['email']):    # test whether a field matches the pattern            
                        errors['email'] = ("Invalid email address!")
                    return errors

    
    #3 in HTML file displaying the error messages - put the stuff about the messages at top of your form.
    <form action="/shows/create" method="POST">
        {% csrf_token %}
        {% if messages %}
        <ul class="messages">
            {% for message in messages %}
            <li {% if message.tags %} class="{{ message.tags }}" {%endif%}>{{ message }}</li>
            {% endfor %}
        </ul>
        {% endif %}
        .........rest of form
        </form>


    #*************************************** ROUTING with REGEX in URL ***********************************************

    #Remember to pass in the name of the variable into the VIEWS.PY file at the very top of your function def index(request, *val*):
    urlpatterns = [
        url(r'^bears$', views.one_method),                        # would only match localhost:8000/bears
        url(r'^bears/(?P<my_val>\d+)$', views.another_method),    # would match localhost:8000/bears/23
        url(r'^bears/(?P<name>\w+)/poke$', views.yet_another),    # would match localhost:8000/bears/pooh/poke
    	url(r'^(?P<id>[0-9]+)/(?P<color>\w+)$', views.one_more),  # would match localhost:8000/17/brown


]
#**************************************************** SESSION TIPS ***********************************************************

request.session['key']                      #retreives value
request.session['key'] = 'value'            #set the value that will be stored by the 'key' to value
'key' in request.session                    #returns boolean of whether a key is in session or not
{{ request.session.name }}                  #accesses the keys inside an html template


#******************************************** Routing via <a> tags **********************************************

    #<td><a href="/shows/{{show.id}}">Show</a> | <a href="/shows/{{show.id}}/edit">Edit</a> | <a href="/shows/{{show.id}}/destroy">Delete</a></td>



