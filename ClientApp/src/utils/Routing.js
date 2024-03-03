import MainPage from "../components/MainPage";
import Catalog, { CategoryFilter } from "../components/Catalog/Catalog";
import React from "react";
import Contacts from "../components/Contacts/Contacts";
import Home from "../components/Home";

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
    }
    ];