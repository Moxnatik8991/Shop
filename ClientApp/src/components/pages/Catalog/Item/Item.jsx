import React from "react";
import "./Item.css"
import QuantityInput from "./QuantityInput";
import { useNavigate } from "react-router-dom";

const Item = ({name, price, description,test=[],id="",...props}) => {
    let navFunck = useNavigate();
    let arR = [...test];
    debugger
    if(test){
        arR.push(
           {name: name,
               id:id}
       )
        debugger
    }
    else {
     
    }
   
    
    return (
        <div className={"item-wrapper"}>
            <img onClick={()=>{navFunck(`/${id}`,{state:{lockBar:arR,itemId: id,element:props.element}})}}
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