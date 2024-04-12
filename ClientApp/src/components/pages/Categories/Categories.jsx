import React , { useState } from 'react';
import { Navigate , useParams } from "react-router-dom";
import LocationBar from "../../../utils/LocationBar";
import Item from "./Item/Item";
import './Categories.css'
import useGetData from "../../../hooks/useGetCategory";
import Category from "./Category/Category";

import gig from './../../../icons/anime.gif'

const Categories = ()=>{
    let {IdCategory}=useParams();
    const {currentCategory,currentPath,items}=useGetData()
    const [load,setLoad]=useState(false)
    

    console.log("render category")

    if(!IdCategory) return <Navigate to={"/"}/>
    
    return (
        <>
            
            <div className="category-container">
                { currentPath &&  <LocationBar path={currentPath}/> }
                { currentCategory?.name && <div className="category-name">{ currentCategory.name }</div> }
                
                <div className="subCatBlock">
                    { currentCategory?.categories && currentCategory.categories.map ( el=>
                        <Category name={el.name} id={el.id} file={el.file}/>)
                        }
                </div>
                
                {!load && items && items?.length > 0 &&
                    <>
                        <div className="just-line"></div>
                        <div className="category-items-block">
                            <div className="category-items-filtres">
                                <h3>Filters</h3>
                                <div>filter2</div>
                                <div>filter3</div>
                            </div>
                            <div style={ {
                                borderRight : "1px solid grey" ,
                                height:"98%"
                            } }>

                            </div>
                            <div className="category-items-list">
                                { items?.map( el=><Item  {...el} /> ) }
                            </div>
                        </div>
                    </>
                }
                {!load && !items && 
                    <div style={{fontSize:"30px"}}>
                        Sorry, but now we haven't any items here... Go away!
                        <img style={{borderRadius:"50%"}} src={gig} alt=""/>
                    </div>
                }

            </div>
        </>);
};

export default Categories;