import React , { useEffect , useState } from 'react';
import { setAuth } from "../../redux/auth.slice";
import { useDispatch , useSelector } from "react-redux";
import { getAllItemsAndCategories } from "../../redux/items.action";
import { NavLink , Outlet , useRoutes } from "react-router-dom";
import st from "./MainLayout.module.scss"
import { Header } from "../global/Header";
import CatalogModal from "../global/CustomModals/CatalogModal";
import { Footer } from "../global/Footer";
import LoginModal from "../global/CustomModals/LoginModal";

const authChecker=(dispatch,isAuth)=>{
    let token = localStorage.getItem('token')
    if(token && !isAuth) dispatch(setAuth(true))
    if(!token && isAuth) dispatch(setAuth(false))
}
const MainLayout = ()=>{
    const dispatch = useDispatch();
    useEffect ( ()=>{
        dispatch(getAllItemsAndCategories())

    } , [] );

    /*let routs = useRoutes(routing);*/

    const [anchorEl, setAnchor] = React.useState(null);
    const handleClick = (event) => {
        setAnchor(anchorEl ? null : event.currentTarget);
    };
    const open = Boolean(anchorEl);
    const id = open ? 'simple-popper' : undefined;

    const{isLoading}=useSelector(state=>state.item)
    const{isAuth}=useSelector(state=>state.auth)
    console.log("render app")
    authChecker(dispatch,isAuth);
    //login modal
    const [loginModalOpen,setLoginModalOpen]=useState(false);
    useEffect ( ()=>{
        if(isAuth&& loginModalOpen) setLoginModalOpen(false)
    } , [isAuth] );
    //login modal
    return (

        <div className={ st.appContainer }>
            <Header/>
            <div className={ st.navMenu }>
                <div className={ st.navMenuContent }>
                    <NavLink to={ "/" }>Main</NavLink>
                    <div onClick={ handleClick }>Catalog</div>
                    <NavLink to={ "/sales" }>Sale</NavLink>
                    <NavLink to={ "/paymentInfo" }>Payment and delivery</NavLink>
                    <NavLink to={ "/contacts" }>Contact us</NavLink>
                    <NavLink to={ "/test" }>Test Page</NavLink>
                    <NavLink to={ "/catalog-redux" }>Cat redux</NavLink>
                    <div style={ { cursor : "pointer" , color : "white" } } onClick={ ()=>{
                        setLoginModalOpen ( true )
                    } }>Login
                    </div>

                </div>

            </div>
            { !isLoading
                ? <div className={ st.content }>
                    <Outlet/>
                    <CatalogModal handleClick={ handleClick } open={ open } anchorEl={ anchorEl } id={ id }/>
                </div>
                : <div className={ st.content }>Loading...</div>
            }


            <Footer/>

            <LoginModal isOpen={ loginModalOpen } onClose={ ()=>{
                setLoginModalOpen ( false )
            } }/>
        </div>
    );
};

export default MainLayout;