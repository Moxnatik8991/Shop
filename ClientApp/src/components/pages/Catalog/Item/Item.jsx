import React from "react";
import "./Item.css"
import QuantityInput from "./QuantityInput";

const Item = ({name, price, description}) => {
    return (
        <div className={"item-wrapper"}>
            <img
                src="https://c0.klipartz.com/pngpicture/612/960/gratis-png-iconos-de-computadora-orden-de-compra-todos.png"
                alt=""/>
            <div>{name}</div>
            <div className={"rating"}>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
            </div>
            <div>{ description }</div>
            <div>{price}</div>
            <QuantityInput/>
            <button className={"add-item-button"}>Add to bucket</button>

        </div>
    )
}
export default Item;