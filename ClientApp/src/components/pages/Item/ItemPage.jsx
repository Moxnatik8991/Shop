import React , { useEffect , useState } from 'react';

import st from './ItemPage.module.scss'
import LocationBar from "../../../utils/LocationBar";
import { NavLink , Outlet } from "react-router-dom";
import useGetData from "../../../hooks/useGetCategory";


const ItemPage = ()=>{

    const { currentItem , currentPath , getNewComments } = useGetData ()
    const [comments , setComments] = useState ( currentItem )
    useEffect ( ()=>{
        setComments ( currentItem?.comments )
    } , [currentItem] );
    
    return (
        <>
            { currentItem && currentPath
                ? <div className={ st.categoryContainer }>
                     <LocationBar path={ currentPath }/>
                    <div className={st.navigation}>
                        <NavLink className={m=>m.isActive? st.active:null} to="" end>Всё о товаре</NavLink>
                        <NavLink className={m=>m.isActive? st.active:null} to="comments">Коментарии</NavLink>
                    </div>
                    <div className={st.contentContainer}>
                        <Outlet context={{setComments,currentItem,comments,getNewComments}}/>
                    </div>

                </div>
                : <div className={ st.categoryContainer }>Loading...</div>
            }
            
        </>
    )
};

export default ItemPage;