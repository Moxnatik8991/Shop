import React from "react";
import "./Item.css"
import { useNavigate } from "react-router-dom";
import QuantityInput from "../../../../utils/QuantityInput";

const Item = ({name, price, description,id}) => {
    
    let navFunk = useNavigate();
    
    
    return (
        <div className={"item-wrapper"}>
            <img onClick={()=>{navFunk(`/${id}`)}}
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