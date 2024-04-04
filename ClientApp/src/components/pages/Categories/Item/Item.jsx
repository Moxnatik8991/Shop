import React from "react";
import { useNavigate } from "react-router-dom";
import st from "./Item.module.scss";

const testArray = [
    {
        name:"name1",
        price:"price1",
        id:"1",
        description:"description1"
    },
    {
        name:"name2",
        price:"price2",
        id:"2",
        description:"description2"
    },
    {
        name:"name3",
        price:"price3",
        id:"3",
        description:"description3"
    },
    {
        name:"name4",
        price:"price4",
        id:"4",
        description:"description4"
    },
    {
        name:"name5",
        price:"price5",
        id:"5",
        description:"description5"
    },
    {
        name:"name6",
        price:"price6",
        id:"6",
        description:"description6"
    },
    {
        name:"name1",
        price:"price1",
        id:"7",
        description:"description1"
    },
    {
        name:"name2",
        price:"price2",
        id:"8",
        description:"description2"
    },
    {
        name:"name3",
        price:"price3",
        id:"9",
        description:"description3"
    },
    {
        name:"name4",
        price:"price4",
        id:"10",
        description:"description4"
    },
    {
        name:"name5",
        price:"price5",
        id:"11",
        description:"description5"
    },
    {
        name:"name6",
        price:"price6",
        id:"12",
        description:"description6"
    },
]

const Item=({name,price,id})=>{
    let navFunk = useNavigate();

    return(
        <div onClick={()=>{navFunk(`/${id}`)}} className={st.itemCont}>
            <div className={st.itemImage}>
                <img src="https://c0.klipartz.com/pngpicture/612/960/gratis-png-iconos-de-computadora-orden-de-compra-todos.png" alt=""/>
            </div>
            <div className={st.itemName}>
                { name }
            </div>
            <div className={st.itemPriceAdnButton}>
                <div>
                    <span style={{alignSelf:"end",textDecorationLine:"line-through",color:"grey",fontSize:"15px"}}>100$</span>
                    <span style={{alignSelf:"center",color:"red",fontSize:"25px"}}>{price} $</span>
                </div>
                <button>Buy</button>
            </div>
        </div>
    )
}
export default Item;