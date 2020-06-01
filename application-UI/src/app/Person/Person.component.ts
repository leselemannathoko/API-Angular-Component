import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-Person',
  templateUrl: './Person.component.html',
  styleUrls: ['./Person.component.css']
})
export class PersonComponent implements OnInit {
people: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getPeople();
  }


  getPeople(){
    this.http.get('https://localhost:44313/api/people').subscribe(response =>{
      this.people = response;
    }, error => {
    console.log(error);
  });
}
}
