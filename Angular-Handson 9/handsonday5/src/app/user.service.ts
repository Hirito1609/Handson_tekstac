import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

const baseUrl = 'https://reqres.in/api/users?page=2';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get(baseUrl);
  }

}
export interface user {
  id:number;
  email:string;
  first_name:string;
  last_name:string;
  avatar : string;
}

