# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-09-12 23:36
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('dojos_ninja_app', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='dojos',
            name='desc',
            field=models.CharField(default='Dojo that teaches coding', max_length=255),
            preserve_default=False,
        ),
    ]
