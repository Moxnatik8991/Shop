import React , { useEffect , useRef , useState } from 'react';
import './ItemPage.css'
import LocationBar from "../../../utils/LocationBar";
import { useLocation , useParams } from "react-router-dom";
import Review from "./Review/Review";
import AddReview from "./AddReview/AddReview";
import ImagesBlock from "./ImagesBlock/ImagesBlock";
import { UseGetInfo } from "../../../hooks/useGetInfo";
import Description from "./DescriptionBlock/Description";
import axios from "axios";
import useGetData from "../../../hooks/useGetCategory";


const ItemPage = ()=>{
   
   const {currentItem,currentPath,getNewComments}=useGetData()
    
    debugger
    console.log("render itemPage")
    return (
        <>
            { currentItem && currentPath
                ? <div className="category-containerr">
                     <LocationBar path={ currentPath }/>
                    <div className="content-container">
                        <ImagesBlock/>
                        <Description item={ currentItem }/>
                        <div style={ { gridColumn : "1/3" , minHeight : "100%" , paddingTop : "20px" } }>
                            <div style={ { borderTop : "2px solid grey" , margin : "0 2%" } }></div>
                            <div style={ {
                                minHeight : "100%" ,
                                padding : "20px" ,
                                display : "flex" ,
                                flexDirection : "column" ,
                                gap : "10px"
                            } }>
                                <h1>Reviews:</h1>
                                {
                                    currentItem?.comments.map ( el=>
                                        <Review key={ el.id }
                                                rating={ el.rating }
                                                firstName={ el.firstName }
                                                dataCreate={ el.dataCreate }
                                                text={ el.text }/> )
                                }
                                <h3 style={ { paddingTop : "20px" } }>Send your review below ↓</h3>
                                <AddReview getNewComments={getNewComments} itemId={ currentItem?.id }/>
                            </div>
                        </div>
                    </div>

                </div>
                : <div className="category-containerr">Loading...</div>
            }
            
        </>
    )
};

export default ItemPage;