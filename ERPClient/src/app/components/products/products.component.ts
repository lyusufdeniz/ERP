import { ProductTypeEnum, productTypes } from './../../models/product.model';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ProductModel } from '../../models/product.model';
import { SharedModule } from '../../modules/shared.module';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { ProductPipe } from '../../pipes/product.pipe';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [SharedModule,ProductPipe],
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent implements OnInit {
  products: ProductModel[] = [];
  search: string = "";
  createModel: ProductModel = new ProductModel();
  updateModel: ProductModel = new ProductModel();
  types =productTypes;
  @ViewChild("createModalClosebtn") createModalClosebtn: ElementRef<HTMLButtonElement> | undefined
  @ViewChild("updateModalClosebtn") updateModalClosebtn: ElementRef<HTMLButtonElement> | undefined
  constructor(private http: HttpService, private swal: SwalService) { }
  ngOnInit(): void {
    this.getAll();

  }
   async getAll() {
    this.http.post<ProductModel[]>("Product/GetAll", {}, (res) => { this.products = res })
  }
  create(createForm: NgForm) {
    if (createForm.valid) {

      this.http.post<string>("Product/Create", this.createModel, (res) => { this.swal.callToast(res) })

      this.createModel = new ProductModel();
      this.createModalClosebtn?.nativeElement.click();
      this.swal.callToast("Ürün Kaydedildi", 'success');
      this.getAll();
    }

  }
  delete(model: ProductModel) {
    this.swal.callSwal("Ürün Sil?", `${model.name} adlı ürünü Silmek İstiyor Musunuz?`, () => {
      this.http.post<string>("Product/Delete", { id: model.id }, (res) => {  this.swal.callToast(res,'success');this.getAll(); })
    })
   
  }
  update(updateForm: NgForm)
  {
    if (updateForm.valid) {

      this.http.post<string>("Product/Update", this.updateModel, (res) => { this.swal.callToast(res,'success') })

      this.updateModel = new ProductModel();
      this.updateModalClosebtn?.nativeElement.click();
      this.swal.callToast("Ürün Güncellendi", 'success');
      this.getAll();
    }
  }
  get(model:ProductModel)
  {
    this.updateModel={...model};
    this.updateModel.typeValue=model.type.value
  }
}
