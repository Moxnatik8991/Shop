import React , { useEffect , useRef , useState } from "react";
import "./Catalog.css"
import axios from "axios";
import Item from "./Item/Item";
import { NavLink , Outlet , useParams } from "react-router-dom";
import LocationBar from "../../../utils/LocationBar";


const Catalog = ()=>{
    
    let [items , setItems] = useState ( [] )
    let [categories , setCategories] = useState ( [] )
    let params = useParams ()

    useEffect ( ()=>{
        let test = async ()=>{
            let allItems = await axios.get ( "https://5iaf6t.realhost-free.net/api/Product/GetAll" )
            setItems ( allItems.data.result )
            let allCategory = await axios.get ( "http://5iaf6t.realhost-free.net/api/Category/GetAll" )
            setCategories ( allCategory.data.result )
        }
        test ();

    } , [] );


    return (
        <>
            { Object.keys ( params ).length > 0 && categories.length > 0
                ? <Outlet context={{categories:categories, params:params}}/>
            :
            <div className="test-sidebar">
             
                <div className="test">
                    <p>Categories</p>
                    { categories && categories.map ( c=><NavLink onDoubleClick={e=>e.preventDefault()}  style={ {textDecoration : "none" , color : "black"} }
                                                                 to={ c.id }>{ c.name } </NavLink> ) }
                </div>
                
                { !params.category &&
                    <div className="page-container">
                        <LocationBar/>
                        <div className="items-container">
                            { items && items.map ( item=><Item id={item.id} iname={ item.name } description={ item.description }
                                                               price={ item.price }/> ) }
                        </div>
                    </div> }
            </div>}

        </>
    )
}
export default Catalog;