import React , { useEffect , useState } from 'react';
import { useOutletContext } from "react-router-dom";
import st from "./Comments.module.scss";
import { Pagination , Rating } from "@mui/material";
import AddReview from "./AddReview/AddReview";
import Review from "./Review/Review";
import { ApiComments } from "../../../../https";
import { usePagination } from "../../../../hooks/usePagination";

const Comments = ()=>{
    const [comments,setComments]=useState()
    const [trigger,setTrigger]=useState(true)
    const [isFormOpen,setIsFormOpen]=useState(false)
    const {page,setPagination,paginationEl}=usePagination();
    const {currentItem,getNewComments}=useOutletContext();
    useEffect ( ()=>{
        ApiComments.getByProductId(currentItem.id,page)
            .then(res=>{
                setComments(res.data.result)
                setPagination(JSON.parse(res.headers.pagination))
                
            })
    } , [currentItem,page,trigger] );
    debugger
    return(
        <>
            <div className={ st.commentsContent }>
                <div className={ st.head }>
                    Комментарии к товару { currentItem.name }
                </div>
                <div className={ st.ratingBar }>
                    <Rating name="half-rating-read" value={ currentItem.rating } precision={ 0.1 } readOnly/>
                    { comments?.length } reviews
                </div>
                <div className={st.addReview}>
                    <span>
                        Оставьте свой отзыв об этом товаре
                    </span>
                    <button onClick={ ()=>{setIsFormOpen ( prevState=>!prevState ) } }>
                        Оставить отзыв
                    </button>
                </div>
                { isFormOpen && <AddReview setTrigger={setTrigger} getNewComments={ getNewComments } itemId={ currentItem?.id }/> }
                <div className={st.reviews}>
                    {
                        comments?.length>0
                            ?comments.map ( el=>
                            <Review key={ el.id }
                                    rating={ el.rating }
                                    firstName={ el.firstName }
                                    dataCreate={ el.dataCreate }
                                    text={ el.text }/> )
                            :<div>На данный товар отзывов нет, ваш отзыв будет первым.</div>
                    }
                    { paginationEl }
                </div>

            </div>
            <div >
                <div className={st.itemCard}>
                    <img src="https://www.pngpacks.com/uploads/data/1832/IMG_pfNBpd1CHRQl.png" alt=""/>
                    <div>{ currentItem.name }</div>
                    <div>{currentItem.price} $</div>
                    <button>Buy</button>
                </div>
            </div>
        </>
    )
};

export default Comments;