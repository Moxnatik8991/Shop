import React from "react";
import ContactsPage from "../components/pages/Contacts/ContactsPage";
import { CatalogRedux } from "../components/pages/_tmpPages/CatalogRedux";
import Categories from "../components/pages/Categories/Categories";
import ItemPage  from "../components/pages/Item/ItemPage";
import MainPage from "../components/pages/Main/MainPage";
import SalePage from "../components/pages/Sales/SalePage";
import PaymentInfoPage from "../components/pages/PaymentInfo/PaymentInfoPage";
import TestPage from "../components/pages/Test/TestPage";
import Login from "../components/pages/Login/Login";
import MainLayout from "../components/pages/MainLayout";
import { useRoutes } from "react-router-dom";
import AdminLayout from "../components/pages/AdminLayout";
import Comments from "../components/pages/Item/Comments/Comments";
import Main from "../components/pages/Item/Main/Main";
export const newRouts =[
    {
        path:"/",
        element:<MainLayout/>,
        children:[
            {
                index:true,
                element:<MainPage/>
            },
            {
                path : ":itemId",
                element : <ItemPage />,
                children:[
                    {
                        index:true,
                        element:<Main/>
                    },
                    {
                        path:"comments",
                        element : <Comments/>
                    }
                ]
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
        ]
    },
    {
        path : "admin",
        element : <AdminLayout/>
    }
]

const Routing = ()=>{
    return useRoutes(newRouts)
}
export default Routing;