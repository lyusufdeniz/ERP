import { MenuModel } from '../../menu';
import { SwalService } from '../../services/swal.service';
import { Component, ElementRef, OnInit, ViewChild, viewChild } from '@angular/core';
import { SharedModule } from '../../modules/shared.module';
import { CustomerModel } from '../../models/customer.model';
import { HttpService } from '../../services/http.service';
import { CustomerPipe } from '../../pipes/customer.pipe';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-customers',
  standalone: true,
  imports: [SharedModule, CustomerPipe],
  templateUrl: './customers.component.html',
  styleUrl: './customers.component.css'
})
export class CustomersComponent implements OnInit {

  customers: CustomerModel[] = [];
  search: string = "";
  createModel: CustomerModel = new CustomerModel();
  updateModel: CustomerModel = new CustomerModel();
  @ViewChild("createModalClosebtn") createModalClosebtn: ElementRef<HTMLButtonElement> | undefined
  @ViewChild("updateModalClosebtn") updateModalClosebtn: ElementRef<HTMLButtonElement> | undefined
  constructor(private http: HttpService, private swal: SwalService) { }

  ngOnInit(): void {
    this.getAll();

  }


   async getAll() {
    this.http.post<CustomerModel[]>("Customer/GetAll", {}, (res) => { this.customers = res })
  }
  create(createForm: NgForm) {
    
    if (createForm.valid) {

      this.http.post<string>("Customer/Create", this.createModel, (res) => { 
        this.swal.callToast(res)
        this.createModel = new CustomerModel();
        this.createModalClosebtn?.nativeElement.click();
        this.swal.callToast("Müşteri Kaydedildi", 'success');
        this.getAll();
      
      })


    }
    else
    {
  
      this.swal.callToast("Hata Kaydı Kontrol Et","error")
      
    }

  }
  delete(model: CustomerModel) {
    this.swal.callSwal("MüşteriSil", `${model.taxNumber} Vergi Numaralı ${model.name} Müşterisini Silmek İstiyor Musunuz?`, () => {
      this.http.post<string>("Customer/Delete", { id: model.id }, (res) => {  this.swal.callToast(res,'success');this.getAll(); })
    })
   
  }
  update(updateForm: NgForm)
  {
    if (updateForm.valid) {

      this.http.post<string>("Customer/Update", this.updateModel, (res) => { this.swal.callToast(res,'success') })

      this.updateModel = new CustomerModel();
      this.updateModalClosebtn?.nativeElement.click();
      this.swal.callToast("Müşteri Güncellendi", 'success');
      this.getAll();
    }
  }
  get(model:CustomerModel)
  {
    this.updateModel={...model};
  }


}
