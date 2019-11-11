import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {
    this.getPoke();
  }

  getPoke(){
    let corsola = this._http.get('https://pokeapi.co/api/v2/pokemon/222/');
    
    corsola.subscribe(corsola => {
      console.log(corsola);

      console.log(corsola.abilities[0]["ability"]["url"]);
      var regeneratorurl = corsola.abilities[0]["ability"]["url"];

      let ability = this._http.get(regeneratorurl);

      ability.subscribe(ability => {
        let number = ability.pokemon.length;

        console.log(`My chosen Pokemon's specie is ${corsola.name} has a base experience of ${corsola.base_experience} and its first 3 abilities are ${corsola.abilities[0]["ability"]["name"]}, ${corsola.abilities[1]["ability"]["name"]}, and ${corsola.abilities[2]["ability"]["name"]}. ${corsola.name} shares the ${corsola.abilities[0]["ability"]["name"]} ability with ${number} other pokemon.`)
      })
    }
  )}


}
