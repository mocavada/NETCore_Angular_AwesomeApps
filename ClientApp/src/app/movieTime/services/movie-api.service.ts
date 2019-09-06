
import { environment } from './../../../environments/environment';
import { Movie } from './../models/movie';
import { Injectable, Inject } from '@angular/core';
import { BehaviorSubject, Subject, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class MovieApiService {

serverUrl = 'http://localhost:5000';
moviesApiUrl = this.serverUrl +  '/api/movies';
movieResult$ = new BehaviorSubject<[Movie]>(null);

constructor(private http: HttpClient) {

  console.log(this.serverUrl);
}

// getEnv() {
//   if (environment.production) {
//     this.serverUrl = environment.serverAddress;
//   } else {
//     this.serverUrl = environment.serverAddressProd;
//   }
// }


getMovies() {
  this.http.get<[Movie]>(this.moviesApiUrl)
  .subscribe(data => {
    this.movieResult$.next(data);
  }, err => {
    console.log('Something Wrong' + err);
  });
}


getMovieById(id: number) {
  return this.http.get(this.moviesApiUrl + '/' + id );
}

editMovie(movie: Movie) {
  return this.http.put<any>(this.moviesApiUrl + '/' + movie.id, movie);
}

}
