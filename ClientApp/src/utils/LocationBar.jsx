import React from 'react';
import { NavLink } from "react-router-dom";


const LocationBar = ({path})=>{
    
    
    
   
    return (
        <div>
            <NavLink to={"/"}>Home</NavLink>
           {
               path.map((el,index)=>{
                   return(<span key={el.id}>
                       {" > "}
                       <NavLink onClick={e=>{if(index===path.length-1) return (e.preventDefault())}} to={`/catalog/${el.id}`}>{el.name}</NavLink>
                   </span>)  })
           }
           
        </div>
        
    );
}

export default LocationBar;