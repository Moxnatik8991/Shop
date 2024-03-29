import React from 'react';
import { Rating } from "@mui/material";

const Review = ({firstName,dataCreate,rating,text})=>{
    return (
        <div className="review">
            <div style={ {
                display : "grid" ,
                justifyContent : "space-between" ,
                gridAutoFlow : "column"
            } }>
                <span style={ { paddingLeft : "10px" } }>{ firstName }</span>
                <span>{ dataCreate.slice(0,10).replaceAll("-",".") }</span>
            </div>
            <div style={{paddingLeft:"7px"}}>
                <Rating  size="small" name="read-only" value={rating} readOnly />
            </div>
            <div style={ { padding : " 15px 10px" } }>
                {text }
            </div>
        </div>
    );
};

export default Review;