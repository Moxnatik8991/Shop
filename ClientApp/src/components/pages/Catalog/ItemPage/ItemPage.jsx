import React , { useRef , useState } from 'react';
import './ItemPage.css'
import LocationBar from "../../../../utils/LocationBar";
import { useLocation } from "react-router-dom";
import Review from "./Review/Review";
import { useForm } from "react-hook-form";
import { Rating } from "@mui/material";

let reviewData = [
    {
        name: "Yaroslav",
        data: "15.12.1998",
        rating: "1",
        reviewText: "some text Yaroslav"
    },
    {
        name: "Serhii",
        data: "07.02.1999",
        rating: "2",
        reviewText: "some text Serhii"
    },
    {
        name: "Danil",
        data: "01.01.2024",
        rating: "4",
        reviewText: "some text Danil"
    },
    
]
let getCurrentData =()=>{
    let today = new Date();
    let dd = String(today.getDate()).padStart(2, '0');
    let mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    let yyyy = today.getFullYear();
    today = dd + '.' + mm + '.' + yyyy;
    return today
}
const ItemPage = ()=>{
    const [value, setValue] = React.useState(2);
    const[reviews,setReviews]=useState(reviewData)
    let today = getCurrentData();
    let a = useLocation();
    let payment = useRef()
    let testFunk=(el,e)=>{
        e.textContent === "Show"?e.textContent = "Hide": e.textContent = "Show"    
        debugger
        if(el.current.style.height==="3rem")
        {
            el.current.style.height="fit-content";
            el.current.style.whiteSpace="normal"
        }
        else 
        {
            el.current.style.height="3rem";
            el.current.style.whiteSpace="nowrap"
        }
         
        debugger
        
    }
    
    const{register,
        handleSubmit,
        formState:{errors},
        reset} = useForm({mode:"onChange"})
     const onSubmit=data=>{
        let raw = [...reviews,{
            name: data.name,
            data: today,
            rating: value,
            reviewText: data.reviewText
        }]
         setReviews(raw)
         reset()
     }
    return (
        <>
            <div className="category-containerr">
                <LocationBar arr={a.state.lockBar} />
                <div className="content-container">
                    <div style={{display:"grid"}}>
                        <img style={{justifySelf:"center"}} src="https://content.rozetka.com.ua/goods/images/big/322649371.jpg" alt=""/>
                    </div>
                    <div>
                        <div>
                            <h3>{ a.state.element.name }</h3>
                        </div>
                        <div className="first-block">
                            <div><span>Seller</span> : Yaroslav</div>
                            <div>

                                <span>Price </span> : { a.state.element.price }${ "   " }
                                <button>Add to Bucket</button>
                            </div>
                            <div style={ { border : "none" } }>
                                Now available!
                            </div>

                        </div>
                        <div className="first-block">
                            <div style={ { border : "none" } }>
                                Different sub parameters!
                            </div>

                        </div>
                        <div className="first-block">
                            <div>
                                <span>Delivery to Yor city</span>
                            </div>
                            <div>
                                <span>Pickup by yourself </span> >
                                <span> few days</span> >
                                <span> Free</span>
                            </div>
                            <div>
                                <span>Delivery with Nova Poshta </span> >
                                <span> 3 - 5 days </span> >
                                <span> 50 - 100 $</span>
                            </div>
                            <div style={ { border : "none" } }>
                                <span>Delivery by courier Yaroslav </span> >
                                <span> 1 - 99 days </span> >
                                <span> 2 000 - 10 000 $</span> 
                            </div>

                        </div>
                        <div className="first-block">
                            <div ref={payment} className="test-hide" style={{height:"3rem"}}>
                                <button onClick={(e)=>{testFunk(payment,e.currentTarget)}}>Show</button>
                                <span>Payment : </span>
                                Payment by card at the branch, Payment upon receipt of goods, Google Pay, Online card, Non-cash for legal entities, Pay online with the social card "Pakunok Malyuka", Non-cash for individuals, Visa, Apple Pay, Mastercard
                            </div>
                            <div style={ { border : "none" } }>
                                <span>Guarantee : </span>  12 months Exchange/return of goods within 14 days
                            </div>

                        </div>
                    </div>
                    <div style={{gridColumn:"1/3",minHeight:"100%",paddingTop:"20px"}}>
                        <div style={{borderTop:"2px solid grey",margin:"0 2%"}}></div>
                        <div style={ {
                            minHeight : "100%" ,
                            padding : "20px" ,
                            display : "flex" ,
                            flexDirection : "column" ,
                            gap : "10px"
                        } }>
                            <h1>Reviews:</h1>
                            {
                                reviews.map ( el=><Review rating={ el.rating } name={ el.name } data={ el.data }
                                                             reviewText={ el.reviewText }/> )
                            }

                            <h3 style={ { paddingTop : "20px" } }>Send your review below ↓</h3>

                            
                            <div className="add-review">
                                <form onSubmit={handleSubmit(onSubmit)} style={{display:"grid",gridGap:"10px"}}>
                                    
                                    <div style={ { display : "grid" , gridTemplateColumns : "100px 1fr" } }>
                                        <span>Your Name : </span>
                                        <div>
                                            <input { ...register ( 'name' , { required : 'Enter your name!', maxLength: {value:10, message:"Max length 10 symbols!"} }, ) }
                                                   type="text"
                                                   placeholder="Enter your name..."
                                                   style={ errors?.name?{
                                                       border : "none" ,
                                                       outline : "none" ,
                                                       borderBottom :"1px solid red" ,
                                                       width : "15ch" ,
                                                       maxWidth : "30%",

                                                   }: {
                                                       border : "none" ,
                                                       outline : "none" ,
                                                       borderBottom :"1px solid black" ,
                                                       width : "15ch" ,
                                                       maxWidth : "30%",

                                                   } }/>
                                            {errors?.name && <span style={{color:"red",paddingLeft:"10px"}}>{errors.name.message}</span>}
                                            
                                        </div>


                                    </div>

                                    <div style={ { display : "grid" , gridTemplateColumns : "100px 1fr" } }>
                                        <span>Rating : </span>
                                        <Rating
                                            name="simple-controlled"
                                            value={value}
                                            onChange={(event, newValue) => {
                                                setValue(newValue);
                                            }}
                                        />
                                        {/*<div>
                                            <input { ...register ( 'reviewRating') }
                                                   placeholder="Enter rating..."
                                                   type="number"
                                                   max={ 5 }
                                                   onChange={ (e)=>{
                                                       debugger
                                                       if (Number ( e.currentTarget.value ) > 5)
                                                           e.currentTarget.value = 5;
                                                   } }
                                                   style={ {
                                                       border : "none" ,
                                                       outline : "none" ,
                                                       borderBottom : "1px solid black" ,
                                                       maxWidth : "30%" ,
                                                       width : "15ch"
                                                   } }/>
                                        </div>*/}


                                    </div>

                                    <div style={ { display : "grid" , gridTemplateColumns : "100px 1fr" } }>
                                        <span>Review : </span>
                                        <textarea { ...register ( 'reviewText' , { required : 'Enter your review message!' } ) }
                                                  placeholder="Enter your review..."
                                                  style={errors?.reviewText?{
                                                      resize : "none" ,
                                                      minHeight : "200px" ,
                                                      outline : "none" ,
                                                      padding : "10px" ,
                                                      borderRadius : "10px" ,
                                                      marginRight : "20px",
                                                      border:"2px solid red"
                                                  }: {
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
                                        <button  style={ { width : "15%" } }>Send</button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </>
    );
};

export default ItemPage;