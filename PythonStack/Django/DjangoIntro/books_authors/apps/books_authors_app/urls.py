from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^authors$', views.authors),
    url(r'^add_book$', views.add_book),
    url(r'^add_author$', views.add_author),
    url(r'^auth_add_book$', views.auth_add_book),
    url(r'^about_authors$', views.authors_id),
    url(r'^authors/(?P<urlid>\d+)$', views.authors_id),
    url(r'^about_books$', views.books_id),
    url(r'^books/(?P<urlid>\d+)$', views.books_id),
    url(r'^book_add_auth$', views.book_add_auth),
]