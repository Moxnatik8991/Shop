import React,{useState} from 'react';
import st from './custom.module.css';
import { CustomBucketModal } from "./components/CustomModals/CustomBucketModal";
import Catalog, { CategoryFilter } from "./components/Catalog/Catalog";
import { NavLink, Route, Routes } from "react-router-dom";



const App = () => {
    const [isBucketModal,setBucketModal]=useState(false)
    let openBucketModal=()=>{
        setBucketModal(true)
    }
    let closeBucketModal=()=>{
        setBucketModal(false)
        
    }
  
    return (
           
        <div className={st.appContainer}>
            <div className={st.heade}> 
                <div className={st.ShopName}>Yaroslav Gey Shop</div>
                <div className={st.search}>
                    <input placeholder={"Enter the name..."} type="text"/>
                    <button>Search</button>
                </div>
                <div className={st.bucketButton}>
                    <button onClick={()=> {openBucketModal(true)}} >Bucket</button>
                    
                </div>
            </div>
            <div className={st.navMenu}>
                <div className={st.navMenuContent}>
                    <NavLink to={"/"}>Main</NavLink>
                    <NavLink to={'/catalog'}>Catalog</NavLink>
                    <NavLink to={"/sale"}>Sale</NavLink>
                    <NavLink to={"/paymentInfo"}>Payment and delivery</NavLink>
                    <NavLink to={"/contacts"}>Contact us</NavLink>
                    <NavLink to={"/test"}>Test Page</NavLink>
                </div>

            </div>
            <Routes>
                <Route path={'/catalog'} element={<Catalog />}>
                    <Route path=":category" element={<CategoryFilter />}/>
                </Route>
            </Routes>
            <div className={st.footer1}>
                footer
            </div>
            <CustomBucketModal isOpen={isBucketModal} onClose={closeBucketModal}>
                <h1>Modal Header</h1>
                <p>Some modal text will be here!</p>
            </CustomBucketModal>

        </div>

    );
}
export default App;
