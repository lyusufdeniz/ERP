
import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SwalService, SweetAlertIcon } from './swal.service';

@Injectable({
  providedIn: 'root'
})
export class ErrorService {

  constructor(private swal:SwalService) { }


  errorHandler(err:HttpErrorResponse)
  {
if(err.status===403)
{
  let errorMessage="";
  for(const e of err.error.ErrorMessages)
  {
    errorMessage+=e+"\n";

  }
  this.swal.callToast(errorMessage,'error');

}
else if(err.status===500)
{
  this.swal.callToast(err.error.errorMessages[0],'error');
}
else
{
  this.swal.callToast("bilinmeyen hata oluştu",'error');
}
  
    
  }
}
