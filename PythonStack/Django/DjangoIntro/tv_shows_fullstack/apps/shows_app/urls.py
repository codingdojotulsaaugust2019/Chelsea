from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^shows$', views.shows),
    url(r'^shows/new$', views.shows_new),
    url(r'^shows/create$', views.shows_create),
    url(r'^shows/(?P<id>\d+)$', views.shows_id),
    url(r'^shows/(?P<id>\d+)/edit$', views.shows_id_edits),
    url(r'^shows/(?P<id>\d+)/update$', views.shows_id_updates),
    url(r'^shows/(?P<id>\d+)/destroy$', views.shows_id_destroy),
]