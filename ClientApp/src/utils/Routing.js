import MainPage from "../components/MainPage";
import Catalog  from "../components/pages/Catalog/Catalog";
import React from "react";
import Contacts from "../components/pages/Contacts/Contacts";
import Home from "../components/Home";
import { CatalogRedux } from "../components/pages/_tmpPages/CatalogRedux";
import Category from "../components/pages/Catalog/CategoryPage/Category";
import ItemPage from "../components/pages/Catalog/ItemPage/ItemPage";

export const routing = [
    {
        index : "/",
        element : <MainPage/>
    },
    {
        path : "catalog",
        element : <Catalog/>,
        children : [
            {
                path : ":category/:id?/:secondId?",
                element : <Category />
            }
        ]
    },
    {
        path : ":item",
        element : <ItemPage />
    },
    {
        path : "contacts",
        element : <Contacts/>
    },
    {
        path : "test/:itemId?", 
        element : <Home/>
    },
    {
        path: 'catalog-redux',
        element: <CatalogRedux />
    }
    ];