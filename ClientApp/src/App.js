import React,{useState} from 'react';
import st from './custom.module.css';
import { CustomBucketModal } from "./components/CustomModals/CustomBucketModal";
import Home from "./components/Home";



const App = () => {
    const [isBucketModal,setBucketModal]=useState(false)
    let openBucketModal=()=>{
        setBucketModal(true)
    }
    let closeBucketModal=()=>{
        setBucketModal(false)
        
    }
  
    return (
        <Home/>
        /*<div className={st.appContainer}>
            <div className={st.heade}>
                <div className={st.ShopName}>Yaroslav Gey Shop</div>
                <div className={st.search}>
                    <input type="text"/>
                    <button>Search</button>
                </div>
                <div className={st.bucketButton}>
                    <button onClick={()=> {openBucketModal(true)}} >Bucket</button>
                    
                </div>
            </div>
            <div className={st.navMenu}>
                <div className={st.navMenuContent}>
                    <span>Main</span>
                    <span>Catalog</span>
                    <span>Sale</span>
                    <span>Payment and delivery</span>
                    <span>Contact us</span>
                </div>

            </div>
            <div> Footer</div>
            <CustomBucketModal isOpen={isBucketModal} onClose={closeBucketModal}>
                <h1>Modal Header</h1>
                <p>Some modal text will be here!</p>
            </CustomBucketModal>

        </div>*/

    );
}
export default App;
