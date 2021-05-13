import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MemberComponent } from './member/member.component';
import { ShowMemberComponent } from './member/show-member/show-member.component';
import { AddMemberComponent } from './member/add-member/add-member.component';
import { SportComponent } from './sport/sport.component';
import { AddSportComponent } from './sport/add-sport/add-sport.component';
import { ShowSportComponent } from './sport/show-sport/show-sport.component';
import { SharedService } from './shared.service';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule,ReaactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    MemberComponent,
    ShowMemberComponent,
    AddMemberComponent,
    SportComponent,
    AddSportComponent,
    ShowSportComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
