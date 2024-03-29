import React from "react";
import "./Item.css"
import QuantityInput from "./QuantityInput";
import { useNavigate } from "react-router-dom";

const Item = ({name, price, description,id,comments,current}) => {
    
    let navFunk = useNavigate();
    let currentPath1=[...current];
    let state1={
        currentPath: currentPath1,
        name:name,
        price:price,
        description:description,
        id:id,
        comments:comments
    }
    
    
    return (
        <div className={"item-wrapper"}>
            <img onClick={()=>{navFunk(`/${id}`,{state:state1})}}
                src="https://c0.klipartz.com/pngpicture/612/960/gratis-png-iconos-de-computadora-orden-de-compra-todos.png"
                alt=""/>
            <div>{name}</div>
            
            <div>{ description }</div>
            <div>{price}</div>
            <QuantityInput/>
            <button className={"add-item-button"}>Add to bucket</button>

        </div>
    )
}
export default Item;