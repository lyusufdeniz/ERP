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

    }
    
  
    

]