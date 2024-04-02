import React , { useState } from 'react';
import st from './SalePage.module.scss'
import fire from './../../../icons/pngwing.com.png'
/*import Item from "../Categories/Item/Item";*/


const testArray = [
    {
        name:"name1",
        price:"price1",
        id:"id",
        description:"description1"
    },
    {
        name:"name2",
        price:"price2",
        id:"id",
        description:"description2"
    },
    {
        name:"name3",
        price:"price3",
        id:"id",
        description:"description3"
    },
    {
        name:"name4",
        price:"price4",
        id:"id",
        description:"description4"
    },
    {
        name:"name5",
        price:"price5",
        id:"id",
        description:"description5"
    },
    {
        name:"name6",
        price:"price6",
        id:"id",
        description:"description6"
    },
    {
        name:"name1",
        price:"price1",
        id:"id",
        description:"description1"
    },
    {
        name:"name2",
        price:"price2",
        id:"id",
        description:"description2"
    },
    {
        name:"name3",
        price:"price3",
        id:"id",
        description:"description3"
    },
    {
        name:"name4",
        price:"price4",
        id:"id",
        description:"description4"
    },
    {
        name:"name5",
        price:"price5",
        id:"id",
        description:"description5"
    },
    {
        name:"name6",
        price:"price6",
        id:"id",
        description:"description6"
    },
]

 export const Item=({name,price,id})=>{
    return(
        <div className={st.itemCont}>
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

const SalePage = ()=>{
    const [visible,setVisible]=useState(4)
    const showMore=()=>{
        setVisible(prev=>prev+3)
    }
    return (
        <div className={ st.container }>
            <div className={ st.header }>
                <div style={ { backgroundColor : "grey" , } }>
                    <div style={ {
                        backgroundColor : "white" ,
                        width : "100%" ,
                        height : "100%" ,
                        borderTopRightRadius : "30px"
                    } }>

                    </div>
                </div>
                <div className={ st.name }>
                    <img width="50px" src={ fire } alt=""/>
                    <span style={ {
                        height : "max-content" ,
                        placeSelf : "center" ,
                        textShadow : "0 0 3px pink" ,
                        fontSize : "20px" ,
                        fontWeight : "bold"
                    } }>Hot Sales! </span>

                </div>
                <div style={ { backgroundColor : "grey" , } }>
                    <div style={ {
                        backgroundColor : "white" ,
                        width : "100%" ,
                        height : "100%" ,
                        borderTopLeftRadius : "30px"
                    } }>

                    </div>
                </div>
            </div>
            <div className={ st.itemContainer }>
                {/*{
                    testArray.slice ( 0 , visible ).map ( el=><Item { ...el }/> )
                }*/}
                {
                    testArray.slice ( 0 , visible ).map ( el=><Item key={el.id} {...el}/> )
                }

            </div>
            <button style={{width:"max-content",placeSelf:"center",background:"none",overflow:"none",borderRadius:"10px",border:"1px solid blueviolet"}} hidden={ visible >= testArray.length } onClick={ showMore }>Show more</button>

        </div>
    );
};

export default SalePage;