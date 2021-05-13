import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observeable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly APIUrl = "https://localhost:44388/api"
  readonly memberUrl ='/Members'

  constructor(private http:HtttC) { 

    getMembers() : Observeable<any[]>{
      retrun this.h 
    }
  }
}
