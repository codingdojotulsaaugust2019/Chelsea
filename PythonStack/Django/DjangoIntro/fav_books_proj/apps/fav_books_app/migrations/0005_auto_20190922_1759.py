# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-09-22 17:59
from __future__ import unicode_literals

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('fav_books_app', '0004_auto_20190922_1754'),
    ]

    operations = [
        migrations.RenameField(
            model_name='books',
            old_name='uploadeder',
            new_name='uploader',
        ),
    ]