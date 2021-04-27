import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class GetRoundsService {
  baseUrl = environment.baseUrl;
  public API = this.baseUrl;

  constructor(private http: HttpClient) { }
  public getRoundsEndPoint = `${this.API}/api/rounds/getRounds`;
  getRound(): Observable<any> {
    return this.http.get<any>(this.getRoundsEndPoint)
  }
}
