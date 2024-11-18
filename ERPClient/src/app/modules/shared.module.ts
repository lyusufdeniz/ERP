import { FormValidateDirective } from 'form-validate-angular';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { TrCurrencyPipe } from 'tr-currency';




@NgModule({
  declarations: [    
  ],
  imports: [
    CommonModule,
    FormsModule,
    FormValidateDirective,
    TrCurrencyPipe
  ],
  exports: [
    CommonModule,
    FormsModule,
    FormValidateDirective,
    TrCurrencyPipe
  ]
})
export class SharedModule { }