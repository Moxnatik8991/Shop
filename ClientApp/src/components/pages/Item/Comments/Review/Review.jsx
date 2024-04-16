import React from 'react';
import { Rating } from "@mui/material";
import st from './Review.module.scss'

const Review = ({firstName,dataCreate,rating,text})=>{
   
    return (
        <div className={st.review}>
            <div className={st.nameAdnData}>
                <div>{ firstName }</div>
                <span>{ dataCreate.slice(0,10).replaceAll("-",".") }</span>
            </div>
            <div className={st.rating}>
                <Rating  size="small" name="read-only" value={rating} readOnly />
            </div>
            <div className={st.content}>
                {text }
            </div>
        </div>
    );
};

export default Review;