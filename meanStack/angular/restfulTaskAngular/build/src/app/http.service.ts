import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getTasks(){
    return this._http.get('/tasks');
    //let tempObservable = this._http.get('/tasks');
    //tempObservable.subscribe(data => console.log(data));
  }

  getTask(id: String){
    return this._http.get('/tasks/' + id);
    //console.log('******************* the route should look like this .../tasks/' + id);
    //let tempObservable = this._http.get('/tasks/' + id);
    //tempObservable.subscribe(data => console.log(data));
  }

}
