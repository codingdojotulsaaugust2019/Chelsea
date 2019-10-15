from __future__ import unicode_literals
from django.db import models

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
        if postData['password'] != postData['conf_password']:
            errors['conf_password'] = "Hey, there Typo Queen. Re-confirm your password."
        if len(postData['password']) < 8:
            errors['password_length'] = "Password must be 8 chacarters, babe. Else, you're practically asking for your info to be stolen."
        return errors

    def login_validator(self, postData):
        errors = {}
        if len(postData['email']) < 1:
            errors['email'] = "What's your email, pal?"
        if len(postData['password']) < 7:
            errors['password'] = "What's your password, pal?"
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

class CoursesManager(models.Manager):
    def course_validator(self, postData):
        errors = {}
        if len(postData['title']) < 3:
            errors['title'] = "Title must be greater than 3 characters."
        if len(postData['description']) < 3:
            errors['desc'] = "Description must be greater than 3 characters."
        if postData['duration'] > 0:
            errors['duration'] = "Course must have a duration of at least 1 hour."
        return errors

class BadgesManager(models.Manager):
    def badge_validator(self, postData):
        errors = {}
        if len(postData['title']) < 3:
            errors['title'] = "Name your badge."
        if len(postData['desc']) < 3:
            errors['desc'] = "Describe your badge."
        return errors

class Users(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    email = models.CharField(max_length=255)
    password = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = UsersManager()

class Courses(models.Model):
    title = models.CharField(max_length=255)
    desc = models.TextField()
    duration = models.PositiveSmallIntegerField()
    creator = models.ForeignKey(Users, related_name="created")
    current_students = models.ManyToManyField(Users, related_name="current_courses")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = CoursesManager()

class Lessons(models.Model):
    title = models.CharField(max_length=255)
    desc = models.TextField()
    content = models.TextField()
    chapter = models.PositiveSmallIntegerField()
    course = models.ForeignKey(Courses, related_name="lessons")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)


class Badges(models.Model):
    title = models.CharField(max_length=255)
    desc = models.TextField()
    course = models.OneToOneField(Courses, related_name="course_badge")
    owners = models.ManyToManyField(Users, related_name="user_badges")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
