import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'; 
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AdivinanzaService {

  private apiURL = 'https://localhost:7245/api/Adivinanza'

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    }),
    responseType: 'text' as 'json'
  };

  constructor(private httpClient: HttpClient) { }

  enviarNumeroIngresado(numeroIngresado: number): Observable<string> {
      return this.httpClient.post<string>(`${this.apiURL}/Adivinar`, numeroIngresado, this.httpOptions)
        .pipe(
          catchError(this.errorHandler)
      );
  }

  reiniciarJuego(): Observable<string> {
    return this.httpClient.post<string>(`${this.apiURL}/Reiniciar`, {}, this.httpOptions)
      .pipe(
        catchError(this.errorHandler)
    );
  }

  errorHandler(error: any) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
        errorMessage = error.error.message;
    } else {
        errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
  }  

}
