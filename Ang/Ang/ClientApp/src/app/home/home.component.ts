import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
 name : string;
 private http: HttpClient;

 constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  this.http = http;
}

 sendData()
 {
   var self = this;
   console.log(self.name);
   var postBody = { FullName: self.name, Age: 543, AverageGrade:5.5 };

   self.http.post('https://localhost:44370/writeStudent',postBody).subscribe(result => {
    console.log(result);
  }, error => console.error(error));

 }


   


}



