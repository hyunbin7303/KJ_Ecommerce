import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private loginPath = environment.apiUrl + 'login'
  private registerPath = environment.apiUrl + 'register'
  constructor(private http: HttpClient) { }
  login(data): Observable<any> {
    return this.http.post(this.loginPath, data)
  }


  register(data): Observable<any> {
    return this.http.post(this.registerPath,data)
  }
}
