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
  activeButton: 'btn-success';
  nonActiveButton: 'btn-outline-success';
  roundHoleCount: number;

  teeTimeRequest = new FormGroup({
    teeTime: new FormControl(''),
    numberOfHoles: new FormControl(''),
    numberOfGolfers: new FormControl(''),
    cart: new FormControl(''),
  })

  constructor(private service: CreateRoundService) { }

  ngOnInit(): void {
    this.roundHoleCount = 0
  }

  submitForm() {
    this.service.createRound(this.teeTimeRequest.value).subscribe(x => {
      debugger
      console.log(x);
    }, err => { console.log(err) }, () => {
    })
  }

  updateHoleCount(countPassed) {
    this.roundHoleCount = countPassed
  }
}
