import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { UserRegister } from '../_models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;

  userRegistration(_data: UserRegister){
    return this.http.post(this.baseUrl + `User/registration`, _data);
  }
}
