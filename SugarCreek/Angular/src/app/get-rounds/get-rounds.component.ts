import { Component, OnInit } from '@angular/core';
import { GetRoundsService } from './get-rounds.service';

@Component({
  selector: 'app-get-rounds',
  templateUrl: './get-rounds.component.html',
  styleUrls: ['./get-rounds.component.css']
})
export class GetRoundsComponent implements OnInit {

  constructor(private service: GetRoundsService) {}

  public teeTimes: any;

  ngOnInit(): void {
    this.service.getRound().subscribe(x => {
      console.log(x);
      this.teeTimes = x;
    })
  }

}
