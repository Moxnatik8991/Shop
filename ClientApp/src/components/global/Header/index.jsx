import React, {useState} from "react";
import style from "./style.module.css"
import {
    CustomBucketModal
} from "../CustomModals/CustomBucketModal";
import { useSelector } from "react-redux";


export const Header = () => {
    const {isAuth}=useSelector(state=>state.auth)

    const [isBucketModal,setBucketModal]=useState(false)
    let openBucketModal=()=>{
        setBucketModal(true)
    }
    let closeBucketModal=()=>{
        setBucketModal(false)
    }
    return (
        <>
            <div className={style.header}>
                <div className={style.ShopName}>Shop</div>
                <div className={style.search}>
                    <input placeholder={"Enter the name..."} type="text"/>
                    <button>Search</button>
                    {isAuth?<span>Welcome, Admin</span>:<span>Not authorized!</span>}
                </div>
                <div className={style.bucketButton}>
                    <button onClick={()=> {openBucketModal(true)}} >Bucket</button>

                </div>
            </div>
            <CustomBucketModal isOpen={isBucketModal} onClose={closeBucketModal}>
                <h1>Modal Header</h1>
                <p>Some modal text will be here!</p>
            </CustomBucketModal>
        </>



    )
}
