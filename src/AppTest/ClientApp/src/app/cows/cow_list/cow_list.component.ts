import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Cow } from './cow.model';

@Component({
  selector: 'app_cow_list',
  templateUrl: './cow_list.component.html',
})
export class CowListComponent {
  public title: string = "Cow List";
  public cows: Cow[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Cow[]>(baseUrl + 'api/Cows/GetCows').subscribe(result => {
      this.cows = result;
    }, error => console.error(error));
  }
}
