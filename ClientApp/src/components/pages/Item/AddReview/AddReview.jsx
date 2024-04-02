import React , { useState } from 'react';
import { Rating } from "@mui/material";
import { useForm } from "react-hook-form";
import axios from "axios";


const AddReview = ({itemId,getNewComments})=>{
    const [value, setValue] = React.useState(2);
    
    const{register,
        handleSubmit,
        formState:{errors},
        reset} = useForm({mode:"onChange"})
    const onSubmit=data=>{
        let comment = {
            "firstName": data.name,
            "rating": value,
            "text": data.reviewText,
            "productId": itemId
        }
        
        axios({
            method: 'post',
            url: 'http://localhost:2222/api/Comment/Add',
            data: comment
            
        })
            .then(response=>{
                if(response.data.isSuccess){
                    getNewComments();
                }
            });
        reset()
    }
    
    
    return (
        <div className="add-review">
            <form onSubmit={ handleSubmit ( onSubmit ) } style={ { display : "grid" , gridGap : "10px" } }>

                <div style={ { display : "grid" , gridTemplateColumns : "100px 1fr" } }>
                    <span>Your Name : </span>
                    <div>
                        <input { ...register ( 'name' , {
                            required : 'Enter your name!' ,
                            maxLength : { value : 10 , message : "Max length 10 symbols!" }
                        } , ) }
                               type="text"
                               placeholder="Enter your name..."
                               style={ errors?.name ? {
                                   border : "none" ,
                                   outline : "none" ,
                                   borderBottom : "1px solid red" ,
                                   width : "15ch" ,
                                   maxWidth : "30%" ,

                               } : {
                                   border : "none" ,
                                   outline : "none" ,
                                   borderBottom : "1px solid black" ,
                                   width : "15ch" ,
                                   maxWidth : "30%" ,

                               } }/>
                        { errors?.name &&
                            <span style={ { color : "red" , paddingLeft : "10px" } }>{ errors.name.message }</span> }

                    </div>


                </div>

                <div style={ { display : "grid" , gridTemplateColumns : "100px 1fr" } }>
                    <span>Rating : </span>
                    <Rating
                        name="simple-controlled"
                        value={ value }
                        onChange={ (event , newValue)=>{
                            setValue ( newValue );
                        } }
                    />
                </div>

                <div style={ { display : "grid" , gridTemplateColumns : "100px 1fr" } }>
                    <span>Review : </span>
                    <textarea { ...register ( 'reviewText' , { required : 'Enter your review message!' } ) }
                              placeholder="Enter your review..."
                              style={ errors?.reviewText ? {
                                  resize : "none" ,
                                  minHeight : "200px" ,
                                  outline : "none" ,
                                  padding : "10px" ,
                                  borderRadius : "10px" ,
                                  marginRight : "20px" ,
                                  border : "2px solid red"
                              } : {
                                  resize : "none" ,
                                  minHeight : "200px" ,
                                  outline : "none" ,
                                  padding : "10px" ,
                                  borderRadius : "10px" ,
                                  marginRight : "20px"
                              } }>
                                            
                                        </textarea>
                </div>

                <div style={ { display : "flex" , placeContent : "center" } }>
                    <button style={ { width : "15%" } }>Send</button>
                </div>
            </form>
        </div>
    );
};

export default AddReview;