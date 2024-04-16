import React  from 'react';
import st from "./AddReview.module.scss";
import { Rating } from "@mui/material";
import { useForm } from "react-hook-form";
import { ApiComments } from "../../../../../https";
import { useSnackbar } from "notistack";

const date = new Date().toJSON();
const AddReview = ({itemId,updComments})=>{
    const [value, setValue] = React.useState(2);
    const { enqueueSnackbar, closeSnackbar } = useSnackbar();
    
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
        let newComment = {
            id : "8b115ec9-6643-4d37-99ae-1a29d015e044",
            dataCreate : date,
            dataUpdate : date,
            ...comment
        }
        //Cors Ждать пока ярик починит
        ApiComments.addNew(comment)
            .then(response=>{
                if(response.error){
                    
                    enqueueSnackbar({variant:'AdmCatError', anchorOrigin:{horizontal:"right",vertical:"bottom"}, action:{closeSnackbar}, message:response.error})
                }
                if(response.isSuccess){
                    updComments(prev=>[newComment,...prev])
                    alert("add success")
                }
            })
        /*axios({
            method: 'post',
            url: 'http://localhost:2222/api/Comment/Add',
            data: comment
            
        })
            .then(response=>{
                if(response.data.isSuccess){
                    updComments(prev=>[testComment,...prev])
                }
            });*/
        reset()
    }
    
    
    return (
        <div className={ st.addReview }>
            <form onSubmit={ handleSubmit ( onSubmit ) } >

                <div>
                    <span>Your Name : </span>
                    <div>
                        <input { ...register ( 'name' , {
                            required : 'Enter your name!' ,
                            maxLength : { value : 10 , message : "Max length 10 symbols!" }
                        } , ) }
                               type="text"
                               placeholder="Enter your name..."
                               className={errors?.name? st.error:null}
                              />
                        { errors?.name &&
                            <span>{ errors.name.message }</span> }

                    </div>


                </div>

                <div>
                    <span>Rating : </span>
                    <Rating
                        name="simple-controlled"
                        value={ value }
                        onChange={ (event , newValue)=>{
                            setValue ( newValue );
                        } }
                    />
                </div>

                <div>
                    <span>Review : </span>
                    <textarea { ...register ( 'reviewText' , { required : 'Enter your review message!' } ) }
                              placeholder="Enter your review..."
                              className={errors?.reviewText? st.error:null}
                    />
                </div>
                    <button>Send</button>
            </form>
        </div>
    );
};

export default AddReview;