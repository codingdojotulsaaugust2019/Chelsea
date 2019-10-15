from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^register$', views.register),
    url(r'^login$', views.login),
    url(r'^logged$', views.logged),
    url(r'^logout$', views.logout),
    url(r'^create$', views.create),
    url(r'^show/(?P<id>\d+)$', views.show),
    url(r'^edit/(?P<id>\d+)', views.edit),
    url(r'^info/(?P<id>\d+)', views.info),
    url(r'^delete/(?P<id>\d+)', views.delete),
    url(r'^edit_proccess/(?P<id>\d+)$', views.edit_proccess),
    url(r'^welcome/(?P<id>\d+)$', views.show),
]