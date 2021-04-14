import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';


@Injectable({
  providedIn: 'root'
})
export class CreateRoundService {
  baseUrl = environment.baseUrl;
  public API = this.baseUrl;

  public postCreateRoundEndPoint = `${this.API}/api/rounds/createRound`;

  constructor(private http: HttpClient) { }

  createLesson(request): Observable<any> {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = request;
    return this.http.post<any>(this.postCreateRoundEndPoint, body, { headers });
  }

}
