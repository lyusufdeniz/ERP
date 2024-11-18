export class MenuModel {


    name: string = "";
    icon: string = "";
    url: string = "";
    subMenus: MenuModel[] = [];

}

export const Menus: MenuModel[] = [
    {
        name: "Ana Sayfa",
        icon: "mdi mdi-grid-large menu-icon",
        url: "/",
        subMenus: []

    },
    {
        name: "Müşteriler",
        icon: "mdi mdi-account-supervisor",
        url: "customers",
        subMenus: []

    },
    {
        name: "Depolar",
        icon: "mdi mdi-warehouse",
        url: "depots",
        subMenus: []

    }
    ,
    {
        name: "Ürünler",
        icon: "mdi mdi-package",
        url: "products",
        subMenus: []

    }
    ,
    {
        name: "Ürün Malzeme",
        icon: "mdi mdi-archive-plus",
        url: "recipes",
        subMenus: []

    }
    
  
    

]