import React , { useEffect } from 'react';
import st from './custom.module.css';
import { NavLink, Route, Routes, useRoutes } from "react-router-dom";
import { routing } from "./utils/Routing";
import {
    Footer
} from "./components/global/Footer";
import {
    Header
} from "./components/global/Header";
import {getAllItemsAndCategories } from "./redux/items.action";
import { useDispatch , useSelector } from "react-redux";
import CatalogModal from "./components/global/CustomModals/CatalogModal";



const App = () => {
    
    const dispatch = useDispatch();
    useEffect ( ()=>{
        
        dispatch(getAllItemsAndCategories())
    } , [] );
    
    let routs = useRoutes(routing);

    const [anchorEl, setAnchor] = React.useState(null);
    const handleClick = (event) => {
        setAnchor(anchorEl ? null : event.currentTarget);
    };
    const open = Boolean(anchorEl);
    const id = open ? 'simple-popper' : undefined;
    
    const{isLoading}=useSelector(state=>state.item)
    console.log("render app")
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
                    </div>

                </div>
                 {!isLoading
                     ? <div className={ st.content }>
                       { routs }
                       <CatalogModal handleClick={ handleClick } open={ open } anchorEl={ anchorEl } id={ id }/>
                     </div>
                     : <div className={ st.content }>Loading...</div>
                 }
                 

                 <Footer/>
             </div>

    );
}
export default App;
