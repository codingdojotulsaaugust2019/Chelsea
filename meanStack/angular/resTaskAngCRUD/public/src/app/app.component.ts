import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'public';
  tasks = [];
  theTask;
  ShowTaskDetail = [];
  newTask: any;
  editTask: any
  editstat: boolean = false;

  constructor(private _httpService: HttpService){}

  ngOnInit(){
    this.newTask = {title: "", description: ""}
    this.editTask = {title: "", description: "", _id: String}
  }

  getTasksfromService(){
    let observable = this._httpService.getTasks();
    observable.subscribe(data => {
      console.log(data["allTasks"]);
      this.tasks = data["allTasks"];
    })
  }

  TasksButton(): void { 
    this.getTasksfromService();
  }

  TaskShowButton(id: string){
    if (!this.ShowTaskDetail.includes(id)){
      this.ShowTaskDetail.push(id);
    }
    else{
      this.ShowTaskDetail.splice(this.ShowTaskDetail.indexOf(id),1);
    }
    console.log(this.ShowTaskDetail);
  }

  onSubmit(){
    let observable = this._httpService.newTask(this.newTask);
    observable.subscribe(data => console.log("***This is the data returned from attempting to post to the server..." + data));
    console.log("****** In component.ts and just sent newTask to service and newTask equals = " + this.newTask);
    this.newTask = {title: "", description: ""};
  }

  onDelete(id: String){
    let observable = this._httpService.removeTask(id);
    observable.subscribe(data => console.log("***This is the data returned from attempting to delete task...", data));
  }

  onEditButton(id: String){
    console.log("************************************************************************************************************************************");
    console.log(id);
    this.editstat = true;
    let observable = this._httpService.getTask(id);
    observable.subscribe(task => {
      console.log("*******  TASK in comp.ts  ********");
      console.log(task);
      this.editTask = {title: `${task["theTask"].title}`, description: `${task["theTask"].description}`, _id: `${task["theTask"]._id}`};
    })
  }

  onEdit(){
    //get the task
    let observable = this._httpService.getTask(this.editTask._id);
    observable.subscribe(task => {
      //update the new editTask data
      let observable2 = this._httpService.editTask(this.editTask);
      observable2.subscribe(updatedTask => console.log("***This is the data returned from attempting to post to the server..." + updatedTask));
      console.log("****** In component.ts and just triggered onEdit and updatedTask equals = " + this.editTask);
      this.editTask = {title: "", description: "", _id: ""};
      })
  }


}
