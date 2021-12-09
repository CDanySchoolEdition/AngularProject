import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as internal from 'assert';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'getStudents').subscribe(result => {
      this.forecasts = result;
      console.log(result);
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  fullName: string;
  age : number;
  averageGrade : number;
}
