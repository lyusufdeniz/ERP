import { Pipe, PipeTransform } from '@angular/core';
import { RecipeDetailModel } from '../models/recipeDetail.model';

@Pipe({
  name: 'recipeDetails',
  standalone: true
})
export class RecipeDetailsPipe implements PipeTransform {

  transform(value: RecipeDetailModel[], search: string): RecipeDetailModel[] {
    if (!search) {
      return value;
    }
      return value.filter(p => p.product.name.toLocaleLowerCase().includes(search.toLocaleLowerCase()))
  }

}
