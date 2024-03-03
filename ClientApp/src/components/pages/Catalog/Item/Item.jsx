import React from "react";
import "./Item.css"
import QuantityInput from "./QuantityInput";

const Item = (props) => {
    return (
        <div className={"item-wrapper"}>
            <img
                src={props.image}
                alt=""/>
            <div>{props.name}</div>
            <div className={"rating"}>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
                <img src="https://static-00.iconduck.com/assets.00/star-icon-2048x1945-i77rl5lz.png" alt=""/>
            </div>
            <div>{props.inStock ? "In stoke" : "Not available now..."}</div>
            
            <QuantityInput/>
            <button className={"add-item-button"}>Add to bucket</button>

        </div>
    )
}
export default Item;