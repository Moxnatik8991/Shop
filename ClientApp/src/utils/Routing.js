import MainPage from "../components/MainPage";
import Catalog  from "../components/pages/Catalog/Catalog";
import React from "react";
import Contacts from "../components/pages/Contacts/Contacts";
import Home from "../components/Home";
import { CatalogRedux } from "../components/pages/_tmpPages/CatalogRedux";
import Category from "../components/pages/Catalog/CategoryPage/Category";
import ItemPage from "../components/pages/Catalog/ItemPage/ItemPage";
import TestCategory from "../components/TestCategory";

export const routing = [
    {
        index : "/",
        element : <MainPage/>
    },
    {
        path : "catalog/:category?",
        element : <Category/>,
        
    },
    {
        path : ":itemId",
        element : <ItemPage />
    },
    {
        path : "contacts",
        element : <Contacts/>
    },
    {
        path : "test/:itemIdId?", 
        element : <Home/>
    },
    {
        path: 'catalog-redux',
        element: <CatalogRedux />
    }
    ];