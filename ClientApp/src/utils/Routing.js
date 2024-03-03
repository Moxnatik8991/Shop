import MainPage from "../components/MainPage";
import Catalog, { CategoryFilter } from "../components/pages/Catalog/Catalog";
import React from "react";
import Contacts from "../components/pages/Contacts/Contacts";
import Home from "../components/Home";
import { CatalogRedux } from "../components/pages/_tmpPages/CatalogRedux";

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
                path : ":category",
                element : <CategoryFilter/>
            }
        ]
    },
    {
        path : "contacts",
        element : <Contacts/>
    },
    {
        path : "test", 
        element : <Home/>
    },
    {
        path: 'catalog-redux',
        element: <CatalogRedux />
    }
    ];