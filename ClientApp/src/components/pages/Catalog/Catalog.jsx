import React, { useEffect, useRef, useState } from "react";
import "./Catalog.css"
import axios from "axios";
import Item from "./Item/Item";
import { NavLink, Outlet, useParams } from "react-router-dom";
import LocationBar from "../../../utils/LocationBar";


const Catalog = () => {
    let [items, setItems] = useState([])
    let [subCategory, setSubCategory] = useState([])
    let [categories, setCategories] = useState([])
    let params = useParams()
   
    useEffect (  ()=>{
        let test = async ()=>{
           let allItems = await axios.get("https://5iaf6t.realhost-free.net/api/Product/GetAll")
            setItems(allItems.data.result)
            let allCategory = await axios.get("http://5iaf6t.realhost-free.net/api/Category/GetAll")
            setCategories(allCategory.data.result)
        }
        test();
        
    }, [] );
    let doSomething=(el)=>{
        let s = categories.filter(i=> i.name===el.text.trimRight())
        setSubCategory(s[0])
    }

    


//test nav menu    
 /*  let cheker = (object,vis = false)=>{
        let result = object.map(i =>
            <div  style={ {cursor : "pointer", padding : "7px"} }
                 hidden={ vis }
                  onClick={ (e)=>{
                      hideShow ( e.currentTarget )
                            } 
                  }>

                { i.name }{ i.categories && i.categories.length > 0 && cheker ( i.categories, true ) }

            </div>
        )
        return result
        
    }
    let hideShow=(el)=>{
       if(el.children.length>0)  el.children[0].hidden = !el.children[0].hidden;
    }*/
    return (
        <>
             <div className="test-sidebar">
                 
                    <div className="test">
                <p>Categories</p>
                
                {  /*<div> { categories && cheker(categories) } </div>*/}
                
                {categories && categories.map(c=><NavLink onClick={(e)=>doSomething(e.currentTarget)} style={{textDecoration:"none",color:"black"}} to={c.id}>{c.name} </NavLink>)}
                
            </div>
                 
                              {Object.keys(params).length>0 && <Outlet />}
                 
                              {!params.category && 
                                  <div className="page-container">
                                      <LocationBar  />
                                      <div className="items-container">
                              {items && items.map(item =><Item name={item.name} description={item.description} price={item.price} />)}
                                      </div>
                    </div> }
            </div>  
            
        </>
    )
}
export default Catalog;