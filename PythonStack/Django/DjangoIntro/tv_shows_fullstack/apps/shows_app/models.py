from django.db import models

class ShowsManager(models.Manager):
    def not_empty_validator(self, postData):
        errors = {}
        #add KEY and VALUES to errors dictionary
        if len(postData["title"]) < 1:
            errors["title"] = "Don't forget the damn title."
            print(errors["title"])

        if len(postData['network']) < 1:
            errors["network"] = "Ummm network please? Don't forget!"

        if len(postData['description']) < 1:
            errors["description"] = "Don't be lazy. Enter a description."

        if postData['release_date']== '':
            errors["network"] = "date must be at least one character long."
        
        return errors

class Shows(models.Model):
    title = models.CharField(max_length=255)
    network = models.CharField(max_length=255)
    description = models.TextField()
    release_date = models.DateTimeField()
    objects = ShowsManager()