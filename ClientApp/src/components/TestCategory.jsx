import React , { useState } from 'react';
import { Navigate , NavLink } from "react-router-dom";
import Item from "./pages/Catalog/Item/Item";
import LocationBar from "../utils/LocationBar";
import { UseGetInfo } from "../hooks/useGetInfo";

const TestCategory = ()=>{
    const {currentCategory,currentPath,category,items}=UseGetInfo()
    const [load,setLoad]=useState(false)
    
    console.log("render category")
    
    if(!category) return <Navigate to={"/"}/>
    return (
       
        <>
            <div className="category-container">
                { currentPath &&  <LocationBar path={currentPath}/> }
                { currentCategory?.name && <div className="category-name">{ currentCategory.name }</div> }
                <div className="advertisment">
                    <img
                        src="https://www.pro-of.com.ua/wp-content/uploads/2018/02/ab35c5ac5b7d2dda5ddc48c01e4efa15.jpg"
                        alt="No image..."/>
                </div>
                <div className="subCatBlock">
                    { currentCategory?.categories && currentCategory.categories.map ( el=><NavLink
                        to={`/catalog/${el.id}`}>
                        <img width={ "50px" } border={ "5px solid black" } style={ { justifySelf : "center" } }
                             src="https://cdn.pixabay.com/photo/2021/10/11/23/49/app-6702045_640.png"
                             alt="No image..."/>
                        <div style={ { justifySelf : "center" } }>{ el.name }</div>

                    </NavLink> ) }
                </div>
                {load && <div>Loading...</div>}
                {!load && items && items.length > 0 &&
                    <>
                        <div className="just-line"></div>
                        <div className="category-items-block">
                            <div className="category-items-filtres">
                                <h3>Filtres</h3>
                                <div>filter2</div>
                                <div>filter3</div>
                            </div>
                            <div style={ {
                                border : "2px solid grey" ,
                                borderRadius : "10px" ,
                                backgroundColor : "grey" ,
                                margin : "10px 0"
                            } }>

                            </div>
                            <div className="category-items-list">
                                { items.map( el=><Item current={currentPath} id={el.id} price={el.price} name={el.name} description={el.description} /> ) }
                            </div>
                        </div>
                    </> 
                }

            </div>
        </>
    );
};

export default TestCategory;