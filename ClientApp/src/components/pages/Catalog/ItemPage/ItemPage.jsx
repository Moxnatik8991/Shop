import React , { useRef , useState } from 'react';
import './ItemPage.css'
import LocationBar from "../../../../utils/LocationBar";
import { useLocation , useParams } from "react-router-dom";
import Review from "./Review/Review";
import AddReview from "./AddReview/AddReview";
import ImagesBlock from "./ImagesBlock/ImagesBlock";
import axios from "axios";
import { UseGetInfo } from "../../../../hooks/useGetInfo";

let reviewData = [
    {
        name: "Yaroslav",
        data: "15.12.1998",
        rating: 1,
        reviewText: "some text Yaroslav"
    },
    {
        name: "Serhii",
        data: "07.02.1999",
        rating: 2,
        reviewText: "some text Serhii"
    },
    {
        name: "Danil",
        data: "01.01.2024",
        rating: 4,
        reviewText: "some text Danil"
    },
    
]
let currentItem;
const ItemPage = ()=>{
 
    const[reviews,setReviews]=useState(reviewData)
   const {item,currentPath}=UseGetInfo()
    
  
    const {state} = useLocation();
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
    debugger
    return (
        <>
            <div className="category-containerr">
                {
                    state? <LocationBar path={state.currentPath} />:currentPath?<LocationBar path={currentPath} />:null
                   
                }
                
                <div className="content-container">
                    <ImagesBlock />
                    <div>
                        <div>
                            <h3>{ state? state.name:item?.name }</h3>
                        </div>
                        <div className="first-block">
                            <div><span>Seller</span> : Yaroslav</div>
                            <div>

                                <span>Price </span> : {state? state.price:item?.price }${ "   " }
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
                               state 
                                   ? state.comments.map ( el=><Review key={el.id} rating={ el.rating } firstName={ el.firstName } dataCreate={ el.dataCreate }
                                                                      text={ el.text }/> )
                                   : item?.comments.map ( el=><Review key={el.id} rating={ el.rating } firstName={ el.firstName } dataCreate={ el.dataCreate }
                                                                      text={ el.text }/> )
                            }

                            <h3 style={ { paddingTop : "20px" } }>Send your review below ↓</h3>
                            
                            <AddReview itemId={state? state.id:item?.id}  />
                        </div>
                    </div>
                </div>

            </div>
        </>
    )
};

export default ItemPage;