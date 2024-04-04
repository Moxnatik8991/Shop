import React , { useState } from 'react';
import st from './SalePage.module.scss'
import fire from './../../../icons/pngwing.com.png'
import Item from "../Categories/Item/Item";


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