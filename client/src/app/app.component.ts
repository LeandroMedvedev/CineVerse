import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'CineVerse';
  customers: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.http.get('https://localhost:7042/v1/customers').subscribe({
      next: (response) => (this.customers = response),
      error: (error) => console.log(error),
      complete: () => console.log('Request has completed!'),
    });
  }
}
