import { MovieApiService } from './../services/movie-api.service';
import { Movie } from './../models/movie';
import { Component, OnInit } from '@angular/core';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatFormFieldModule} from '@angular/material/form-field';
import { FormGroup, FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';


@Component({
  selector: 'app-movie-add',
  templateUrl: './movie-add.component.html',
  styleUrls: ['./movie-add.component.css']
})
export class MovieAddComponent implements OnInit {

  movieForm: FormGroup;
  movies;
  validMessage = '';

  constructor(private fb: FormBuilder,
              private router: Router,
              private movieService: MovieApiService) { }

  ngOnInit() {
      this.createForm();
  }


  createForm() {
    this.movieForm = this.fb.group({
      title: [],
      genre: [],
      price: [],
      releaseDate: []
    });
  }

  onSubmit(f: any) {
    if (f.valid) {
      this.validMessage = 'Your information has been saved. Thank you!';
      console.log('This form is good to go.');
      this.movieService.addMovie(f.value);
      this.movieForm.reset();
    } else {
      // f.value.jobType = parseInt(f.value.jobType, 0);
      console.log(f.value);
      // this.devjson = f.value;
    }

    this.router.navigate(['movie-add']);
  }


  relaod() {
    window.location.reload();
  }

}
