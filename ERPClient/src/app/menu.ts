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
        name: "Kullanıcılar",
        icon: "mdi-account",
        url: "/Users",
        subMenus: [{
            name: "İstatistikler",
            icon: "",
            url: "/Users",
            subMenus: []

        }]

    },
    {
        name: "Grafikler",
        icon: "mdi-chart-bar",
        url: "/Users",
        subMenus: [{
            name: "1",
            icon: "",
            url: "/Users",
            subMenus: []

        }]

    },
    

]