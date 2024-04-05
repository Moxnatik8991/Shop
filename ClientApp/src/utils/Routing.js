
import React from "react";
import ContactsPage from "../components/pages/Contacts/ContactsPage";
import { CatalogRedux } from "../components/pages/_tmpPages/CatalogRedux";
import Categories from "../components/pages/Categories/Categories";
import ItemPage from "../components/pages/Item/ItemPage";
import MainPage from "../components/pages/Main/MainPage";
import SalePage from "../components/pages/Sales/SalePage";
import PaymentInfoPage from "../components/pages/PaymentInfo/PaymentInfoPage";
import TestPage from "../components/pages/Test/TestPage";
import Login from "../components/pages/Login/Login";


export const routing = [
    {
        index : "/",
        element : <MainPage/>
    },
    {
        path : ":itemId",
        element : <ItemPage />
    },
    {
        path : "catalog/:IdCategory?",
        element : <Categories/>,
        
    },
    {
        path : "paymentInfo",
        element : <PaymentInfoPage/>,

    },
    {
        path : "sales",
        element : <SalePage/>,

    },
    {
        path : "contacts",
        element : <ContactsPage/>
    },
    {
        path : "test", 
        element : <TestPage/>
    },
    {
        path: 'catalog-redux',
        element: <CatalogRedux />
    },
    {
        path: 'login',
        element: <Login />
    }
    ];