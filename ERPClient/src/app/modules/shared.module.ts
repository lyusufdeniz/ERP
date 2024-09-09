import { FormValidateDirective } from 'form-validate-angular';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';




@NgModule({
  declarations: [    
  ],
  imports: [
    CommonModule,
    FormsModule,
    FormValidateDirective
  ],
  exports: [
    CommonModule,
    FormsModule,
    FormValidateDirective
  ]
})
export class SharedModule { }