import React,{useState} from 'react';
import st from './custom.module.css';
import { CustomBucketModal } from "./components/global/CustomModals/CustomBucketModal";
import Catalog, { CategoryFilter } from "./components/pages/Catalog/Catalog";
import { NavLink, Route, Routes, useRoutes } from "react-router-dom";
import Contacts from "./components/pages/Contacts/Contacts";
import { routing } from "./utils/Routing";
import {
    Footer
} from "./components/global/Footer";
import {
    Header
} from "./components/global/Header";
import {
    Container
} from "./components/ui/Container/Container";



const App = () => {
    let routs = useRoutes(routing);
  
    return (
           
        <div className={st.appContainer}>
            <Header />
            <div className={st.navMenu}>
                <div className={st.navMenuContent}>
                    <NavLink to={"/"}>Main</NavLink>
                    <NavLink to={'/catalog'}>Catalog</NavLink>
                    <NavLink to={"/sale"}>Sale</NavLink>
                    <NavLink to={"/paymentInfo"}>Payment and delivery</NavLink>
                    <NavLink to={"/contacts"}>Contact us</NavLink>
                    <NavLink to={"/test"}>Test Page</NavLink>
                    <NavLink to={"/catalog-redux"}>Cat redux</NavLink>
                </div>

            </div>
            <div className={st.content}>
                {routs}
            </div>
            <Footer />
        </div>

    );
}
export default App;
