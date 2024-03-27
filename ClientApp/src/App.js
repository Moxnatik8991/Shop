import React from 'react';
import st from './custom.module.css';
import { NavLink, Route, Routes, useRoutes } from "react-router-dom";
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
import { Modal } from "./components/Home";



const App = () => {
    let routs = useRoutes(routing);

    const [anchorEl, setAnchor] = React.useState(null);
    const handleClick = (event) => {
        
        setAnchor(anchorEl ? null : event.currentTarget);
    };

    const open = Boolean(anchorEl);
    const id = open ? 'simple-popper' : undefined;


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
                    <div onClick={handleClick}>Test Modal</div>
                </div>

            </div>
            <div className={st.content}>
                {routs}
                <Modal open={open} anchorEl={anchorEl} id={id} />
            </div>
            <Footer />
        </div>

    );
}
export default App;
