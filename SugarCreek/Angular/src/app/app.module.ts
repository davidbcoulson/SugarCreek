import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { CreateRoundsComponent } from './create-rounds/create-rounds.component';
import { GetRoundsComponent } from './get-rounds/get-rounds.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    CreateRoundsComponent,
    GetRoundsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
//
