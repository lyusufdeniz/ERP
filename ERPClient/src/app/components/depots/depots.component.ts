import { Component, ElementRef, ViewChild, OnInit } from '@angular/core';
import { DepotModel } from '../../models/depot.model';
import { SharedModule } from '../../modules/shared.module';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { DepotPipe } from '../../pipes/depot.pipe';

@Component({
  selector: 'app-depots',
  standalone: true,
  imports: [SharedModule,DepotPipe],
  templateUrl: './depots.component.html',
  styleUrl: './depots.component.css'
})
export class DepotsComponent implements OnInit {
  depots: DepotModel[] = [];
  search: string = "";
  createModel: DepotModel = new DepotModel();
  updateModel: DepotModel = new DepotModel();
  @ViewChild("createModalClosebtn") createModalClosebtn: ElementRef<HTMLButtonElement> | undefined
  @ViewChild("updateModalClosebtn") updateModalClosebtn: ElementRef<HTMLButtonElement> | undefined
  constructor(private http: HttpService, private swal: SwalService) { }
  ngOnInit(): void {
    this.getAll();

  }
   async getAll() {
    this.http.post<DepotModel[]>("Depot/GetAll", {}, (res) => { this.depots = res })
  }
  create(createForm: NgForm) {
    if (createForm.valid) {

      this.http.post<string>("Depot/Create", this.createModel, (res) => { this.swal.callToast(res) })

      this.createModel = new DepotModel();
      this.createModalClosebtn?.nativeElement.click();
      this.swal.callToast("Depo Kaydedildi", 'success');
      this.getAll();
    }

  }
  delete(model: DepotModel) {
    this.swal.callSwal("Depo Sil?", `${model.name} ${model.city}/${model.town} Deposunu Silmek İstiyor Musunuz?`, () => {
      this.http.post<string>("Depot/Delete", { id: model.id }, (res) => {  this.swal.callToast(res,'success');this.getAll(); })
    })
   
  }
  update(updateForm: NgForm)
  {
    if (updateForm.valid) {

      this.http.post<string>("Depot/Update", this.updateModel, (res) => { this.swal.callToast(res,'success') })

      this.updateModel = new DepotModel();
      this.updateModalClosebtn?.nativeElement.click();
      this.swal.callToast("Depo Güncellendi", 'success');
      this.getAll();
    }
  }
  get(model:DepotModel)
  {
    this.updateModel={...model};
  }
}
