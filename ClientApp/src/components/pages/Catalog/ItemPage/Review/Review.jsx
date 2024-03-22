import React from 'react';
import ratingImg from "../../../../../icons/rating.png";
import { Rating } from "@mui/material";

const Review = ({name,data,rating,reviewText})=>{
    return (
        <div className="review">
            <div style={ {
                display : "grid" ,
                justifyContent : "space-between" ,
                gridAutoFlow : "column"
            } }>
                <span style={ { paddingLeft : "10px" } }>{ name }</span>
                <span>{ data }</span>
            </div>
            <div style={{paddingLeft:"7px"}}>
                <Rating  size="small" name="read-only" value={rating} readOnly />
            </div>
            <div style={ { padding : " 15px 10px" } }>
                {reviewText }
            </div>
        </div>
    );
};

export default Review;