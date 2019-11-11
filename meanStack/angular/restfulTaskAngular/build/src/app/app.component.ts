import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['../../node_modules/bootstrap/dist/css/bootstrap.min.css']
})

export class AppComponent implements OnInit {
  tasks = [];
  theTask;

  constructor(private _httpService: HttpService){}

  ngOnInit(){
    this.getTasksfromService();
    this.getAtaskFromService();
  }

  getTasksfromService(){
    let observable = this._httpService.getTasks();
    observable.subscribe(data => {
      console.log(data["allTasks"]);
      this.tasks = data["allTasks"];
    })
  }

  getAtaskFromService(){
    let observable = this._httpService.getTask("5dc4bb42d6019c03ada55a1e");
    observable.subscribe(data => {
      console.log(data["theTask"]);
      this.theTask = data["theTask"];
    })
  }
}
