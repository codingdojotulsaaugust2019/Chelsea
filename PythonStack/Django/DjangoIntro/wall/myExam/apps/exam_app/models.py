from django.db import models
import re

class UserManager(models.Manager):
    def reg_validator(self, postData):
        errors = {}
        if len(postData['first_name']) < 1:
            errors['first_name'] = "What's your first name, pal?"
        if len(postData['last_name']) < 1:
            errors['last_name'] = "What's your last name, pal?"
        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Your email address sucks. I will not accept it."
        if len(User.objects.filter(email=postData['email'])) != 0:
            errors['uniqueuserid'] = "Someone is already registered under this username/email. LOL."
        if postData['password'] != postData['conf_pass']:
            errors['conf_pass'] = "Hey, there Typo Queen. Re-confirm your password."
        if len(postData['password']) < 8:
            errors['password_length'] = "Password must be 8 chacarters, babe. Else, you're practically asking for your info to be stolen."
        return errors

    def login_validator(self, postData):
        if User.objects.filter(email!=request.POST['email']):
            errors['email']: "I literally cannot find that email address in here anywhere. Are you sure you registered?"
            return errors
        user = User.objects.filter(email=request.POST['email'])
        if bcrypt.checkpw(request.POST['password'].encode(), user.pw_hash.encode()):
            print("Password match")#Finish this
        else:
            errors['password'] = "This password is funky. Doesn't match. Access denied."

#Currently at a NOT NULL constraint failed error and am stuck. starting fresh new assignment

class Comment(models.Model):
    cbody = models.TextField
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

class Message(models.Model):
    mbody = models.TextField
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

class User(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    email = models.CharField(max_length=255)
    password = models.CharField(max_length=255)
    pass_conf = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    comments = models.ForeignKey(Comment, related_name="commentor")
    messages = models.ForeignKey(Message, related_name="messenger")
    objects = UserManager()







#class SomethingManager(models.Manager):

   # def not_empty_validator(self, postData):
        #errors = {}

        #if len(postData['name']) < 1:
        #    errors['name'] = "Don't forget to fill me in!"
       # if postData['release_date'] == '':
        #    errors['release_date'] = "Must enter a date!"
        
        #return errors

#class Things(models.Model):
    #Something = models.CharField(max_length=255)
    #description = models.TextField()
    #release_date = models.DateTimeField()
    #objects = SomethingManager()