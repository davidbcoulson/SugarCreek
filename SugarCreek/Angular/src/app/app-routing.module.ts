import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateRoundsComponent } from './create-rounds/create-rounds.component';
import { GetRoundsComponent } from './get-rounds/get-rounds.component';
import { MainComponent } from './main/main.component';

const routes: Routes = [
  { path: '', component: MainComponent },
  { path: 'GetRounds', component: GetRoundsComponent },
  { path: 'CreateRounds', component: CreateRoundsComponent },
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
//
