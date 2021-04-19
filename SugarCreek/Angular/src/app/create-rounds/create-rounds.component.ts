import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { CreateRoundService } from './create-round.service';

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

  constructor(private service: CreateRoundService) { }

  ngOnInit(): void {
  }

  submitForm() {
    this.service.createRound(this.teeTimeRequest.value).subscribe(x => {
      debugger
      console.log(x);
    }, err => { console.log(err) }, () => {
    })
  }
}
