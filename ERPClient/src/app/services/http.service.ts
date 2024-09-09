import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { host } from '../constants';
import { ResultModel } from '../models/result.model';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http: HttpClient) { }

  post<T>(apiurl: string, body: any, callBack: (res: T) => void, errorCallback?: () => void) {
    this.http.post<ResultModel<T>>(`${host}/${apiurl}}`, body, {
      headers: {
        Authorization: "Bearer " + "token"
      }
    }).subscribe({
      next: (res: any) => {
        if (res.data) {
          callBack(res.data)
        }
      }
        ,
       
      error: (error: HttpErrorResponse) => {

        if (errorCallback) {
          errorCallback()
        }
      }
    })
  }
}
