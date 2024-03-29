import React from 'react';
import { NavLink } from "react-router-dom";


const LocationBar = ({path})=>{
    
    let path1 = [...path]
    
   
    return (
        <div>
            <NavLink to={"/"}>Home</NavLink>
           {
               
               path1 && path1.reverse().map((el,index)=>{
                   
                   return(<span key={el.id}>
                       {" > "}
                       <NavLink onClick={e=>{if(index===path1.length-1) return (e.preventDefault())}} to={`/catalog/${el.id}`}>{el.name}</NavLink>
                   </span>)  })
           }
           
        </div>
        
    );
}

export default LocationBar;