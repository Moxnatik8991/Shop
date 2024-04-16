import React from 'react';
import { useOutletContext } from "react-router-dom";
import ImagesBlock from "./ImagesBlock/ImagesBlock";
import Description from "./DescriptionBlock/Description";

const Main = ()=>{
    const {currentItem}=useOutletContext()
    return(
        <>
            <ImagesBlock/>
            <Description item={ currentItem }/>
        </>
    )
};

export default Main;