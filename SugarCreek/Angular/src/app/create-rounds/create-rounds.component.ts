import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-create-rounds',
  templateUrl: './create-rounds.component.html',
  styleUrls: ['./create-rounds.component.css']
})
export class CreateRoundsComponent implements OnInit {
  formComplete: boolean;
  formclass: string;
  loaderclass: string;
  successMessage: string;

  teeTimeRequest = new FormGroup({
    teeTime: new FormControl(''),
    numberOfHoles: new FormControl(''),
    cart: new FormControl(''),
  })

  constructor() { }

  ngOnInit(): void {
  }

  submitForm() {
    this.formclass = "hidden";
    this.loaderclass = "visible"
    this.service.submitContactRequest(this.teeTimeRequest.value).subscribe(x => {
      console.log(x);
    }, err => { console.log(err) }, () => {
      this.loaderclass = "hidden";
      this.successMessage = "visible";
    })
  }
}
