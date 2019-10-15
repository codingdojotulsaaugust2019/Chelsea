from django.conf.urls import url, include
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^show/(?P<name>.*)$', views.show),
    url(r'^start_over$', views.start_over)
]
