from __future__ import unicode_literals
from django.db import models
import re, bcrypt


class UsersManager(models.Manager):
    def reg_validator(self, postData):
        errors = {}
        if len(postData['first_name']) < 1:
            errors['first_name'] = "What's your first name, pal?"
        if len(postData['last_name']) < 1:
            errors['last_name'] = "What's your last name, pal?"
        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Your email address sucks. I will not accept it."
        if len(Users.objects.filter(email=postData['email'])) != 0:
            errors['unique_login_required'] = "Someone is already registered under this username/email. LOL."
        if postData['password'] != postData['conf_pass']:
            errors['conf_pass'] = "Hey, there Typo Queen. Re-confirm your password."
        if len(postData['password']) < 8:
            errors['password_length'] = "Password must be 8 chacarters, babe. Else, you're practically asking for your info to be stolen."
        return errors

    def login_validator(self, postData):
        errors = {}
        if not Users.objects.filter(email=postData['email']):
            errors['email']: "I literally cannot find that email address in here anywhere. Are you sure you registered?"
            return errors
        user = Users.objects.filter(email=postData['email'])
        print("*************This is my variable 'user' in my login validator in models!!...*******", user)
        if user:
            user = user[0]
            if not bcrypt.checkpw(postData['password'].encode(), user.password.encode()):
                errors['password'] = "This password is funky. Doesn't match. Access denied."
        return errors

class BooksManager(models.Manager):
    def book_validator(self, postData):
        errors = {}
        if len(postData['title']) < 1:
            errors['title'] = "Don't forget the title!"
        if len(postData['desc']) < 5:
            errors['desc'] = "C'mon, all I'm asking for is 5 freakin' characters..."
        return errors


class Users(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    email = models.CharField(max_length=255)
    password = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = UsersManager()

class Books(models.Model):
    title = models.CharField(max_length=255)
    desc = models.TextField()
    uploader = models.ForeignKey(Users, related_name="uploaded")
    users_that_favd = models.ManyToManyField(Users, related_name="fav_books") 
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = BooksManager()