from django.conf.urls import url
from . import views


urlpatterns = [
    url(r'^$', views.index),
    url(r'^register$', views.register),
    url(r'^register_form$', views.register_form),
    url(r'^login$', views.login),
    url(r'^logout$', views.logout),
    url(r'^logged$', views.logged),
    url(r'^create_course$', views.create_course),
    url(r'^update_course/(?P<id>\d+)$', views.update_course),
    url(r'^create_course_process$', views.create_course_process),
    url(r'^create_lesson_process$', views.create_lesson_process),
    url(r'^login_form$', views.login_form),
    url(r'^show/(?P<id>\d+)$', views.show),
    url(r'^(?P<id>\d+)/edit_course$', views.edit_course),
    url(r'^(?P<id>\d+)/delete_course$', views.delete_course),
]