import { Component } from '@angular/core';

import { SharedModule } from '../../modules/shared.module';

import { ProductModel } from '../../models/product.model';
import { RecipeModel } from '../../models/recipe.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { ActivatedRoute } from '@angular/router';
import { NgForm } from '@angular/forms';
import { RecipeDetailsPipe } from '../../pipes/recipe-details.pipe';
import { RecipeDetailModel } from '../../models/recipeDetail.model';

@Component({
  selector: 'app-recipe-details',
  standalone: true,
  imports: [SharedModule, RecipeDetailsPipe],
  templateUrl: './recipe-details.component.html',
  styleUrl: './recipe-details.component.css'
})
export class RecipeDetailsComponent {
  recipe: RecipeModel = new RecipeModel();
  search:string = "";
  products: ProductModel[] = [];
  recipeId: string = "";
  isUpdateFormActive: boolean = false;

  createModel:RecipeDetailModel = new RecipeDetailModel();
  updateModel:RecipeDetailModel = new RecipeDetailModel();

  constructor(
    private http: HttpService,
    private swal: SwalService,
    private acivated: ActivatedRoute
  ){
    this.acivated.params.subscribe(res=> {
      this.recipeId = res["id"];
      this.getRecipeById();    
      this.createModel.recipeId = this.recipeId;  
    })
  }

  ngOnInit(): void {
    this.getAllProducts();
  }

  getRecipeById(){
    this.http.post<RecipeModel>("RecipeDetails/GetById",{recipeId: this.recipeId},(res)=> {
      this.recipe = res;
    });
  }

  getAllProducts(){
    this.http.post<ProductModel[]>("Product/GetAll",{},(res)=> {
      this.products = res.filter(p=> p.type.value == 2);
    });
  }

  create(form: NgForm){
    if(form.valid){
      this.http.post<string>("RecipeDetails/Create",this.createModel,(res)=> {
        this.swal.callToast(res);
        this.createModel = new RecipeDetailModel();
        this.createModel.recipeId = this.recipeId;
        this.getRecipeById();
      });
    }
  }

  deleteById(model: RecipeDetailModel){
    this.swal.callSwal("Malzeme Listesindeki Ürünü Sil?",`${model.product.name} ürününü silmek istiyor musunuz?`,()=> {
      this.http.post<string>("RecipeDetails/Delete",{id: model.id},(res)=> {
        this.getRecipeById();
        this.swal.callToast(res,"info");
      });
    })
  }

  get(model: RecipeDetailModel){    
    this.updateModel = {...model};
    this.updateModel.product = this.products.find(p=> p.id == this.updateModel.productId) ?? new ProductModel();
    this.isUpdateFormActive = true;
  }

  update(form: NgForm){
    if(form.valid){
      this.http.post<string>("RecipeDetails/Update",this.updateModel,(res)=> {
        this.swal.callToast(res,"info");        
        this.getRecipeById();
        this.isUpdateFormActive = false;
      });
    }
  }
}