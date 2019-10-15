from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^login$', views.login),
    url(r'^logout$', views.logout),
    url(r'^register$', views.register),
    url(r'^welcome$', views.logged_in),
    url(r'^message$', views.create_message),
    url(r'^comment$', views.create_comment),
    url(r'^delete$', views.delete_comment),
]