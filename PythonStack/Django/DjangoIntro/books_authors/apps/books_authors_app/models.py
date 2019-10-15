from django.db import models


class Authors(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    notes = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    # written_books = List of books written by author.
    #def __repr__(self):

        #return f"<Authors Object: {self.id},{self.first_name} {self.last_name}>"

class Books(models.Model):
    title = models.CharField(max_length=255)
    desc = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    author = models.ManyToManyField(Authors, related_name="written_books")

    #def __repr__(self):
        #return f"<Books Object: {self.title}>"
