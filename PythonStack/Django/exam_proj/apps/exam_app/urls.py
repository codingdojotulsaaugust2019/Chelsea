from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^register$', views.register),
    url(r'^login$', views.login),
    url(r'^logged$', views.logged),
    url(r'^logout$', views.logout),
    url(r'^create$', views.create),
    url(r'^create_proccess$', views.create_proccess),
    url(r'^edit/(?P<id>\d+)', views.edit),
    url(r'^like/(?P<id>\d+)', views.like),
    url(r'^stats/(?P<id>\d+)', views.stats),
    url(r'^grant/(?P<id>\d+)', views.grant),
    url(r'^delete/(?P<id>\d+)', views.delete),
    url(r'^edit_proccess/(?P<id>\d+)$', views.edit_proccess),
]