# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-09-21 20:47
from __future__ import unicode_literals

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('fav_books_app', '0002_auto_20190921_1857'),
    ]

    operations = [
        migrations.AddField(
            model_name='users',
            name='uploaded_books',
            field=models.ForeignKey(default=1, on_delete=django.db.models.deletion.CASCADE, related_name='uploader', to='fav_books_app.Books'),
            preserve_default=False,
        ),
    ]
