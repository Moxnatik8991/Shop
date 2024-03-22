import React from 'react';
import { NavLink } from "react-router-dom";


const LocationBar = ({arr,item})=>{
    let path = "/catalog"
   
    return (
        <div>
            <NavLink to={"/"}>Home</NavLink>
            {" > "}
            <NavLink to={"/catalog"} >Catalog</NavLink>
           {
               
               arr && arr.map((el,index)=>{
                   path = path.concat("/",el.id)
                   return(<span>
                       {" > "}
                       <NavLink onClick={e=>{if(index===arr.length-1) return (e.preventDefault())}} to={path}>{el.name}</NavLink>
                   </span>)  })
           }
           
        </div>
        
    );
}

export default LocationBar;