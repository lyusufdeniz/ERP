import { SwalService } from './../services/swal.service';
import { Component, ElementRef, OnInit, ViewChild, viewChild } from '@angular/core';
import { SharedModule } from '../modules/shared.module';
import { CustomerModel } from '../models/customer.model';
import { HttpService } from '../services/http.service';
import { CustomerPipe } from '../pipes/customer.pipe';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-customers',
  standalone: true,
  imports: [SharedModule,CustomerPipe],
  templateUrl: './customers.component.html',
  styleUrl: './customers.component.css'
})
export class CustomersComponent implements OnInit {

  customers:CustomerModel[]=[];
  search:string="";
  createModel:CustomerModel=new CustomerModel();
  updateModel:CustomerModel=new CustomerModel();
  @ViewChild("createModalClosebtn") createModalClosebtn :ElementRef<HTMLButtonElement> |undefined
  constructor(private http:HttpService,private swal: SwalService){}

  ngOnInit(): void {
    this.getAll();
 
  }

  getAll()
  {
    this.http.post<CustomerModel[]>("Customer",{},(res)=>{this.customers=res})
  }
  create(createForm:NgForm)
  {
    if(createForm.valid)
    {
    
      this.http.post<string>("Customer/Create",this.createModel,(res)=>{this.swal.callToast(res)})
      
      this.createModel=new CustomerModel();
      this.createModalClosebtn?.nativeElement.click();
    }
    
  }


}
