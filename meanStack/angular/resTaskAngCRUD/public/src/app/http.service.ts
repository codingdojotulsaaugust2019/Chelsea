import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient){}

  getTasks(){
    return this._http.get('/tasks');
  }

  getTask(id: String){
    return this._http.get('/tasks/' + id);
  }

  newTask(task){
    console.log("**** in the http service newTask Route and the incoming task equals..." + task);
    return this._http.post('/tasks', task);
  }

  removeTask(id){
    console.log("**** in the http service remove route, the id is..." + id);
    return this._http.delete('/tasks/' + id);
  }

  editTask(editTask){
    console.log("***************************************************");
    console.log(editTask);
    console.log("**** in the http service editTask, the id is...." + editTask._id);
    return this._http.put('/tasks/'+editTask._id, editTask);
  }
}
